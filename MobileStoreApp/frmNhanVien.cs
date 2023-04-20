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
    public partial class frmNhanVien : Form
    {
        BUS_Controller ctrl_B = new BUS_Controller();
        bool isEmployee = false;
        public frmNhanVien()
        {
            InitializeComponent();
        }

        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            txtMaNhanVien.Enabled = false;
            btnCapNhat.Enabled = false;
            dgvNhanVien.DataSource = ctrl_B.ShowEmployee();
            cbChucVu.Items.Add("Nhân viên");
            cbChucVu.Items.Add("Quản lý");
            cbChucVu.SelectedIndex = 0;
        }

        private void ClearTxt()
        {
            txtMaNhanVien.Text = String.Empty;
            txtHoNhanVien.Text = String.Empty;
            txtTenNhanVien.Text = String.Empty;
            txtDiaChi.Text = String.Empty;
            txtDienThoai.Text = String.Empty;
            txtTaiKhoan.Text = String.Empty;
            txtMatKhau.Text = String.Empty;
            cbChucVu.Text = String.Empty;
        }


        private void ResetEnable()
        {
            txtHoNhanVien.Enabled = true;
            txtTenNhanVien.Enabled = true;
            dtpNgaySinh.Enabled = true;
            txtDiaChi.Enabled = true;
            txtDienThoai.Enabled = true;
            txtTaiKhoan.Enabled = true;
            txtMatKhau.Enabled = true;
            cbChucVu.Enabled = true;
        }

        private void ResetDisable()
        {
            txtMaNhanVien.Enabled = false;
            txtHoNhanVien.Enabled = false;
            txtTenNhanVien.Enabled = false;
            dtpNgaySinh.Enabled = false;
            txtDiaChi.Enabled = false;
            txtDienThoai.Enabled = false;
            txtTaiKhoan.Enabled = false;
            txtMatKhau.Enabled = false;
            cbChucVu.Enabled = false;
        }

        private void cbChucVu_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbChucVu.SelectedIndex == 0)
            {
                isEmployee = true;
            }
            else if (cbChucVu.SelectedIndex == 1)
            {
                isEmployee = false;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtHoNhanVien.Text == String.Empty || txtTenNhanVien.Text == String.Empty ||
                    txtDiaChi.Text == String.Empty || txtDienThoai.Text == String.Empty ||
                    txtTaiKhoan.Text == String.Empty || txtMatKhau.Text == String.Empty)
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Cảnh báo");
                }
                else
                {
                    bool isEmployee = false;
                    MessageBox.Show(isEmployee.ToString());
                    if (cbChucVu.SelectedIndex == 0)
                    {
                        isEmployee = true;
                    }
                    else if (cbChucVu.SelectedIndex == 1)
                    {
                        isEmployee = false;
                    }
                    int lastRowIndex = dgvNhanVien.Rows.Count - 2;
                    string IDNhanVien = dgvNhanVien.Rows[lastRowIndex].Cells[0].Value.ToString();
                    Employee empl = new Employee(Int32.Parse(IDNhanVien) + 1, txtHoNhanVien.Text, txtTenNhanVien.Text,
                            DateTime.Parse(dtpNgaySinh.Text), txtDiaChi.Text, txtDienThoai.Text, txtTaiKhoan.Text,
                            txtMatKhau.Text, isEmployee);
                    bool check = ctrl_B.AddEmployee(empl);
                    if (check == true)
                    {
                        MessageBox.Show("Thêm nhân viên thành công!");
                        dgvNhanVien.DataSource = ctrl_B.ShowEmployee();
                        ClearTxt();
                    }
                    else
                    {
                        MessageBox.Show("Thêm nhân viên thất bại!");
                    }
                }    

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dr = MessageBox.Show("Bạn có chắc chắn hủy hợp đồng với nhân viên này?", "Thông báo", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {
                    bool isEmployee = false;
                    if (cbChucVu.SelectedIndex == 0)
                    {
                        isEmployee = true;
                    }
                    else if (cbChucVu.SelectedIndex == 1)
                    {
                        isEmployee = false;
                    }
                    int i = dgvNhanVien.CurrentRow.Index;
                    int IDEmpl = Int32.Parse(dgvNhanVien.Rows[i].Cells[0].Value.ToString());

                    DataTable dt = ctrl_B.ShowReceiptByIDEmployee(IDEmpl);
                    //for (int j = 0; j < dt.Rows.Count; j++)
                    //{
                    //    MessageBox.Show(dt.Rows[j][0].ToString());
                    //}

                    if (dt == null || dt.Rows.Count == 0)
                    {
                        bool check = ctrl_B.RemoveEmployee(IDEmpl);
                        if (check == true)
                        {
                            MessageBox.Show("Nhân viên đã không còn làm việc ở đây nữa!");
                            dgvNhanVien.DataSource = ctrl_B.ShowEmployee();
                            ClearTxt();
                        }
                        else
                        {
                            MessageBox.Show("Xóa nhân viên thất bại!");
                        }
                    }
                    else
                    {
                        NhanVien empledit = new NhanVien();
                        empledit.IDNhanVien = Int32.Parse(dgvNhanVien.Rows[i].Cells[0].Value.ToString());
                        empledit.HoNhanVien = dgvNhanVien.Rows[i].Cells[1].Value.ToString();
                        empledit.TenNhanVien = dgvNhanVien.Rows[i].Cells[2].Value.ToString();
                        empledit.NgaySinhNhanVien = DateTime.Parse(dgvNhanVien.Rows[i].Cells[3].Value.ToString());
                        empledit.DiaChiNhanVien = dgvNhanVien.Rows[i].Cells[4].Value.ToString();
                        empledit.DienThoaiNhanVien = dgvNhanVien.Rows[i].Cells[5].Value.ToString();
                        empledit.TaiKhoanNhanVien = null;
                        empledit.MatKhauNhanVien = null;
                        empledit.LoaiNhanVien = bool.Parse(dgvNhanVien.Rows[i].Cells[8].Value.ToString());

                        //bool checked = ctrl_B.EditedEmployee(empledit);
                        bool check = ctrl_B.EditedEmployee(empledit);
                        if (check == true)
                        {
                            MessageBox.Show("Nhân viên đã bị đuổi!");
                            dgvNhanVien.DataSource = ctrl_B.ShowEmployee();
                            ClearTxt();
                        }
                        else
                        {
                            MessageBox.Show("Nhân viên chưa bị đuổi!");
                        }    
                    }    

                    //Employee empl = new Employee(Int32.Parse(dgvNhanVien.Rows[i].Cells[0].Value.ToString()),
                    //dgvNhanVien.Rows[i].Cells[1].Value.ToString(),
                    //dgvNhanVien.Rows[i].Cells[2].Value.ToString(),
                    //DateTime.Parse(dgvNhanVien.Rows[i].Cells[3].Value.ToString()),
                    //dgvNhanVien.Rows[i].Cells[4].Value.ToString(),
                    //dgvNhanVien.Rows[i].Cells[5].Value.ToString(),
                    //dgvNhanVien.Rows[i].Cells[6].Value.ToString(),
                    //dgvNhanVien.Rows[i].Cells[7].Value.ToString(),
                    //isEmployee);
                    //bool check = ctrl_B.RemoveEmployee(IDEmpl);
                    //if (check == true)
                    //{
                    //    MessageBox.Show("Nhân viên đã không còn làm việc ở đây nữa!");
                    //    dgvNhanVien.DataSource = ctrl_B.ShowEmployee();
                    //    ClearTxt();
                    //}    
                    //else
                    //{
                    //    MessageBox.Show("Xóa nhân viên thất bại!");
                    //}    
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
                int i = dgvNhanVien.CurrentRow.Index;
                txtMaNhanVien.Text = dgvNhanVien.Rows[i].Cells[0].Value.ToString();
                txtHoNhanVien.Text = dgvNhanVien.Rows[i].Cells[1].Value.ToString();
                txtTenNhanVien.Text = dgvNhanVien.Rows[i].Cells[2].Value.ToString();
                dtpNgaySinh.Text = dgvNhanVien.Rows[i].Cells[3].Value.ToString();
                txtDiaChi.Text = dgvNhanVien.Rows[i].Cells[4].Value.ToString();
                txtDienThoai.Text = dgvNhanVien.Rows[i].Cells[5].Value.ToString();
                txtTaiKhoan.Text = dgvNhanVien.Rows[i].Cells[6].Value.ToString();
                txtMatKhau.Text = dgvNhanVien.Rows[i].Cells[7].Value.ToString();
                if (dgvNhanVien.Rows[i].Cells[8].Value.ToString() == true.ToString())
                    cbChucVu.Text = "Nhân viên";
                else
                    cbChucVu.Text = "Quản lý";
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
                if (txtHoNhanVien.Text == String.Empty || txtTenNhanVien.Text == String.Empty ||
                    txtDiaChi.Text == String.Empty || txtDienThoai.Text == String.Empty ||
                    txtTaiKhoan.Text == String.Empty || txtMatKhau.Text == String.Empty)
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Cảnh báo");
                }
                else
                {
                    bool isEmployee = false;
                    if (cbChucVu.SelectedIndex == 0)
                    {
                        isEmployee = true;
                    }
                    else if (cbChucVu.SelectedIndex == 1)
                    {
                        isEmployee = false;
                    }
                    int lastRowIndex = dgvNhanVien.Rows.Count - 2;
                    //string IDNhanVien = dgvNhanVien.Rows[lastRowIndex].Cells[0].Value.ToString();
                    Employee empl = new Employee(Int32.Parse(txtMaNhanVien.Text), txtHoNhanVien.Text, txtTenNhanVien.Text,
                            DateTime.Parse(dtpNgaySinh.Text), txtDiaChi.Text, txtDienThoai.Text, txtTaiKhoan.Text,
                            txtMatKhau.Text, isEmployee);
                    bool check = ctrl_B.EditEmployee(empl);
                    if (check == true)
                    {
                        MessageBox.Show("Cập nhật thông tin nhân viên thành công!", "Thông báo");
                        dgvNhanVien.DataSource = ctrl_B.ShowEmployee();
                        ClearTxt();
                    }
                    else
                    {
                        MessageBox.Show("Cập nhật thông tin nhân viên thất bại!", "Thông báo");
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
            DataTable dt = ctrl_B.FoundEmployee(txtTimKiem.Text);
            dgvNhanVien.DataSource = dt;
        }

        //private void btnTimKiem_Click(object sender, EventArgs e)
        //{
        //    DataTable dt = ctrl_B.FoundEmployee(txtTimKiem.Text);
        //    dgvNhanVien.DataSource = dt;
        //}

        private void dgvNhanVien_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                int i = dgvNhanVien.CurrentRow.Index;

                txtMaNhanVien.Text = dgvNhanVien.Rows[i].Cells[0].Value.ToString();
                txtHoNhanVien.Text = dgvNhanVien.Rows[i].Cells[1].Value.ToString();
                txtTenNhanVien.Text = dgvNhanVien.Rows[i].Cells[2].Value.ToString();
                dtpNgaySinh.Text = dgvNhanVien.Rows[i].Cells[3].Value.ToString();
                txtDiaChi.Text = dgvNhanVien.Rows[i].Cells[4].Value.ToString();
                txtDienThoai.Text = dgvNhanVien.Rows[i].Cells[5].Value.ToString();
                if (dgvNhanVien.Rows[i].Cells[6].Value.ToString() == String.Empty && dgvNhanVien.Rows[i].Cells[7].Value.ToString() == String.Empty)
                {
                    txtTaiKhoan.Text = "null";
                    txtMatKhau.Text = "null";
                }
                else
                {
                    txtTaiKhoan.Text = dgvNhanVien.Rows[i].Cells[6].Value.ToString();
                    txtMatKhau.Text = dgvNhanVien.Rows[i].Cells[7].Value.ToString();
                }
                if (dgvNhanVien.Rows[i].Cells[8].Value.ToString() == true.ToString())
                    cbChucVu.Text = "Nhân viên";
                else
                    cbChucVu.Text = "Quản lý";
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
    }
}
