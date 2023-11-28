namespace QL_PhongMachTu
{
    partial class frmLoaiBenh
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
            gbxLoaiBenh = new GroupBox();
            dtvLoaiBenh = new DataGridView();
            btnThoat = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            btnThem = new Button();
            label1 = new Label();
            groupBox1 = new GroupBox();
            txtTenLoaiBenh = new TextBox();
            txtMaLoaiBenh = new TextBox();
            label3 = new Label();
            label2 = new Label();
            btnReset = new Button();
            gbxLoaiBenh.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtvLoaiBenh).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // gbxLoaiBenh
            // 
            gbxLoaiBenh.Controls.Add(dtvLoaiBenh);
            gbxLoaiBenh.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            gbxLoaiBenh.Location = new Point(15, 256);
            gbxLoaiBenh.Margin = new Padding(4);
            gbxLoaiBenh.Name = "gbxLoaiBenh";
            gbxLoaiBenh.Padding = new Padding(4);
            gbxLoaiBenh.Size = new Size(581, 319);
            gbxLoaiBenh.TabIndex = 23;
            gbxLoaiBenh.TabStop = false;
            gbxLoaiBenh.Text = "Danh Sách Loại Bệnh";
            // 
            // dtvLoaiBenh
            // 
            dtvLoaiBenh.AllowUserToAddRows = false;
            dtvLoaiBenh.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtvLoaiBenh.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtvLoaiBenh.Dock = DockStyle.Fill;
            dtvLoaiBenh.Location = new Point(4, 32);
            dtvLoaiBenh.Margin = new Padding(4);
            dtvLoaiBenh.Name = "dtvLoaiBenh";
            dtvLoaiBenh.ReadOnly = true;
            dtvLoaiBenh.RowHeadersWidth = 51;
            dtvLoaiBenh.RowTemplate.DefaultCellStyle.ForeColor = SystemColors.WindowText;
            dtvLoaiBenh.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.Teal;
            dtvLoaiBenh.RowTemplate.DefaultCellStyle.SelectionForeColor = SystemColors.Window;
            dtvLoaiBenh.RowTemplate.Height = 29;
            dtvLoaiBenh.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtvLoaiBenh.Size = new Size(573, 283);
            dtvLoaiBenh.TabIndex = 0;
            dtvLoaiBenh.CellClick += dtvLoaiBenh_CellClick;
            // 
            // btnThoat
            // 
            btnThoat.BackColor = Color.Teal;
            btnThoat.Cursor = Cursors.Hand;
            btnThoat.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnThoat.ForeColor = Color.White;
            btnThoat.Location = new Point(608, 512);
            btnThoat.Margin = new Padding(4);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(350, 59);
            btnThoat.TabIndex = 22;
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
            btnSua.Location = new Point(608, 415);
            btnSua.Margin = new Padding(4);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(160, 74);
            btnSua.TabIndex = 21;
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
            btnXoa.Location = new Point(798, 319);
            btnXoa.Margin = new Padding(4);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(160, 74);
            btnXoa.TabIndex = 20;
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
            btnThem.Location = new Point(608, 319);
            btnThem.Margin = new Padding(4);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(160, 74);
            btnThem.TabIndex = 19;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
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
            label1.Size = new Size(969, 58);
            label1.TabIndex = 18;
            label1.Text = "Quản Lý Loại Bệnh";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.White;
            groupBox1.Controls.Add(txtTenLoaiBenh);
            groupBox1.Controls.Add(txtMaLoaiBenh);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(15, 74);
            groupBox1.Margin = new Padding(4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4);
            groupBox1.Size = new Size(934, 186);
            groupBox1.TabIndex = 24;
            groupBox1.TabStop = false;
            groupBox1.Text = "Nhập Loại Bệnh";
            // 
            // txtTenLoaiBenh
            // 
            txtTenLoaiBenh.BackColor = Color.White;
            txtTenLoaiBenh.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtTenLoaiBenh.Location = new Point(569, 110);
            txtTenLoaiBenh.Margin = new Padding(4);
            txtTenLoaiBenh.Name = "txtTenLoaiBenh";
            txtTenLoaiBenh.Size = new Size(288, 39);
            txtTenLoaiBenh.TabIndex = 3;
            // 
            // txtMaLoaiBenh
            // 
            txtMaLoaiBenh.BackColor = SystemColors.ControlLight;
            txtMaLoaiBenh.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtMaLoaiBenh.Location = new Point(39, 110);
            txtMaLoaiBenh.Margin = new Padding(4);
            txtMaLoaiBenh.Name = "txtMaLoaiBenh";
            txtMaLoaiBenh.ReadOnly = true;
            txtMaLoaiBenh.Size = new Size(288, 39);
            txtMaLoaiBenh.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(569, 44);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(199, 38);
            label3.TabIndex = 1;
            label3.Text = "Tên Loại Bệnh";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(39, 44);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(196, 38);
            label2.TabIndex = 0;
            label2.Text = "Mã Loại Bệnh";
            // 
            // btnReset
            // 
            btnReset.BackColor = Color.Teal;
            btnReset.Cursor = Cursors.Hand;
            btnReset.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnReset.ForeColor = Color.White;
            btnReset.Location = new Point(798, 415);
            btnReset.Margin = new Padding(4);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(160, 74);
            btnReset.TabIndex = 25;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = false;
            btnReset.Click += button1_Click;
            // 
            // frmLoaiBenh
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(969, 590);
            ControlBox = false;
            Controls.Add(btnReset);
            Controls.Add(gbxLoaiBenh);
            Controls.Add(btnThoat);
            Controls.Add(btnSua);
            Controls.Add(btnXoa);
            Controls.Add(btnThem);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4);
            MaximizeBox = false;
            Name = "frmLoaiBenh";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản Lý Loại Bệnh";
            gbxLoaiBenh.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtvLoaiBenh).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gbxLoaiBenh;
        private DataGridView dtvLoaiBenh;
        private Button btnThoat;
        private Button btnSua;
        private Button btnXoa;
        private Button btnThem;
        private Label label1;
        private GroupBox groupBox1;
        private TextBox txtTenLoaiBenh;
        private TextBox txtMaLoaiBenh;
        private Label label3;
        private Label label2;
        private Button btnReset;
    }
}