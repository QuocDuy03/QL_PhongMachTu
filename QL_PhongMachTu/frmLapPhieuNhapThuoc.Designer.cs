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
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(1319, 72);
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
            grbThongTinPhieuLapThuoc.Location = new Point(8, 89);
            grbThongTinPhieuLapThuoc.Margin = new Padding(4);
            grbThongTinPhieuLapThuoc.Name = "grbThongTinPhieuLapThuoc";
            grbThongTinPhieuLapThuoc.Padding = new Padding(4);
            grbThongTinPhieuLapThuoc.Size = new Size(951, 162);
            grbThongTinPhieuLapThuoc.TabIndex = 1;
            grbThongTinPhieuLapThuoc.TabStop = false;
            grbThongTinPhieuLapThuoc.Text = "Thông Tin Phiếu Nhập Thuốc";
            // 
            // txtTongTien
            // 
            txtTongTien.Location = new Point(648, 84);
            txtTongTien.Margin = new Padding(4);
            txtTongTien.Name = "txtTongTien";
            txtTongTien.ReadOnly = true;
            txtTongTien.Size = new Size(226, 35);
            txtTongTien.TabIndex = 5;
            // 
            // dtpNgayLapPhieu
            // 
            dtpNgayLapPhieu.CustomFormat = "dd/MM/yyyy";
            dtpNgayLapPhieu.Format = DateTimePickerFormat.Custom;
            dtpNgayLapPhieu.Location = new Point(306, 84);
            dtpNgayLapPhieu.Margin = new Padding(4);
            dtpNgayLapPhieu.Name = "dtpNgayLapPhieu";
            dtpNgayLapPhieu.Size = new Size(300, 35);
            dtpNgayLapPhieu.TabIndex = 4;
            // 
            // txtMaPhieuNhapThuoc
            // 
            txtMaPhieuNhapThuoc.BackColor = SystemColors.ControlLight;
            txtMaPhieuNhapThuoc.Location = new Point(16, 84);
            txtMaPhieuNhapThuoc.Margin = new Padding(4);
            txtMaPhieuNhapThuoc.Name = "txtMaPhieuNhapThuoc";
            txtMaPhieuNhapThuoc.ReadOnly = true;
            txtMaPhieuNhapThuoc.Size = new Size(245, 35);
            txtMaPhieuNhapThuoc.TabIndex = 3;
            // 
            // lblTongTien
            // 
            lblTongTien.AutoSize = true;
            lblTongTien.Location = new Point(648, 51);
            lblTongTien.Margin = new Padding(4, 0, 4, 0);
            lblTongTien.Name = "lblTongTien";
            lblTongTien.Size = new Size(109, 30);
            lblTongTien.TabIndex = 2;
            lblTongTien.Text = "Tổng Tiền";
            // 
            // lblNgayLap
            // 
            lblNgayLap.AutoSize = true;
            lblNgayLap.Location = new Point(306, 51);
            lblNgayLap.Margin = new Padding(4, 0, 4, 0);
            lblNgayLap.Name = "lblNgayLap";
            lblNgayLap.Size = new Size(162, 30);
            lblNgayLap.TabIndex = 1;
            lblNgayLap.Text = "Ngày Lập Phiếu";
            // 
            // lblMaPhieuNhapThuoc
            // 
            lblMaPhieuNhapThuoc.AutoSize = true;
            lblMaPhieuNhapThuoc.Location = new Point(16, 51);
            lblMaPhieuNhapThuoc.Margin = new Padding(4, 0, 4, 0);
            lblMaPhieuNhapThuoc.Name = "lblMaPhieuNhapThuoc";
            lblMaPhieuNhapThuoc.Size = new Size(101, 30);
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
            grbThongTinThuoc.Location = new Point(10, 259);
            grbThongTinThuoc.Margin = new Padding(4);
            grbThongTinThuoc.Name = "grbThongTinThuoc";
            grbThongTinThuoc.Padding = new Padding(4);
            grbThongTinThuoc.Size = new Size(949, 189);
            grbThongTinThuoc.TabIndex = 2;
            grbThongTinThuoc.TabStop = false;
            grbThongTinThuoc.Text = "Thông Tin Loại Thuốc";
            // 
            // txtDonGiaNhap
            // 
            txtDonGiaNhap.Location = new Point(645, 102);
            txtDonGiaNhap.Margin = new Padding(4);
            txtDonGiaNhap.Name = "txtDonGiaNhap";
            txtDonGiaNhap.Size = new Size(226, 35);
            txtDonGiaNhap.TabIndex = 5;
            txtDonGiaNhap.TextChanged += txtDonGiaNhap_TextChanged;
            // 
            // lblDonGiaNhap
            // 
            lblDonGiaNhap.AutoSize = true;
            lblDonGiaNhap.Location = new Point(645, 69);
            lblDonGiaNhap.Margin = new Padding(4, 0, 4, 0);
            lblDonGiaNhap.Name = "lblDonGiaNhap";
            lblDonGiaNhap.Size = new Size(148, 30);
            lblDonGiaNhap.TabIndex = 4;
            lblDonGiaNhap.Text = "Đơn Giá Nhập";
            // 
            // nudSoLuongNhap
            // 
            nudSoLuongNhap.Location = new Point(304, 104);
            nudSoLuongNhap.Margin = new Padding(4);
            nudSoLuongNhap.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            nudSoLuongNhap.Name = "nudSoLuongNhap";
            nudSoLuongNhap.Size = new Size(301, 35);
            nudSoLuongNhap.TabIndex = 3;
            nudSoLuongNhap.ValueChanged += nudSoLuongNhap_ValueChanged;
            // 
            // lblSoLuong
            // 
            lblSoLuong.AutoSize = true;
            lblSoLuong.Location = new Point(305, 69);
            lblSoLuong.Margin = new Padding(4, 0, 4, 0);
            lblSoLuong.Name = "lblSoLuong";
            lblSoLuong.Size = new Size(162, 30);
            lblSoLuong.TabIndex = 2;
            lblSoLuong.Text = "Số Lượng Nhập";
            // 
            // lblTenThuoc
            // 
            lblTenThuoc.AutoSize = true;
            lblTenThuoc.Location = new Point(14, 69);
            lblTenThuoc.Margin = new Padding(4, 0, 4, 0);
            lblTenThuoc.Name = "lblTenThuoc";
            lblTenThuoc.Size = new Size(111, 30);
            lblTenThuoc.TabIndex = 1;
            lblTenThuoc.Text = "Tên Thuốc";
            // 
            // cboTenThuoc
            // 
            cboTenThuoc.FormattingEnabled = true;
            cboTenThuoc.Location = new Point(14, 104);
            cboTenThuoc.Margin = new Padding(4);
            cboTenThuoc.Name = "cboTenThuoc";
            cboTenThuoc.Size = new Size(245, 36);
            cboTenThuoc.TabIndex = 0;
            // 
            // grbDanhSachPhieuNhapThuoc
            // 
            grbDanhSachPhieuNhapThuoc.Controls.Add(dgvDanhSachPhieuNhapThuoc);
            grbDanhSachPhieuNhapThuoc.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            grbDanhSachPhieuNhapThuoc.Location = new Point(10, 455);
            grbDanhSachPhieuNhapThuoc.Margin = new Padding(4);
            grbDanhSachPhieuNhapThuoc.Name = "grbDanhSachPhieuNhapThuoc";
            grbDanhSachPhieuNhapThuoc.Padding = new Padding(4);
            grbDanhSachPhieuNhapThuoc.Size = new Size(564, 410);
            grbDanhSachPhieuNhapThuoc.TabIndex = 3;
            grbDanhSachPhieuNhapThuoc.TabStop = false;
            grbDanhSachPhieuNhapThuoc.Text = "Danh Sách Phiếu Nhập Thuốc";
            // 
            // dgvDanhSachPhieuNhapThuoc
            // 
            dgvDanhSachPhieuNhapThuoc.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDanhSachPhieuNhapThuoc.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDanhSachPhieuNhapThuoc.Dock = DockStyle.Fill;
            dgvDanhSachPhieuNhapThuoc.Location = new Point(4, 32);
            dgvDanhSachPhieuNhapThuoc.Margin = new Padding(4);
            dgvDanhSachPhieuNhapThuoc.Name = "dgvDanhSachPhieuNhapThuoc";
            dgvDanhSachPhieuNhapThuoc.ReadOnly = true;
            dgvDanhSachPhieuNhapThuoc.RowHeadersWidth = 51;
            dgvDanhSachPhieuNhapThuoc.RowTemplate.DefaultCellStyle.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dgvDanhSachPhieuNhapThuoc.RowTemplate.DefaultCellStyle.ForeColor = SystemColors.WindowText;
            dgvDanhSachPhieuNhapThuoc.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.Teal;
            dgvDanhSachPhieuNhapThuoc.RowTemplate.DefaultCellStyle.SelectionForeColor = SystemColors.Window;
            dgvDanhSachPhieuNhapThuoc.RowTemplate.Height = 29;
            dgvDanhSachPhieuNhapThuoc.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDanhSachPhieuNhapThuoc.Size = new Size(556, 374);
            dgvDanhSachPhieuNhapThuoc.TabIndex = 0;
            dgvDanhSachPhieuNhapThuoc.CellContentClick += dgvDanhSachPhieuNhapThuoc_CellContentClick;
            // 
            // grbDanhSachThuoc
            // 
            grbDanhSachThuoc.Controls.Add(dgvDanhSachThuoc);
            grbDanhSachThuoc.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            grbDanhSachThuoc.Location = new Point(590, 455);
            grbDanhSachThuoc.Margin = new Padding(4);
            grbDanhSachThuoc.Name = "grbDanhSachThuoc";
            grbDanhSachThuoc.Padding = new Padding(4);
            grbDanhSachThuoc.Size = new Size(709, 410);
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
            dgvDanhSachThuoc.Location = new Point(4, 32);
            dgvDanhSachThuoc.Margin = new Padding(4);
            dgvDanhSachThuoc.Name = "dgvDanhSachThuoc";
            dgvDanhSachThuoc.ReadOnly = true;
            dgvDanhSachThuoc.RowHeadersWidth = 51;
            dgvDanhSachThuoc.RowTemplate.DefaultCellStyle.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dgvDanhSachThuoc.RowTemplate.DefaultCellStyle.ForeColor = SystemColors.WindowText;
            dgvDanhSachThuoc.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.Teal;
            dgvDanhSachThuoc.RowTemplate.DefaultCellStyle.SelectionForeColor = SystemColors.Window;
            dgvDanhSachThuoc.RowTemplate.Height = 29;
            dgvDanhSachThuoc.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDanhSachThuoc.Size = new Size(701, 374);
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
            btnLapPhieu.Location = new Point(988, 400);
            btnLapPhieu.Margin = new Padding(4);
            btnLapPhieu.Name = "btnLapPhieu";
            btnLapPhieu.Size = new Size(311, 48);
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
            btnThoat.Location = new Point(82, 888);
            btnThoat.Margin = new Padding(4);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(485, 61);
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
            btnThem.Location = new Point(988, 250);
            btnThem.Margin = new Padding(4);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(140, 51);
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
            btnSua.Location = new Point(988, 328);
            btnSua.Margin = new Padding(4);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(140, 51);
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
            btnReset.Location = new Point(1159, 329);
            btnReset.Margin = new Padding(4);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(140, 51);
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
            btnXemThongTinThuoc.Location = new Point(740, 888);
            btnXemThongTinThuoc.Margin = new Padding(4);
            btnXemThongTinThuoc.Name = "btnXemThongTinThuoc";
            btnXemThongTinThuoc.Size = new Size(485, 61);
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
            btnXoa.Location = new Point(1159, 250);
            btnXoa.Margin = new Padding(4);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(140, 51);
            btnXoa.TabIndex = 12;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = false;
            btnXoa.Click += btnXoa_Click;
            // 
            // frmLapPhieuNhapThuoc
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1319, 964);
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
            Margin = new Padding(4);
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