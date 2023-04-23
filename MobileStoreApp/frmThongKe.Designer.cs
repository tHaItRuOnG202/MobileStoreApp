
namespace MobileStoreApp
{
    partial class frmThongKe

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
            this.lbHeader = new System.Windows.Forms.Label();
            this.gbThongTin = new System.Windows.Forms.GroupBox();
            this.dtpThoiGianSanPham = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.grChiTiet = new System.Windows.Forms.GroupBox();
            this.dgvKhachHangDoanhThu = new System.Windows.Forms.DataGridView();
            this.IDKhachHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenKhachHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TongTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvSanPhamDoanhThu = new System.Windows.Forms.DataGridView();
            this.IDSanPham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenSanPham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DoanhThu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDangXuat = new System.Windows.Forms.Button();
            this.btnDong = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtpThoiGianKhachHang = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.gbThongTin.SuspendLayout();
            this.grChiTiet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhachHangDoanhThu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSanPhamDoanhThu)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbHeader
            // 
            this.lbHeader.BackColor = System.Drawing.Color.Transparent;
            this.lbHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbHeader.Font = new System.Drawing.Font("Tahoma", 32F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHeader.ForeColor = System.Drawing.Color.SeaGreen;
            this.lbHeader.Location = new System.Drawing.Point(0, 0);
            this.lbHeader.Name = "lbHeader";
            this.lbHeader.Size = new System.Drawing.Size(1300, 76);
            this.lbHeader.TabIndex = 0;
            this.lbHeader.Text = "QUẢN LÝ THỐNG KÊ";
            this.lbHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gbThongTin
            // 
            this.gbThongTin.BackColor = System.Drawing.Color.Transparent;
            this.gbThongTin.Controls.Add(this.dtpThoiGianSanPham);
            this.gbThongTin.Controls.Add(this.label6);
            this.gbThongTin.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbThongTin.Location = new System.Drawing.Point(12, 100);
            this.gbThongTin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbThongTin.Name = "gbThongTin";
            this.gbThongTin.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbThongTin.Size = new System.Drawing.Size(655, 119);
            this.gbThongTin.TabIndex = 1;
            this.gbThongTin.TabStop = false;
            this.gbThongTin.Text = "Thông tin thống kê sản phẩm:";
            // 
            // dtpThoiGianSanPham
            // 
            this.dtpThoiGianSanPham.CustomFormat = "MM/yyyy";
            this.dtpThoiGianSanPham.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpThoiGianSanPham.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpThoiGianSanPham.Location = new System.Drawing.Point(207, 51);
            this.dtpThoiGianSanPham.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtpThoiGianSanPham.Name = "dtpThoiGianSanPham";
            this.dtpThoiGianSanPham.Size = new System.Drawing.Size(332, 30);
            this.dtpThoiGianSanPham.TabIndex = 2;
            this.dtpThoiGianSanPham.ValueChanged += new System.EventHandler(this.dtpThoiGianSanPham_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(20, 58);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 23);
            this.label6.TabIndex = 0;
            this.label6.Text = "Thời gian:";
            // 
            // grChiTiet
            // 
            this.grChiTiet.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grChiTiet.BackColor = System.Drawing.Color.Transparent;
            this.grChiTiet.Controls.Add(this.dgvKhachHangDoanhThu);
            this.grChiTiet.Controls.Add(this.dgvSanPhamDoanhThu);
            this.grChiTiet.Controls.Add(this.btnDangXuat);
            this.grChiTiet.Controls.Add(this.btnDong);
            this.grChiTiet.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grChiTiet.Location = new System.Drawing.Point(12, 247);
            this.grChiTiet.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grChiTiet.Name = "grChiTiet";
            this.grChiTiet.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grChiTiet.Size = new System.Drawing.Size(1277, 483);
            this.grChiTiet.TabIndex = 4;
            this.grChiTiet.TabStop = false;
            this.grChiTiet.Text = "Chi tiết thống kê:";
            // 
            // dgvKhachHangDoanhThu
            // 
            this.dgvKhachHangDoanhThu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvKhachHangDoanhThu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKhachHangDoanhThu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDKhachHang,
            this.TenKhachHang,
            this.TongTien});
            this.dgvKhachHangDoanhThu.Location = new System.Drawing.Point(667, 39);
            this.dgvKhachHangDoanhThu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvKhachHangDoanhThu.Name = "dgvKhachHangDoanhThu";
            this.dgvKhachHangDoanhThu.ReadOnly = true;
            this.dgvKhachHangDoanhThu.RowHeadersWidth = 51;
            this.dgvKhachHangDoanhThu.RowTemplate.Height = 24;
            this.dgvKhachHangDoanhThu.Size = new System.Drawing.Size(603, 354);
            this.dgvKhachHangDoanhThu.TabIndex = 0;
            // 
            // IDKhachHang
            // 
            this.IDKhachHang.DataPropertyName = "IDKhachHang";
            this.IDKhachHang.HeaderText = "Mã khách hàng";
            this.IDKhachHang.MinimumWidth = 6;
            this.IDKhachHang.Name = "IDKhachHang";
            this.IDKhachHang.ReadOnly = true;
            this.IDKhachHang.Width = 125;
            // 
            // TenKhachHang
            // 
            this.TenKhachHang.DataPropertyName = "TenKhachHang";
            this.TenKhachHang.HeaderText = "Tên khách hàng";
            this.TenKhachHang.MinimumWidth = 6;
            this.TenKhachHang.Name = "TenKhachHang";
            this.TenKhachHang.ReadOnly = true;
            this.TenKhachHang.Width = 125;
            // 
            // TongTien
            // 
            this.TongTien.DataPropertyName = "TongTien";
            this.TongTien.HeaderText = "Tổng tiền";
            this.TongTien.MinimumWidth = 6;
            this.TongTien.Name = "TongTien";
            this.TongTien.ReadOnly = true;
            this.TongTien.Width = 125;
            // 
            // dgvSanPhamDoanhThu
            // 
            this.dgvSanPhamDoanhThu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSanPhamDoanhThu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDSanPham,
            this.TenSanPham,
            this.SoLuong,
            this.DoanhThu});
            this.dgvSanPhamDoanhThu.Location = new System.Drawing.Point(6, 39);
            this.dgvSanPhamDoanhThu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvSanPhamDoanhThu.Name = "dgvSanPhamDoanhThu";
            this.dgvSanPhamDoanhThu.ReadOnly = true;
            this.dgvSanPhamDoanhThu.RowHeadersWidth = 51;
            this.dgvSanPhamDoanhThu.RowTemplate.Height = 24;
            this.dgvSanPhamDoanhThu.Size = new System.Drawing.Size(629, 354);
            this.dgvSanPhamDoanhThu.TabIndex = 0;
            // 
            // IDSanPham
            // 
            this.IDSanPham.DataPropertyName = "IDSanPham";
            this.IDSanPham.HeaderText = "Mã sản phẩm";
            this.IDSanPham.MinimumWidth = 6;
            this.IDSanPham.Name = "IDSanPham";
            this.IDSanPham.ReadOnly = true;
            this.IDSanPham.Width = 125;
            // 
            // TenSanPham
            // 
            this.TenSanPham.DataPropertyName = "TenSanPham";
            this.TenSanPham.HeaderText = "Tên sản phẩm";
            this.TenSanPham.MinimumWidth = 6;
            this.TenSanPham.Name = "TenSanPham";
            this.TenSanPham.ReadOnly = true;
            this.TenSanPham.Width = 125;
            // 
            // SoLuong
            // 
            this.SoLuong.DataPropertyName = "SoLuong";
            this.SoLuong.HeaderText = "Số lượng";
            this.SoLuong.MinimumWidth = 6;
            this.SoLuong.Name = "SoLuong";
            this.SoLuong.ReadOnly = true;
            this.SoLuong.Width = 125;
            // 
            // DoanhThu
            // 
            this.DoanhThu.DataPropertyName = "DoanhThu";
            this.DoanhThu.HeaderText = "Doanh thu";
            this.DoanhThu.MinimumWidth = 6;
            this.DoanhThu.Name = "DoanhThu";
            this.DoanhThu.ReadOnly = true;
            this.DoanhThu.Width = 125;
            // 
            // btnDangXuat
            // 
            this.btnDangXuat.BackColor = System.Drawing.Color.Red;
            this.btnDangXuat.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangXuat.ForeColor = System.Drawing.Color.White;
            this.btnDangXuat.Location = new System.Drawing.Point(827, 417);
            this.btnDangXuat.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.Size = new System.Drawing.Size(146, 51);
            this.btnDangXuat.TabIndex = 3;
            this.btnDangXuat.Text = "Đăng xuất";
            this.btnDangXuat.UseVisualStyleBackColor = false;
            // 
            // btnDong
            // 
            this.btnDong.BackColor = System.Drawing.Color.White;
            this.btnDong.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDong.ForeColor = System.Drawing.Color.Red;
            this.btnDong.Location = new System.Drawing.Point(628, 417);
            this.btnDong.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(156, 51);
            this.btnDong.TabIndex = 3;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = false;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.dtpThoiGianKhachHang);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(697, 100);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(591, 119);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin thống kê khách hàng:";
            // 
            // dtpThoiGianKhachHang
            // 
            this.dtpThoiGianKhachHang.CustomFormat = "MM/yyyy";
            this.dtpThoiGianKhachHang.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpThoiGianKhachHang.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpThoiGianKhachHang.Location = new System.Drawing.Point(202, 52);
            this.dtpThoiGianKhachHang.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtpThoiGianKhachHang.Name = "dtpThoiGianKhachHang";
            this.dtpThoiGianKhachHang.Size = new System.Drawing.Size(333, 30);
            this.dtpThoiGianKhachHang.TabIndex = 2;
            this.dtpThoiGianKhachHang.ValueChanged += new System.EventHandler(this.dtpThoiGianKhachHang_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thời gian:";
            // 
            // frmThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 743);
            this.Controls.Add(this.grChiTiet);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbThongTin);
            this.Controls.Add(this.lbHeader);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmThongKe";
            this.Text = "Quản lý thống kê";
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmThongKe_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.frmThongKe_Paint);
            this.gbThongTin.ResumeLayout(false);
            this.gbThongTin.PerformLayout();
            this.grChiTiet.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhachHangDoanhThu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSanPhamDoanhThu)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbHeader;
        private System.Windows.Forms.GroupBox gbThongTin;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox grChiTiet;
        private System.Windows.Forms.DataGridView dgvSanPhamDoanhThu;
        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.DateTimePicker dtpThoiGianSanPham;
        private System.Windows.Forms.DataGridView dgvKhachHangDoanhThu;
        private System.Windows.Forms.Button btnDangXuat;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDKhachHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenKhachHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn TongTien;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDSanPham;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenSanPham;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn DoanhThu;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtpThoiGianKhachHang;
        private System.Windows.Forms.Label label1;
    }
}