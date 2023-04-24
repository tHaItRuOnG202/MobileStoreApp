
namespace MobileStoreApp
{
    partial class formTrangChuQuanLy
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuQuanLy = new System.Windows.Forms.MenuStrip();
            this.menuDMQuanLy = new System.Windows.Forms.ToolStripMenuItem();
            this.menuNhanVien = new System.Windows.Forms.ToolStripMenuItem();
            this.menuKhachHang = new System.Windows.Forms.ToolStripMenuItem();
            this.menuLoaiSanPham = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSanPham = new System.Windows.Forms.ToolStripMenuItem();
            this.menuGiamGia = new System.Windows.Forms.ToolStripMenuItem();
            this.menuHoaDon = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.menuThoat = new System.Windows.Forms.ToolStripMenuItem();
            this.menuThongKe = new System.Windows.Forms.ToolStripMenuItem();
            this.menuQuanLy.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuQuanLy
            // 
            this.menuQuanLy.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuQuanLy.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuDMQuanLy,
            this.menuThongKe});
            this.menuQuanLy.Location = new System.Drawing.Point(0, 0);
            this.menuQuanLy.Name = "menuQuanLy";
            this.menuQuanLy.Size = new System.Drawing.Size(1000, 28);
            this.menuQuanLy.TabIndex = 0;
            this.menuQuanLy.Text = "menuQuanLy";
            // 
            // menuDMQuanLy
            // 
            this.menuDMQuanLy.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuNhanVien,
            this.menuKhachHang,
            this.menuLoaiSanPham,
            this.menuSanPham,
            this.menuGiamGia,
            this.menuHoaDon,
            this.toolStripSeparator1,
            this.menuThoat});
            this.menuDMQuanLy.Name = "menuDMQuanLy";
            this.menuDMQuanLy.Size = new System.Drawing.Size(142, 24);
            this.menuDMQuanLy.Text = "Danh mục quản lý";
            // 
            // menuNhanVien
            // 
            this.menuNhanVien.Name = "menuNhanVien";
            this.menuNhanVien.Size = new System.Drawing.Size(224, 26);
            this.menuNhanVien.Text = "Nhân viên";
            this.menuNhanVien.Click += new System.EventHandler(this.menuNhanVien_Click);
            // 
            // menuKhachHang
            // 
            this.menuKhachHang.Name = "menuKhachHang";
            this.menuKhachHang.Size = new System.Drawing.Size(224, 26);
            this.menuKhachHang.Text = "Khách hàng";
            this.menuKhachHang.Click += new System.EventHandler(this.menuKhachHang_Click);
            // 
            // menuLoaiSanPham
            // 
            this.menuLoaiSanPham.Name = "menuLoaiSanPham";
            this.menuLoaiSanPham.Size = new System.Drawing.Size(224, 26);
            this.menuLoaiSanPham.Text = "Loại sản phẩm";
            this.menuLoaiSanPham.Click += new System.EventHandler(this.menuLoaiSanPham_Click);
            // 
            // menuSanPham
            // 
            this.menuSanPham.Name = "menuSanPham";
            this.menuSanPham.Size = new System.Drawing.Size(224, 26);
            this.menuSanPham.Text = "Sản phẩm";
            this.menuSanPham.Click += new System.EventHandler(this.menuSanPham_Click);
            // 
            // menuGiamGia
            // 
            this.menuGiamGia.Name = "menuGiamGia";
            this.menuGiamGia.Size = new System.Drawing.Size(224, 26);
            this.menuGiamGia.Text = "Giảm giá";
            this.menuGiamGia.Click += new System.EventHandler(this.menuGiamGia_Click);
            // 
            // menuHoaDon
            // 
            this.menuHoaDon.Name = "menuHoaDon";
            this.menuHoaDon.Size = new System.Drawing.Size(224, 26);
            this.menuHoaDon.Text = "Hóa đơn";
            this.menuHoaDon.Click += new System.EventHandler(this.menuHoaDon_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(221, 6);
            // 
            // menuThoat
            // 
            this.menuThoat.Name = "menuThoat";
            this.menuThoat.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.menuThoat.Size = new System.Drawing.Size(224, 26);
            this.menuThoat.Text = "Thoát";
            this.menuThoat.Click += new System.EventHandler(this.menuThoat_Click);
            // 
            // menuThongKe
            // 
            this.menuThongKe.Name = "menuThongKe";
            this.menuThongKe.Size = new System.Drawing.Size(84, 24);
            this.menuThongKe.Text = "Thống kê";
            this.menuThongKe.Click += new System.EventHandler(this.menuThongKe_Click);
            // 
            // formTrangChuQuanLy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 562);
            this.Controls.Add(this.menuQuanLy);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuQuanLy;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "formTrangChuQuanLy";
            this.Text = "Trang Chủ Quản Lý";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.formTrangChuQuanLy_Paint);
            this.menuQuanLy.ResumeLayout(false);
            this.menuQuanLy.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuQuanLy;
        private System.Windows.Forms.ToolStripMenuItem menuDMQuanLy;
        private System.Windows.Forms.ToolStripMenuItem menuNhanVien;
        private System.Windows.Forms.ToolStripMenuItem menuKhachHang;
        private System.Windows.Forms.ToolStripMenuItem menuLoaiSanPham;
        private System.Windows.Forms.ToolStripMenuItem menuSanPham;
        private System.Windows.Forms.ToolStripMenuItem menuGiamGia;
        private System.Windows.Forms.ToolStripMenuItem menuHoaDon;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem menuThoat;
        private System.Windows.Forms.ToolStripMenuItem menuThongKe;
    }
}

