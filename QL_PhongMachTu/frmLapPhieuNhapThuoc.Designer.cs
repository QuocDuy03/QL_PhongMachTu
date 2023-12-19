namespace QL_PhongMachTu
{
    partial class frmLapPhieuNhapThuoc
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            grbThongTinPhieuLapThuoc = new GroupBox();
            txtTongTien = new TextBox();
            dtpNgayLapPhieu = new DateTimePicker();
            txtMaPhieuNhapThuoc = new TextBox();
            lblTongTien = new Label();
            lblNgayLap = new Label();
            lblMaPhieuNhapThuoc = new Label();
            grbThongTinThuoc = new GroupBox();
            txtDonGiaNhap = new TextBox();
            lblDonGiaNhap = new Label();
            nudSoLuongNhap = new NumericUpDown();
            lblSoLuong = new Label();
            lblTenThuoc = new Label();
            cboTenThuoc = new ComboBox();
            grbDanhSachPhieuNhapThuoc = new GroupBox();
            dgvDanhSachPhieuNhapThuoc = new DataGridView();
            grbDanhSachThuoc = new GroupBox();
            dgvDanhSachThuoc = new DataGridView();
            LoaiThuoc = new DataGridViewTextBoxColumn();
            SoLuongNhap = new DataGridViewTextBoxColumn();
            DonGiaNhap = new DataGridViewTextBoxColumn();
            btnLapPhieu = new Button();
            btnThoat = new Button();
            btnThem = new Button();
            btnSua = new Button();
            btnReset = new Button();
            btnXemThongTinThuoc = new Button();
            errorProvider = new ErrorProvider(components);
            btnXoa = new Button();
            grbThongTinPhieuLapThuoc.SuspendLayout();
            grbThongTinThuoc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudSoLuongNhap).BeginInit();
            grbDanhSachPhieuNhapThuoc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDanhSachPhieuNhapThuoc).BeginInit();
            grbDanhSachThuoc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDanhSachThuoc).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = Color.Teal;
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(923, 43);
            label1.TabIndex = 0;
            label1.Text = "Lập Phiếu Nhập Thuốc";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click;
            // 
            // grbThongTinPhieuLapThuoc
            // 
            grbThongTinPhieuLapThuoc.Controls.Add(txtTongTien);
            grbThongTinPhieuLapThuoc.Controls.Add(dtpNgayLapPhieu);
            grbThongTinPhieuLapThuoc.Controls.Add(txtMaPhieuNhapThuoc);
            grbThongTinPhieuLapThuoc.Controls.Add(lblTongTien);
            grbThongTinPhieuLapThuoc.Controls.Add(lblNgayLap);
            grbThongTinPhieuLapThuoc.Controls.Add(lblMaPhieuNhapThuoc);
            grbThongTinPhieuLapThuoc.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            grbThongTinPhieuLapThuoc.Location = new Point(6, 53);
            grbThongTinPhieuLapThuoc.Margin = new Padding(3, 2, 3, 2);
            grbThongTinPhieuLapThuoc.Name = "grbThongTinPhieuLapThuoc";
            grbThongTinPhieuLapThuoc.Padding = new Padding(3, 2, 3, 2);
            grbThongTinPhieuLapThuoc.Size = new Size(666, 97);
            grbThongTinPhieuLapThuoc.TabIndex = 1;
            grbThongTinPhieuLapThuoc.TabStop = false;
            grbThongTinPhieuLapThuoc.Text = "Thông Tin Phiếu Nhập Thuốc";
            // 
            // txtTongTien
            // 
            txtTongTien.Location = new Point(454, 50);
            txtTongTien.Margin = new Padding(3, 2, 3, 2);
            txtTongTien.Name = "txtTongTien";
            txtTongTien.ReadOnly = true;
            txtTongTien.Size = new Size(159, 26);
            txtTongTien.TabIndex = 5;
            // 
            // dtpNgayLapPhieu
            // 
            dtpNgayLapPhieu.CustomFormat = "dd/MM/yyyy";
            dtpNgayLapPhieu.Format = DateTimePickerFormat.Custom;
            dtpNgayLapPhieu.Location = new Point(214, 50);
            dtpNgayLapPhieu.Margin = new Padding(3, 2, 3, 2);
            dtpNgayLapPhieu.Name = "dtpNgayLapPhieu";
            dtpNgayLapPhieu.Size = new Size(211, 26);
            dtpNgayLapPhieu.TabIndex = 4;
            // 
            // txtMaPhieuNhapThuoc
            // 
            txtMaPhieuNhapThuoc.BackColor = SystemColors.ControlLight;
            txtMaPhieuNhapThuoc.Location = new Point(11, 50);
            txtMaPhieuNhapThuoc.Margin = new Padding(3, 2, 3, 2);
            txtMaPhieuNhapThuoc.Name = "txtMaPhieuNhapThuoc";
            txtMaPhieuNhapThuoc.ReadOnly = true;
            txtMaPhieuNhapThuoc.Size = new Size(173, 26);
            txtMaPhieuNhapThuoc.TabIndex = 3;
            // 
            // lblTongTien
            // 
            lblTongTien.AutoSize = true;
            lblTongTien.Location = new Point(454, 31);
            lblTongTien.Name = "lblTongTien";
            lblTongTien.Size = new Size(72, 19);
            lblTongTien.TabIndex = 2;
            lblTongTien.Text = "Tổng Tiền";
            // 
            // lblNgayLap
            // 
            lblNgayLap.AutoSize = true;
            lblNgayLap.Location = new Point(214, 31);
            lblNgayLap.Name = "lblNgayLap";
            lblNgayLap.Size = new Size(107, 19);
            lblNgayLap.TabIndex = 1;
            lblNgayLap.Text = "Ngày Lập Phiếu";
            // 
            // lblMaPhieuNhapThuoc
            // 
            lblMaPhieuNhapThuoc.AutoSize = true;
            lblMaPhieuNhapThuoc.Location = new Point(11, 31);
            lblMaPhieuNhapThuoc.Name = "lblMaPhieuNhapThuoc";
            lblMaPhieuNhapThuoc.Size = new Size(68, 19);
            lblMaPhieuNhapThuoc.TabIndex = 0;
            lblMaPhieuNhapThuoc.Text = "Mã Phiếu";
            // 
            // grbThongTinThuoc
            // 
            grbThongTinThuoc.Controls.Add(txtDonGiaNhap);
            grbThongTinThuoc.Controls.Add(lblDonGiaNhap);
            grbThongTinThuoc.Controls.Add(nudSoLuongNhap);
            grbThongTinThuoc.Controls.Add(lblSoLuong);
            grbThongTinThuoc.Controls.Add(lblTenThuoc);
            grbThongTinThuoc.Controls.Add(cboTenThuoc);
            grbThongTinThuoc.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            grbThongTinThuoc.Location = new Point(7, 155);
            grbThongTinThuoc.Margin = new Padding(3, 2, 3, 2);
            grbThongTinThuoc.Name = "grbThongTinThuoc";
            grbThongTinThuoc.Padding = new Padding(3, 2, 3, 2);
            grbThongTinThuoc.Size = new Size(664, 113);
            grbThongTinThuoc.TabIndex = 2;
            grbThongTinThuoc.TabStop = false;
            grbThongTinThuoc.Text = "Thông Tin Loại Thuốc";
            // 
            // txtDonGiaNhap
            // 
            txtDonGiaNhap.Location = new Point(452, 61);
            txtDonGiaNhap.Margin = new Padding(3, 2, 3, 2);
            txtDonGiaNhap.Name = "txtDonGiaNhap";
            txtDonGiaNhap.Size = new Size(159, 26);
            txtDonGiaNhap.TabIndex = 5;
            txtDonGiaNhap.TextChanged += txtDonGiaNhap_TextChanged;
            // 
            // lblDonGiaNhap
            // 
            lblDonGiaNhap.AutoSize = true;
            lblDonGiaNhap.Location = new Point(452, 41);
            lblDonGiaNhap.Name = "lblDonGiaNhap";
            lblDonGiaNhap.Size = new Size(99, 19);
            lblDonGiaNhap.TabIndex = 4;
            lblDonGiaNhap.Text = "Đơn Giá Nhập";
            // 
            // nudSoLuongNhap
            // 
            nudSoLuongNhap.Location = new Point(213, 62);
            nudSoLuongNhap.Margin = new Padding(3, 2, 3, 2);
            nudSoLuongNhap.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            nudSoLuongNhap.Name = "nudSoLuongNhap";
            nudSoLuongNhap.Size = new Size(211, 26);
            nudSoLuongNhap.TabIndex = 3;
            nudSoLuongNhap.ValueChanged += nudSoLuongNhap_ValueChanged;
            // 
            // lblSoLuong
            // 
            lblSoLuong.AutoSize = true;
            lblSoLuong.Location = new Point(214, 41);
            lblSoLuong.Name = "lblSoLuong";
            lblSoLuong.Size = new Size(108, 19);
            lblSoLuong.TabIndex = 2;
            lblSoLuong.Text = "Số Lượng Nhập";
            // 
            // lblTenThuoc
            // 
            lblTenThuoc.AutoSize = true;
            lblTenThuoc.Location = new Point(10, 41);
            lblTenThuoc.Name = "lblTenThuoc";
            lblTenThuoc.Size = new Size(74, 19);
            lblTenThuoc.TabIndex = 1;
            lblTenThuoc.Text = "Tên Thuốc";
            // 
            // cboTenThuoc
            // 
            cboTenThuoc.FormattingEnabled = true;
            cboTenThuoc.Location = new Point(10, 62);
            cboTenThuoc.Margin = new Padding(3, 2, 3, 2);
            cboTenThuoc.Name = "cboTenThuoc";
            cboTenThuoc.Size = new Size(173, 27);
            cboTenThuoc.TabIndex = 0;
            // 
            // grbDanhSachPhieuNhapThuoc
            // 
            grbDanhSachPhieuNhapThuoc.Controls.Add(dgvDanhSachPhieuNhapThuoc);
            grbDanhSachPhieuNhapThuoc.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            grbDanhSachPhieuNhapThuoc.Location = new Point(7, 273);
            grbDanhSachPhieuNhapThuoc.Margin = new Padding(3, 2, 3, 2);
            grbDanhSachPhieuNhapThuoc.Name = "grbDanhSachPhieuNhapThuoc";
            grbDanhSachPhieuNhapThuoc.Padding = new Padding(3, 2, 3, 2);
            grbDanhSachPhieuNhapThuoc.Size = new Size(395, 246);
            grbDanhSachPhieuNhapThuoc.TabIndex = 3;
            grbDanhSachPhieuNhapThuoc.TabStop = false;
            grbDanhSachPhieuNhapThuoc.Text = "Danh Sách Phiếu Nhập Thuốc";
            // 
            // dgvDanhSachPhieuNhapThuoc
            // 
            dgvDanhSachPhieuNhapThuoc.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDanhSachPhieuNhapThuoc.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDanhSachPhieuNhapThuoc.Dock = DockStyle.Fill;
            dgvDanhSachPhieuNhapThuoc.Location = new Point(3, 21);
            dgvDanhSachPhieuNhapThuoc.Margin = new Padding(3, 2, 3, 2);
            dgvDanhSachPhieuNhapThuoc.Name = "dgvDanhSachPhieuNhapThuoc";
            dgvDanhSachPhieuNhapThuoc.ReadOnly = true;
            dgvDanhSachPhieuNhapThuoc.RowHeadersWidth = 51;
            dgvDanhSachPhieuNhapThuoc.RowTemplate.DefaultCellStyle.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dgvDanhSachPhieuNhapThuoc.RowTemplate.DefaultCellStyle.ForeColor = SystemColors.WindowText;
            dgvDanhSachPhieuNhapThuoc.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.Teal;
            dgvDanhSachPhieuNhapThuoc.RowTemplate.DefaultCellStyle.SelectionForeColor = SystemColors.Window;
            dgvDanhSachPhieuNhapThuoc.RowTemplate.Height = 29;
            dgvDanhSachPhieuNhapThuoc.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDanhSachPhieuNhapThuoc.Size = new Size(389, 223);
            dgvDanhSachPhieuNhapThuoc.TabIndex = 0;
            dgvDanhSachPhieuNhapThuoc.CellContentClick += dgvDanhSachPhieuNhapThuoc_CellContentClick;
            // 
            // grbDanhSachThuoc
            // 
            grbDanhSachThuoc.Controls.Add(dgvDanhSachThuoc);
            grbDanhSachThuoc.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            grbDanhSachThuoc.Location = new Point(413, 273);
            grbDanhSachThuoc.Margin = new Padding(3, 2, 3, 2);
            grbDanhSachThuoc.Name = "grbDanhSachThuoc";
            grbDanhSachThuoc.Padding = new Padding(3, 2, 3, 2);
            grbDanhSachThuoc.Size = new Size(496, 246);
            grbDanhSachThuoc.TabIndex = 4;
            grbDanhSachThuoc.TabStop = false;
            grbDanhSachThuoc.Text = "Danh Sách Thuốc";
            // 
            // dgvDanhSachThuoc
            // 
            dgvDanhSachThuoc.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDanhSachThuoc.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDanhSachThuoc.Columns.AddRange(new DataGridViewColumn[] { LoaiThuoc, SoLuongNhap, DonGiaNhap });
            dgvDanhSachThuoc.Dock = DockStyle.Fill;
            dgvDanhSachThuoc.Location = new Point(3, 21);
            dgvDanhSachThuoc.Margin = new Padding(3, 2, 3, 2);
            dgvDanhSachThuoc.Name = "dgvDanhSachThuoc";
            dgvDanhSachThuoc.ReadOnly = true;
            dgvDanhSachThuoc.RowHeadersWidth = 51;
            dgvDanhSachThuoc.RowTemplate.DefaultCellStyle.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dgvDanhSachThuoc.RowTemplate.DefaultCellStyle.ForeColor = SystemColors.WindowText;
            dgvDanhSachThuoc.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.Teal;
            dgvDanhSachThuoc.RowTemplate.DefaultCellStyle.SelectionForeColor = SystemColors.Window;
            dgvDanhSachThuoc.RowTemplate.Height = 29;
            dgvDanhSachThuoc.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDanhSachThuoc.Size = new Size(490, 223);
            dgvDanhSachThuoc.TabIndex = 0;
            dgvDanhSachThuoc.CellClick += dgvDanhSachThuoc_CellClick;
            dgvDanhSachThuoc.CellContentClick += dgvDanhSachThuoc_CellContentClick;
            // 
            // LoaiThuoc
            // 
            LoaiThuoc.HeaderText = "Loại thuốc";
            LoaiThuoc.MinimumWidth = 6;
            LoaiThuoc.Name = "LoaiThuoc";
            LoaiThuoc.ReadOnly = true;
            // 
            // SoLuongNhap
            // 
            SoLuongNhap.HeaderText = "Số lượng nhập";
            SoLuongNhap.MinimumWidth = 6;
            SoLuongNhap.Name = "SoLuongNhap";
            SoLuongNhap.ReadOnly = true;
            // 
            // DonGiaNhap
            // 
            DonGiaNhap.HeaderText = "Đơn giá nhập";
            DonGiaNhap.MinimumWidth = 6;
            DonGiaNhap.Name = "DonGiaNhap";
            DonGiaNhap.ReadOnly = true;
            // 
            // btnLapPhieu
            // 
            btnLapPhieu.BackColor = Color.Teal;
            btnLapPhieu.Cursor = Cursors.Hand;
            btnLapPhieu.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnLapPhieu.ForeColor = Color.White;
            btnLapPhieu.Location = new Point(692, 240);
            btnLapPhieu.Margin = new Padding(3, 2, 3, 2);
            btnLapPhieu.Name = "btnLapPhieu";
            btnLapPhieu.Size = new Size(218, 29);
            btnLapPhieu.TabIndex = 5;
            btnLapPhieu.Text = "Lập Phiếu";
            btnLapPhieu.UseVisualStyleBackColor = false;
            btnLapPhieu.Click += btnLapPhieu_Click;
            // 
            // btnThoat
            // 
            btnThoat.BackColor = Color.Teal;
            btnThoat.Cursor = Cursors.Hand;
            btnThoat.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnThoat.ForeColor = Color.White;
            btnThoat.Location = new Point(57, 533);
            btnThoat.Margin = new Padding(3, 2, 3, 2);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(340, 37);
            btnThoat.TabIndex = 6;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = false;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnThem
            // 
            btnThem.BackColor = Color.Teal;
            btnThem.Cursor = Cursors.Hand;
            btnThem.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnThem.ForeColor = Color.White;
            btnThem.Location = new Point(692, 150);
            btnThem.Margin = new Padding(3, 2, 3, 2);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(98, 31);
            btnThem.TabIndex = 7;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // 
            // btnSua
            // 
            btnSua.BackColor = Color.Teal;
            btnSua.Cursor = Cursors.Hand;
            btnSua.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnSua.ForeColor = Color.White;
            btnSua.Location = new Point(692, 197);
            btnSua.Margin = new Padding(3, 2, 3, 2);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(98, 31);
            btnSua.TabIndex = 9;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = false;
            btnSua.Click += btnSua_Click;
            // 
            // btnReset
            // 
            btnReset.BackColor = Color.Teal;
            btnReset.Cursor = Cursors.Hand;
            btnReset.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnReset.ForeColor = Color.White;
            btnReset.Location = new Point(811, 197);
            btnReset.Margin = new Padding(3, 2, 3, 2);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(98, 31);
            btnReset.TabIndex = 10;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = false;
            btnReset.Click += btnReset_Click;
            // 
            // btnXemThongTinThuoc
            // 
            btnXemThongTinThuoc.BackColor = Color.Teal;
            btnXemThongTinThuoc.Cursor = Cursors.Hand;
            btnXemThongTinThuoc.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnXemThongTinThuoc.ForeColor = Color.White;
            btnXemThongTinThuoc.Location = new Point(518, 533);
            btnXemThongTinThuoc.Margin = new Padding(3, 2, 3, 2);
            btnXemThongTinThuoc.Name = "btnXemThongTinThuoc";
            btnXemThongTinThuoc.Size = new Size(340, 37);
            btnXemThongTinThuoc.TabIndex = 11;
            btnXemThongTinThuoc.Text = "Xem Thông Tin Thuốc";
            btnXemThongTinThuoc.UseVisualStyleBackColor = false;
            btnXemThongTinThuoc.Click += btnXemThongTinThuoc_Click;
            // 
            // errorProvider
            // 
            errorProvider.ContainerControl = this;
            // 
            // btnXoa
            // 
            btnXoa.BackColor = Color.Teal;
            btnXoa.Cursor = Cursors.Hand;
            btnXoa.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnXoa.ForeColor = Color.White;
            btnXoa.Location = new Point(811, 150);
            btnXoa.Margin = new Padding(3, 2, 3, 2);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(98, 31);
            btnXoa.TabIndex = 12;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = false;
            btnXoa.Click += btnXoa_Click;
            // 
            // frmLapPhieuNhapThuoc
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(923, 578);
            Controls.Add(btnXoa);
            Controls.Add(btnXemThongTinThuoc);
            Controls.Add(btnReset);
            Controls.Add(btnLapPhieu);
            Controls.Add(btnSua);
            Controls.Add(btnThem);
            Controls.Add(btnThoat);
            Controls.Add(grbDanhSachThuoc);
            Controls.Add(grbDanhSachPhieuNhapThuoc);
            Controls.Add(grbThongTinThuoc);
            Controls.Add(grbThongTinPhieuLapThuoc);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            Name = "frmLapPhieuNhapThuoc";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Lập Phiếu Nhập Thuốc";
            Load += frmLapPhieuNhapThuoc_Load;
            grbThongTinPhieuLapThuoc.ResumeLayout(false);
            grbThongTinPhieuLapThuoc.PerformLayout();
            grbThongTinThuoc.ResumeLayout(false);
            grbThongTinThuoc.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudSoLuongNhap).EndInit();
            grbDanhSachPhieuNhapThuoc.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvDanhSachPhieuNhapThuoc).EndInit();
            grbDanhSachThuoc.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvDanhSachThuoc).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private GroupBox grbThongTinPhieuLapThuoc;
        private TextBox txtTongTien;
        private DateTimePicker dtpNgayLapPhieu;
        private TextBox txtMaPhieuNhapThuoc;
        private Label lblTongTien;
        private Label lblNgayLap;
        private Label lblMaPhieuNhapThuoc;
        private GroupBox grbThongTinThuoc;
        private TextBox txtDonGiaNhap;
        private Label lblDonGiaNhap;
        private NumericUpDown nudSoLuongNhap;
        private Label lblSoLuong;
        private Label lblTenThuoc;
        private ComboBox cboTenThuoc;
        private GroupBox grbDanhSachPhieuNhapThuoc;
        private GroupBox grbDanhSachThuoc;
        private Button btnLapPhieu;
        private Button btnThoat;
        private DataGridView dgvDanhSachPhieuNhapThuoc;
        private DataGridView dgvDanhSachThuoc;
        private Button btnThem;
        private Button btnSua;
        private Button btnReset;
        private DataGridViewTextBoxColumn LoaiThuoc;
        private DataGridViewTextBoxColumn SoLuongNhap;
        private DataGridViewTextBoxColumn DonGiaNhap;
        private Button btnXemThongTinThuoc;
        private ErrorProvider errorProvider;
        private Button btnXoa;
    }
}