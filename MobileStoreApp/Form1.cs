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
    }

}
