namespace QL_PhongMachTu
{
    partial class frmQuanLyThuoc
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            btnThem = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            btnReset = new Button();
            txtMaThuoc = new TextBox();
            txtTenThuoc = new TextBox();
            txtGiaBan = new TextBox();
            groupBox1 = new GroupBox();
            dgvDanhSachLoaiThuoc = new DataGridView();
            label6 = new Label();
            btnThoat = new Button();
            cboDonVi = new ComboBox();
            cboCachDung = new ComboBox();
            errorProvider = new ErrorProvider(components);
            btnNhapThuoc = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDanhSachLoaiThuoc).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.BackColor = Color.Teal;
            lblTitle.Dock = DockStyle.Top;
            lblTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(0, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(1182, 41);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "QUẢN LÝ THUỐC";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            lblTitle.Click += lblTitle_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(19, 53);
            label2.Name = "label2";
            label2.Size = new Size(85, 21);
            label2.TabIndex = 1;
            label2.Text = "Mã Thuốc";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(19, 139);
            label3.Name = "label3";
            label3.Size = new Size(88, 21);
            label3.TabIndex = 2;
            label3.Text = "Tên Thuốc";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(19, 225);
            label4.Name = "label4";
            label4.Size = new Size(62, 21);
            label4.TabIndex = 3;
            label4.Text = "Đơn Vị";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(19, 397);
            label5.Name = "label5";
            label5.Size = new Size(68, 21);
            label5.TabIndex = 4;
            label5.Text = "Giá Bán";
            // 
            // btnThem
            // 
            btnThem.BackColor = Color.Teal;
            btnThem.Cursor = Cursors.Hand;
            btnThem.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnThem.ForeColor = Color.White;
            btnThem.Location = new Point(19, 490);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(157, 71);
            btnThem.TabIndex = 5;
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
            btnSua.Location = new Point(203, 491);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(157, 71);
            btnSua.TabIndex = 6;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = false;
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.BackColor = Color.Teal;
            btnXoa.Cursor = Cursors.Hand;
            btnXoa.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnXoa.ForeColor = Color.White;
            btnXoa.Location = new Point(19, 591);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(157, 71);
            btnXoa.TabIndex = 7;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = false;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnReset
            // 
            btnReset.BackColor = Color.Teal;
            btnReset.Cursor = Cursors.Hand;
            btnReset.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnReset.ForeColor = Color.White;
            btnReset.Location = new Point(203, 591);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(157, 71);
            btnReset.TabIndex = 8;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = false;
            btnReset.Click += btnReset_Click;
            // 
            // txtMaThuoc
            // 
            txtMaThuoc.BackColor = SystemColors.ControlLight;
            txtMaThuoc.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtMaThuoc.Location = new Point(149, 51);
            txtMaThuoc.Name = "txtMaThuoc";
            txtMaThuoc.ReadOnly = true;
            txtMaThuoc.Size = new Size(223, 29);
            txtMaThuoc.TabIndex = 0;
            // 
            // txtTenThuoc
            // 
            txtTenThuoc.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtTenThuoc.Location = new Point(149, 140);
            txtTenThuoc.Name = "txtTenThuoc";
            txtTenThuoc.Size = new Size(223, 29);
            txtTenThuoc.TabIndex = 1;
            txtTenThuoc.TextChanged += txtTenThuoc_TextChanged;
            // 
            // txtGiaBan
            // 
            txtGiaBan.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtGiaBan.Location = new Point(149, 394);
            txtGiaBan.Name = "txtGiaBan";
            txtGiaBan.Size = new Size(223, 29);
            txtGiaBan.TabIndex = 4;
            txtGiaBan.TextChanged += txtGiaBan_TextChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dgvDanhSachLoaiThuoc);
            groupBox1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(389, 44);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(767, 712);
            groupBox1.TabIndex = 13;
            groupBox1.TabStop = false;
            groupBox1.Text = "Danh Sách Loại Thuốc";
            // 
            // dgvDanhSachLoaiThuoc
            // 
            dgvDanhSachLoaiThuoc.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDanhSachLoaiThuoc.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDanhSachLoaiThuoc.Dock = DockStyle.Fill;
            dgvDanhSachLoaiThuoc.Location = new Point(3, 22);
            dgvDanhSachLoaiThuoc.Name = "dgvDanhSachLoaiThuoc";
            dgvDanhSachLoaiThuoc.ReadOnly = true;
            dgvDanhSachLoaiThuoc.RowHeadersWidth = 51;
            dgvDanhSachLoaiThuoc.RowTemplate.DefaultCellStyle.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            dgvDanhSachLoaiThuoc.RowTemplate.DefaultCellStyle.ForeColor = SystemColors.WindowText;
            dgvDanhSachLoaiThuoc.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.Teal;
            dgvDanhSachLoaiThuoc.RowTemplate.DefaultCellStyle.SelectionForeColor = SystemColors.Window;
            dgvDanhSachLoaiThuoc.RowTemplate.Height = 25;
            dgvDanhSachLoaiThuoc.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDanhSachLoaiThuoc.Size = new Size(761, 687);
            dgvDanhSachLoaiThuoc.TabIndex = 0;
            dgvDanhSachLoaiThuoc.CellClick += dgvDanhSachLoaiThuoc_CellClick;
            dgvDanhSachLoaiThuoc.CellContentClick += dgvDanhSachLoaiThuoc_CellContentClick;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(19, 311);
            label6.Name = "label6";
            label6.Size = new Size(93, 21);
            label6.TabIndex = 14;
            label6.Text = "Cách Dùng";
            // 
            // btnThoat
            // 
            btnThoat.BackColor = Color.Teal;
            btnThoat.Cursor = Cursors.Hand;
            btnThoat.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnThoat.ForeColor = Color.White;
            btnThoat.Location = new Point(19, 685);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(157, 71);
            btnThoat.TabIndex = 15;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = false;
            btnThoat.Click += btnThoat_Click;
            // 
            // cboDonVi
            // 
            cboDonVi.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cboDonVi.FormattingEnabled = true;
            cboDonVi.Location = new Point(149, 227);
            cboDonVi.Name = "cboDonVi";
            cboDonVi.Size = new Size(223, 29);
            cboDonVi.TabIndex = 16;
            // 
            // cboCachDung
            // 
            cboCachDung.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cboCachDung.FormattingEnabled = true;
            cboCachDung.Location = new Point(149, 310);
            cboCachDung.Name = "cboCachDung";
            cboCachDung.Size = new Size(223, 29);
            cboCachDung.TabIndex = 17;
            // 
            // errorProvider
            // 
            errorProvider.ContainerControl = this;
            // 
            // btnNhapThuoc
            // 
            btnNhapThuoc.BackColor = Color.Teal;
            btnNhapThuoc.Cursor = Cursors.Hand;
            btnNhapThuoc.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnNhapThuoc.ForeColor = Color.White;
            btnNhapThuoc.Location = new Point(203, 688);
            btnNhapThuoc.Name = "btnNhapThuoc";
            btnNhapThuoc.Size = new Size(180, 68);
            btnNhapThuoc.TabIndex = 18;
            btnNhapThuoc.Text = "Nhập Thuốc";
            btnNhapThuoc.UseVisualStyleBackColor = false;
            btnNhapThuoc.Click += btnNhapThuoc_Click;
            // 
            // frmQuanLyThuoc
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(1182, 770);
            Controls.Add(btnNhapThuoc);
            Controls.Add(cboCachDung);
            Controls.Add(cboDonVi);
            Controls.Add(btnThoat);
            Controls.Add(label6);
            Controls.Add(groupBox1);
            Controls.Add(txtGiaBan);
            Controls.Add(txtTenThuoc);
            Controls.Add(txtMaThuoc);
            Controls.Add(btnReset);
            Controls.Add(btnXoa);
            Controls.Add(btnSua);
            Controls.Add(btnThem);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(lblTitle);
            Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            Name = "frmQuanLyThuoc";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản Lý Thuốc";
            Load += frmQuanLyThuoc_Load;
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvDanhSachLoaiThuoc).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button btnThem;
        private Button btnSua;
        private Button btnXoa;
        private Button btnReset;
        private TextBox txtMaThuoc;
        private TextBox txtTenThuoc;
        private TextBox txtGiaBan;
        private GroupBox groupBox1;
        private DataGridView dgvDanhSachLoaiThuoc;
        private Label label6;
        private Button btnThoat;
        private ComboBox cboDonVi;
        private ComboBox cboCachDung;
        private ErrorProvider errorProvider;
        private Button btnNhapThuoc;
    }
}