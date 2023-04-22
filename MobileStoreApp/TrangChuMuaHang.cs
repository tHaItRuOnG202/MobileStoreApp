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
using DAO_MoblieStoreApp;
using BUS_MobileStoreApp;

namespace MobileStoreApp
{
    public partial class TrangChuMuaHang : Form
    {
        BUS_Controller ctrl_B = new BUS_Controller();
        const int MAX_ARRAY = 9999999;
        //int cell = 130;

        public TrangChuMuaHang()
        {
            InitializeComponent();
        }

        //private void button1_Click(object sender, EventArgs e)
        //{
        //    Size s = new Size(1000, 1000);

        //    DataTable ProductList = ctrl_B.ShowProductV2();
        //    string[] idSanPhams = new string[MAX_ARRAY];
        //    string[] tenSanPhams = new string[MAX_ARRAY];
        //    string[] giaSanPhams = new string[MAX_ARRAY];
        //    int rowCount = ctrl_B.ShowProductV2().Rows.Count;
        //    int picWidth = 100;
        //    int picHeight = 100;
        //    int picX = picWidth;
        //    int picY = picHeight;
        //    int labelNameX = picWidth + 10;
        //    int labelNameY = picHeight + 100;
        //    int countPic = 0;
        //    for (int i = 0; i < rowCount; i++)
        //    {
        //        if (countPic == 3)
        //        {
        //            countPic = 0;
        //            picX = 100;
        //            picY = picHeight * 2 + 50;
        //            labelNameX = labelNameX + 10;
        //            labelNameY = picHeight * 2 + 100;
        //        }
        //        idSanPhams[i] = ProductList.Rows[i][4].ToString();

        //        tenSanPhams[i] = ProductList.Rows[i][1].ToString();

        //        string duongDan = Application.StartupPath + "\\pictures\\" + idSanPhams[i];
        //        Label tenSanPham = new Label();

        //        tenSanPham.Location = new Point(countPic * labelNameX, labelNameY);
        //        tenSanPham.Text = tenSanPhams[i];
        //        //MessageBox.Show(duongDan);

        //        PictureBox pictureBox = new PictureBox();

        //        // Thiết lập thuộc tính Location để đặt vị trí mới cho PictureBox
        //        pictureBox.Location = new Point(countPic * (picX + 10), picY);

        //        // Thiết lập thuộc tính Size để đặt kích thước cho PictureBox
        //        pictureBox.Size = new Size(picWidth, picHeight);

        //        //Thiết lập hiển thị hình ảnh
        //        pictureBox.SizeMode = PictureBoxSizeMode.Zoom;

        //        // Thiết lập thuộc tính Image để đặt hình ảnh cho PictureBox

        //        try
        //        {
        //            //pictureBox.Image = Image.FromFile("E:\\LTGD\\MobileStoreApp\\MobileStoreApp\\bin\\Debug\\pictures\\oppo-n2-flip-den-thumb-600x600.jpg");
        //            pictureBox.Image = Image.FromFile(duongDan);
        //        }
        //        catch (FileNotFoundException)
        //        {
        //            //MessageBox.Show("Không tìm thấy hình ảnh!", "Thông báo");
        //            pictureBox.Image = Image.FromFile(Application.StartupPath + "\\pictures\\" + "404-error.png");
        //            tenSanPham.Text = "Not Found";
        //        }

        //        countPic++;

        //        //Thêm label cho sản phẩm


        //        //tenSanPham.Text = ;

        //        // Thêm PictureBox vào một Control trên form của bạn, ví dụ như Panel
        //        panel1.Controls.Add(pictureBox);
        //        panel1.Controls.Add(tenSanPham);

        //        //MessageBox.Show(duongDan);
        //    }

        //private void button1_Click(object sender, EventArgs e)
        //{
        //    //Graphics e = this.CreateGraphics();
        //    DataTable ProductList = ctrl_B.ShowProductV2();
        //    string[] hinhSanPhams = new string[MAX_ARRAY];
        //    string[] tenSanPhams = new string[MAX_ARRAY];
        //    string[] giaSanPhams = new string[MAX_ARRAY];
        //    int rowCount = ctrl_B.ShowProductV2().Rows.Count;

        //    //flowLayoutPanel1.Dock = DockStyle.Top;

        //    for (int i = 0; i < rowCount; i++)
        //    {
        //        hinhSanPhams[i] = ProductList.Rows[i][4].ToString();
        //        tenSanPhams[i] = ProductList.Rows[i][1].ToString();
        //        giaSanPhams[i] = ProductList.Rows[i][3].ToString();
        //        string duongDan = Application.StartupPath + "\\pictures\\" + hinhSanPhams[i];
        //        PictureBox pictureBox = new PictureBox();
        //        pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
        //        pictureBox.Width = 120;
        //        pictureBox.Height = 120;
        //        pictureBox.Margin = new Padding(10, 10, 10, 30);

        //        TableLayoutPanel productLayout = new TableLayoutPanel();
        //        productLayout.ColumnCount = 1;
        //        productLayout.RowCount = 2;
        //        productLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
        //        productLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 40F));
        //        productLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 60F));

