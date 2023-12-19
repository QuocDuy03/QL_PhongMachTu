namespace QL_PhongMachTu
{
    partial class frmThayDoiQuyDinh
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
            label1 = new Label();
            groupBox1 = new GroupBox();
            dtvQuyDinh = new DataGridView();
            groupBox2 = new GroupBox();
            txtGiaTri = new TextBox();
            txtTenThamSo = new TextBox();
            label3 = new Label();
            label2 = new Label();
            btnSua = new Button();
            btnThoat = new Button();
            errorProvider = new ErrorProvider(components);
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtvQuyDinh).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
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
            label1.Size = new Size(472, 38);
            label1.TabIndex = 0;
            label1.Text = "Thay Đổi Quy Định";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dtvQuyDinh);
            groupBox1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(10, 161);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(272, 159);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Danh Sách Quy Định";
            // 
            // dtvQuyDinh
            // 
            dtvQuyDinh.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtvQuyDinh.Dock = DockStyle.Fill;
            dtvQuyDinh.Location = new Point(3, 21);
            dtvQuyDinh.Margin = new Padding(3, 2, 3, 2);
            dtvQuyDinh.Name = "dtvQuyDinh";
            dtvQuyDinh.ReadOnly = true;
            dtvQuyDinh.RowHeadersWidth = 51;
            dtvQuyDinh.RowTemplate.Height = 29;
            dtvQuyDinh.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtvQuyDinh.Size = new Size(266, 136);
            dtvQuyDinh.TabIndex = 0;
            dtvQuyDinh.CellClick += dtvQuyDinh_CellClick;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtGiaTri);
            groupBox2.Controls.Add(txtTenThamSo);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label2);
            groupBox2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox2.Location = new Point(10, 49);
            groupBox2.Margin = new Padding(3, 2, 3, 2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 2, 3, 2);
            groupBox2.Size = new Size(452, 107);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Thông tin tham số";
            // 
            // txtGiaTri
            // 
            txtGiaTri.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtGiaTri.Location = new Point(263, 56);
            txtGiaTri.Margin = new Padding(3, 2, 3, 2);
            txtGiaTri.Name = "txtGiaTri";
            txtGiaTri.Size = new Size(173, 29);
            txtGiaTri.TabIndex = 3;
            txtGiaTri.TextChanged += txtGiaTri_TextChanged;
            // 
            // txtTenThamSo
            // 
            txtTenThamSo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtTenThamSo.Location = new Point(6, 56);
            txtTenThamSo.Margin = new Padding(3, 2, 3, 2);
            txtTenThamSo.Name = "txtTenThamSo";
            txtTenThamSo.ReadOnly = true;
            txtTenThamSo.Size = new Size(173, 29);
            txtTenThamSo.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(263, 29);
            label3.Name = "label3";
            label3.Size = new Size(67, 25);
            label3.TabIndex = 1;
            label3.Text = "Giá Trị";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(6, 29);
            label2.Name = "label2";
            label2.Size = new Size(121, 25);
            label2.TabIndex = 0;
            label2.Text = "Tên Tham Số";
            // 
            // btnSua
            // 
            btnSua.BackColor = Color.Teal;
            btnSua.Cursor = Cursors.Hand;
            btnSua.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            btnSua.ForeColor = Color.White;
            btnSua.Location = new Point(286, 178);
            btnSua.Margin = new Padding(3, 2, 3, 2);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(178, 61);
            btnSua.TabIndex = 4;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = false;
            btnSua.Click += btnSua_Click;
            // 
            // btnThoat
            // 
            btnThoat.BackColor = Color.Teal;
            btnThoat.Cursor = Cursors.Hand;
            btnThoat.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            btnThoat.ForeColor = Color.White;
            btnThoat.Location = new Point(286, 258);
            btnThoat.Margin = new Padding(3, 2, 3, 2);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(178, 61);
            btnThoat.TabIndex = 5;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = false;
            btnThoat.Click += btnThoat_Click;
            // 
            // errorProvider
            // 
            errorProvider.ContainerControl = this;
            // 
            // frmThayDoiQuyDinh
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(472, 324);
            ControlBox = false;
            Controls.Add(btnThoat);
            Controls.Add(btnSua);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            Name = "frmThayDoiQuyDinh";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Thay Định Quy Định";
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtvQuyDinh).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private TextBox txtGiaTri;
        private TextBox txtTenThamSo;
        private Label label3;
        private Label label2;
        private Button btnSua;
        private DataGridView dtvQuyDinh;
        private Button btnThoat;
        private ErrorProvider errorProvider;
    }
}