using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAO_MoblieStoreApp;
using DTO_MobileStoreApp;
using BUS_MobileStoreApp;

namespace MobileStoreApp
{
    public partial class frmHoaDon : Form
    {
        BUS_Controller ctrl_B = new BUS_Controller();
        public static string HoTen = "";
        public static string IDNhanVien = "";
        const int MAX_ARRAY = 9999999;
        int count;
        public frmHoaDon()
        {
            frmDangNhap frmDangNhap = new frmDangNhap();
            InitializeComponent();
        }

        private void ClearTxt()
        {
            txtMaHoaDon.Text = String.Empty;
            cbMaKhachHang.Text = String.Empty;
            lbTenKhachHang.Text = String.Empty;
            cbMaKhachHang.Text = String.Empty;
            txtMaHoaDon.Text = String.Empty;
            lbTenSanPham.Text = String.Empty;
            lbGiamGia.Text = String.Empty;
            lbDonVi.Text = String.Empty;
            lbDonGia.Text = String.Empty;
            lbTongTien.Text = String.Empty;
        }

        private void LoadReceipt()
        {
            txtMaHoaDon.Enabled = false;
            //cbMaKhachHang.DataSource = ctrl_B.ShowCustomer();
            //cbMaKhachHang.DisplayMember = "IDKhachHang";
            //cbMaKhachHang.ValueMember = "IDKhachHang";
            //cbMaSanPham.DataSource = ctrl_B.ShowProduct();
            //cbMaSanPham.DisplayMember = "IDSanPham";
            //cbMaSanPham.ValueMember = "IDSanPham";
            //cbMaKhachHang.SelectedIndex = 0;
            //cbMaSanPham.SelectedIndex = 0;
            DataTable ProductList = ctrl_B.ShowProduct();
            DataTable CustomerList = ctrl_B.ShowCustomer();
            string[] idSanPhams = new string[MAX_ARRAY];
            int rowCount = ctrl_B.ShowProduct().Rows.Count;
            for (int i = 0; i < rowCount; i++)
            {
                idSanPhams[i] = ProductList.Rows[i][0].ToString();
                cbMaSanPham.Items.Add(idSanPhams[i]);
            }
            cbMaSanPham.SelectedIndex = 0;
            string[] idKhachHangs = new string[MAX_ARRAY];
            int rowCount1 = ctrl_B.ShowCustomer().Rows.Count;
            for (int i = 0; i < rowCount1; i++)
            {
                idKhachHangs[i] = CustomerList.Rows[i][0].ToString();
                cbMaKhachHang.Items.Add(idKhachHangs[i]);
            }
            cbMaKhachHang.SelectedIndex = 0;
        }

        private void frmHoaDon_Load(object sender, EventArgs e)
        {
            this.LoadReceipt();
        }

        public bool DatagridviewCheck()
        {
            bool isNull = false;
            for (int i = 0; i <= dgvChiTietHoaDon.RowCount - 1; i++)
            {
                for (int j = 0; j < dgvChiTietHoaDon.ColumnCount; j++)
                {
                    //if (dgvHoaDon.Rows[i].Cells[j].Value == null || dgvHoaDon.Rows[i].Cells[j].Value == DBNull.Value)
                    if (dgvChiTietHoaDon.RowCount == 1)
                    {
                        isNull = true;
                    }
                }
                if (isNull)
                    break;
            }
            return isNull;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtSoLuong.Text == String.Empty)
                {
                    MessageBox.Show("Vui lòng nhập số lượng!");
                    return;
                }

                string maSP = cbMaSanPham.Text;
                string tenSP = lbTenSanPham.Text;
                string soLuong = txtSoLuong.Text;
                string donGia = lbDonGia.Text;
                string donVi = lbDonVi.Text;
                string giamGia = (Int16.Parse(lbGiamGia.Text)).ToString();
                string tien = (Int16.Parse(txtSoLuong.Text) * decimal.Parse(lbDonGia.Text) - decimal.Parse(lbGiamGia.Text) * Int16.Parse(txtSoLuong.Text)).ToString();

                if (dgvChiTietHoaDon.Rows.Count == 1)
                {
                    dgvChiTietHoaDon.Rows.Add(maSP, tenSP, soLuong, donGia, donVi, giamGia, tien);
                    count = 1;
                    MessageBox.Show("Thêm sản phẩm mới thành công!");
                }
                else
                {
                    for (int i = 0; i < dgvChiTietHoaDon.RowCount - 1; i++)
                    {
                        if (dgvChiTietHoaDon.Rows[i].Cells[0].Value.ToString() == maSP)
                        {
                            MessageBox.Show("Sản phẩm đã tồn tại");
                            count = 1;
                            break;
                        }
                        else
                        {
                            count++;
                        }
                    }

                    if (count == dgvChiTietHoaDon.RowCount)
                    {
                        dgvChiTietHoaDon.Rows.Add(maSP, tenSP, soLuong, donGia, donVi, giamGia, tien);
                        count = 1;
                        MessageBox.Show("Sản phẩm mới đã được thêm vào!");
                    }
                }

