namespace QL_PhongMachTu
{
    partial class frmLapHoaDon
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
            grbDanhSachPhieuKham = new GroupBox();
            dgvDanhSachPhieuKham = new DataGridView();
            lblNgayLap = new Label();
            dtpNgayLap = new DateTimePicker();
            btnXemHoaDon = new Button();
            btnThoat = new Button();
            grbDanhSachPhieuKham.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDanhSachPhieuKham).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.BackColor = Color.Teal;
            lblTitle.Dock = DockStyle.Top;
            lblTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(0, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(758, 50);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Lập Hóa Đơn Thanh Toán";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // grbDanhSachPhieuKham
            // 
            grbDanhSachPhieuKham.Controls.Add(dgvDanhSachPhieuKham);
            grbDanhSachPhieuKham.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            grbDanhSachPhieuKham.Location = new Point(10, 105);
            grbDanhSachPhieuKham.Margin = new Padding(3, 2, 3, 2);
            grbDanhSachPhieuKham.Name = "grbDanhSachPhieuKham";
            grbDanhSachPhieuKham.Padding = new Padding(3, 2, 3, 2);
            grbDanhSachPhieuKham.Size = new Size(740, 229);
            grbDanhSachPhieuKham.TabIndex = 2;
            grbDanhSachPhieuKham.TabStop = false;
            grbDanhSachPhieuKham.Text = "Danh Sách Phiếu Khám Trong Ngày";
            // 
            // dgvDanhSachPhieuKham
            // 
            dgvDanhSachPhieuKham.AllowUserToAddRows = false;
            dgvDanhSachPhieuKham.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDanhSachPhieuKham.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDanhSachPhieuKham.Dock = DockStyle.Fill;
            dgvDanhSachPhieuKham.Location = new Point(3, 21);
            dgvDanhSachPhieuKham.Margin = new Padding(3, 2, 3, 2);
            dgvDanhSachPhieuKham.Name = "dgvDanhSachPhieuKham";
            dgvDanhSachPhieuKham.ReadOnly = true;
            dgvDanhSachPhieuKham.RowHeadersWidth = 51;
            dgvDanhSachPhieuKham.RowTemplate.Height = 29;
            dgvDanhSachPhieuKham.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDanhSachPhieuKham.Size = new Size(734, 206);
            dgvDanhSachPhieuKham.TabIndex = 0;
            // 
            // lblNgayLap
            // 
            lblNgayLap.AutoSize = true;
            lblNgayLap.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblNgayLap.Location = new Point(240, 68);
            lblNgayLap.Name = "lblNgayLap";
            lblNgayLap.Size = new Size(82, 21);
            lblNgayLap.TabIndex = 3;
            lblNgayLap.Text = "Ngày Lập";
            // 
            // dtpNgayLap
            // 
            dtpNgayLap.CalendarFont = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dtpNgayLap.CustomFormat = "dd/MM/yyyy";
            dtpNgayLap.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dtpNgayLap.Format = DateTimePickerFormat.Custom;
            dtpNgayLap.Location = new Point(333, 66);
            dtpNgayLap.Margin = new Padding(3, 2, 3, 2);
            dtpNgayLap.Name = "dtpNgayLap";
            dtpNgayLap.Size = new Size(219, 29);
            dtpNgayLap.TabIndex = 4;
            dtpNgayLap.ValueChanged += dtpNgayLap_ValueChanged;
            // 
            // btnXemHoaDon
            // 
            btnXemHoaDon.BackColor = Color.Teal;
            btnXemHoaDon.Cursor = Cursors.Hand;
            btnXemHoaDon.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnXemHoaDon.ForeColor = Color.White;
            btnXemHoaDon.Location = new Point(61, 350);
            btnXemHoaDon.Margin = new Padding(3, 2, 3, 2);
            btnXemHoaDon.Name = "btnXemHoaDon";
            btnXemHoaDon.Size = new Size(284, 39);
            btnXemHoaDon.TabIndex = 5;
            btnXemHoaDon.Text = "Xem Hóa Đơn";
            btnXemHoaDon.UseVisualStyleBackColor = false;
            btnXemHoaDon.Click += btnXemHoaDon_Click;
            // 
            // btnThoat
            // 
            btnThoat.BackColor = Color.Teal;
            btnThoat.Cursor = Cursors.Hand;
            btnThoat.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnThoat.ForeColor = Color.White;
            btnThoat.Location = new Point(402, 350);
            btnThoat.Margin = new Padding(3, 2, 3, 2);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(284, 39);
            btnThoat.TabIndex = 6;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = false;
            btnThoat.Click += btnThoat_Click;
            // 
            // frmLapHoaDon
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(758, 404);
            ControlBox = false;
            Controls.Add(btnThoat);
            Controls.Add(btnXemHoaDon);
            Controls.Add(dtpNgayLap);
            Controls.Add(lblNgayLap);
            Controls.Add(grbDanhSachPhieuKham);
            Controls.Add(lblTitle);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            Name = "frmLapHoaDon";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Lập Hóa Đơn Thanh Toán";
            Load += frmLapHoaDon_Load;
            grbDanhSachPhieuKham.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvDanhSachPhieuKham).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private GroupBox grbDanhSachPhieuKham;
        private Label lblNgayLap;
        private DateTimePicker dtpNgayLap;
        private DataGridView dgvDanhSachPhieuKham;
        private Button btnXemHoaDon;
        private Button btnThoat;
    }
}