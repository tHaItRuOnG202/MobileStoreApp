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

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //private void frmThongKe_Paint(object sender, PaintEventArgs e)
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
