using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS_MobileStoreApp;
using DTO_MobileStoreApp;
using DAO_MoblieStoreApp;

namespace MobileStoreApp
{
    public partial class frmGiamGia : Form
    {
        BUS_Controller ctrl_B = new BUS_Controller();
        public frmGiamGia()
        {
            InitializeComponent();
        }

        private void frmGiamGia_Load(object sender, EventArgs e)
        {
            txtMaGiamGia.Enabled = false;
            btnCapNhat.Enabled = false;
            dgvGiamGia.DataSource = ctrl_B.ShowDiscount();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dr = MessageBox.Show("Bạn có chắc chắn xoá giảm giá này?", "Thông báo", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {
                    int i = dgvGiamGia.CurrentRow.Index;
                    int IDDisc = Int32.Parse(dgvGiamGia.Rows[i].Cells[0].Value.ToString());

                    DataTable dt = ctrl_B.ShowProductByIDDiscount(IDDisc);
                    //for (int j = 0; j < dt.Rows.Count; j++)
                    //{
                    //    MessageBox.Show(dt.Rows[j][0].ToString());
                    //}

                    if (dt == null || dt.Rows.Count == 0)
                    {
                        bool check = ctrl_B.RemoveDiscount(IDDisc);
                        if (check == true)
                        {
                            MessageBox.Show("Xóa mã giảm giá thành công!");
                            dgvGiamGia.DataSource = ctrl_B.ShowDiscount();
                            txtMaGiamGia.Text = txtGiaTri.Text = String.Empty;
                        }
                        else
                        {
                            MessageBox.Show("Xóa mã giảm giá thất bại!");
                        }
                    }
                    else
                    {
                        int reset = 0;
                        for (int j = 0; j < dt.Rows.Count; j++)
                        {
                            SanPham sp = new SanPham();
                            sp.IDSanPham = Int32.Parse(dt.Rows[j][0].ToString());
                            sp.TenSanPham = dt.Rows[j][1].ToString();
                            sp.DonVi = dt.Rows[j][2].ToString();
                            sp.DonGia = dt.Rows[j][3].ToString();
                            sp.HinhAnh = dt.Rows[j][4].ToString();
                            sp.IDLoaiSanPham = Int32.Parse(dt.Rows[j][5].ToString());
                            sp.IDGiamGia = 0;
                            ctrl_B.EditedProduct(sp);
                            reset++;
                        }    

                        if (reset == dt.Rows.Count)
                        {
                            bool check = ctrl_B.RemoveDiscount(IDDisc);
                            MessageBox.Show("Những sản phẩm đang áp dụng mã giảm giá này đã được hủy!" + reset.ToString() + dt.Rows.Count.ToString());
                            dgvGiamGia.DataSource = ctrl_B.ShowDiscount();
                            txtMaGiamGia.Text = txtGiaTri.Text = String.Empty;
                        }
                        else
                        {
                            MessageBox.Show("Hủy mã giảm giá thất bại");
                        }
                    }  
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
