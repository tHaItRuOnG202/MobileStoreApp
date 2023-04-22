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

        private void loadAll()
        {
            flowLayoutPanel1.Controls.Clear();
        }

        private void LoadProductMenuOld()
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

        private void LoadProductMenu(DataTable dataTable)
        {
            //DataTable ProductList = ctrl_B.ShowProductV2();
            string[] hinhSanPhams = new string[MAX_ARRAY];
            string[] tenSanPhams = new string[MAX_ARRAY];
            string[] giaSanPhams = new string[MAX_ARRAY];
            int rowCount = dataTable.Rows.Count;

            //flowLayoutPanel1.Dock = DockStyle.Top;

            for (int i = 0; i < rowCount; i++)
            {
                hinhSanPhams[i] = dataTable.Rows[i][4].ToString();
                tenSanPhams[i] = dataTable.Rows[i][1].ToString();
                giaSanPhams[i] = dataTable.Rows[i][3].ToString();
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
                nameProduct.Anchor = AnchorStyles.None;
                nameProduct.TextAlign = ContentAlignment.MiddleCenter;
                nameProduct.Size = new Size(200, 200);
                nameProduct.Font = new Font("Microsoft Sans Serif", 9, FontStyle.Bold);
                //nameProduct.BackColor = Color.Aqua;
                productLayout.Controls.Add(nameProduct, 0, 0);
                //l.Location = new Point(pictureBox.Width, pictureBox.Height);

                Label priceProduct = new Label();
                priceProduct.Text = giaSanPhams[i];
                priceProduct.Dock = DockStyle.Fill;
                priceProduct.Size = new Size(200, 200);
                priceProduct.Anchor = AnchorStyles.None;
                priceProduct.TextAlign = ContentAlignment.MiddleCenter;
                //priceProduct.Margin = new Padding(10, 10, 10, 10);
                priceProduct.Font = new Font("Microsoft Sans Serif", 9, FontStyle.Bold);
                //priceProduct.BackColor = Color.Yellow;
                productLayout.Controls.Add(priceProduct, 0, 1);

                try
                {
                    //pictureBox.Image = Image.FromFile("E:\\LTGD\\MobileStoreApp\\MobileStoreApp\\bin\\Debug\\pictures\\oppo-n2-flip-den-thumb-600x600.jpg");
                    pictureBox.Image = Image.FromFile(duongDan);
                }
                catch (FileNotFoundException)
                {
                    //MessageBox.Show("Không tìm thấy hình ảnh!" + i.ToString(), "Thông báo");
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
            DataTable ProductList = ctrl_B.ShowProductV2();
            LoadProductMenu(ProductList);
            //LoadProductMenu();
            cbSort.Items.Add("Giảm dần theo giá");
            cbSort.Items.Add("Tăng dần theo giá");
        }

        private void llbThanhToan_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmDangNhap frmDangNhap = new frmDangNhap();
            frmDangNhap.ShowDialog();
        }

        private void cbSort_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.loadAll();
            DataTable dt = ctrl_B.sortGd(cbSort.SelectedIndex);
            LoadProductMenu(dt);
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            this.loadAll();
            DataTable dt = ctrl_B.FoundProduct(txtSearch.Text);
            this.LoadProductMenu(dt);
        }
    }
}
