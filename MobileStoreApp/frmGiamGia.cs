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
using System.Drawing.Drawing2D;

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

        private void ResetEnable()
        {
            txtGiaTri.Enabled = true;
            dtpNgayBatDau.Enabled = true;
            dtpNgayKetThuc.Enabled = true;
        }

        private void ResetDisable()
        {
            txtGiaTri.Enabled = false;
            dtpNgayBatDau.Enabled = false;
            dtpNgayKetThuc.Enabled = false;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtGiaTri.Text == String.Empty || dtpNgayBatDau.Text == String.Empty ||
                    dtpNgayKetThuc.Text == String.Empty)
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                }
                else
                {
                    if (dtpNgayBatDau.Value.Date > dtpNgayKetThuc.Value.Date)
                    {
                        MessageBox.Show("Ngày bắt đầu phải nhỏ hơn ngày kết thúc!");
                    }
                    else
                    {
                        int lastRowIndex = dgvGiamGia.Rows.Count - 2;
                        string IDGiamGia = dgvGiamGia.Rows[lastRowIndex].Cells[0].Value.ToString();
                        Discount disc = new Discount(Int32.Parse(IDGiamGia) + 1, txtGiaTri.Text, DateTime.Parse(dtpNgayBatDau.Text),
                                DateTime.Parse(dtpNgayKetThuc.Text));
                        bool check = ctrl_B.AddDiscount(disc);
                        if (check == true)
                        {
                            MessageBox.Show("Thêm giảm giá thành công");
                            dgvGiamGia.DataSource = ctrl_B.ShowDiscount();
                            txtGiaTri.Text = String.Empty;
                        }
                        else
                        {
                            MessageBox.Show("Thêm giảm giá thất bại");
                        }
                    }    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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

                    if (IDDisc == 0)
                    {
                        MessageBox.Show("Không được xóa mã giảm giá này!");
                    }
                    else
                    {
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
                                MessageBox.Show("Xóa mã giảm giá thành công. Những sản phẩm đang áp dụng mã giảm giá này đã được hủy!");
                                dgvGiamGia.DataSource = ctrl_B.ShowDiscount();
                                txtMaGiamGia.Text = txtGiaTri.Text = String.Empty;
                            }
                            else
                            {
                                MessageBox.Show("Xóa mã giảm giá thất bại");
                            }
                        }
                    }    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                ResetEnable();
                int i = dgvGiamGia.CurrentRow.Index;

                txtMaGiamGia.Text = dgvGiamGia.Rows[i].Cells[0].Value.ToString();
                txtGiaTri.Text = dgvGiamGia.Rows[i].Cells[1].Value.ToString();
                dtpNgayBatDau.Text = dgvGiamGia.Rows[i].Cells[2].Value.ToString();
                dtpNgayKetThuc.Text = dgvGiamGia.Rows[i].Cells[3].Value.ToString();

                btnCapNhat.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtGiaTri.Text == String.Empty || dtpNgayBatDau.Text == String.Empty ||
                    dtpNgayKetThuc.Text == String.Empty)
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Cảnh báo");
                }
                else
                {
                    int lastRowIndex = dgvGiamGia.Rows.Count - 2;
                    //string IDGiamGia = dgvGiamGia.Rows[lastRowIndex].Cells[0].Value.ToString();
                    Discount disc = new Discount(Int32.Parse(txtMaGiamGia.Text), txtGiaTri.Text, DateTime.Parse(dtpNgayBatDau.Text),
                            DateTime.Parse(dtpNgayKetThuc.Text));
                    bool check = ctrl_B.EditDiscount(disc);
                    if (check == true)
                    {
                        MessageBox.Show("Cập nhật thông tin giảm giá thành công!", "Thông báo");
                        dgvGiamGia.DataSource = ctrl_B.ShowDiscount();
                        txtGiaTri.Text = String.Empty;
                    }
                    else
                    {
                        MessageBox.Show("Cập nhật thông tin giảm giá thất bại!", "Thông báo");
                    }
                    btnCapNhat.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = ctrl_B.FoundDiscount(txtTimKiem.Text);
            dgvGiamGia.DataSource = dt;
        }

        private void dgvGiamGia_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                int i = dgvGiamGia.CurrentRow.Index;

                txtMaGiamGia.Text = dgvGiamGia.Rows[i].Cells[0].Value.ToString();
                txtGiaTri.Text = dgvGiamGia.Rows[i].Cells[1].Value.ToString();
                dtpNgayBatDau.Text = dgvGiamGia.Rows[i].Cells[2].Value.ToString();
                dtpNgayKetThuc.Text = dgvGiamGia.Rows[i].Cells[3].Value.ToString();
                
                ResetDisable();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {

        }

        private void frmGiamGia_Paint(object sender, PaintEventArgs e)
        {
            Graphics myGraphics = e.Graphics;
            Pen myPen = new Pen(Color.FromArgb(144, 238, 144), 1);

            Rectangle area = new Rectangle(0, 0, this.Width - 1, this.Height - 1);
            LinearGradientBrush lgb = new LinearGradientBrush(area, Color.FromArgb(144, 238, 144), Color.FromArgb(245, 251, 251), LinearGradientMode.ForwardDiagonal);

            myGraphics.FillRectangle(lgb, area);
            myGraphics.DrawRectangle(myPen, area);
        }
    }
}
