namespace QL_PhongMachTu
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
            lblTitle = new Label();
            lblHoTen = new Label();
            lblNgayKham = new Label();
            lblTienKham = new Label();
            lblTienThuoc = new Label();
            grbDonThuoc = new GroupBox();
            dgvDonThuoc = new DataGridView();
            lblTongTien = new Label();
            lblHienTongTien = new Label();
            btnThanhToan = new Button();
            btnDong = new Button();
            lblMaHoaDon = new Label();
            lblMaPhieuKham = new Label();
            txtMaHoaDon = new TextBox();
            txtMaPhieuKham = new TextBox();
            txtHoTen = new TextBox();
            txtNgayKham = new TextBox();
            txtTienKham = new TextBox();
            txtTienThuoc = new TextBox();
            grbDonThuoc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDonThuoc).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.Dock = DockStyle.Top;
            lblTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitle.Location = new Point(0, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(651, 40);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Thông Tin Hóa Đơn";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblHoTen
            // 
            lblHoTen.AutoSize = true;
            lblHoTen.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblHoTen.Location = new Point(14, 108);
            lblHoTen.Name = "lblHoTen";
            lblHoTen.Size = new Size(71, 19);
            lblHoTen.TabIndex = 1;
            lblHoTen.Text = "Họ và Tên";
            // 
            // lblNgayKham
            // 
            lblNgayKham.AutoSize = true;
            lblNgayKham.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblNgayKham.Location = new Point(337, 108);
            lblNgayKham.Name = "lblNgayKham";
            lblNgayKham.Size = new Size(82, 19);
            lblNgayKham.TabIndex = 2;
            lblNgayKham.Text = "Ngày Khám";
            // 
            // lblTienKham
            // 
            lblTienKham.AutoSize = true;
            lblTienKham.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblTienKham.Location = new Point(14, 151);
            lblTienKham.Name = "lblTienKham";
            lblTienKham.Size = new Size(76, 19);
            lblTienKham.TabIndex = 3;
            lblTienKham.Text = "Tiền Khám";
            // 
            // lblTienThuoc
            // 
            lblTienThuoc.AutoSize = true;
            lblTienThuoc.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblTienThuoc.Location = new Point(337, 151);
            lblTienThuoc.Name = "lblTienThuoc";
            lblTienThuoc.Size = new Size(79, 19);
            lblTienThuoc.TabIndex = 4;
            lblTienThuoc.Text = "Tiền Thuốc";
            // 
            // grbDonThuoc
            // 
            grbDonThuoc.Controls.Add(dgvDonThuoc);
            grbDonThuoc.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            grbDonThuoc.Location = new Point(11, 178);
            grbDonThuoc.Margin = new Padding(3, 2, 3, 2);
            grbDonThuoc.Name = "grbDonThuoc";
            grbDonThuoc.Padding = new Padding(3, 2, 3, 2);
            grbDonThuoc.Size = new Size(629, 206);
            grbDonThuoc.TabIndex = 5;
            grbDonThuoc.TabStop = false;
            grbDonThuoc.Text = "Đơn Thuốc";
            // 
            // dgvDonThuoc
            // 
            dgvDonThuoc.AllowUserToAddRows = false;
            dgvDonThuoc.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDonThuoc.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDonThuoc.Dock = DockStyle.Fill;
            dgvDonThuoc.Location = new Point(3, 21);
            dgvDonThuoc.Margin = new Padding(3, 2, 3, 2);
            dgvDonThuoc.Name = "dgvDonThuoc";
            dgvDonThuoc.ReadOnly = true;
            dgvDonThuoc.RowHeadersWidth = 51;
            dgvDonThuoc.RowTemplate.Height = 29;
            dgvDonThuoc.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDonThuoc.Size = new Size(623, 183);
            dgvDonThuoc.TabIndex = 0;
            // 
            // lblTongTien
            // 
            lblTongTien.AutoSize = true;
            lblTongTien.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblTongTien.Location = new Point(243, 394);
            lblTongTien.Name = "lblTongTien";
            lblTongTien.Size = new Size(118, 30);
            lblTongTien.TabIndex = 6;
            lblTongTien.Text = "Tổng Tiền:";
            // 
            // lblHienTongTien
            // 
            lblHienTongTien.AutoSize = true;
            lblHienTongTien.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblHienTongTien.Location = new Point(368, 394);
            lblHienTongTien.Name = "lblHienTongTien";
            lblHienTongTien.Size = new Size(0, 30);
            lblHienTongTien.TabIndex = 7;
            // 
            // btnThanhToan
            // 
            btnThanhToan.BackColor = Color.Teal;
            btnThanhToan.Cursor = Cursors.Hand;
            btnThanhToan.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnThanhToan.ForeColor = Color.White;
            btnThanhToan.Location = new Point(79, 430);
            btnThanhToan.Margin = new Padding(3, 2, 3, 2);
            btnThanhToan.Name = "btnThanhToan";
            btnThanhToan.Size = new Size(224, 35);
            btnThanhToan.TabIndex = 8;
            btnThanhToan.Text = "Thanh Toán";
            btnThanhToan.UseVisualStyleBackColor = false;
            btnThanhToan.Click += btnThanhToan_Click;
            // 
            // btnDong
            // 
            btnDong.BackColor = Color.Teal;
            btnDong.Cursor = Cursors.Hand;
            btnDong.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnDong.ForeColor = Color.White;
            btnDong.Location = new Point(344, 430);
            btnDong.Margin = new Padding(3, 2, 3, 2);
            btnDong.Name = "btnDong";
            btnDong.Size = new Size(224, 35);
            btnDong.TabIndex = 9;
            btnDong.Text = "Đóng";
            btnDong.UseVisualStyleBackColor = false;
            btnDong.Click += btnDong_Click;
            // 
            // lblMaHoaDon
            // 
            lblMaHoaDon.AutoSize = true;
            lblMaHoaDon.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblMaHoaDon.Location = new Point(14, 65);
            lblMaHoaDon.Name = "lblMaHoaDon";
            lblMaHoaDon.Size = new Size(89, 19);
            lblMaHoaDon.TabIndex = 10;
            lblMaHoaDon.Text = "Mã Hóa Đơn";
            // 
            // lblMaPhieuKham
            // 
            lblMaPhieuKham.AutoSize = true;
            lblMaPhieuKham.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblMaPhieuKham.Location = new Point(337, 65);
            lblMaPhieuKham.Name = "lblMaPhieuKham";
            lblMaPhieuKham.Size = new Size(108, 19);
            lblMaPhieuKham.TabIndex = 11;
            lblMaPhieuKham.Text = "Mã Phiếu Khám";
            // 
            // txtMaHoaDon
            // 
            txtMaHoaDon.BackColor = SystemColors.ActiveCaption;
            txtMaHoaDon.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtMaHoaDon.Location = new Point(117, 59);
            txtMaHoaDon.Margin = new Padding(3, 2, 3, 2);
            txtMaHoaDon.Name = "txtMaHoaDon";
            txtMaHoaDon.ReadOnly = true;
            txtMaHoaDon.Size = new Size(182, 29);
            txtMaHoaDon.TabIndex = 12;
            // 
            // txtMaPhieuKham
            // 
            txtMaPhieuKham.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtMaPhieuKham.Location = new Point(458, 59);
            txtMaPhieuKham.Margin = new Padding(3, 2, 3, 2);
            txtMaPhieuKham.Name = "txtMaPhieuKham";
            txtMaPhieuKham.ReadOnly = true;
            txtMaPhieuKham.Size = new Size(182, 29);
            txtMaPhieuKham.TabIndex = 13;
            // 
            // txtHoTen
            // 
            txtHoTen.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtHoTen.Location = new Point(117, 105);
            txtHoTen.Margin = new Padding(3, 2, 3, 2);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.ReadOnly = true;
            txtHoTen.Size = new Size(182, 29);
            txtHoTen.TabIndex = 14;
            // 
            // txtNgayKham
            // 
            txtNgayKham.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtNgayKham.Location = new Point(458, 105);
            txtNgayKham.Margin = new Padding(3, 2, 3, 2);
            txtNgayKham.Name = "txtNgayKham";
            txtNgayKham.ReadOnly = true;
            txtNgayKham.Size = new Size(182, 29);
            txtNgayKham.TabIndex = 15;
            // 
            // txtTienKham
            // 
            txtTienKham.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtTienKham.Location = new Point(117, 148);
            txtTienKham.Margin = new Padding(3, 2, 3, 2);
            txtTienKham.Name = "txtTienKham";
            txtTienKham.ReadOnly = true;
            txtTienKham.Size = new Size(182, 29);
            txtTienKham.TabIndex = 16;
            // 
            // txtTienThuoc
            // 
            txtTienThuoc.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtTienThuoc.Location = new Point(458, 148);
            txtTienThuoc.Margin = new Padding(3, 2, 3, 2);
            txtTienThuoc.Name = "txtTienThuoc";
            txtTienThuoc.ReadOnly = true;
            txtTienThuoc.Size = new Size(182, 29);
            txtTienThuoc.TabIndex = 17;
            // 
            // frmHoaDon
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.White;
            ClientSize = new Size(651, 475);
            ControlBox = false;
            Controls.Add(txtTienThuoc);
            Controls.Add(txtTienKham);
            Controls.Add(txtNgayKham);
            Controls.Add(txtHoTen);
            Controls.Add(txtMaPhieuKham);
            Controls.Add(txtMaHoaDon);
            Controls.Add(lblMaPhieuKham);
            Controls.Add(lblMaHoaDon);
            Controls.Add(btnDong);
            Controls.Add(btnThanhToan);
            Controls.Add(lblHienTongTien);
            Controls.Add(lblTongTien);
            Controls.Add(grbDonThuoc);
            Controls.Add(lblTienThuoc);
            Controls.Add(lblTienKham);
            Controls.Add(lblNgayKham);
            Controls.Add(lblHoTen);
            Controls.Add(lblTitle);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            Name = "frmHoaDon";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Thông Tin Hóa Đơn";
            grbDonThuoc.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvDonThuoc).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblHoTen;
        private Label lblNgayKham;
        private Label lblTienKham;
        private Label lblTienThuoc;
        private GroupBox grbDonThuoc;
        private Label lblTongTien;
        private Label lblHienTongTien;
        private Button btnThanhToan;
        private Button btnDong;
        private Label lblMaHoaDon;
        private Label lblMaPhieuKham;
        private TextBox txtMaHoaDon;
        private TextBox txtMaPhieuKham;
        private TextBox txtHoTen;
        private TextBox txtNgayKham;
        private TextBox txtTienKham;
        private TextBox txtTienThuoc;
        private DataGridView dgvDonThuoc;
    }
}