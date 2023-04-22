
namespace MobileStoreApp
{
    partial class frmHoaDon
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
            this.label1 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.gbChiTietHoaDon = new System.Windows.Forms.GroupBox();
            this.lbGiamGia = new System.Windows.Forms.Label();
            this.lbTenSanPham = new System.Windows.Forms.Label();
            this.lbDonGia = new System.Windows.Forms.Label();
            this.lbDonVi = new System.Windows.Forms.Label();
            this.lbTongTien = new System.Windows.Forms.Label();
            this.cbMaSanPham = new System.Windows.Forms.ComboBox();
            this.dgvChiTietHoaDon = new System.Windows.Forms.DataGridView();
            this.IDSanPham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenSanPham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonVi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiamGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TongTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDangXuat = new System.Windows.Forms.Button();
            this.btnDong = new System.Windows.Forms.Button();
            this.btnXoaHoaDon = new System.Windows.Forms.Button();
            this.btnThemHoaDon = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaHoaDon = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dtpNgayXuatHoaDon = new System.Windows.Forms.DateTimePicker();
            this.cbMaKhachHang = new System.Windows.Forms.ComboBox();
            this.gbThongTinHoaDon = new System.Windows.Forms.GroupBox();
            this.lbTenKhachHang = new System.Windows.Forms.Label();
            this.lbTenNhanVien = new System.Windows.Forms.Label();
            this.lbMaNhanVien = new System.Windows.Forms.Label();
            this.gbChiTietHoaDon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietHoaDon)).BeginInit();
            this.gbThongTinHoaDon.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 31.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1200, 76);
            this.label1.TabIndex = 0;
            this.label1.Text = "THANH TOÁN HÓA ĐƠN";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(6, 38);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(115, 20);
            this.label13.TabIndex = 0;
            this.label13.Text = "Mã sản phẩm:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(330, 38);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(120, 20);
            this.label12.TabIndex = 0;
            this.label12.Text = "Tên sản phẩm:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(6, 84);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(79, 20);
            this.label11.TabIndex = 0;
            this.label11.Text = "Số lượng:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(329, 84);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(81, 20);
            this.label10.TabIndex = 0;
            this.label10.Text = "Giảm giá:";
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoLuong.Location = new System.Drawing.Point(152, 81);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(147, 27);
            this.txtSoLuong.TabIndex = 1;
            this.txtSoLuong.TextChanged += new System.EventHandler(this.txtSoLuong_TextChanged);
            // 
            // gbChiTietHoaDon
            // 
            this.gbChiTietHoaDon.Controls.Add(this.lbGiamGia);
            this.gbChiTietHoaDon.Controls.Add(this.lbTenSanPham);
            this.gbChiTietHoaDon.Controls.Add(this.lbDonGia);
            this.gbChiTietHoaDon.Controls.Add(this.lbDonVi);
            this.gbChiTietHoaDon.Controls.Add(this.lbTongTien);
            this.gbChiTietHoaDon.Controls.Add(this.cbMaSanPham);
            this.gbChiTietHoaDon.Controls.Add(this.dgvChiTietHoaDon);
            this.gbChiTietHoaDon.Controls.Add(this.btnDangXuat);
            this.gbChiTietHoaDon.Controls.Add(this.btnDong);
            this.gbChiTietHoaDon.Controls.Add(this.btnXoaHoaDon);
            this.gbChiTietHoaDon.Controls.Add(this.btnThemHoaDon);
            this.gbChiTietHoaDon.Controls.Add(this.btnXoa);
            this.gbChiTietHoaDon.Controls.Add(this.btnThem);
            this.gbChiTietHoaDon.Controls.Add(this.label9);
            this.gbChiTietHoaDon.Controls.Add(this.label14);
            this.gbChiTietHoaDon.Controls.Add(this.txtSoLuong);
            this.gbChiTietHoaDon.Controls.Add(this.label10);
            this.gbChiTietHoaDon.Controls.Add(this.label8);
            this.gbChiTietHoaDon.Controls.Add(this.label11);
            this.gbChiTietHoaDon.Controls.Add(this.label12);
            this.gbChiTietHoaDon.Controls.Add(this.label13);
            this.gbChiTietHoaDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbChiTietHoaDon.Location = new System.Drawing.Point(10, 293);
            this.gbChiTietHoaDon.Name = "gbChiTietHoaDon";
            this.gbChiTietHoaDon.Size = new System.Drawing.Size(1178, 464);
            this.gbChiTietHoaDon.TabIndex = 1;
            this.gbChiTietHoaDon.TabStop = false;
            this.gbChiTietHoaDon.Text = "Chi tiết hóa đơn:";
            // 
            // lbGiamGia
            // 
            this.lbGiamGia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lbGiamGia.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbGiamGia.Location = new System.Drawing.Point(468, 77);
            this.lbGiamGia.Name = "lbGiamGia";
            this.lbGiamGia.Size = new System.Drawing.Size(329, 27);
            this.lbGiamGia.TabIndex = 6;
            // 
            // lbTenSanPham
            // 
            this.lbTenSanPham.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lbTenSanPham.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbTenSanPham.Location = new System.Drawing.Point(468, 35);
            this.lbTenSanPham.Name = "lbTenSanPham";
            this.lbTenSanPham.Size = new System.Drawing.Size(329, 27);
            this.lbTenSanPham.TabIndex = 6;
            // 
            // lbDonGia
            // 
            this.lbDonGia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lbDonGia.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbDonGia.Location = new System.Drawing.Point(947, 77);
            this.lbDonGia.Name = "lbDonGia";
            this.lbDonGia.Size = new System.Drawing.Size(208, 27);
            this.lbDonGia.TabIndex = 6;
            // 
            // lbDonVi
            // 
            this.lbDonVi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lbDonVi.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbDonVi.Location = new System.Drawing.Point(947, 35);
            this.lbDonVi.Name = "lbDonVi";
            this.lbDonVi.Size = new System.Drawing.Size(208, 27);
            this.lbDonVi.TabIndex = 6;
            // 
            // lbTongTien
            // 
            this.lbTongTien.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lbTongTien.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbTongTien.Location = new System.Drawing.Point(818, 126);
            this.lbTongTien.Name = "lbTongTien";
            this.lbTongTien.Size = new System.Drawing.Size(337, 27);
            this.lbTongTien.TabIndex = 6;
            // 
            // cbMaSanPham
            // 
            this.cbMaSanPham.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMaSanPham.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMaSanPham.FormattingEnabled = true;
            this.cbMaSanPham.Location = new System.Drawing.Point(153, 38);
            this.cbMaSanPham.Name = "cbMaSanPham";
            this.cbMaSanPham.Size = new System.Drawing.Size(146, 28);
            this.cbMaSanPham.TabIndex = 5;
            this.cbMaSanPham.SelectedIndexChanged += new System.EventHandler(this.cbMaSanPham_SelectedIndexChanged);
            // 
            // dgvChiTietHoaDon
            // 
            this.dgvChiTietHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChiTietHoaDon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDSanPham,
            this.TenSanPham,
            this.SoLuong,
            this.DonGia,
            this.DonVi,
            this.GiamGia,
            this.TongTien});
            this.dgvChiTietHoaDon.Location = new System.Drawing.Point(12, 185);
            this.dgvChiTietHoaDon.Name = "dgvChiTietHoaDon";
            this.dgvChiTietHoaDon.RowHeadersWidth = 51;
            this.dgvChiTietHoaDon.RowTemplate.Height = 24;
            this.dgvChiTietHoaDon.Size = new System.Drawing.Size(1143, 207);
            this.dgvChiTietHoaDon.TabIndex = 4;
            this.dgvChiTietHoaDon.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvChiTietHoaDon_CellEndEdit);
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
            this.SoLuong.Width = 125;
            // 
            // DonGia
            // 
            this.DonGia.DataPropertyName = "DonGia";
            this.DonGia.HeaderText = "Đơn giá";
            this.DonGia.MinimumWidth = 6;
            this.DonGia.Name = "DonGia";
            this.DonGia.ReadOnly = true;
            this.DonGia.Width = 125;
            // 
            // DonVi
            // 
            this.DonVi.DataPropertyName = "DonVi";
            this.DonVi.HeaderText = "Đơn vị";
            this.DonVi.MinimumWidth = 6;
            this.DonVi.Name = "DonVi";
            this.DonVi.ReadOnly = true;
            this.DonVi.Width = 125;
            // 
            // GiamGia
            // 
            this.GiamGia.DataPropertyName = "GiamGia";
            this.GiamGia.HeaderText = "Giảm giá/Đơn vị";
            this.GiamGia.MinimumWidth = 6;
            this.GiamGia.Name = "GiamGia";
            this.GiamGia.ReadOnly = true;
            this.GiamGia.Width = 125;
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
            // btnDangXuat
            // 
            this.btnDangXuat.Location = new System.Drawing.Point(776, 412);
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.Size = new System.Drawing.Size(102, 35);
            this.btnDangXuat.TabIndex = 3;
            this.btnDangXuat.Text = "Đăng xuất";
            this.btnDangXuat.UseVisualStyleBackColor = true;
            // 
            // btnDong
            // 
            this.btnDong.Location = new System.Drawing.Point(647, 412);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(102, 35);
            this.btnDong.TabIndex = 3;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // btnXoaHoaDon
            // 
            this.btnXoaHoaDon.Location = new System.Drawing.Point(480, 412);
            this.btnXoaHoaDon.Name = "btnXoaHoaDon";
            this.btnXoaHoaDon.Size = new System.Drawing.Size(140, 35);
            this.btnXoaHoaDon.TabIndex = 3;
            this.btnXoaHoaDon.Text = "Xóa hóa đơn";
            this.btnXoaHoaDon.UseVisualStyleBackColor = true;
            this.btnXoaHoaDon.Click += new System.EventHandler(this.btnXoaHoaDon_Click);
            // 
            // btnThemHoaDon
            // 
            this.btnThemHoaDon.Location = new System.Drawing.Point(301, 412);
            this.btnThemHoaDon.Name = "btnThemHoaDon";
            this.btnThemHoaDon.Size = new System.Drawing.Size(152, 35);
            this.btnThemHoaDon.TabIndex = 3;
            this.btnThemHoaDon.Text = "Thêm hóa đơn";
            this.btnThemHoaDon.UseVisualStyleBackColor = true;
            this.btnThemHoaDon.Click += new System.EventHandler(this.btnThemHoaDon_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(152, 126);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(102, 35);
            this.btnXoa.TabIndex = 3;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(15, 126);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(102, 35);
            this.btnThem.TabIndex = 3;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(829, 83);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 20);
            this.label9.TabIndex = 0;
            this.label9.Text = "Đơn giá:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(697, 131);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(115, 20);
            this.label14.TabIndex = 0;
            this.label14.Text = "Tổng hóa đơn:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(829, 37);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 20);
            this.label8.TabIndex = 0;
            this.label8.Text = "Đơn vị:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã hóa đơn:";
            // 
            // txtMaHoaDon
            // 
            this.txtMaHoaDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaHoaDon.Location = new System.Drawing.Point(152, 34);
            this.txtMaHoaDon.Name = "txtMaHoaDon";
            this.txtMaHoaDon.Size = new System.Drawing.Size(337, 28);
            this.txtMaHoaDon.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(651, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(145, 24);
            this.label5.TabIndex = 0;
            this.label5.Text = "Mã khách hàng:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 24);
            this.label3.TabIndex = 0;
            this.label3.Text = "Mã nhân viên:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(651, 81);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(153, 24);
            this.label6.TabIndex = 0;
            this.label6.Text = "Tên khách hàng:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 24);
            this.label4.TabIndex = 0;
            this.label4.Text = "Tên nhân viên:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(648, 126);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(131, 24);
            this.label7.TabIndex = 0;
            this.label7.Text = "Ngày xuất HD:";
            // 
            // dtpNgayXuatHoaDon
            // 
            this.dtpNgayXuatHoaDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgayXuatHoaDon.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayXuatHoaDon.Location = new System.Drawing.Point(817, 126);
            this.dtpNgayXuatHoaDon.Name = "dtpNgayXuatHoaDon";
            this.dtpNgayXuatHoaDon.Size = new System.Drawing.Size(337, 28);
            this.dtpNgayXuatHoaDon.TabIndex = 2;
            // 
            // cbMaKhachHang
            // 
            this.cbMaKhachHang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMaKhachHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMaKhachHang.FormattingEnabled = true;
            this.cbMaKhachHang.Location = new System.Drawing.Point(817, 31);
            this.cbMaKhachHang.Name = "cbMaKhachHang";
            this.cbMaKhachHang.Size = new System.Drawing.Size(337, 30);
            this.cbMaKhachHang.TabIndex = 3;
            this.cbMaKhachHang.SelectedIndexChanged += new System.EventHandler(this.cbMaKhachHang_SelectedIndexChanged);
            // 
            // gbThongTinHoaDon
            // 
            this.gbThongTinHoaDon.Controls.Add(this.lbTenKhachHang);
            this.gbThongTinHoaDon.Controls.Add(this.lbTenNhanVien);
            this.gbThongTinHoaDon.Controls.Add(this.lbMaNhanVien);
            this.gbThongTinHoaDon.Controls.Add(this.cbMaKhachHang);
            this.gbThongTinHoaDon.Controls.Add(this.dtpNgayXuatHoaDon);
            this.gbThongTinHoaDon.Controls.Add(this.label7);
            this.gbThongTinHoaDon.Controls.Add(this.label4);
            this.gbThongTinHoaDon.Controls.Add(this.label6);
            this.gbThongTinHoaDon.Controls.Add(this.label3);
            this.gbThongTinHoaDon.Controls.Add(this.label5);
            this.gbThongTinHoaDon.Controls.Add(this.txtMaHoaDon);
            this.gbThongTinHoaDon.Controls.Add(this.label2);
            this.gbThongTinHoaDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbThongTinHoaDon.Location = new System.Drawing.Point(11, 91);
            this.gbThongTinHoaDon.Name = "gbThongTinHoaDon";
            this.gbThongTinHoaDon.Size = new System.Drawing.Size(1178, 179);
            this.gbThongTinHoaDon.TabIndex = 1;
            this.gbThongTinHoaDon.TabStop = false;
            this.gbThongTinHoaDon.Text = "Thông tin hóa đơn:";
            // 
            // lbTenKhachHang
            // 
            this.lbTenKhachHang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lbTenKhachHang.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbTenKhachHang.Location = new System.Drawing.Point(817, 80);
            this.lbTenKhachHang.Name = "lbTenKhachHang";
            this.lbTenKhachHang.Size = new System.Drawing.Size(337, 28);
            this.lbTenKhachHang.TabIndex = 6;
            // 
            // lbTenNhanVien
            // 
            this.lbTenNhanVien.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lbTenNhanVien.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbTenNhanVien.Location = new System.Drawing.Point(152, 129);
            this.lbTenNhanVien.Name = "lbTenNhanVien";
            this.lbTenNhanVien.Size = new System.Drawing.Size(334, 28);
            this.lbTenNhanVien.TabIndex = 6;
            // 
            // lbMaNhanVien
            // 
            this.lbMaNhanVien.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lbMaNhanVien.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbMaNhanVien.Location = new System.Drawing.Point(152, 85);
            this.lbMaNhanVien.Name = "lbMaNhanVien";
            this.lbMaNhanVien.Size = new System.Drawing.Size(337, 28);
            this.lbMaNhanVien.TabIndex = 6;
            // 
            // frmHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 773);
            this.Controls.Add(this.gbChiTietHoaDon);
            this.Controls.Add(this.gbThongTinHoaDon);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmHoaDon";
            this.Text = "Thanh toán hóa đơn";
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmHoaDon_Load);
            this.gbChiTietHoaDon.ResumeLayout(false);
            this.gbChiTietHoaDon.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietHoaDon)).EndInit();
            this.gbThongTinHoaDon.ResumeLayout(false);
            this.gbThongTinHoaDon.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.GroupBox gbChiTietHoaDon;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMaHoaDon;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtpNgayXuatHoaDon;
        private System.Windows.Forms.ComboBox cbMaKhachHang;
        private System.Windows.Forms.GroupBox gbThongTinHoaDon;
        private System.Windows.Forms.DataGridView dgvChiTietHoaDon;
        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.Button btnXoaHoaDon;
        private System.Windows.Forms.Button btnThemHoaDon;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox cbMaSanPham;
        private System.Windows.Forms.Label lbTongTien;
        private System.Windows.Forms.Button btnDangXuat;
        private System.Windows.Forms.Label lbGiamGia;
        private System.Windows.Forms.Label lbTenSanPham;
        private System.Windows.Forms.Label lbDonGia;
        private System.Windows.Forms.Label lbDonVi;
        private System.Windows.Forms.Label lbTenKhachHang;
        private System.Windows.Forms.Label lbTenNhanVien;
        private System.Windows.Forms.Label lbMaNhanVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDSanPham;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenSanPham;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonVi;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiamGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn TongTien;
    }
}