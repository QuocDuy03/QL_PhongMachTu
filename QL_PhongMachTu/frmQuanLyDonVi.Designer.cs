namespace QL_PhongMachTu
{
    partial class frmQuanLyDonVi
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
            btnThoat = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            btnThem = new Button();
            grbDanhSachTaiKhoan = new GroupBox();
            dvwDanhSachDonVi = new DataGridView();
            groupBox1 = new GroupBox();
            txtTenDonVi = new TextBox();
            txtMaDonVi = new TextBox();
            label3 = new Label();
            label2 = new Label();
            btnReset = new Button();
            grbDanhSachTaiKhoan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dvwDanhSachDonVi).BeginInit();
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
            label1.Size = new Size(964, 58);
            label1.TabIndex = 0;
            label1.Text = "Quản Lý Đơn Vị";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click;
            // 
            // btnThoat
            // 
            btnThoat.BackColor = Color.Teal;
            btnThoat.Cursor = Cursors.Hand;
            btnThoat.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnThoat.ForeColor = Color.White;
            btnThoat.Location = new Point(604, 502);
            btnThoat.Margin = new Padding(4);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(350, 59);
            btnThoat.TabIndex = 15;
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
            btnSua.Location = new Point(608, 414);
            btnSua.Margin = new Padding(4);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(160, 74);
            btnSua.TabIndex = 14;
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
            btnXoa.Location = new Point(798, 314);
            btnXoa.Margin = new Padding(4);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(160, 74);
            btnXoa.TabIndex = 13;
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
            btnThem.Location = new Point(608, 314);
            btnThem.Margin = new Padding(4);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(160, 74);
            btnThem.TabIndex = 12;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // 
            // grbDanhSachTaiKhoan
            // 
            grbDanhSachTaiKhoan.Controls.Add(dvwDanhSachDonVi);
            grbDanhSachTaiKhoan.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            grbDanhSachTaiKhoan.Location = new Point(15, 251);
            grbDanhSachTaiKhoan.Margin = new Padding(4);
            grbDanhSachTaiKhoan.Name = "grbDanhSachTaiKhoan";
            grbDanhSachTaiKhoan.Padding = new Padding(4);
            grbDanhSachTaiKhoan.Size = new Size(581, 310);
            grbDanhSachTaiKhoan.TabIndex = 16;
            grbDanhSachTaiKhoan.TabStop = false;
            grbDanhSachTaiKhoan.Text = "Danh Sách Đơn Vị";
            // 
            // dvwDanhSachDonVi
            // 
            dvwDanhSachDonVi.AllowUserToAddRows = false;
            dvwDanhSachDonVi.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dvwDanhSachDonVi.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dvwDanhSachDonVi.Dock = DockStyle.Fill;
            dvwDanhSachDonVi.Location = new Point(4, 32);
            dvwDanhSachDonVi.Margin = new Padding(4);
            dvwDanhSachDonVi.Name = "dvwDanhSachDonVi";
            dvwDanhSachDonVi.ReadOnly = true;
            dvwDanhSachDonVi.RowHeadersWidth = 51;
            dvwDanhSachDonVi.RowTemplate.DefaultCellStyle.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            dvwDanhSachDonVi.RowTemplate.DefaultCellStyle.ForeColor = SystemColors.WindowText;
            dvwDanhSachDonVi.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.Teal;
            dvwDanhSachDonVi.RowTemplate.DefaultCellStyle.SelectionForeColor = SystemColors.Window;
            dvwDanhSachDonVi.RowTemplate.Height = 29;
            dvwDanhSachDonVi.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dvwDanhSachDonVi.Size = new Size(573, 274);
            dvwDanhSachDonVi.TabIndex = 0;
            dvwDanhSachDonVi.CellClick += dvwDanhSachTaiKhoan_CellClick;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.White;
            groupBox1.Controls.Add(txtTenDonVi);
            groupBox1.Controls.Add(txtMaDonVi);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(15, 69);
            groupBox1.Margin = new Padding(4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4);
            groupBox1.Size = new Size(934, 186);
            groupBox1.TabIndex = 17;
            groupBox1.TabStop = false;
            groupBox1.Text = "Nhập Đơn Vị";
            // 
            // txtTenDonVi
            // 
            txtTenDonVi.BackColor = SystemColors.Menu;
            txtTenDonVi.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtTenDonVi.Location = new Point(569, 110);
            txtTenDonVi.Margin = new Padding(4);
            txtTenDonVi.Name = "txtTenDonVi";
            txtTenDonVi.Size = new Size(288, 39);
            txtTenDonVi.TabIndex = 3;
            // 
            // txtMaDonVi
            // 
            txtMaDonVi.BackColor = SystemColors.ControlLight;
            txtMaDonVi.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtMaDonVi.Location = new Point(39, 110);
            txtMaDonVi.Margin = new Padding(4);
            txtMaDonVi.Name = "txtMaDonVi";
            txtMaDonVi.ReadOnly = true;
            txtMaDonVi.Size = new Size(288, 39);
            txtMaDonVi.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(569, 44);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(161, 38);
            label3.TabIndex = 1;
            label3.Text = "Tên Đơn Vị";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(39, 44);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(158, 38);
            label2.TabIndex = 0;
            label2.Text = "Mã Đơn Vị";
            // 
            // btnReset
            // 
            btnReset.BackColor = Color.Teal;
            btnReset.Cursor = Cursors.Hand;
            btnReset.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnReset.ForeColor = Color.White;
            btnReset.Location = new Point(798, 414);
            btnReset.Margin = new Padding(4);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(160, 74);
            btnReset.TabIndex = 18;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = false;
            btnReset.Click += btnReset_Click;
            // 
            // frmQuanLyDonVi
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(964, 576);
            Controls.Add(btnReset);
            Controls.Add(groupBox1);
            Controls.Add(grbDanhSachTaiKhoan);
            Controls.Add(btnThoat);
            Controls.Add(btnSua);
            Controls.Add(btnXoa);
            Controls.Add(btnThem);
            Controls.Add(label1);
            Margin = new Padding(4);
            Name = "frmQuanLyDonVi";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản Lý Đơn Vị";
            grbDanhSachTaiKhoan.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dvwDanhSachDonVi).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Button btnThoat;
        private Button btnSua;
        private Button btnXoa;
        private Button btnThem;
        private GroupBox grbDanhSachTaiKhoan;
        private DataGridView dvwDanhSachDonVi;
        private GroupBox groupBox1;
        private TextBox txtTenDonVi;
        private TextBox txtMaDonVi;
        private Label label3;
        private Label label2;
        private Button btnReset;
    }
}