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

namespace MobileStoreApp
{
    public partial class frmThongKe : Form
    {
        BUS_Controller ctrl_B = new BUS_Controller();
        public frmThongKe()
        {
            InitializeComponent();
        }

        private void frmThongKe_Load(object sender, EventArgs e)
        {
            int month = dtpThoiGianSanPham.Value.Month;
            int year = dtpThoiGianSanPham.Value.Year;

            dgvKhachHangDoanhThu.DataSource = ctrl_B.ShowRevenueCustomer(month, year);

            dgvSanPhamDoanhThu.DataSource = ctrl_B.ShowRevenueProduct(month, year);
        }

        private void dtpThoiGianSanPham_ValueChanged(object sender, EventArgs e)
        {
            int month = dtpThoiGianSanPham.Value.Month;
            int year = dtpThoiGianSanPham.Value.Year;

            dgvSanPhamDoanhThu.DataSource = ctrl_B.ShowRevenueProduct(month, year);
        }

        private void dtpThoiGianKhachHang_ValueChanged(object sender, EventArgs e)
        {
            int month = dtpThoiGianSanPham.Value.Month;
            int year = dtpThoiGianSanPham.Value.Year;

            dgvKhachHangDoanhThu.DataSource = ctrl_B.ShowRevenueCustomer(month, year);
        }
    }
}
