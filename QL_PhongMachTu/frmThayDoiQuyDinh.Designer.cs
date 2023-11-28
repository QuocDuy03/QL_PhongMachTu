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
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(675, 64);
            label1.TabIndex = 0;
            label1.Text = "Thay Đổi Quy Định";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dtvQuyDinh);
            groupBox1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(15, 268);
            groupBox1.Margin = new Padding(4, 4, 4, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 4, 4, 4);
            groupBox1.Size = new Size(389, 265);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Danh Sách Quy Định";
            // 
            // dtvQuyDinh
            // 
            dtvQuyDinh.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtvQuyDinh.Dock = DockStyle.Fill;
            dtvQuyDinh.Location = new Point(4, 32);
            dtvQuyDinh.Margin = new Padding(4, 4, 4, 4);
            dtvQuyDinh.Name = "dtvQuyDinh";
            dtvQuyDinh.ReadOnly = true;
            dtvQuyDinh.RowHeadersWidth = 51;
            dtvQuyDinh.RowTemplate.Height = 29;
            dtvQuyDinh.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtvQuyDinh.Size = new Size(381, 229);
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
            groupBox2.Location = new Point(15, 81);
            groupBox2.Margin = new Padding(4, 4, 4, 4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(4, 4, 4, 4);
            groupBox2.Size = new Size(646, 179);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Thông tin tham số";
            // 
            // txtGiaTri
            // 
            txtGiaTri.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtGiaTri.Location = new Point(376, 94);
            txtGiaTri.Margin = new Padding(4, 4, 4, 4);
            txtGiaTri.Name = "txtGiaTri";
            txtGiaTri.Size = new Size(245, 39);
            txtGiaTri.TabIndex = 3;
            txtGiaTri.TextChanged += txtGiaTri_TextChanged;
            // 
            // txtTenThamSo
            // 
            txtTenThamSo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtTenThamSo.Location = new Point(8, 94);
            txtTenThamSo.Margin = new Padding(4, 4, 4, 4);
            txtTenThamSo.Name = "txtTenThamSo";
            txtTenThamSo.ReadOnly = true;
            txtTenThamSo.Size = new Size(245, 39);
            txtTenThamSo.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(376, 48);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(91, 36);
            label3.TabIndex = 1;
            label3.Text = "Giá Trị";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(8, 48);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(172, 36);
            label2.TabIndex = 0;
            label2.Text = "Tên Tham Số";
            // 
            // btnSua
            // 
            btnSua.BackColor = Color.Teal;
            btnSua.Cursor = Cursors.Hand;
            btnSua.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            btnSua.ForeColor = Color.White;
            btnSua.Location = new Point(408, 296);
            btnSua.Margin = new Padding(4, 4, 4, 4);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(254, 102);
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
            btnThoat.Location = new Point(408, 430);
            btnThoat.Margin = new Padding(4, 4, 4, 4);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(254, 102);
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
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(675, 540);
            ControlBox = false;
            Controls.Add(btnThoat);
            Controls.Add(btnSua);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4, 4, 4, 4);
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