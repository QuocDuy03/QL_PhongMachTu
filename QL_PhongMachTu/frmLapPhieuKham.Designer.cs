namespace QL_PhongMachTu
{
    partial class frmLapPhieuKham
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            grbDanhSachBenhNhan = new GroupBox();
            dgvDanhSachBenhNhan = new DataGridView();
            groupBox2 = new GroupBox();
            label4 = new Label();
            groupBox5 = new GroupBox();
            nudSoLuong = new NumericUpDown();
            txtCachDung = new TextBox();
            txtDonVi = new TextBox();
            cboTenThuoc = new ComboBox();
            label13 = new Label();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            txtGioiTinh = new TextBox();
            groupBox4 = new GroupBox();
            label15 = new Label();
            txtMaPhieuKham = new TextBox();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            cboLoaiBenh = new ComboBox();
            txtTrieuChung = new TextBox();
            dtpNgayKham = new DateTimePicker();
            txtDiaChi = new TextBox();
            txtNamSinh = new TextBox();
            txtHoTen = new TextBox();
            txtMaBenhNhan = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label3 = new Label();
            label2 = new Label();
            btnThem = new Button();
            grbToaThuoc = new GroupBox();
            dgvToaThuoc = new DataGridView();
            TenThuoc = new DataGridViewTextBoxColumn();
            DonVi = new DataGridViewTextBoxColumn();
            SoLuong = new DataGridViewTextBoxColumn();
            CachDung = new DataGridViewTextBoxColumn();
            lblTitle = new Label();
            label14 = new Label();
            btnXoa = new Button();
            btnSua = new Button();
            btnReset = new Button();
            btnLapPhieu = new Button();
            btnThoat = new Button();
            txtSoLuongKhamBenh = new Label();
            btnLapHoaDon = new Button();
            errorProvider = new ErrorProvider(components);
            grbDanhSachBenhNhan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDanhSachBenhNhan).BeginInit();
            groupBox2.SuspendLayout();
            groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudSoLuong).BeginInit();
            groupBox4.SuspendLayout();
            grbToaThuoc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvToaThuoc).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            SuspendLayout();
            // 
            // grbDanhSachBenhNhan
            // 
            grbDanhSachBenhNhan.Controls.Add(dgvDanhSachBenhNhan);
            grbDanhSachBenhNhan.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            grbDanhSachBenhNhan.Location = new Point(15, 520);
            grbDanhSachBenhNhan.Margin = new Padding(4, 5, 4, 5);
            grbDanhSachBenhNhan.Name = "grbDanhSachBenhNhan";
            grbDanhSachBenhNhan.Padding = new Padding(4, 5, 4, 5);
            grbDanhSachBenhNhan.Size = new Size(622, 365);
            grbDanhSachBenhNhan.TabIndex = 0;
            grbDanhSachBenhNhan.TabStop = false;
            grbDanhSachBenhNhan.Text = "Danh Sách Bệnh Nhân Trong Ngày";
            grbDanhSachBenhNhan.Enter += grbDanhSachBenhNhan_Enter;
            // 
            // dgvDanhSachBenhNhan
            // 
            dgvDanhSachBenhNhan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDanhSachBenhNhan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDanhSachBenhNhan.Dock = DockStyle.Fill;
            dgvDanhSachBenhNhan.Location = new Point(4, 30);
            dgvDanhSachBenhNhan.Margin = new Padding(4, 5, 4, 5);
            dgvDanhSachBenhNhan.Name = "dgvDanhSachBenhNhan";
            dgvDanhSachBenhNhan.ReadOnly = true;
            dgvDanhSachBenhNhan.RowHeadersWidth = 51;
            dgvDanhSachBenhNhan.RowTemplate.DefaultCellStyle.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dgvDanhSachBenhNhan.RowTemplate.DefaultCellStyle.ForeColor = SystemColors.WindowText;
            dgvDanhSachBenhNhan.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.Teal;
            dgvDanhSachBenhNhan.RowTemplate.DefaultCellStyle.SelectionForeColor = SystemColors.Window;
            dgvDanhSachBenhNhan.RowTemplate.Height = 25;
            dgvDanhSachBenhNhan.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDanhSachBenhNhan.Size = new Size(614, 330);
            dgvDanhSachBenhNhan.TabIndex = 0;
            dgvDanhSachBenhNhan.CellClick += dgvDanhSachBenhNhan_CellClick;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(groupBox5);
            groupBox2.Controls.Add(txtGioiTinh);
            groupBox2.Controls.Add(groupBox4);
            groupBox2.Controls.Add(txtDiaChi);
            groupBox2.Controls.Add(txtNamSinh);
            groupBox2.Controls.Add(txtHoTen);
            groupBox2.Controls.Add(txtMaBenhNhan);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label2);
            groupBox2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox2.Location = new Point(18, 71);
            groupBox2.Margin = new Padding(4, 5, 4, 5);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(4, 5, 4, 5);
            groupBox2.Size = new Size(1091, 435);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "Thông Tin Bệnh Nhân";
            groupBox2.Enter += groupBox2_Enter;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(439, 32);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(89, 25);
            label4.TabIndex = 13;
            label4.Text = "Giới Tính";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(nudSoLuong);
            groupBox5.Controls.Add(txtCachDung);
            groupBox5.Controls.Add(txtDonVi);
            groupBox5.Controls.Add(cboTenThuoc);
            groupBox5.Controls.Add(label13);
            groupBox5.Controls.Add(label12);
            groupBox5.Controls.Add(label11);
            groupBox5.Controls.Add(label10);
            groupBox5.Location = new Point(18, 305);
            groupBox5.Margin = new Padding(4, 5, 4, 5);
            groupBox5.Name = "groupBox5";
            groupBox5.Padding = new Padding(4, 5, 4, 5);
            groupBox5.Size = new Size(1058, 120);
            groupBox5.TabIndex = 11;
            groupBox5.TabStop = false;
            groupBox5.Text = "Kê Thuốc";
            groupBox5.Enter += groupBox5_Enter;
            // 
            // nudSoLuong
            // 
            nudSoLuong.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            nudSoLuong.Location = new Point(762, 67);
            nudSoLuong.Margin = new Padding(4);
            nudSoLuong.Name = "nudSoLuong";
            nudSoLuong.Size = new Size(231, 39);
            nudSoLuong.TabIndex = 4;
            nudSoLuong.ValueChanged += nudSoLuong_ValueChanged;
            // 
            // txtCachDung
            // 
            txtCachDung.BackColor = SystemColors.ControlLight;
            txtCachDung.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtCachDung.Location = new Point(521, 67);
            txtCachDung.Margin = new Padding(4, 5, 4, 5);
            txtCachDung.Name = "txtCachDung";
            txtCachDung.ReadOnly = true;
            txtCachDung.Size = new Size(212, 39);
            txtCachDung.TabIndex = 3;
            // 
            // txtDonVi
            // 
            txtDonVi.BackColor = SystemColors.ControlLight;
            txtDonVi.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtDonVi.Location = new Point(326, 67);
            txtDonVi.Margin = new Padding(4, 5, 4, 5);
            txtDonVi.Name = "txtDonVi";
            txtDonVi.ReadOnly = true;
            txtDonVi.Size = new Size(172, 39);
            txtDonVi.TabIndex = 1;
            // 
            // cboTenThuoc
            // 
            cboTenThuoc.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cboTenThuoc.FormattingEnabled = true;
            cboTenThuoc.Location = new Point(11, 67);
            cboTenThuoc.Margin = new Padding(4, 5, 4, 5);
            cboTenThuoc.Name = "cboTenThuoc";
            cboTenThuoc.Size = new Size(282, 40);
            cboTenThuoc.TabIndex = 0;
            cboTenThuoc.TextChanged += cboTenThuoc_TextChanged;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(521, 30);
            label13.Margin = new Padding(4, 0, 4, 0);
            label13.Name = "label13";
            label13.Size = new Size(104, 25);
            label13.TabIndex = 3;
            label13.Text = "Cách Dùng";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(762, 30);
            label12.Margin = new Padding(4, 0, 4, 0);
            label12.Name = "label12";
            label12.Size = new Size(92, 25);
            label12.TabIndex = 2;
            label12.Text = "Số Lượng";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(326, 30);
            label11.Margin = new Padding(4, 0, 4, 0);
            label11.Name = "label11";
            label11.Size = new Size(69, 25);
            label11.TabIndex = 1;
            label11.Text = "Đơn Vị";
            label11.Click += label11_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(11, 30);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(140, 25);
            label10.TabIndex = 0;
            label10.Text = "Tên Loại Thuốc";
            // 
            // txtGioiTinh
            // 
            txtGioiTinh.BackColor = SystemColors.ControlLight;
            txtGioiTinh.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtGioiTinh.Location = new Point(440, 69);
            txtGioiTinh.Margin = new Padding(4, 5, 4, 5);
            txtGioiTinh.Name = "txtGioiTinh";
            txtGioiTinh.ReadOnly = true;
            txtGioiTinh.Size = new Size(116, 39);
            txtGioiTinh.TabIndex = 12;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(label15);
            groupBox4.Controls.Add(txtMaPhieuKham);
            groupBox4.Controls.Add(label9);
            groupBox4.Controls.Add(label8);
            groupBox4.Controls.Add(label7);
            groupBox4.Controls.Add(cboLoaiBenh);
            groupBox4.Controls.Add(txtTrieuChung);
            groupBox4.Controls.Add(dtpNgayKham);
            groupBox4.Location = new Point(18, 120);
            groupBox4.Margin = new Padding(4, 5, 4, 5);
            groupBox4.Name = "groupBox4";
            groupBox4.Padding = new Padding(4, 5, 4, 5);
            groupBox4.Size = new Size(1058, 180);
            groupBox4.TabIndex = 10;
            groupBox4.TabStop = false;
            groupBox4.Text = "Thông Tin Phiếu Khám";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(51, 30);
            label15.Margin = new Padding(4, 0, 4, 0);
            label15.Name = "label15";
            label15.Size = new Size(146, 25);
            label15.TabIndex = 15;
            label15.Text = "Mã Phiếu Khám";
            // 
            // txtMaPhieuKham
            // 
            txtMaPhieuKham.BackColor = SystemColors.ControlLight;
            txtMaPhieuKham.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtMaPhieuKham.Location = new Point(51, 62);
            txtMaPhieuKham.Margin = new Padding(4, 5, 4, 5);
            txtMaPhieuKham.Name = "txtMaPhieuKham";
            txtMaPhieuKham.ReadOnly = true;
            txtMaPhieuKham.Size = new Size(134, 39);
            txtMaPhieuKham.TabIndex = 14;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(636, 105);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(176, 25);
            label9.TabIndex = 5;
            label9.Text = "Dự Đoán Loại Bệnh";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(51, 105);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(116, 25);
            label8.TabIndex = 4;
            label8.Text = "Triệu Chứng";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(636, 30);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(111, 25);
            label7.TabIndex = 3;
            label7.Text = "Ngày Khám";
            // 
            // cboLoaiBenh
            // 
            cboLoaiBenh.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cboLoaiBenh.FormattingEnabled = true;
            cboLoaiBenh.Location = new Point(636, 135);
            cboLoaiBenh.Margin = new Padding(4, 5, 4, 5);
            cboLoaiBenh.Name = "cboLoaiBenh";
            cboLoaiBenh.Size = new Size(356, 40);
            cboLoaiBenh.TabIndex = 2;
            // 
            // txtTrieuChung
            // 
            txtTrieuChung.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtTrieuChung.Location = new Point(51, 135);
            txtTrieuChung.Margin = new Padding(4, 5, 4, 5);
            txtTrieuChung.Name = "txtTrieuChung";
            txtTrieuChung.Size = new Size(468, 39);
            txtTrieuChung.TabIndex = 1;
            txtTrieuChung.TextChanged += txtTrieuChung_TextChanged;
            // 
            // dtpNgayKham
            // 
            dtpNgayKham.CustomFormat = "dd/MM/yyyy";
            dtpNgayKham.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dtpNgayKham.Format = DateTimePickerFormat.Custom;
            dtpNgayKham.Location = new Point(636, 62);
            dtpNgayKham.Margin = new Padding(4, 5, 4, 5);
            dtpNgayKham.Name = "dtpNgayKham";
            dtpNgayKham.Size = new Size(356, 39);
            dtpNgayKham.TabIndex = 0;
            dtpNgayKham.ValueChanged += dtpNgayKham_ValueChanged;
            // 
            // txtDiaChi
            // 
            txtDiaChi.BackColor = SystemColors.ControlLight;
            txtDiaChi.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtDiaChi.Location = new Point(715, 69);
            txtDiaChi.Margin = new Padding(4, 5, 4, 5);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.ReadOnly = true;
            txtDiaChi.Size = new Size(358, 39);
            txtDiaChi.TabIndex = 5;
            // 
            // txtNamSinh
            // 
            txtNamSinh.BackColor = SystemColors.ControlLight;
            txtNamSinh.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtNamSinh.Location = new Point(570, 69);
            txtNamSinh.Margin = new Padding(4, 5, 4, 5);
            txtNamSinh.Name = "txtNamSinh";
            txtNamSinh.ReadOnly = true;
            txtNamSinh.Size = new Size(138, 39);
            txtNamSinh.TabIndex = 4;
            // 
            // txtHoTen
            // 
            txtHoTen.BackColor = SystemColors.ControlLight;
            txtHoTen.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtHoTen.Location = new Point(168, 69);
            txtHoTen.Margin = new Padding(4, 5, 4, 5);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.ReadOnly = true;
            txtHoTen.Size = new Size(260, 39);
            txtHoTen.TabIndex = 2;
            // 
            // txtMaBenhNhan
            // 
            txtMaBenhNhan.BackColor = SystemColors.ControlLight;
            txtMaBenhNhan.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtMaBenhNhan.Location = new Point(20, 69);
            txtMaBenhNhan.Margin = new Padding(4, 5, 4, 5);
            txtMaBenhNhan.Name = "txtMaBenhNhan";
            txtMaBenhNhan.ReadOnly = true;
            txtMaBenhNhan.Size = new Size(134, 39);
            txtMaBenhNhan.TabIndex = 1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(716, 32);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(72, 25);
            label6.TabIndex = 4;
            label6.Text = "Địa Chỉ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(569, 32);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(94, 25);
            label5.TabIndex = 3;
            label5.Text = "Năm Sinh";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(168, 32);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(98, 25);
            label3.TabIndex = 1;
            label3.Text = "Họ Và Tên";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 32);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(139, 25);
            label2.TabIndex = 0;
            label2.Text = "Mã Bệnh Nhân";
            // 
            // btnThem
            // 
            btnThem.BackColor = Color.Teal;
            btnThem.Cursor = Cursors.Hand;
            btnThem.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            btnThem.ForeColor = Color.White;
            btnThem.Location = new Point(1140, 300);
            btnThem.Margin = new Padding(4, 5, 4, 5);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(160, 64);
            btnThem.TabIndex = 4;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // 
            // grbToaThuoc
            // 
            grbToaThuoc.Controls.Add(dgvToaThuoc);
            grbToaThuoc.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            grbToaThuoc.Location = new Point(651, 520);
            grbToaThuoc.Margin = new Padding(4, 5, 4, 5);
            grbToaThuoc.Name = "grbToaThuoc";
            grbToaThuoc.Padding = new Padding(4, 5, 4, 5);
            grbToaThuoc.Size = new Size(844, 365);
            grbToaThuoc.TabIndex = 0;
            grbToaThuoc.TabStop = false;
            grbToaThuoc.Text = "Toa Thuốc";
            // 
            // dgvToaThuoc
            // 
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.Teal;
            dgvToaThuoc.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvToaThuoc.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = Color.Teal;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvToaThuoc.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvToaThuoc.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvToaThuoc.Columns.AddRange(new DataGridViewColumn[] { TenThuoc, DonVi, SoLuong, CachDung });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.Control;
            dataGridViewCellStyle3.SelectionBackColor = Color.Teal;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvToaThuoc.DefaultCellStyle = dataGridViewCellStyle3;
            dgvToaThuoc.Dock = DockStyle.Fill;
            dgvToaThuoc.Location = new Point(4, 30);
            dgvToaThuoc.Margin = new Padding(4, 5, 4, 5);
            dgvToaThuoc.Name = "dgvToaThuoc";
            dgvToaThuoc.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = SystemColors.Window;
            dataGridViewCellStyle4.SelectionBackColor = Color.Teal;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgvToaThuoc.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgvToaThuoc.RowHeadersWidth = 51;
            dataGridViewCellStyle5.ForeColor = Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = Color.Teal;
            dataGridViewCellStyle5.SelectionForeColor = Color.White;
            dgvToaThuoc.RowsDefaultCellStyle = dataGridViewCellStyle5;
            dgvToaThuoc.RowTemplate.DefaultCellStyle.ForeColor = Color.Black;
            dgvToaThuoc.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.Teal;
            dgvToaThuoc.RowTemplate.DefaultCellStyle.SelectionForeColor = Color.White;
            dgvToaThuoc.RowTemplate.Height = 25;
            dgvToaThuoc.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvToaThuoc.Size = new Size(836, 330);
            dgvToaThuoc.TabIndex = 0;
            dgvToaThuoc.CellClick += dgvToaThuoc_CellClick;
            dgvToaThuoc.CellContentClick += dgvToaThuoc_CellContentClick;
            // 
            // TenThuoc
            // 
            TenThuoc.HeaderText = "Thuốc";
            TenThuoc.MinimumWidth = 6;
            TenThuoc.Name = "TenThuoc";
            TenThuoc.ReadOnly = true;
            // 
            // DonVi
            // 
            DonVi.HeaderText = "Đơn Vị";
            DonVi.MinimumWidth = 6;
            DonVi.Name = "DonVi";
            DonVi.ReadOnly = true;
            // 
            // SoLuong
            // 
            SoLuong.HeaderText = "Số Lượng";
            SoLuong.MinimumWidth = 6;
            SoLuong.Name = "SoLuong";
            SoLuong.ReadOnly = true;
            // 
            // CachDung
            // 
            CachDung.HeaderText = "Cách Dùng";
            CachDung.MinimumWidth = 6;
            CachDung.Name = "CachDung";
            CachDung.ReadOnly = true;
            // 
            // lblTitle
            // 
            lblTitle.BackColor = Color.Teal;
            lblTitle.Dock = DockStyle.Top;
            lblTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(0, 0);
            lblTitle.Margin = new Padding(4, 0, 4, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(1509, 66);
            lblTitle.TabIndex = 2;
            lblTitle.Text = "Lập Phiếu Khám Bệnh";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            lblTitle.Click += lblTitle_Click;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label14.Location = new Point(1121, 202);
            label14.Margin = new Padding(4, 0, 4, 0);
            label14.Name = "label14";
            label14.Size = new Size(287, 38);
            label14.TabIndex = 5;
            label14.Text = "Số Lượt Khám Bệnh:";
            label14.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnXoa
            // 
            btnXoa.BackColor = Color.Teal;
            btnXoa.Cursor = Cursors.Hand;
            btnXoa.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            btnXoa.ForeColor = Color.White;
            btnXoa.Location = new Point(1335, 300);
            btnXoa.Margin = new Padding(4, 5, 4, 5);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(160, 64);
            btnXoa.TabIndex = 6;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = false;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnSua
            // 
            btnSua.BackColor = Color.Teal;
            btnSua.Cursor = Cursors.Hand;
            btnSua.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            btnSua.ForeColor = Color.White;
            btnSua.Location = new Point(1140, 380);
            btnSua.Margin = new Padding(4, 5, 4, 5);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(160, 64);
            btnSua.TabIndex = 7;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = false;
            btnSua.Click += btnSua_Click;
            // 
            // btnReset
            // 
            btnReset.BackColor = Color.Teal;
            btnReset.Cursor = Cursors.Hand;
            btnReset.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            btnReset.ForeColor = Color.White;
            btnReset.Location = new Point(1335, 380);
            btnReset.Margin = new Padding(4, 5, 4, 5);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(160, 64);
            btnReset.TabIndex = 8;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = false;
            btnReset.Click += btnReset_Click;
            // 
            // btnLapPhieu
            // 
            btnLapPhieu.BackColor = Color.Teal;
            btnLapPhieu.Cursor = Cursors.Hand;
            btnLapPhieu.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnLapPhieu.ForeColor = Color.White;
            btnLapPhieu.Location = new Point(1140, 460);
            btnLapPhieu.Margin = new Padding(4, 5, 4, 5);
            btnLapPhieu.Name = "btnLapPhieu";
            btnLapPhieu.Size = new Size(355, 54);
            btnLapPhieu.TabIndex = 9;
            btnLapPhieu.Text = "Lập Phiếu";
            btnLapPhieu.UseVisualStyleBackColor = false;
            btnLapPhieu.Click += btnLapPhieu_Click;
            // 
            // btnThoat
            // 
            btnThoat.AutoSize = true;
            btnThoat.BackColor = Color.Teal;
            btnThoat.Cursor = Cursors.Hand;
            btnThoat.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnThoat.ForeColor = Color.White;
            btnThoat.Location = new Point(798, 900);
            btnThoat.Margin = new Padding(4, 5, 4, 5);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(555, 54);
            btnThoat.TabIndex = 10;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = false;
            btnThoat.Click += btnThoat_Click;
            // 
            // txtSoLuongKhamBenh
            // 
            txtSoLuongKhamBenh.AutoSize = true;
            txtSoLuongKhamBenh.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            txtSoLuongKhamBenh.Location = new Point(1430, 198);
            txtSoLuongKhamBenh.Margin = new Padding(4, 0, 4, 0);
            txtSoLuongKhamBenh.Name = "txtSoLuongKhamBenh";
            txtSoLuongKhamBenh.Size = new Size(62, 48);
            txtSoLuongKhamBenh.TabIndex = 11;
            txtSoLuongKhamBenh.Text = "40";
            txtSoLuongKhamBenh.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnLapHoaDon
            // 
            btnLapHoaDon.BackColor = Color.Teal;
            btnLapHoaDon.Cursor = Cursors.Hand;
            btnLapHoaDon.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnLapHoaDon.ForeColor = Color.White;
            btnLapHoaDon.Location = new Point(171, 900);
            btnLapHoaDon.Margin = new Padding(4, 5, 4, 5);
            btnLapHoaDon.Name = "btnLapHoaDon";
            btnLapHoaDon.Size = new Size(529, 54);
            btnLapHoaDon.TabIndex = 12;
            btnLapHoaDon.Text = "Lập Hóa Đơn";
            btnLapHoaDon.UseVisualStyleBackColor = false;
            btnLapHoaDon.Click += btnLapHoaDon_Click;
            // 
            // errorProvider
            // 
            errorProvider.ContainerControl = this;
            // 
            // frmLapPhieuKham
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(1509, 974);
            Controls.Add(btnLapHoaDon);
            Controls.Add(txtSoLuongKhamBenh);
            Controls.Add(btnThoat);
            Controls.Add(btnLapPhieu);
            Controls.Add(btnReset);
            Controls.Add(btnSua);
            Controls.Add(btnXoa);
            Controls.Add(label14);
            Controls.Add(lblTitle);
            Controls.Add(grbToaThuoc);
            Controls.Add(btnThem);
            Controls.Add(groupBox2);
            Controls.Add(grbDanhSachBenhNhan);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4);
            Name = "frmLapPhieuKham";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Lập Phiếu Khám Bệnh";
            Load += frmLapPhieuKham_Load;
            grbDanhSachBenhNhan.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvDanhSachBenhNhan).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudSoLuong).EndInit();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            grbToaThuoc.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvToaThuoc).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox grbDanhSachBenhNhan;
        private GroupBox groupBox2;
        private GroupBox grbToaThuoc;
        private DataGridView dgvDanhSachBenhNhan;
        private DataGridView dgvToaThuoc;
        private Label lblTitle;
        private Label label3;
        private Label label2;
        private Label label5;
        private Label label6;
        private TextBox txtMaBenhNhan;
        private TextBox txtDiaChi;
        private TextBox txtNamSinh;
        private TextBox txtHoTen;
        private GroupBox groupBox4;
        private DateTimePicker dtpNgayKham;
        private TextBox txtTrieuChung;
        private ComboBox cboLoaiBenh;
        private Label label8;
        private Label label7;
        private Label label9;
        private GroupBox groupBox5;
        private Label label13;
        private Label label12;
        private Label label11;
        private Label label10;
        private ComboBox cboTenThuoc;
        private Button btnThem;
        private TextBox txtCachDung;
        private TextBox txtDonVi;
        private Label label14;
        private Button btnXoa;
        private Button btnSua;
        private Button btnReset;
        private Button btnLapPhieu;
        private Button btnThoat;
        private NumericUpDown nudSoLuong;
        private Label label4;
        private TextBox txtGioiTinh;
        private Label label15;
        private TextBox txtMaPhieuKham;
        private Label txtSoLuongKhamBenh;
        private Button btnLapHoaDon;
        private ErrorProvider errorProvider;
        private DataGridViewTextBoxColumn TenThuoc;
        private DataGridViewTextBoxColumn DonVi;
        private DataGridViewTextBoxColumn SoLuong;
        private DataGridViewTextBoxColumn CachDung;
    }
}