using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS_MobileStoreApp;
using DTO_MobileStoreApp;

namespace MobileStoreApp
{
    public partial class frmSanPham : Form
    {
        BUS_Controller ctrl_B = new BUS_Controller();
        string path;
        public frmSanPham()
        {
            InitializeComponent();
        }

        private void frmSanPham_Load(object sender, EventArgs e)
        {
            txtMaSanPham.Enabled = false;
            btnCapNhat.Enabled = false;
            txtDuongDan.Enabled = false;
            dgvSanPham.DataSource = ctrl_B.ShowProduct();
            cbLoaiSanPham.DataSource = ctrl_B.ShowCategories();
            cbLoaiSanPham.DisplayMember = "TenLoaiSanPham";
            cbLoaiSanPham.ValueMember = "IDLoaiSanPham";
            cbGiamGia.DataSource = ctrl_B.ShowDiscount();
            cbGiamGia.DisplayMember = "GiaTri";
            cbGiamGia.ValueMember = "IDGiamGia";
            cbLoaiSanPham.SelectedIndex = 0;
            cbGiamGia.SelectedIndex = 0;
            path = Application.StartupPath + "\\pictures\\";
        }

        private void ClearTxt()
        {
            txtMaSanPham.Text = String.Empty;
            txtTenSanPham.Text = String.Empty;
            txtDonGia.Text = String.Empty;
            txtDonVi.Text = String.Empty;
        }

        private void ResetEnable()
        {
            txtTenSanPham.Enabled = true;
            txtDonGia.Enabled = true;
            txtDonVi.Enabled = true;
            cbLoaiSanPham.Enabled = true;
            cbGiamGia.Enabled = true;
        }

        private void ResetDisable()
        {
            txtTenSanPham.Enabled = false;
            txtDonGia.Enabled = false;
            txtDonVi.Enabled = false;
            cbLoaiSanPham.Enabled = false;
            cbGiamGia.Enabled = false;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtTenSanPham.Text == String.Empty || txtDonVi.Text == String.Empty ||
                    txtDonGia.Text == String.Empty || txtDuongDan.Text == String.Empty)
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Cảnh báo");
                }
                else
                {
                    int lastRowIndex = dgvSanPham.Rows.Count - 2;
                    string IDSanPham = dgvSanPham.Rows[lastRowIndex].Cells[0].Value.ToString();
                    Product prod = new Product(Int32.Parse(IDSanPham) + 1, txtTenSanPham.Text, txtDonVi.Text,
                            txtDonGia.Text, txtDuongDan.Text, Int32.Parse(cbLoaiSanPham.SelectedValue.ToString()),
                            Int32.Parse(cbGiamGia.SelectedValue.ToString()));
                    bool check = ctrl_B.AddProduct(prod);
                    if (check == true)
                    {
                        MessageBox.Show("Thêm sản phẩm thành công!");
                        dgvSanPham.DataSource = ctrl_B.ShowProduct();
                        ClearTxt();
                    }
                    else
                    {
                        MessageBox.Show("Thêm sản phẩm thất bại!");
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
                DialogResult dr = MessageBox.Show("Bạn có chắc chắn xóa sản phẩm này?", "Thông báo", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {
                    int i = dgvSanPham.CurrentRow.Index;

                    bool check = ctrl_B.RemoveProduct(Int32.Parse(dgvSanPham.Rows[i].Cells[0].Value.ToString()));
                    if (check == true)
                    {
                        MessageBox.Show("Xóa sản phẩm thành công!");
                        dgvSanPham.DataSource = ctrl_B.ShowProduct();
                        ClearTxt();
                    }
                    else
                    {
                        MessageBox.Show("Xóa sản phẩm thất bại!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnTaiHinhAnh_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "PNG files (*.png)|*.png|JPEG files (*.jpg)|*.jpg|All files (*.*)|*.*";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                string filePath = dlg.FileName;
                string fileName = Path.GetFileName(filePath);
                txtDuongDan.Text = fileName;
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                ResetEnable();
                int i = dgvSanPham.CurrentRow.Index;
                txtMaSanPham.Text = dgvSanPham.Rows[i].Cells[0].Value.ToString();
                txtTenSanPham.Text = dgvSanPham.Rows[i].Cells[1].Value.ToString();
                txtDonVi.Text = dgvSanPham.Rows[i].Cells[2].Value.ToString();
                txtDonGia.Text = dgvSanPham.Rows[i].Cells[3].Value.ToString();
                txtDuongDan.Text = dgvSanPham.Rows[i].Cells[6].Value.ToString();
                cbLoaiSanPham.Text = dgvSanPham.Rows[i].Cells[5].Value.ToString();
                cbGiamGia.Text = dgvSanPham.Rows[i].Cells[6].Value.ToString();

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
                if (txtTenSanPham.Text == String.Empty || txtDonVi.Text == String.Empty ||
                    txtDonGia.Text == String.Empty)
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Cảnh báo");
                }
                else
                {
                    int lastRowIndex = dgvSanPham.Rows.Count - 2;
                    //string IDSanPham = dgvSanPham.Rows[lastRowIndex].Cells[0].Value.ToString();
                    Product prod = new Product(Int32.Parse(txtMaSanPham.Text), txtTenSanPham.Text, txtDonVi.Text,
                            txtDonGia.Text, txtDuongDan.Text, Int32.Parse(cbLoaiSanPham.SelectedValue.ToString()),
                            Int32.Parse(cbGiamGia.SelectedValue.ToString()));
                    bool check = ctrl_B.EditProduct(prod);
                    if (check == true)
                    {
                        MessageBox.Show("Cập nhật thông tin sản phẩm thành công!", "Thông báo");
                        dgvSanPham.DataSource = ctrl_B.ShowProduct();
                        ClearTxt();
                    }
                    else
                    {
                        MessageBox.Show("Cập nhật thông tin sản phẩm thất bại!", "Thông báo");
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
            DataTable dt = ctrl_B.FoundProduct(txtTimKiem.Text);
            dgvSanPham.DataSource = dt;
        }

        private void dgvSanPham_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int i = dgvSanPham.CurrentRow.Index;

            txtDuongDan.Text = dgvSanPham.Rows[i].Cells[6].Value.ToString();
            picHinhAnh.SizeMode = PictureBoxSizeMode.Zoom;
            try
            {
                picHinhAnh.Image = Image.FromFile(path + txtDuongDan.Text);
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("Không tìm thấy hình ảnh!", "Thông báo");
                picHinhAnh.Image = Image.FromFile(path + "404-error.png");
            }
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {

        }
    }
}