        //        Label nameProduct = new Label();
        //        nameProduct.Text = tenSanPhams[i];
        //        nameProduct.Dock = DockStyle.Fill;
        //        nameProduct.Size = new Size(200, 20);
        //        nameProduct.Margin = new Padding(10, 10, 10, 10);
        //        nameProduct.Font = new Font("Microsoft Sans Serif", 9, FontStyle.Bold);
        //        productLayout.Controls.Add(nameProduct, 0, 0);
        //        //l.Location = new Point(pictureBox.Width, pictureBox.Height);

        //        Label priceProduct = new Label();
        //        priceProduct.Text = giaSanPhams[i];
        //        priceProduct.Dock = DockStyle.Fill;
        //        priceProduct.Size = new Size(200, 20);
        //        priceProduct.Margin = new Padding(10, 10, 10, 10);
        //        priceProduct.Font = new Font("Microsoft Sans Serif", 9, FontStyle.Bold);
        //        productLayout.Controls.Add(priceProduct, 0, 1);

        //        try
        //        {
        //            //pictureBox.Image = Image.FromFile("E:\\LTGD\\MobileStoreApp\\MobileStoreApp\\bin\\Debug\\pictures\\oppo-n2-flip-den-thumb-600x600.jpg");
        //            pictureBox.Image = Image.FromFile(duongDan);
        //        }
        //        catch (FileNotFoundException)
        //        {
        //            MessageBox.Show("Không tìm thấy hình ảnh!" + i.ToString(), "Thông báo");
        //            pictureBox.Image = Image.FromFile(Application.StartupPath + "\\pictures\\" + "404-error.png");
        //            //flowLayoutPanel1.Controls.Add(pictureBox);
        //            //tenSanPham.Text = "Not Found";
        //        }
        //        flowLayoutPanel1.Controls.Add(pictureBox);
        //        flowLayoutPanel1.Controls.Add(productLayout);
        //    }
        //}

        private void LoadProductMenu()
        {
            //Graphics e = this.CreateGraphics();
            DataTable ProductList = ctrl_B.ShowProductV2();
            string[] hinhSanPhams = new string[MAX_ARRAY];
            string[] tenSanPhams = new string[MAX_ARRAY];
            string[] giaSanPhams = new string[MAX_ARRAY];
            int rowCount = ctrl_B.ShowProductV2().Rows.Count;

            //flowLayoutPanel1.Dock = DockStyle.Top;

            for (int i = 0; i < rowCount; i++)
            {
                hinhSanPhams[i] = ProductList.Rows[i][4].ToString();
                tenSanPhams[i] = ProductList.Rows[i][1].ToString();
                giaSanPhams[i] = ProductList.Rows[i][3].ToString();
                string duongDan = Application.StartupPath + "\\pictures\\" + hinhSanPhams[i];
                PictureBox pictureBox = new PictureBox();
                pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                pictureBox.Width = 120;
                pictureBox.Height = 120;
                pictureBox.Margin = new Padding(10, 10, 10, 30);

                TableLayoutPanel productLayout = new TableLayoutPanel();
                productLayout.ColumnCount = 1;
                productLayout.RowCount = 2;
                productLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
                productLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 40F));
                productLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 60F));

                Label nameProduct = new Label();
                nameProduct.Text = tenSanPhams[i];
                nameProduct.Dock = DockStyle.Fill;
                nameProduct.Size = new Size(200, 20);
                nameProduct.Margin = new Padding(10, 10, 10, 10);
                nameProduct.Font = new Font("Microsoft Sans Serif", 9, FontStyle.Bold);
                productLayout.Controls.Add(nameProduct, 0, 0);
                //l.Location = new Point(pictureBox.Width, pictureBox.Height);

                Label priceProduct = new Label();
                priceProduct.Text = giaSanPhams[i];
                priceProduct.Dock = DockStyle.Fill;
                priceProduct.Size = new Size(200, 20);
                priceProduct.Margin = new Padding(10, 10, 10, 10);
                priceProduct.Font = new Font("Microsoft Sans Serif", 9, FontStyle.Bold);
                productLayout.Controls.Add(priceProduct, 0, 1);

                try
                {
                    //pictureBox.Image = Image.FromFile("E:\\LTGD\\MobileStoreApp\\MobileStoreApp\\bin\\Debug\\pictures\\oppo-n2-flip-den-thumb-600x600.jpg");
                    pictureBox.Image = Image.FromFile(duongDan);
                }
                catch (FileNotFoundException)
                {
                    MessageBox.Show("Không tìm thấy hình ảnh!" + i.ToString(), "Thông báo");
                    pictureBox.Image = Image.FromFile(Application.StartupPath + "\\pictures\\" + "404-error.png");
                    //flowLayoutPanel1.Controls.Add(pictureBox);
                    //tenSanPham.Text = "Not Found";
                }
                flowLayoutPanel1.Controls.Add(pictureBox);
                flowLayoutPanel1.Controls.Add(productLayout);
            }
        }

        private void TrangChuMuaHang_Load(object sender, EventArgs e)
        {
            LoadProductMenu();
        }

        private void llbThanhToan_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmHoaDon frmHoaDon = new frmHoaDon();
            frmHoaDon.ShowDialog();
        }
    }
}