                double thanhTien = 0;
                int columnIndex = dgvChiTietHoaDon.Columns["TongTien"].Index;
                for (int i = 0; i < dgvChiTietHoaDon.RowCount - 1; i++)
                {
                    thanhTien += double.Parse(dgvChiTietHoaDon.Rows[i].Cells[columnIndex].Value.ToString());
                }
                txtSoLuong.Text = String.Empty;
                lbTongTien.Text = thanhTien.ToString("N0") + " đ";
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
                bool isNull = DatagridviewCheck();
                //int sl = dgvHoaDon.RowCount;
                //MessageBox.Show("Không có gì để xóa!" + isNull + sl);
                if (isNull == true)
                {
                    MessageBox.Show("Chưa có sản phẩm nào để xóa");
                }
                else
                {
                    int rowIndex = dgvChiTietHoaDon.CurrentCell.RowIndex;
                    if (dgvChiTietHoaDon.CurrentCell.Value == null)
                    {
                        MessageBox.Show("Không có gì để xóa!");
                    }
                    //if (dgvHoaDon.Rows[rowIndex].Cells[0].Value.ToString() == String.Empty || dgvHoaDon.Rows[rowIndex].Cells[0].Value == null)
                    //{
                    //    MessageBox.Show("Không có gì để xóa!");
                    //}
                    else
                    {
                        dgvChiTietHoaDon.Rows.RemoveAt(rowIndex);
                    }
                    double thanhTien = 0;
                    int columnIndex = dgvChiTietHoaDon.Columns["TongTien"].Index;
                    for (int i = 0; i < dgvChiTietHoaDon.RowCount - 1; i++)
                    {
                        thanhTien += double.Parse(dgvChiTietHoaDon.Rows[i].Cells[columnIndex].Value.ToString());
                    }
                    lbTongTien.Text = thanhTien.ToString("N0") + " đ";
                    MessageBox.Show("Xóa thành công sản phẩm!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnThemHoaDon_Click(object sender, EventArgs e)
        {
            
        }

        private void cbMaSanPham_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                //int IDProd = 1;
                //if (cbMaSanPham.SelectedItem != null)
                //{
                    
                //}

                int IDProd = Int32.Parse(cbMaSanPham.Text);

                SanPham sp = ctrl_B.GetPrById(IDProd);

                if (sp != null)
                {
                    lbTenSanPham.Text = sp.TenSanPham;
                    lbDonVi.Text = sp.DonVi;
                    lbGiamGia.Text = ctrl_B.GetDistByProd(Int32.Parse(cbMaSanPham.Text));
                    lbDonGia.Text = sp.DonGia;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cbMaKhachHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int IDCust = Int32.Parse(cbMaKhachHang.Text);
                KhachHang kh = ctrl_B.GetCustByID(IDCust);

                if (kh != null)
                    lbTenKhachHang.Text = kh.TenKhachHang;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void UpdateMoney()
        {

            int rowIndex = dgvChiTietHoaDon.CurrentCell.RowIndex;

            string soLuong = dgvChiTietHoaDon.Rows[rowIndex].Cells[2].Value.ToString();
            string donGia = dgvChiTietHoaDon.Rows[rowIndex].Cells[3].Value.ToString();
            string giamGia = dgvChiTietHoaDon.Rows[rowIndex].Cells[5].Value.ToString();
            //MessageBox.Show(soLuong + donGia + giamGia);

            string tongGiamGia = (Int32.Parse(soLuong) * double.Parse(giamGia)).ToString();
            string tongTien = (Int32.Parse(soLuong) * double.Parse(donGia) - Int32.Parse(soLuong) * double.Parse(giamGia)).ToString();
            dgvChiTietHoaDon.Rows[rowIndex].Cells[5].Value = tongGiamGia;
            dgvChiTietHoaDon.Rows[rowIndex].Cells[6].Value = tongTien;

            double thanhTien = 0;
            int columnIndex = dgvChiTietHoaDon.Columns["TongTien"].Index;
            for (int i = 0; i < dgvChiTietHoaDon.RowCount - 1; i++)
            {
                thanhTien += double.Parse(dgvChiTietHoaDon.Rows[i].Cells[columnIndex].Value.ToString());
            }
            lbTongTien.Text = thanhTien.ToString("N0") + " đ";
        }

        private void dgvChiTietHoaDon_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvChiTietHoaDon.CurrentCell.Value == null)
                {
                    MessageBox.Show("Bạn chưa nhập số lượng!");
                    dgvChiTietHoaDon.CurrentCell.Value = 1;

                }
                else
                {
                    int rowIndex = dgvChiTietHoaDon.CurrentCell.RowIndex;

                    string soLuong = dgvChiTietHoaDon.Rows[rowIndex].Cells[2].Value.ToString();
                    string donGia = dgvChiTietHoaDon.Rows[rowIndex].Cells[3].Value.ToString();
                    string giamGia = dgvChiTietHoaDon.Rows[rowIndex].Cells[5].Value.ToString();
                    //MessageBox.Show(soLuong + donGia + giamGia);

                    string tongGiamGia = (double.Parse(giamGia)).ToString();
                    string tongTien = (Int32.Parse(soLuong) * double.Parse(donGia) - Int32.Parse(soLuong) * double.Parse(giamGia)).ToString();
                    dgvChiTietHoaDon.Rows[rowIndex].Cells[5].Value = tongGiamGia;
                    dgvChiTietHoaDon.Rows[rowIndex].Cells[6].Value = tongTien;

                    double thanhTien = 0;
                    int columnIndex = dgvChiTietHoaDon.Columns["TongTien"].Index;
                    for (int i = 0; i < dgvChiTietHoaDon.RowCount - 1; i++)
                    {
                        thanhTien += double.Parse(dgvChiTietHoaDon.Rows[i].Cells[columnIndex].Value.ToString());
                    }
                    lbTongTien.Text = thanhTien.ToString("N0") + " đ";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnXoaHoaDon_Click(object sender, EventArgs e)
        {
            dgvChiTietHoaDon.Rows.Clear();
        }
    }
}
