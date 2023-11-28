namespace QL_PhongMachTu
{
    partial class frmTraCuuBenhNhan
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
            label1 = new Label();
            groupBox1 = new GroupBox();
            cboLoaiBenh = new ComboBox();
            dtpNgayKham = new DateTimePicker();
            txtTrieuChung = new TextBox();
            txtMaBenhNhan = new TextBox();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            txtDiaChi = new TextBox();
            txtNamSinh = new TextBox();
            txtHoTen = new TextBox();
            cboGioiTinh = new ComboBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            groupBox2 = new GroupBox();
            dtvTraCuuBN = new DataGridView();
            btnTraCuu = new Button();
            btnReset = new Button();
            btnThemBenhNhan = new Button();
            btnLapPhieuKham = new Button();
            btnThoat = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtvTraCuuBN).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = Color.Teal;
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Segoe UI", 17F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(0, 0);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(1475, 61);
            label1.TabIndex = 0;
            label1.Text = "Tra Cứu Bệnh Nhân";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cboLoaiBenh);
            groupBox1.Controls.Add(dtpNgayKham);
            groupBox1.Controls.Add(txtTrieuChung);
            groupBox1.Controls.Add(txtMaBenhNhan);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(txtDiaChi);
            groupBox1.Controls.Add(txtNamSinh);
            groupBox1.Controls.Add(txtHoTen);
            groupBox1.Controls.Add(cboGioiTinh);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(15, 65);
            groupBox1.Margin = new Padding(4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4);
            groupBox1.Size = new Size(1264, 291);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Nhập Thông Tin";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // cboLoaiBenh
            // 
            cboLoaiBenh.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cboLoaiBenh.FormattingEnabled = true;
            cboLoaiBenh.Location = new Point(591, 220);
            cboLoaiBenh.Margin = new Padding(4);
            cboLoaiBenh.Name = "cboLoaiBenh";
            cboLoaiBenh.Size = new Size(289, 40);
            cboLoaiBenh.TabIndex = 16;
            // 
            // dtpNgayKham
            // 
            dtpNgayKham.CustomFormat = "dd/MM/yyyy";
            dtpNgayKham.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dtpNgayKham.Format = DateTimePickerFormat.Custom;
            dtpNgayKham.Location = new Point(352, 220);
            dtpNgayKham.Margin = new Padding(4);
            dtpNgayKham.Name = "dtpNgayKham";
            dtpNgayKham.Size = new Size(193, 39);
            dtpNgayKham.TabIndex = 15;
            // 
            // txtTrieuChung
            // 
            txtTrieuChung.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtTrieuChung.Location = new Point(920, 220);
            txtTrieuChung.Margin = new Padding(4);
            txtTrieuChung.Name = "txtTrieuChung";
            txtTrieuChung.Size = new Size(289, 39);
            txtTrieuChung.TabIndex = 14;
            // 
            // txtMaBenhNhan
            // 
            txtMaBenhNhan.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtMaBenhNhan.Location = new Point(24, 220);
            txtMaBenhNhan.Margin = new Padding(4);
            txtMaBenhNhan.Name = "txtMaBenhNhan";
            txtMaBenhNhan.Size = new Size(289, 39);
            txtMaBenhNhan.TabIndex = 12;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(920, 165);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(146, 32);
            label9.TabIndex = 11;
            label9.Text = "Triệu Chứng";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(590, 165);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(122, 32);
            label8.TabIndex = 10;
            label8.Text = "Loại Bệnh";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(358, 165);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(141, 32);
            label7.TabIndex = 9;
            label7.Text = "Ngày Khám";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(28, 165);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(178, 32);
            label6.TabIndex = 8;
            label6.Text = "Mã Bệnh Nhân";
            // 
            // txtDiaChi
            // 
            txtDiaChi.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtDiaChi.Location = new Point(920, 85);
            txtDiaChi.Margin = new Padding(4);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(289, 39);
            txtDiaChi.TabIndex = 7;
            // 
            // txtNamSinh
            // 
            txtNamSinh.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtNamSinh.Location = new Point(591, 86);
            txtNamSinh.Margin = new Padding(4);
            txtNamSinh.Name = "txtNamSinh";
            txtNamSinh.Size = new Size(289, 39);
            txtNamSinh.TabIndex = 6;
            // 
            // txtHoTen
            // 
            txtHoTen.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtHoTen.Location = new Point(28, 85);
            txtHoTen.Margin = new Padding(4);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(289, 39);
            txtHoTen.TabIndex = 5;
            // 
            // cboGioiTinh
            // 
            cboGioiTinh.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cboGioiTinh.FormattingEnabled = true;
            cboGioiTinh.Items.AddRange(new object[] { "Nam", "Nu" });
            cboGioiTinh.Location = new Point(358, 85);
            cboGioiTinh.Margin = new Padding(4);
            cboGioiTinh.Name = "cboGioiTinh";
            cboGioiTinh.Size = new Size(188, 40);
            cboGioiTinh.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(920, 35);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(92, 32);
            label5.TabIndex = 3;
            label5.Text = "Địa Chỉ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(352, 35);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(112, 32);
            label4.TabIndex = 2;
            label4.Text = "Giới Tính";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(591, 35);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(120, 32);
            label3.TabIndex = 1;
            label3.Text = "Năm Sinh";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(24, 35);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(124, 32);
            label2.TabIndex = 0;
            label2.Text = "Họ Và Tên";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dtvTraCuuBN);
            groupBox2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox2.Location = new Point(15, 364);
            groupBox2.Margin = new Padding(4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(4);
            groupBox2.Size = new Size(1445, 459);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Kết Quả Tìm Kiếm";
            // 
            // dtvTraCuuBN
            // 
            dtvTraCuuBN.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtvTraCuuBN.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtvTraCuuBN.Dock = DockStyle.Fill;
            dtvTraCuuBN.Location = new Point(4, 32);
            dtvTraCuuBN.Margin = new Padding(4);
            dtvTraCuuBN.Name = "dtvTraCuuBN";
            dtvTraCuuBN.ReadOnly = true;
            dtvTraCuuBN.RowHeadersWidth = 51;
            dtvTraCuuBN.RowTemplate.Height = 29;
            dtvTraCuuBN.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtvTraCuuBN.Size = new Size(1437, 423);
            dtvTraCuuBN.TabIndex = 0;
            // 
            // btnTraCuu
            // 
            btnTraCuu.BackColor = Color.Teal;
            btnTraCuu.Cursor = Cursors.Hand;
            btnTraCuu.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            btnTraCuu.ForeColor = Color.White;
            btnTraCuu.Location = new Point(1311, 150);
            btnTraCuu.Margin = new Padding(4);
            btnTraCuu.Name = "btnTraCuu";
            btnTraCuu.Size = new Size(145, 71);
            btnTraCuu.TabIndex = 3;
            btnTraCuu.Text = "Tra Cứu";
            btnTraCuu.UseVisualStyleBackColor = false;
            btnTraCuu.Click += button1_Click;
            // 
            // btnReset
            // 
            btnReset.BackColor = Color.Teal;
            btnReset.Cursor = Cursors.Hand;
            btnReset.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            btnReset.ForeColor = Color.White;
            btnReset.Location = new Point(1311, 256);
            btnReset.Margin = new Padding(4);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(145, 71);
            btnReset.TabIndex = 4;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = false;
            btnReset.Click += btnReset_Click;
            // 
            // btnThemBenhNhan
            // 
            btnThemBenhNhan.BackColor = Color.Teal;
            btnThemBenhNhan.Cursor = Cursors.Hand;
            btnThemBenhNhan.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnThemBenhNhan.ForeColor = Color.White;
            btnThemBenhNhan.Location = new Point(191, 852);
            btnThemBenhNhan.Margin = new Padding(4);
            btnThemBenhNhan.Name = "btnThemBenhNhan";
            btnThemBenhNhan.Size = new Size(294, 64);
            btnThemBenhNhan.TabIndex = 5;
            btnThemBenhNhan.Text = "Thêm Bệnh Nhân";
            btnThemBenhNhan.UseVisualStyleBackColor = false;
            btnThemBenhNhan.Click += btnThemBenhNhan_Click;
            // 
            // btnLapPhieuKham
            // 
            btnLapPhieuKham.BackColor =Color.Teal;
            btnLapPhieuKham.Cursor = Cursors.Hand;
            btnLapPhieuKham.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnLapPhieuKham.ForeColor = Color.White;
            btnLapPhieuKham.Location = new Point(592, 852);
            btnLapPhieuKham.Margin = new Padding(4);
            btnLapPhieuKham.Name = "btnLapPhieuKham";
            btnLapPhieuKham.Size = new Size(294, 64);
            btnLapPhieuKham.TabIndex = 6;
            btnLapPhieuKham.Text = "Lập Phiếu Khám Bệnh";
            btnLapPhieuKham.UseVisualStyleBackColor = false;
            btnLapPhieuKham.Click += btnLapPhieuKham_Click;
            // 
            // btnThoat
            // 
            btnThoat.BackColor = Color.Teal;
            btnThoat.Cursor = Cursors.Hand;
            btnThoat.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnThoat.ForeColor = Color.White;
            btnThoat.Location = new Point(998, 852);
            btnThoat.Margin = new Padding(4);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(294, 64);
            btnThoat.TabIndex = 7;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = false;
            btnThoat.Click += btnThoat_Click;
            // 
            // frmTraCuuBenhNhan
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1475, 941);
            ControlBox = false;
            Controls.Add(btnThoat);
            Controls.Add(btnLapPhieuKham);
            Controls.Add(btnThemBenhNhan);
            Controls.Add(btnReset);
            Controls.Add(btnTraCuu);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4);
            MaximizeBox = false;
            Name = "frmTraCuuBenhNhan";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Tra Cứu Bệnh Nhân";
            Load += frmTraCuuBenhNhan_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtvTraCuuBN).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private GroupBox groupBox2;
        private TextBox txtDiaChi;
        private TextBox txtNamSinh;
        private TextBox txtHoTen;
        private ComboBox cboGioiTinh;
        private DataGridView dtvTraCuuBN;
        private Button btnTraCuu;
        private Button btnReset;
        private Button btnThemBenhNhan;
        private Button btnLapPhieuKham;
        private Button btnThoat;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label9;
        private TextBox txtMaBenhNhan;
        private ComboBox cboLoaiBenh;
        private DateTimePicker dtpNgayKham;
        private TextBox txtTrieuChung;
    }
}