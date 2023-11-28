namespace QL_PhongMachTu
{
    partial class frmThemTTBenhNhan
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
            label1 = new Label();
            btnThem = new Button();
            btnXoa = new Button();
            btnSua = new Button();
            btnThoat = new Button();
            btnLapPhieuKham = new Button();
            grbThongTinBenhNhan = new GroupBox();
            txtNamSinh = new TextBox();
            chkNu = new CheckBox();
            chkNam = new CheckBox();
            txtDiaChi = new TextBox();
            txtTenBenhNhan = new TextBox();
            txtMaBenhNhan = new TextBox();
            label7 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            grbDanhSachBenhNhan = new GroupBox();
            dgvDanhSachBenhNhan = new DataGridView();
            btnReset = new Button();
            errorProvider = new ErrorProvider(components);
            grbThongTinBenhNhan.SuspendLayout();
            grbDanhSachBenhNhan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDanhSachBenhNhan).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = Color.Teal;
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(0, 0);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(1316, 51);
            label1.TabIndex = 0;
            label1.Text = "Thông Tin Bệnh Nhân";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // btnThem
            // 
            btnThem.BackColor = Color.Teal;
            btnThem.Cursor = Cursors.Hand;
            btnThem.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnThem.ForeColor = Color.White;
            btnThem.Location = new Point(791, 418);
            btnThem.Margin = new Padding(4);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(210, 100);
            btnThem.TabIndex = 1;
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
            btnXoa.Location = new Point(1051, 418);
            btnXoa.Margin = new Padding(4);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(210, 101);
            btnXoa.TabIndex = 2;
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
            btnSua.Location = new Point(791, 554);
            btnSua.Margin = new Padding(4);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(210, 100);
            btnSua.TabIndex = 3;
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
            btnThoat.Location = new Point(1051, 554);
            btnThoat.Margin = new Padding(4);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(210, 100);
            btnThoat.TabIndex = 4;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = false;
            btnThoat.Click += btnThoat_Click_1;
            // 
            // btnLapPhieuKham
            // 
            btnLapPhieuKham.BackColor = Color.Teal;
            btnLapPhieuKham.Cursor = Cursors.Hand;
            btnLapPhieuKham.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnLapPhieuKham.ForeColor = Color.White;
            btnLapPhieuKham.Location = new Point(1051, 690);
            btnLapPhieuKham.Margin = new Padding(4);
            btnLapPhieuKham.Name = "btnLapPhieuKham";
            btnLapPhieuKham.Size = new Size(210, 100);
            btnLapPhieuKham.TabIndex = 5;
            btnLapPhieuKham.Text = "Lập Phiếu Khám Bệnh";
            btnLapPhieuKham.UseVisualStyleBackColor = false;
            btnLapPhieuKham.Click += btnLapPhieuKham_Click;
            // 
            // grbThongTinBenhNhan
            // 
            grbThongTinBenhNhan.Controls.Add(txtNamSinh);
            grbThongTinBenhNhan.Controls.Add(chkNu);
            grbThongTinBenhNhan.Controls.Add(chkNam);
            grbThongTinBenhNhan.Controls.Add(txtDiaChi);
            grbThongTinBenhNhan.Controls.Add(txtTenBenhNhan);
            grbThongTinBenhNhan.Controls.Add(txtMaBenhNhan);
            grbThongTinBenhNhan.Controls.Add(label7);
            grbThongTinBenhNhan.Controls.Add(label5);
            grbThongTinBenhNhan.Controls.Add(label4);
            grbThongTinBenhNhan.Controls.Add(label3);
            grbThongTinBenhNhan.Controls.Add(label2);
            grbThongTinBenhNhan.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            grbThongTinBenhNhan.Location = new Point(21, 61);
            grbThongTinBenhNhan.Margin = new Padding(4);
            grbThongTinBenhNhan.Name = "grbThongTinBenhNhan";
            grbThongTinBenhNhan.Padding = new Padding(4);
            grbThongTinBenhNhan.Size = new Size(1280, 224);
            grbThongTinBenhNhan.TabIndex = 0;
            grbThongTinBenhNhan.TabStop = false;
            grbThongTinBenhNhan.Text = "Nhập Thông Tin Bệnh Nhân";
            grbThongTinBenhNhan.Enter += grbThongTinBenhNhan_Enter;
            // 
            // txtNamSinh
            // 
            txtNamSinh.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtNamSinh.Location = new Point(899, 100);
            txtNamSinh.Margin = new Padding(4);
            txtNamSinh.Name = "txtNamSinh";
            txtNamSinh.Size = new Size(340, 39);
            txtNamSinh.TabIndex = 21;
            txtNamSinh.TextChanged += txtNamSinh_TextChanged;
            // 
            // chkNu
            // 
            chkNu.AutoSize = true;
            chkNu.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            chkNu.Location = new Point(1015, 41);
            chkNu.Margin = new Padding(4);
            chkNu.Name = "chkNu";
            chkNu.Size = new Size(72, 36);
            chkNu.TabIndex = 4;
            chkNu.Text = "Nữ";
            chkNu.UseVisualStyleBackColor = true;
            chkNu.CheckedChanged += chkNu_CheckedChanged;
            // 
            // chkNam
            // 
            chkNam.AutoSize = true;
            chkNam.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            chkNam.Location = new Point(899, 41);
            chkNam.Margin = new Padding(4);
            chkNam.Name = "chkNam";
            chkNam.Size = new Size(91, 36);
            chkNam.TabIndex = 3;
            chkNam.Text = "Nam";
            chkNam.UseVisualStyleBackColor = true;
            chkNam.CheckedChanged += chkNam_CheckedChanged;
            // 
            // txtDiaChi
            // 
            txtDiaChi.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtDiaChi.Location = new Point(899, 161);
            txtDiaChi.Margin = new Padding(4);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(340, 39);
            txtDiaChi.TabIndex = 6;
            txtDiaChi.TextChanged += txtDiaChi_TextChanged;
            // 
            // txtTenBenhNhan
            // 
            txtTenBenhNhan.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtTenBenhNhan.Location = new Point(234, 161);
            txtTenBenhNhan.Margin = new Padding(4);
            txtTenBenhNhan.Name = "txtTenBenhNhan";
            txtTenBenhNhan.Size = new Size(340, 39);
            txtTenBenhNhan.TabIndex = 1;
            txtTenBenhNhan.TextChanged += txtTenBenhNhan_TextChanged;
            // 
            // txtMaBenhNhan
            // 
            txtMaBenhNhan.BackColor = SystemColors.Control;
            txtMaBenhNhan.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtMaBenhNhan.Location = new Point(234, 100);
            txtMaBenhNhan.Margin = new Padding(4);
            txtMaBenhNhan.Name = "txtMaBenhNhan";
            txtMaBenhNhan.ReadOnly = true;
            txtMaBenhNhan.Size = new Size(340, 39);
            txtMaBenhNhan.TabIndex = 0;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(740, 165);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(95, 32);
            label7.TabIndex = 19;
            label7.Text = "Địa Chỉ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(740, 42);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(117, 32);
            label5.TabIndex = 17;
            label5.Text = "Giới Tính";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(740, 104);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(124, 32);
            label4.TabIndex = 16;
            label4.Text = "Năm Sinh";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(24, 165);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(128, 32);
            label3.TabIndex = 15;
            label3.Text = "Họ Và Tên";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(21, 104);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(182, 32);
            label2.TabIndex = 14;
            label2.Text = "Mã Bệnh Nhân";
            // 
            // grbDanhSachBenhNhan
            // 
            grbDanhSachBenhNhan.Controls.Add(dgvDanhSachBenhNhan);
            grbDanhSachBenhNhan.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            grbDanhSachBenhNhan.Location = new Point(21, 292);
            grbDanhSachBenhNhan.Margin = new Padding(4);
            grbDanhSachBenhNhan.Name = "grbDanhSachBenhNhan";
            grbDanhSachBenhNhan.Padding = new Padding(4);
            grbDanhSachBenhNhan.Size = new Size(715, 502);
            grbDanhSachBenhNhan.TabIndex = 6;
            grbDanhSachBenhNhan.TabStop = false;
            grbDanhSachBenhNhan.Text = "Danh Sách Bệnh Nhân";
            // 
            // dgvDanhSachBenhNhan
            // 
            dgvDanhSachBenhNhan.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = Color.Teal;
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dgvDanhSachBenhNhan.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvDanhSachBenhNhan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = Color.Teal;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvDanhSachBenhNhan.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvDanhSachBenhNhan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = Color.Teal;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvDanhSachBenhNhan.DefaultCellStyle = dataGridViewCellStyle3;
            dgvDanhSachBenhNhan.Dock = DockStyle.Fill;
            dgvDanhSachBenhNhan.Location = new Point(4, 28);
            dgvDanhSachBenhNhan.Margin = new Padding(4);
            dgvDanhSachBenhNhan.Name = "dgvDanhSachBenhNhan";
            dgvDanhSachBenhNhan.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = Color.Teal;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgvDanhSachBenhNhan.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgvDanhSachBenhNhan.RowHeadersWidth = 51;
            dgvDanhSachBenhNhan.RowTemplate.DefaultCellStyle.ForeColor = SystemColors.WindowText;
            dgvDanhSachBenhNhan.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.Teal;
            dgvDanhSachBenhNhan.RowTemplate.DefaultCellStyle.SelectionForeColor = SystemColors.Window;
            dgvDanhSachBenhNhan.RowTemplate.Height = 29;
            dgvDanhSachBenhNhan.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDanhSachBenhNhan.Size = new Size(707, 470);
            dgvDanhSachBenhNhan.TabIndex = 0;
            dgvDanhSachBenhNhan.CellClick += dgvDanhSachBenhNhan_CellClick;
            // 
            // btnReset
            // 
            btnReset.BackColor = Color.Teal;
            btnReset.Cursor = Cursors.Hand;
            btnReset.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnReset.ForeColor = Color.White;
            btnReset.Location = new Point(791, 690);
            btnReset.Margin = new Padding(4);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(210, 100);
            btnReset.TabIndex = 7;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = false;
            btnReset.Click += btnReset_Click;
            // 
            // errorProvider
            // 
            errorProvider.ContainerControl = this;
            // 
            // frmThemTTBenhNhan
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.White;
            ClientSize = new Size(1316, 824);
            Controls.Add(btnReset);
            Controls.Add(grbDanhSachBenhNhan);
            Controls.Add(grbThongTinBenhNhan);
            Controls.Add(btnLapPhieuKham);
            Controls.Add(btnThoat);
            Controls.Add(btnSua);
            Controls.Add(btnXoa);
            Controls.Add(btnThem);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4);
            MaximizeBox = false;
            Name = "frmThemTTBenhNhan";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Thêm Thông Tin Bệnh Nhân";
            Load += frmThemTTBenhNhan_Load;
            grbThongTinBenhNhan.ResumeLayout(false);
            grbThongTinBenhNhan.PerformLayout();
            grbDanhSachBenhNhan.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvDanhSachBenhNhan).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Button btnThem;
        private Button btnXoa;
        private Button btnSua;
        private Button btnThoat;
        private Button btnLapPhieuKham;
        private GroupBox grbThongTinBenhNhan;
        private CheckBox chkNu;
        private CheckBox chkNam;
        private TextBox txtDiaChi;
        private TextBox txtTenBenhNhan;
        private TextBox txtMaBenhNhan;
        private Label label7;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private GroupBox grbDanhSachBenhNhan;
        private DataGridView dgvDanhSachBenhNhan;
        private TextBox txtNamSinh;
        private Button btnReset;
        private ErrorProvider errorProvider;
    }
}