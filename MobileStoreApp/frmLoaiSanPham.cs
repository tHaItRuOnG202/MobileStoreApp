using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS_MobileStoreApp;
using DTO_MobileStoreApp;
using System.Drawing.Drawing2D;

namespace MobileStoreApp
{
    public partial class frmLoaiSanPham : Form
    {
        BUS_Controller ctrl_B = new BUS_Controller();
        public frmLoaiSanPham()
        {
            InitializeComponent();
        }

        private void frmLoaiSanPham_Load(object sender, EventArgs e)
        {
            txtMaLoaiSanPham.Enabled = false;
            dgvLoaiSanPham.DataSource = ctrl_B.ShowCategories();
            btnCapNhat.Enabled = false;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtTenLoaiSanPham.Text == String.Empty)
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                }
                else
                {
                    int lastRowIndex = dgvLoaiSanPham.Rows.Count - 2;
                    string IDLoaiSanPham = dgvLoaiSanPham.Rows[lastRowIndex].Cells[0].Value.ToString();
                    Categories cate = new Categories(Int32.Parse(IDLoaiSanPham) + 1, txtTenLoaiSanPham.Text);

                    bool check = ctrl_B.AddCategories(cate);
                    if (check == true)
                    {
                        MessageBox.Show("Thêm loại sản phẩm thành công!");
                        dgvLoaiSanPham.DataSource = ctrl_B.ShowCategories();
                        txtMaLoaiSanPham.Text = txtTenLoaiSanPham.Text = String.Empty;
                    }    
                    else
                    {
                        MessageBox.Show("Thêm loại sản phẩm thất bại!");
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
                DialogResult dr = MessageBox.Show("Bạn có chắc chắn xóa loại sản phẩm này?", "Thông báo", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {
                    int i = dgvLoaiSanPham.CurrentRow.Index;

                    Categories cate = new Categories(Int32.Parse(dgvLoaiSanPham.Rows[i].Cells[0].Value.ToString()),
                    dgvLoaiSanPham.Rows[i].Cells[1].Value.ToString());
                    bool check = ctrl_B.RemoveCategories(Int32.Parse(dgvLoaiSanPham.Rows[i].Cells[0].Value.ToString()));
                    if (check == true)
                    {
                        MessageBox.Show("Xóa loại sản phẩm thành công!");
                        dgvLoaiSanPham.DataSource = ctrl_B.ShowCategories();
                        txtMaLoaiSanPham.Text = txtTenLoaiSanPham.Text = String.Empty;
                    }
                    else
                    {
                        MessageBox.Show("Xóa loại sản phẩm thất bại!");
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
                txtTenLoaiSanPham.Enabled = true;
                int i = dgvLoaiSanPham.CurrentRow.Index;
                txtMaLoaiSanPham.Text = dgvLoaiSanPham.Rows[i].Cells[0].Value.ToString();
                txtTenLoaiSanPham.Text = dgvLoaiSanPham.Rows[i].Cells[1].Value.ToString();

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
                if (txtTenLoaiSanPham.Text == String.Empty)
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                }
                else
                {
                    int lastRowIndex = dgvLoaiSanPham.Rows.Count - 2;
                    string IDLoaiSanPham = dgvLoaiSanPham.Rows[lastRowIndex].Cells[0].Value.ToString();
                    Categories cate = new Categories(Int32.Parse(txtMaLoaiSanPham.Text), txtTenLoaiSanPham.Text);
                    bool check = ctrl_B.EditCategories(cate);
                    if(check == true)
                    {
                        MessageBox.Show("Cập nhật loại sản phẩm thành công!", "Thông báo");

                        dgvLoaiSanPham.DataSource = ctrl_B.ShowCategories();
                        txtMaLoaiSanPham.Text = txtTenLoaiSanPham.Text = String.Empty;
                    }
                    else
                    {
                        MessageBox.Show("Cập nhật loại sản phẩm thất bại!", "Thông báo");
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
            DataTable dt = ctrl_B.FoundCategories(txtTimKiem.Text);
            dgvLoaiSanPham.DataSource = dt;
        }

        //private void btnTimKiem_Click(object sender, EventArgs e)
        //{
        //    DataTable dt = ctrl_B.FoundCategories(txtTimKiem.Text);
        //    dgvLoaiSanPham.DataSource = dt;
        //}

        private void dgvLoaiSanPham_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                int i = dgvLoaiSanPham.CurrentRow.Index;
                txtMaLoaiSanPham.Text = dgvLoaiSanPham.Rows[i].Cells[0].Value.ToString();
                txtTenLoaiSanPham.Text = dgvLoaiSanPham.Rows[i].Cells[1].Value.ToString();
                txtMaLoaiSanPham.Enabled = false;
                txtTenLoaiSanPham.Enabled = false;
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

        //private void frmLoaiSanPham_Paint(object sender, PaintEventArgs e)
        //{
        //    Graphics myGraphics = e.Graphics;
        //    Pen myPen = new Pen(Color.FromArgb(144, 238, 144), 1);

        //    Rectangle area = new Rectangle(0, 0, this.Width - 1, this.Height - 1);
        //    LinearGradientBrush lgb = new LinearGradientBrush(area, Color.FromArgb(144, 238, 144), Color.FromArgb(245, 251, 251), LinearGradientMode.ForwardDiagonal);

        //    myGraphics.FillRectangle(lgb, area);
        //    myGraphics.DrawRectangle(myPen, area);
        //}
    }
}
