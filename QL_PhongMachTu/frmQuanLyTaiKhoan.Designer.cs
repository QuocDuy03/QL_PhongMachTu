namespace QL_PhongMachTu
{
    partial class frmQuanLyTaiKhoan
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
            lblTitle = new Label();
            grbDanhSachTaiKhoan = new GroupBox();
            dvwDanhSachTaiKhoan = new DataGridView();
            lblTenDangNhap = new Label();
            lblMatKhau = new Label();
            lblLoaiTaiKhoan = new Label();
            txtTenDangNhap = new TextBox();
            txtMatKhau = new TextBox();
            cboLoaiTaiKhoan = new ComboBox();
            btnThem = new Button();
            btnXoa = new Button();
            btnSua = new Button();
            btnThoat = new Button();
            grbDanhSachTaiKhoan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dvwDanhSachTaiKhoan).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitle.ForeColor = Color.Teal;
            lblTitle.Location = new Point(320, 26);
            lblTitle.Margin = new Padding(4, 0, 4, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(350, 45);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "QUẢN LÝ TÀI KHOẢN";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            lblTitle.Click += lblTitle_Click;
            // 
            // grbDanhSachTaiKhoan
            // 
            grbDanhSachTaiKhoan.Controls.Add(dvwDanhSachTaiKhoan);
            grbDanhSachTaiKhoan.Location = new Point(15, 251);
            grbDanhSachTaiKhoan.Margin = new Padding(4, 4, 4, 4);
            grbDanhSachTaiKhoan.Name = "grbDanhSachTaiKhoan";
            grbDanhSachTaiKhoan.Padding = new Padding(4, 4, 4, 4);
            grbDanhSachTaiKhoan.Size = new Size(581, 301);
            grbDanhSachTaiKhoan.TabIndex = 1;
            grbDanhSachTaiKhoan.TabStop = false;
            grbDanhSachTaiKhoan.Text = "Danh Sách Tài Khoản";
            // 
            // dvwDanhSachTaiKhoan
            // 
            dvwDanhSachTaiKhoan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dvwDanhSachTaiKhoan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dvwDanhSachTaiKhoan.Dock = DockStyle.Fill;
            dvwDanhSachTaiKhoan.Location = new Point(4, 28);
            dvwDanhSachTaiKhoan.Margin = new Padding(4, 4, 4, 4);
            dvwDanhSachTaiKhoan.Name = "dvwDanhSachTaiKhoan";
            dvwDanhSachTaiKhoan.ReadOnly = true;
            dvwDanhSachTaiKhoan.RowHeadersWidth = 51;
            dvwDanhSachTaiKhoan.RowTemplate.Height = 29;
            dvwDanhSachTaiKhoan.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dvwDanhSachTaiKhoan.Size = new Size(573, 269);
            dvwDanhSachTaiKhoan.TabIndex = 0;
            dvwDanhSachTaiKhoan.CellClick += dvwDanhSachTaiKhoan_CellClick;
            dvwDanhSachTaiKhoan.CellContentClick += dvwDanhSachTaiKhoan_CellContentClick;
            // 
            // lblTenDangNhap
            // 
            lblTenDangNhap.AutoSize = true;
            lblTenDangNhap.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblTenDangNhap.Location = new Point(28, 105);
            lblTenDangNhap.Margin = new Padding(4, 0, 4, 0);
            lblTenDangNhap.Name = "lblTenDangNhap";
            lblTenDangNhap.Size = new Size(183, 32);
            lblTenDangNhap.TabIndex = 2;
            lblTenDangNhap.Text = "Tên Đăng Nhập";
            // 
            // lblMatKhau
            // 
            lblMatKhau.AutoSize = true;
            lblMatKhau.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblMatKhau.Location = new Point(564, 105);
            lblMatKhau.Margin = new Padding(4, 0, 4, 0);
            lblMatKhau.Name = "lblMatKhau";
            lblMatKhau.Size = new Size(121, 32);
            lblMatKhau.TabIndex = 3;
            lblMatKhau.Text = "Mật Khẩu";
            // 
            // lblLoaiTaiKhoan
            // 
            lblLoaiTaiKhoan.AutoSize = true;
            lblLoaiTaiKhoan.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblLoaiTaiKhoan.Location = new Point(28, 184);
            lblLoaiTaiKhoan.Margin = new Padding(4, 0, 4, 0);
            lblLoaiTaiKhoan.Name = "lblLoaiTaiKhoan";
            lblLoaiTaiKhoan.Size = new Size(173, 32);
            lblLoaiTaiKhoan.TabIndex = 4;
            lblLoaiTaiKhoan.Text = "Loại Tài Khoản";
            // 
            // txtTenDangNhap
            // 
            txtTenDangNhap.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtTenDangNhap.Location = new Point(226, 105);
            txtTenDangNhap.Margin = new Padding(4, 4, 4, 4);
            txtTenDangNhap.Name = "txtTenDangNhap";
            txtTenDangNhap.Size = new Size(275, 39);
            txtTenDangNhap.TabIndex = 5;
            // 
            // txtMatKhau
            // 
            txtMatKhau.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtMatKhau.Location = new Point(695, 105);
            txtMatKhau.Margin = new Padding(4, 4, 4, 4);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.Size = new Size(275, 39);
            txtMatKhau.TabIndex = 6;
            // 
            // cboLoaiTaiKhoan
            // 
            cboLoaiTaiKhoan.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cboLoaiTaiKhoan.FormattingEnabled = true;
            cboLoaiTaiKhoan.Location = new Point(226, 180);
            cboLoaiTaiKhoan.Margin = new Padding(4, 4, 4, 4);
            cboLoaiTaiKhoan.Name = "cboLoaiTaiKhoan";
            cboLoaiTaiKhoan.Size = new Size(275, 40);
            cboLoaiTaiKhoan.TabIndex = 7;
            // 
            // btnThem
            // 
            btnThem.BackColor = Color.Teal;
            btnThem.Cursor = Cursors.Hand;
            btnThem.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnThem.ForeColor = Color.White;
            btnThem.Location = new Point(621, 316);
            btnThem.Margin = new Padding(4, 4, 4, 4);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(160, 74);
            btnThem.TabIndex = 8;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // 
            // btnXoa
            // 
            btnXoa.BackColor = Color.Teal;
            btnXoa.Cursor = Cursors.Hand;
            btnXoa.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnXoa.ForeColor = Color.White;
            btnXoa.Location = new Point(811, 316);
            btnXoa.Margin = new Padding(4, 4, 4, 4);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(160, 74);
            btnXoa.TabIndex = 9;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = false;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnSua
            // 
            btnSua.BackColor = Color.Teal;
            btnSua.Cursor = Cursors.Hand;
            btnSua.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnSua.ForeColor = Color.White;
            btnSua.Location = new Point(621, 438);
            btnSua.Margin = new Padding(4, 4, 4, 4);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(160, 74);
            btnSua.TabIndex = 10;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = false;
            btnSua.Click += btnSua_Click;
            // 
            // btnThoat
            // 
            btnThoat.BackColor = Color.Teal;
            btnThoat.Cursor = Cursors.Hand;
            btnThoat.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnThoat.ForeColor = Color.White;
            btnThoat.Location = new Point(811, 438);
            btnThoat.Margin = new Padding(4, 4, 4, 4);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(160, 74);
            btnThoat.TabIndex = 11;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = false;
            btnThoat.Click += btnThoat_Click;
            // 
            // frmQuanLyTaiKhoan
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1000, 568);
            Controls.Add(btnThoat);
            Controls.Add(btnSua);
            Controls.Add(btnXoa);
            Controls.Add(btnThem);
            Controls.Add(cboLoaiTaiKhoan);
            Controls.Add(txtMatKhau);
            Controls.Add(txtTenDangNhap);
            Controls.Add(lblLoaiTaiKhoan);
            Controls.Add(lblMatKhau);
            Controls.Add(lblTenDangNhap);
            Controls.Add(grbDanhSachTaiKhoan);
            Controls.Add(lblTitle);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4, 4, 4, 4);
            MaximizeBox = false;
            Name = "frmQuanLyTaiKhoan";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản Lý Tài Khoản";
            Load += frmQuanLyTaiKhoan_Load;
            grbDanhSachTaiKhoan.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dvwDanhSachTaiKhoan).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private GroupBox grbDanhSachTaiKhoan;
        private DataGridView dvwDanhSachTaiKhoan;
        private Label lblTenDangNhap;
        private Label lblMatKhau;
        private Label lblLoaiTaiKhoan;
        private TextBox txtTenDangNhap;
        private TextBox txtMatKhau;
        private ComboBox cboLoaiTaiKhoan;
        private Button btnThem;
        private Button btnXoa;
        private Button btnSua;
        private Button btnThoat;
    }
}