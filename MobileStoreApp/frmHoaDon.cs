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
using System.Text.RegularExpressions;
using System.Drawing.Drawing2D;

namespace MobileStoreApp
{
    public partial class frmHoaDon : Form
    {
        BUS_Controller ctrl_B = new BUS_Controller();
        //public static string HoTen = "";
        //public static string IDNhanVien = "";
        private int ID;
        private string Ho;
        private string Ten;
        const int MAX_ARRAY = 9999999;
        int count;
        
        public frmHoaDon(int IDNhanVien, string HoNhanVien, string TenNhanVien)
        {
            //frmDangNhap frmDangNhap = new frmDangNhap();
            InitializeComponent();
            this.ID = IDNhanVien;
            this.Ho = HoNhanVien;
            this.Ten = TenNhanVien;
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
            //lbMaNhanVien.Text = IDNhanVien;
            //lbTenNhanVien.Text = HoTen;
            dtpNgayXuatHoaDon.Enabled = false;
            lbMaNhanVien.Text = ID.ToString();
            lbTenNhanVien.Text = Ho + " " + Ten;
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

        private bool applyDiscount(SanPham sp)
        {
            DateTime ngayBatDau = ctrl_B.takeDiscount(sp.IDGiamGia).NgayBatDau;
            DateTime ngayKetThuc = ctrl_B.takeDiscount(sp.IDGiamGia).NgayKetThuc;
            DateTime ngayHientai = DateTime.Now;

            if (ngayHientai.Date.CompareTo(ngayBatDau.Date) >= 0 && ngayHientai.CompareTo(ngayKetThuc.Date) <= 0)
            {
                MessageBox.Show("Sản phẩm đang trong thời gian giảm giá!");
                return true;
            }
            else
            {
                return false;
            }    
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

                SanPham sp = ctrl_B.GetPrById(Int32.Parse(cbMaSanPham.Text));
                bool check = applyDiscount(sp);

                string maSP = cbMaSanPham.Text;
                string tenSP = lbTenSanPham.Text;
                string soLuong = txtSoLuong.Text;
                string donGia = lbDonGia.Text;
                string donVi = lbDonVi.Text;
                string giamGia = (Int32.Parse(lbGiamGia.Text)).ToString();
                string tien;
                if (check == true)
                {
                    tien = (Int32.Parse(txtSoLuong.Text) * decimal.Parse(lbDonGia.Text) - decimal.Parse(lbGiamGia.Text) * Int32.Parse(txtSoLuong.Text)).ToString();
                }
                else
                {
                    tien = (Int32.Parse(txtSoLuong.Text) * decimal.Parse(lbDonGia.Text)).ToString();
                }

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
                lbTongTien.Text = thanhTien.ToString();
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
                    lbTongTien.Text = thanhTien.ToString();
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
            try
            {
                bool isNull = DatagridviewCheck();

                if (isNull == true)
                {
                    MessageBox.Show("Chưa có thông tin hóa đơn để thêm!");
                }
                else
                {
                    DataTable receiptTable = ctrl_B.ShowReceipt();
                    int lastRowIndex = receiptTable.Rows.Count - 1;
                    int lastReceiptID = Int32.Parse(receiptTable.Rows[lastRowIndex][0].ToString());

                    int idHD = lastReceiptID;
                    string idKH = cbMaKhachHang.Text;
                    string idNV = lbMaNhanVien.Text;
                    DateTime dateTime = DateTime.Parse(dtpNgayXuatHoaDon.Text);
                    ctrl_B.AddReceipt(idHD + 1, dateTime, lbTongTien.Text, Int32.Parse(idNV), Int32.Parse(idKH));

                    for (int i = 0; i < dgvChiTietHoaDon.RowCount - 1; i++)
                    {
                        string idPro = dgvChiTietHoaDon.Rows[i].Cells[0].Value.ToString();
                        string quantity = dgvChiTietHoaDon.Rows[i].Cells[2].Value.ToString();
                        string uPrice = dgvChiTietHoaDon.Rows[i].Cells[3].Value.ToString();
                        string totalPrice = dgvChiTietHoaDon.Rows[i].Cells[6].Value.ToString();
                        //decimal uPrice = decimal.Parse(row.Cells[3].ToString());
                        //decimal totalPrice = decimal.Parse(row.Cells[6].ToString());

                        ctrl_B.AddReceiptDetail(idHD + 1, idPro, Int32.Parse(quantity), uPrice);
                    }
                    MessageBox.Show("Thêm hóa đơn thành công!");
                    dgvChiTietHoaDon.Rows.Clear();
                    cbMaKhachHang.SelectedIndex = 0;
                    cbMaSanPham.SelectedIndex = 0;
                    //ctrl_B.AddReceiptDetail(idHD, idPro, quantity, uPrice, totalPrice);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cbMaSanPham_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int IDProd = Int32.Parse(cbMaSanPham.Text);

                SanPham sp = ctrl_B.GetPrById(IDProd);

                if (sp != null)
                {
                    lbTenSanPham.Text = sp.TenSanPham;
                    lbDonVi.Text = sp.DonVi;
                    lbGiamGia.Text = ctrl_B.takeDiscount(sp.IDGiamGia).GiaTri;
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
            lbTongTien.Text = thanhTien.ToString();
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
                    lbTongTien.Text = thanhTien.ToString();
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

        private void txtSoLuong_TextChanged(object sender, EventArgs e)
        {
            string pattern = @"^(\d*|\s*)$";
            Regex regex = new Regex(pattern);
            bool isMatch = regex.IsMatch(txtSoLuong.Text);
            if (isMatch && txtSoLuong.Text != "0")
            {

            }
            else
            {
                MessageBox.Show("Chỉ được phép nhập số lớn hơn 0!");
                txtSoLuong.Text = "1";
            }    
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmHoaDon_Paint(object sender, PaintEventArgs e)
        {
            Graphics myGraphics = e.Graphics;
            Pen myPen = new Pen(Color.FromArgb(144, 238, 144), 1);

            Rectangle area = new Rectangle(0, 0, this.Width - 1, this.Height - 1);
            LinearGradientBrush lgb = new LinearGradientBrush(area, Color.FromArgb(144, 238, 144), Color.FromArgb(245, 251, 251), LinearGradientMode.ForwardDiagonal);

            myGraphics.FillRectangle(lgb, area);
            myGraphics.DrawRectangle(myPen, area);
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {

        }
    }
}
