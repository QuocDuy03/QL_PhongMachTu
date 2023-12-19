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
            label1.Name = "label1";
            label1.Size = new Size(1032, 37);
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
            groupBox1.Location = new Point(10, 39);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(885, 175);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Nhập Thông Tin";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // cboLoaiBenh
            // 
            cboLoaiBenh.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cboLoaiBenh.FormattingEnabled = true;
            cboLoaiBenh.Location = new Point(414, 132);
            cboLoaiBenh.Margin = new Padding(3, 2, 3, 2);
            cboLoaiBenh.Name = "cboLoaiBenh";
            cboLoaiBenh.Size = new Size(204, 29);
            cboLoaiBenh.TabIndex = 16;
            // 
            // dtpNgayKham
            // 
            dtpNgayKham.CustomFormat = "dd/MM/yyyy";
            dtpNgayKham.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dtpNgayKham.Format = DateTimePickerFormat.Custom;
            dtpNgayKham.Location = new Point(246, 132);
            dtpNgayKham.Margin = new Padding(3, 2, 3, 2);
            dtpNgayKham.Name = "dtpNgayKham";
            dtpNgayKham.Size = new Size(136, 29);
            dtpNgayKham.TabIndex = 15;
            // 
            // txtTrieuChung
            // 
            txtTrieuChung.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtTrieuChung.Location = new Point(644, 132);
            txtTrieuChung.Margin = new Padding(3, 2, 3, 2);
            txtTrieuChung.Name = "txtTrieuChung";
            txtTrieuChung.Size = new Size(204, 29);
            txtTrieuChung.TabIndex = 14;
            // 
            // txtMaBenhNhan
            // 
            txtMaBenhNhan.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtMaBenhNhan.Location = new Point(17, 132);
            txtMaBenhNhan.Margin = new Padding(3, 2, 3, 2);
            txtMaBenhNhan.Name = "txtMaBenhNhan";
            txtMaBenhNhan.Size = new Size(204, 29);
            txtMaBenhNhan.TabIndex = 12;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(644, 99);
            label9.Name = "label9";
            label9.Size = new Size(98, 21);
            label9.TabIndex = 11;
            label9.Text = "Triệu Chứng";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(413, 99);
            label8.Name = "label8";
            label8.Size = new Size(81, 21);
            label8.TabIndex = 10;
            label8.Text = "Loại Bệnh";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(251, 99);
            label7.Name = "label7";
            label7.Size = new Size(93, 21);
            label7.TabIndex = 9;
            label7.Text = "Ngày Khám";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(20, 99);
            label6.Name = "label6";
            label6.Size = new Size(116, 21);
            label6.TabIndex = 8;
            label6.Text = "Mã Bệnh Nhân";
            // 
            // txtDiaChi
            // 
            txtDiaChi.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtDiaChi.Location = new Point(644, 51);
            txtDiaChi.Margin = new Padding(3, 2, 3, 2);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(204, 29);
            txtDiaChi.TabIndex = 7;
            // 
            // txtNamSinh
            // 
            txtNamSinh.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtNamSinh.Location = new Point(414, 52);
            txtNamSinh.Margin = new Padding(3, 2, 3, 2);
            txtNamSinh.Name = "txtNamSinh";
            txtNamSinh.Size = new Size(204, 29);
            txtNamSinh.TabIndex = 6;
            // 
            // txtHoTen
            // 
            txtHoTen.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtHoTen.Location = new Point(20, 51);
            txtHoTen.Margin = new Padding(3, 2, 3, 2);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(204, 29);
            txtHoTen.TabIndex = 5;
            // 
            // cboGioiTinh
            // 
            cboGioiTinh.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cboGioiTinh.FormattingEnabled = true;
            cboGioiTinh.Items.AddRange(new object[] { "Nam", "Nu" });
            cboGioiTinh.Location = new Point(251, 51);
            cboGioiTinh.Margin = new Padding(3, 2, 3, 2);
            cboGioiTinh.Name = "cboGioiTinh";
            cboGioiTinh.Size = new Size(133, 29);
            cboGioiTinh.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(644, 21);
            label5.Name = "label5";
            label5.Size = new Size(60, 21);
            label5.TabIndex = 3;
            label5.Text = "Địa Chỉ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(246, 21);
            label4.Name = "label4";
            label4.Size = new Size(74, 21);
            label4.TabIndex = 2;
            label4.Text = "Giới Tính";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(414, 21);
            label3.Name = "label3";
            label3.Size = new Size(79, 21);
            label3.TabIndex = 1;
            label3.Text = "Năm Sinh";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(17, 21);
            label2.Name = "label2";
            label2.Size = new Size(82, 21);
            label2.TabIndex = 0;
            label2.Text = "Họ Và Tên";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dtvTraCuuBN);
            groupBox2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox2.Location = new Point(10, 218);
            groupBox2.Margin = new Padding(3, 2, 3, 2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 2, 3, 2);
            groupBox2.Size = new Size(1012, 275);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Kết Quả Tìm Kiếm";
            // 
            // dtvTraCuuBN
            // 
            dtvTraCuuBN.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtvTraCuuBN.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtvTraCuuBN.Dock = DockStyle.Fill;
            dtvTraCuuBN.Location = new Point(3, 21);
            dtvTraCuuBN.Margin = new Padding(3, 2, 3, 2);
            dtvTraCuuBN.Name = "dtvTraCuuBN";
            dtvTraCuuBN.ReadOnly = true;
            dtvTraCuuBN.RowHeadersWidth = 51;
            dtvTraCuuBN.RowTemplate.Height = 29;
            dtvTraCuuBN.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtvTraCuuBN.Size = new Size(1006, 252);
            dtvTraCuuBN.TabIndex = 0;
            // 
            // btnTraCuu
            // 
            btnTraCuu.BackColor = Color.Teal;
            btnTraCuu.Cursor = Cursors.Hand;
            btnTraCuu.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            btnTraCuu.ForeColor = Color.White;
            btnTraCuu.Location = new Point(918, 90);
            btnTraCuu.Margin = new Padding(3, 2, 3, 2);
            btnTraCuu.Name = "btnTraCuu";
            btnTraCuu.Size = new Size(102, 43);
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
            btnReset.Location = new Point(918, 154);
            btnReset.Margin = new Padding(3, 2, 3, 2);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(102, 43);
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
            btnThemBenhNhan.Location = new Point(134, 511);
            btnThemBenhNhan.Margin = new Padding(3, 2, 3, 2);
            btnThemBenhNhan.Name = "btnThemBenhNhan";
            btnThemBenhNhan.Size = new Size(206, 38);
            btnThemBenhNhan.TabIndex = 5;
            btnThemBenhNhan.Text = "Thêm Bệnh Nhân";
            btnThemBenhNhan.UseVisualStyleBackColor = false;
            btnThemBenhNhan.Click += btnThemBenhNhan_Click;
            // 
            // btnLapPhieuKham
            // 
            btnLapPhieuKham.BackColor = Color.Teal;
            btnLapPhieuKham.Cursor = Cursors.Hand;
            btnLapPhieuKham.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnLapPhieuKham.ForeColor = Color.White;
            btnLapPhieuKham.Location = new Point(414, 511);
            btnLapPhieuKham.Margin = new Padding(3, 2, 3, 2);
            btnLapPhieuKham.Name = "btnLapPhieuKham";
            btnLapPhieuKham.Size = new Size(206, 38);
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
            btnThoat.Location = new Point(699, 511);
            btnThoat.Margin = new Padding(3, 2, 3, 2);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(206, 38);
            btnThoat.TabIndex = 7;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = false;
            btnThoat.Click += btnThoat_Click;
            // 
            // frmTraCuuBenhNhan
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(1032, 565);
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
            Margin = new Padding(3, 2, 3, 2);
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