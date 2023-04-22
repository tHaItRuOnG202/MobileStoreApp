using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MobileStoreApp
{
    public partial class formTrangChuQuanLy : Form
    {
        public formTrangChuQuanLy()
        {
            InitializeComponent();
        }

        private void formTrangChuQuanLy_Paint(object sender, PaintEventArgs e)
        {
            string slogan = "TRANG CHỦ QUẢN LÝ BÁN HÀNG DI ĐỘNG";
            Rectangle rect = new Rectangle(0, 0, ClientRectangle.Width, ClientRectangle.Height);
            LinearGradientBrush lgbrush = new LinearGradientBrush(rect, Color.FromArgb(207, 244, 210), Color.FromArgb(86, 197, 150), 1);
            HatchBrush hbr = new HatchBrush(HatchStyle.DottedDiamond, Color.AliceBlue, Color.DarkGreen);
            Font font = new Font("Tahoma", 45, FontStyle.Bold);
            StringFormat format = new StringFormat();
            format.FormatFlags = StringFormatFlags.DirectionRightToLeft;
            format.Alignment = StringAlignment.Center;
            format.LineAlignment = StringAlignment.Center;
            e.Graphics.FillRectangle(lgbrush, rect);
            e.Graphics.DrawString(slogan, font, hbr, rect, format);
        }

        private void menuNhanVien_Click(object sender, EventArgs e)
        {
            frmNhanVien frmNhanVien = new frmNhanVien();
            frmNhanVien.ShowDialog();
        }

        private void menuKhachHang_Click(object sender, EventArgs e)
        {
            frmKhachHang frmKhachHang = new frmKhachHang();
            frmKhachHang.ShowDialog();
        }

        private void menuLoaiSanPham_Click(object sender, EventArgs e)
        {
            frmLoaiSanPham frmLoaiSanPham = new frmLoaiSanPham();
            frmLoaiSanPham.ShowDialog();
        }

        private void menuSanPham_Click(object sender, EventArgs e)
        {
            frmSanPham frmSanPham = new frmSanPham();
            frmSanPham.ShowDialog();
        }

        private void menuGiamGia_Click(object sender, EventArgs e)
        {
            frmGiamGia frmGiamGia = new frmGiamGia();
            frmGiamGia.ShowDialog();
        }

        private void menuHoaDon_Click(object sender, EventArgs e)
        {
            frmQuanLyHoaDon frmQuanLyHoaDon = new frmQuanLyHoaDon();
            frmQuanLyHoaDon.ShowDialog();
        }

        private void menuThongKe_Click(object sender, EventArgs e)
        {
            frmThongKe frmThongKe = new frmThongKe();
            frmThongKe.ShowDialog();
        }
    }

}
