using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS_MobileStoreApp;
using DTO_MobileStoreApp;

namespace MobileStoreApp
{
    public partial class frmKhachHang : Form
    {
        BUS_Controller ctrl_B = new BUS_Controller();
        public frmKhachHang()
        {
            InitializeComponent();
        }

        private void frmKhachHang_Load(object sender, EventArgs e)
        {
            txtMaKhachHang.Enabled = false;
            dgvKhachHang.DataSource = ctrl_B.ShowCustomer();
            btnCapNhat.Enabled = false;
        }

        private void ClearTxt()
        {
            txtMaKhachHang.Text = String.Empty;
            txtTenKhachHang.Text = String.Empty;
            txtDiaChi.Text = String.Empty;
            txtDienThoai.Text = String.Empty;
            txtEmail.Text = String.Empty;
        }

        private void ResetEnable()
        {
            txtTenKhachHang.Enabled = true;
            dtpNgaySinh.Enabled = true;
            txtDiaChi.Enabled = true;
            txtDienThoai.Enabled = true;
            txtEmail.Enabled = true;
        }

        private void ResetDisable()
        {
            txtTenKhachHang.Enabled = false;
            dtpNgaySinh.Enabled = false;
            txtDiaChi.Enabled = false;
            txtDienThoai.Enabled = false;
            txtEmail.Enabled = false;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtTenKhachHang.Text == String.Empty || txtDiaChi.Text == String.Empty || 
                    txtDienThoai.Text == String.Empty || txtEmail.Text == String.Empty)
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                }
                else
                {
                    int lastRowIndex = dgvKhachHang.Rows.Count - 2;
                    string IDKhachHang = dgvKhachHang.Rows[lastRowIndex].Cells[0].Value.ToString();
                    Customer cust = new Customer(Int32.Parse(IDKhachHang) + 1, txtTenKhachHang.Text,
                            DateTime.Parse(dtpNgaySinh.Text), txtDiaChi.Text, txtDienThoai.Text, txtEmail.Text);
                    bool check = ctrl_B.AddCustomer(cust);
                    if (check == true)
                    {
                        MessageBox.Show("Thêm khách hàng thành công");
                        dgvKhachHang.DataSource = ctrl_B.ShowCustomer();
                        ClearTxt();
                    }
                    else
                    {
                        MessageBox.Show("Thêm khách hàng thất bại");
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
                DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn xóa khách hàng?", "Thông báo", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {
                    int i = dgvKhachHang.CurrentRow.Index;
                    int IDCust = Int32.Parse(dgvKhachHang.Rows[i].Cells[0].Value.ToString());

                    if (IDCust == 0)
                    {
                        MessageBox.Show("Không được phép xóa!");
                    }
                    else
                    {
                        Customer cust = new Customer(Int32.Parse(dgvKhachHang.Rows[i].Cells[0].Value.ToString()),
                        dgvKhachHang.Rows[i].Cells[1].Value.ToString(),
                        DateTime.Parse(dgvKhachHang.Rows[i].Cells[2].Value.ToString()),
                        dgvKhachHang.Rows[i].Cells[3].Value.ToString(),
                        dgvKhachHang.Rows[i].Cells[4].Value.ToString(),
                        dgvKhachHang.Rows[i].Cells[5].Value.ToString());
                        //dgvKhachHang.Rows[i].Cells[6].Value.ToString(),
                        //dgvKhachHang.Rows[i].Cells[7].Value.ToString());
                        bool check = ctrl_B.RemoveCustomer(Int32.Parse(dgvKhachHang.Rows[i].Cells[0].Value.ToString()));
                        if (check == true)
                        {
                            MessageBox.Show("Xóa khách hàng thành công!", "Thông báo");
                            dgvKhachHang.DataSource = ctrl_B.ShowCustomer();
                            ClearTxt();
                        }
                        else
                        {
                            MessageBox.Show("Xóa khách hàng thất bại!", "Thông báo");
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
                int i = dgvKhachHang.CurrentRow.Index;

                txtMaKhachHang.Text = dgvKhachHang.Rows[i].Cells[0].Value.ToString();
                txtTenKhachHang.Text = dgvKhachHang.Rows[i].Cells[1].Value.ToString();
                dtpNgaySinh.Text = dgvKhachHang.Rows[i].Cells[2].Value.ToString();
                txtDiaChi.Text = dgvKhachHang.Rows[i].Cells[3].Value.ToString();
                txtDienThoai.Text = dgvKhachHang.Rows[i].Cells[4].Value.ToString();
                txtEmail.Text = dgvKhachHang.Rows[i].Cells[5].Value.ToString();
                //txtTaiKhoan.Text = dgvKhachHang.Rows[i].Cells[6].Value.ToString();
                //txtMatKhau.Text = dgvKhachHang.Rows[i].Cells[7].Value.ToString();
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
                if (txtTenKhachHang.Text == String.Empty || txtDiaChi.Text == String.Empty || 
                    txtDienThoai.Text == String.Empty || txtEmail.Text == String.Empty)
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                }
                else
                {
                    int lastRowIndex = dgvKhachHang.Rows.Count - 2;
                    string IDKhachHang = dgvKhachHang.Rows[lastRowIndex].Cells[0].Value.ToString();
                    Customer cust = new Customer(Int32.Parse(txtMaKhachHang.Text), txtTenKhachHang.Text,
                            DateTime.Parse(dtpNgaySinh.Text), txtDiaChi.Text, txtDienThoai.Text, txtEmail.Text);
                    bool check = ctrl_B.EditCustomer(cust);
                    if (check == true)
                    {
                        MessageBox.Show("Cập nhật thông tin khách hàng thành công!", "Thông báo");

                        dgvKhachHang.DataSource = ctrl_B.ShowCustomer();
                        ClearTxt();
                    }
                    else
                    {
                        MessageBox.Show("Cập nhật thông tin khách hàng thất bại!", "Thông báo");
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
            DataTable dt = ctrl_B.FoundCustomer(txtTimKiem.Text);
            dgvKhachHang.DataSource = dt;
        }

        private void dgvKhachHang_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                int i = dgvKhachHang.CurrentRow.Index;

                txtMaKhachHang.Text = dgvKhachHang.Rows[i].Cells[0].Value.ToString();
                txtTenKhachHang.Text = dgvKhachHang.Rows[i].Cells[1].Value.ToString();
                dtpNgaySinh.Text = dgvKhachHang.Rows[i].Cells[2].Value.ToString();
                txtDiaChi.Text = dgvKhachHang.Rows[i].Cells[3].Value.ToString();
                txtDienThoai.Text = dgvKhachHang.Rows[i].Cells[4].Value.ToString();
                txtEmail.Text = dgvKhachHang.Rows[i].Cells[5].Value.ToString();

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

        private void frmKhachHang_Paint(object sender, PaintEventArgs e)
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
