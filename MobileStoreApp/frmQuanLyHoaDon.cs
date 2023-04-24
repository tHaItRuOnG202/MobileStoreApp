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
    public partial class frmQuanLyHoaDon : Form
    {
        BUS_Controller ctrl_B = new BUS_Controller();
        public frmQuanLyHoaDon()
        {
            InitializeComponent();
        }

        private void frmQuanLyHoaDon_Load(object sender, EventArgs e)
        {
            dgvHoaDon.DataSource = ctrl_B.ShowReceiptV2();
            txtKhachHang.Enabled = false;
            txtNhanVien.Enabled = false;
            txtMaHoaDon.Enabled = false;
        }

        private void dgvHoaDon_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                int i = dgvHoaDon.CurrentRow.Index;

                txtMaHoaDon.Text = dgvHoaDon.Rows[i].Cells[0].Value.ToString();
                dtpNgayXuatHoaDon.Text = dgvHoaDon.Rows[i].Cells[1].Value.ToString();
                lbTongTien.Text = dgvHoaDon.Rows[i].Cells[2].Value.ToString();
                txtNhanVien.Text = dgvHoaDon.Rows[i].Cells[3].Value.ToString();
                txtKhachHang.Text = dgvHoaDon.Rows[i].Cells[4].Value.ToString();

                SeeReceiptDetail();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void SeeReceiptDetail()
        {
            int rowIndex = dgvHoaDon.CurrentRow.Index;
            dgvChiTietHoaDon.DataSource = ctrl_B.ShowReceiptDetail(Int32.Parse(dgvHoaDon.Rows[rowIndex].Cells[0].Value.ToString()));

            //for (int j = 0; j < dgvChiTietHoaDon.RowCount - 1; j++)
            //{
            //    string soLuong = dgvChiTietHoaDon.Rows[j].Cells[3].Value.ToString();
            //    string donGia = dgvChiTietHoaDon.Rows[j].Cells[5].Value.ToString();
                //string giamGia = dgvChiTietHoaDon.Rows[j].Cells[6].Value.ToString();

                //MessageBox.Show(soLuong + donGia + giamGia);

                //string tongGiamGia = (Int32.Parse(soLuong) * double.Parse(giamGia)).ToString();
                //string tongTien = (Int32.Parse(soLuong) * double.Parse(donGia) - Int).ToString();

                //dgvChiTietHoaDon.Rows[j].Cells[6].Value = tongGiamGia;
                //dgvChiTietHoaDon.Rows[j].Cells[0].Value = tongTien;
            //}
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = ctrl_B.FindReceiptCustomer(txtTimKiem.Text);
            dgvHoaDon.DataSource = dt;
        }

        //private void frmQuanLyHoaDon_Paint(object sender, PaintEventArgs e)
        //{
        //    Graphics myGraphics = e.Graphics;
        //    Pen myPen = new Pen(Color.FromArgb(144, 238, 144), 1);

        //    Rectangle area = new Rectangle(0, 0, this.Width - 1, this.Height - 1);
        //    LinearGradientBrush lgb = new LinearGradientBrush(area, Color.FromArgb(144, 238, 144), Color.FromArgb(245, 251, 251), LinearGradientMode.ForwardDiagonal);

        //    myGraphics.FillRectangle(lgb, area);
        //    myGraphics.DrawRectangle(myPen, area);
        //}

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
