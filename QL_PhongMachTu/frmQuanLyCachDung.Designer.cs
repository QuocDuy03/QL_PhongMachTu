namespace QL_PhongMachTu
{
    partial class frmQuanLyCachDung
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
            grbDanhSachTaiKhoan = new GroupBox();
            dvwDanhSachCachDung = new DataGridView();
            btnThoat = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            btnThem = new Button();
            groupBox1 = new GroupBox();
            txtTenCachDung = new TextBox();
            txtMaCachDung = new TextBox();
            label3 = new Label();
            label2 = new Label();
            btnReset = new Button();
            grbDanhSachTaiKhoan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dvwDanhSachCachDung).BeginInit();
            groupBox1.SuspendLayout();
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
            label1.Size = new Size(959, 55);
            label1.TabIndex = 0;
            label1.Text = "Quản Lý Cách Dùng";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click;
            // 
            // grbDanhSachTaiKhoan
            // 
            grbDanhSachTaiKhoan.Controls.Add(dvwDanhSachCachDung);
            grbDanhSachTaiKhoan.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            grbDanhSachTaiKhoan.Location = new Point(4, 248);
            grbDanhSachTaiKhoan.Margin = new Padding(4);
            grbDanhSachTaiKhoan.Name = "grbDanhSachTaiKhoan";
            grbDanhSachTaiKhoan.Padding = new Padding(4);
            grbDanhSachTaiKhoan.Size = new Size(581, 301);
            grbDanhSachTaiKhoan.TabIndex = 21;
            grbDanhSachTaiKhoan.TabStop = false;
            grbDanhSachTaiKhoan.Text = "Danh Sách Cách Dùng";
            // 
            // dvwDanhSachCachDung
            // 
            dvwDanhSachCachDung.AllowUserToAddRows = false;
            dvwDanhSachCachDung.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dvwDanhSachCachDung.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dvwDanhSachCachDung.Dock = DockStyle.Fill;
            dvwDanhSachCachDung.Location = new Point(4, 32);
            dvwDanhSachCachDung.Margin = new Padding(4);
            dvwDanhSachCachDung.Name = "dvwDanhSachCachDung";
            dvwDanhSachCachDung.ReadOnly = true;
            dvwDanhSachCachDung.RowHeadersWidth = 51;
            dvwDanhSachCachDung.RowTemplate.DefaultCellStyle.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            dvwDanhSachCachDung.RowTemplate.DefaultCellStyle.ForeColor = SystemColors.WindowText;
            dvwDanhSachCachDung.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.Teal;
            dvwDanhSachCachDung.RowTemplate.DefaultCellStyle.SelectionForeColor = SystemColors.Window;
            dvwDanhSachCachDung.RowTemplate.Height = 29;
            dvwDanhSachCachDung.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dvwDanhSachCachDung.Size = new Size(573, 265);
            dvwDanhSachCachDung.TabIndex = 0;
            dvwDanhSachCachDung.CellClick += dvwDanhSachCachDung_CellClick;
            // 
            // btnThoat
            // 
            btnThoat.BackColor = Color.Teal;
            btnThoat.Cursor = Cursors.Hand;
            btnThoat.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnThoat.ForeColor = Color.White;
            btnThoat.Location = new Point(596, 495);
            btnThoat.Margin = new Padding(4);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(348, 58);
            btnThoat.TabIndex = 20;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = false;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnSua
            // 
            btnSua.BackColor = Color.Teal;
            btnSua.Cursor = Cursors.Hand;
            btnSua.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnSua.ForeColor = Color.White;
            btnSua.Location = new Point(596, 411);
            btnSua.Margin = new Padding(4);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(160, 74);
            btnSua.TabIndex = 19;
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
            btnXoa.Location = new Point(786, 310);
            btnXoa.Margin = new Padding(4);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(160, 74);
            btnXoa.TabIndex = 18;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = false;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnThem
            // 
            btnThem.BackColor = Color.Teal;
            btnThem.Cursor = Cursors.Hand;
            btnThem.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnThem.ForeColor = Color.White;
            btnThem.Location = new Point(596, 310);
            btnThem.Margin = new Padding(4);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(160, 74);
            btnThem.TabIndex = 17;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtTenCachDung);
            groupBox1.Controls.Add(txtMaCachDung);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(10, 65);
            groupBox1.Margin = new Padding(4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4);
            groupBox1.Size = new Size(946, 186);
            groupBox1.TabIndex = 22;
            groupBox1.TabStop = false;
            groupBox1.Text = "Nhập Cách Dùng";
            // 
            // txtTenCachDung
            // 
            txtTenCachDung.BackColor = Color.White;
            txtTenCachDung.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtTenCachDung.Location = new Point(594, 109);
            txtTenCachDung.Margin = new Padding(4);
            txtTenCachDung.Name = "txtTenCachDung";
            txtTenCachDung.Size = new Size(288, 39);
            txtTenCachDung.TabIndex = 7;
            // 
            // txtMaCachDung
            // 
            txtMaCachDung.BackColor = SystemColors.ControlLight;
            txtMaCachDung.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtMaCachDung.Location = new Point(64, 109);
            txtMaCachDung.Margin = new Padding(4);
            txtMaCachDung.Name = "txtMaCachDung";
            txtMaCachDung.ReadOnly = true;
            txtMaCachDung.Size = new Size(288, 39);
            txtMaCachDung.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(594, 42);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(212, 38);
            label3.TabIndex = 5;
            label3.Text = "Tên Cách Dùng";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(64, 42);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(209, 38);
            label2.TabIndex = 4;
            label2.Text = "Mã Cách Dùng";
            // 
            // btnReset
            // 
            btnReset.BackColor = Color.Teal;
            btnReset.Cursor = Cursors.Hand;
            btnReset.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnReset.ForeColor = Color.White;
            btnReset.Location = new Point(786, 411);
            btnReset.Margin = new Padding(4);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(160, 74);
            btnReset.TabIndex = 23;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = false;
            btnReset.Click += btnReset_Click;
            // 
            // frmQuanLyCachDung
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(959, 565);
            Controls.Add(btnReset);
            Controls.Add(groupBox1);
            Controls.Add(grbDanhSachTaiKhoan);
            Controls.Add(btnThoat);
            Controls.Add(btnSua);
            Controls.Add(btnXoa);
            Controls.Add(btnThem);
            Controls.Add(label1);
            Margin = new Padding(4);
            Name = "frmQuanLyCachDung";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản Lý Cách Dùng";
            grbDanhSachTaiKhoan.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dvwDanhSachCachDung).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private GroupBox grbDanhSachTaiKhoan;
        private DataGridView dvwDanhSachCachDung;
        private Button btnThoat;
        private Button btnSua;
        private Button btnXoa;
        private Button btnThem;
        private GroupBox groupBox1;
        private TextBox txtTenCachDung;
        private TextBox txtMaCachDung;
        private Label label3;
        private Label label2;
        private Button btnReset;
    }
}