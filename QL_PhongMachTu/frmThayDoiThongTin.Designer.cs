namespace QL_PhongMachTu
{
    partial class frmThayDoiThongTin
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
            lblTitle = new Label();
            lblTenDangNhap = new Label();
            lblMatKhau = new Label();
            lblMatKhauMoi = new Label();
            lblXacNhanMatKhauMoi = new Label();
            btnThayDoi = new Button();
            btnThoat = new Button();
            txtTenDangNhap = new TextBox();
            txtMatKhau = new TextBox();
            txtMatKhauMoi = new TextBox();
            txtXacNhanMatKhau = new TextBox();
            errorProvider = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitle.ForeColor = Color.Teal;
            lblTitle.Location = new Point(226, 22);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(552, 45);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "THAY ĐỔI THÔNG TIN TÀI KHOẢN";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            lblTitle.Click += lblTitle_Click;
            // 
            // lblTenDangNhap
            // 
            lblTenDangNhap.AutoSize = true;
            lblTenDangNhap.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblTenDangNhap.Location = new Point(68, 125);
            lblTenDangNhap.Name = "lblTenDangNhap";
            lblTenDangNhap.Size = new Size(197, 32);
            lblTenDangNhap.TabIndex = 1;
            lblTenDangNhap.Text = "Tên Đăng Nhập:";
            // 
            // lblMatKhau
            // 
            lblMatKhau.AutoSize = true;
            lblMatKhau.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblMatKhau.Location = new Point(68, 192);
            lblMatKhau.Name = "lblMatKhau";
            lblMatKhau.Size = new Size(131, 32);
            lblMatKhau.TabIndex = 2;
            lblMatKhau.Text = "Mật Khẩu:";
            // 
            // lblMatKhauMoi
            // 
            lblMatKhauMoi.AutoSize = true;
            lblMatKhauMoi.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblMatKhauMoi.Location = new Point(68, 255);
            lblMatKhauMoi.Name = "lblMatKhauMoi";
            lblMatKhauMoi.Size = new Size(183, 32);
            lblMatKhauMoi.TabIndex = 3;
            lblMatKhauMoi.Text = "Mật Khẩu Mới:";
            // 
            // lblXacNhanMatKhauMoi
            // 
            lblXacNhanMatKhauMoi.AutoSize = true;
            lblXacNhanMatKhauMoi.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblXacNhanMatKhauMoi.Location = new Point(68, 310);
            lblXacNhanMatKhauMoi.Name = "lblXacNhanMatKhauMoi";
            lblXacNhanMatKhauMoi.Size = new Size(290, 32);
            lblXacNhanMatKhauMoi.TabIndex = 4;
            lblXacNhanMatKhauMoi.Text = "Nhập Lại Mật Khẩu Mới:";
            // 
            // btnThayDoi
            // 
            btnThayDoi.BackColor = Color.Teal;
            btnThayDoi.Cursor = Cursors.Hand;
            btnThayDoi.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnThayDoi.ForeColor = Color.White;
            btnThayDoi.Location = new Point(266, 405);
            btnThayDoi.Name = "btnThayDoi";
            btnThayDoi.Size = new Size(155, 52);
            btnThayDoi.TabIndex = 5;
            btnThayDoi.Text = "Thay Đổi";
            btnThayDoi.UseVisualStyleBackColor = false;
            btnThayDoi.Click += btnThayDoi_Click;
            // 
            // btnThoat
            // 
            btnThoat.BackColor = Color.Teal;
            btnThoat.Cursor = Cursors.Hand;
            btnThoat.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnThoat.ForeColor = Color.White;
            btnThoat.Location = new Point(518, 405);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(155, 52);
            btnThoat.TabIndex = 6;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = false;
            btnThoat.Click += btnThoat_Click;
            // 
            // txtTenDangNhap
            // 
            txtTenDangNhap.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtTenDangNhap.Location = new Point(367, 125);
            txtTenDangNhap.Name = "txtTenDangNhap";
            txtTenDangNhap.ReadOnly = true;
            txtTenDangNhap.Size = new Size(460, 39);
            txtTenDangNhap.TabIndex = 7;
            // 
            // txtMatKhau
            // 
            txtMatKhau.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtMatKhau.Location = new Point(367, 192);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.PasswordChar = '*';
            txtMatKhau.Size = new Size(460, 39);
            txtMatKhau.TabIndex = 8;
            txtMatKhau.TextChanged += txtMatKhau_TextChanged;
            // 
            // txtMatKhauMoi
            // 
            txtMatKhauMoi.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtMatKhauMoi.Location = new Point(367, 253);
            txtMatKhauMoi.Name = "txtMatKhauMoi";
            txtMatKhauMoi.PasswordChar = '*';
            txtMatKhauMoi.Size = new Size(460, 39);
            txtMatKhauMoi.TabIndex = 9;
            txtMatKhauMoi.TextChanged += txtMatKhauMoi_TextChanged;
            // 
            // txtXacNhanMatKhau
            // 
            txtXacNhanMatKhau.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtXacNhanMatKhau.Location = new Point(367, 310);
            txtXacNhanMatKhau.Name = "txtXacNhanMatKhau";
            txtXacNhanMatKhau.PasswordChar = '*';
            txtXacNhanMatKhau.Size = new Size(460, 39);
            txtXacNhanMatKhau.TabIndex = 10;
            txtXacNhanMatKhau.TextChanged += txtXacNhanMatKhau_TextChanged;
            // 
            // errorProvider
            // 
            errorProvider.ContainerControl = this;
            // 
            // frmThayDoiThongTin
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(906, 490);
            Controls.Add(txtXacNhanMatKhau);
            Controls.Add(txtMatKhauMoi);
            Controls.Add(txtMatKhau);
            Controls.Add(txtTenDangNhap);
            Controls.Add(btnThoat);
            Controls.Add(btnThayDoi);
            Controls.Add(lblXacNhanMatKhauMoi);
            Controls.Add(lblMatKhauMoi);
            Controls.Add(lblMatKhau);
            Controls.Add(lblTenDangNhap);
            Controls.Add(lblTitle);
            Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "frmThayDoiThongTin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Thay Đổi Thông Tin";
            Load += frmThayDoiThongTin_Load;
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblTenDangNhap;
        private Label lblMatKhau;
        private Label lblMatKhauMoi;
        private Label lblXacNhanMatKhauMoi;
        private Button btnThayDoi;
        private Button btnThoat;
        private TextBox txtTenDangNhap;
        private TextBox txtMatKhau;
        private TextBox txtMatKhauMoi;
        private TextBox txtXacNhanMatKhau;
        private ErrorProvider errorProvider;
    }
}