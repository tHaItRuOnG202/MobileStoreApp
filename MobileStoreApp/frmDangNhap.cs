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

namespace MobileStoreApp
{
    public partial class frmDangNhap : Form
    {
        IMPROOKSTOREDataContext db;
        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtTenDangNhap.Text != String.Empty || txtMatKhau.Text != String.Empty)
                {
                    db = new IMPROOKSTOREDataContext();
                    var nvid = from n in db.NhanViens
                               select new
                               {
                                   n.TaiKhoanNhanVien,
                                   n.MatKhauNhanVien,
                                   n.IDNhanVien,
                                   n.HoNhanVien,
                                   n.TenNhanVien,
                                   n.LoaiNhanVien
                               };

                    int count = 0;
                    foreach (var n in nvid)
                    {
                        if (txtTenDangNhap.Text == n.TaiKhoanNhanVien && txtMatKhau.Text == n.MatKhauNhanVien && n.LoaiNhanVien == true)
                        {
                            MessageBox.Show("Đăng nhập thành công");
                            frmHoaDon frmHoaDon = new frmHoaDon();
                            frmHoaDon.HoTen = n.HoNhanVien + " " + n.TenNhanVien;
                            frmHoaDon.IDNhanVien = n.IDNhanVien.ToString();
                            frmHoaDon.ShowDialog();
                            //this.Close();
                            //frmHoaDon.Show();
                            break;
                        }
                        else if (txtTenDangNhap.Text == n.TaiKhoanNhanVien && txtMatKhau.Text == n.MatKhauNhanVien && n.LoaiNhanVien == false)
                        {
                            MessageBox.Show("Đăng nhập thành công");
                            formTrangChuQuanLy formTrangChuQuanLy = new formTrangChuQuanLy();
                            formTrangChuQuanLy.ShowDialog();
                            break;
                        }    
                        else
                        {
                            count++;
                        }
                        if (nvid.Count() == count)
                        {
                            MessageBox.Show("Sai tài khoản hoặc mật khẩu!");
                            break;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập thông tin đăng nhập!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
