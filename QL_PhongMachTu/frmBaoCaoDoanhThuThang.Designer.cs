namespace QL_PhongMachTu
{
    partial class frmBaoCaoDoanhThuThang
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
            grbNgayLapBaoCao = new GroupBox();
            label2 = new Label();
            dtpNgayLapBaoCao = new DateTimePicker();
            grbKetQuaBaoCao = new GroupBox();
            dgvBaoCaoDoanhThu = new DataGridView();
            btnLapBaoCao = new Button();
            btnXuatBaoCao = new Button();
            btnThoat = new Button();
            grbNgayLapBaoCao.SuspendLayout();
            grbKetQuaBaoCao.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBaoCaoDoanhThu).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = Color.Teal;
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(922, 37);
            label1.TabIndex = 0;
            label1.Text = "Báo Cáo Doanh Thu Tháng";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // grbNgayLapBaoCao
            // 
            grbNgayLapBaoCao.Controls.Add(label2);
            grbNgayLapBaoCao.Controls.Add(dtpNgayLapBaoCao);
            grbNgayLapBaoCao.Location = new Point(10, 39);
            grbNgayLapBaoCao.Margin = new Padding(3, 2, 3, 2);
            grbNgayLapBaoCao.Name = "grbNgayLapBaoCao";
            grbNgayLapBaoCao.Padding = new Padding(3, 2, 3, 2);
            grbNgayLapBaoCao.Size = new Size(604, 88);
            grbNgayLapBaoCao.TabIndex = 1;
            grbNgayLapBaoCao.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(99, 34);
            label2.Name = "label2";
            label2.Size = new Size(118, 25);
            label2.TabIndex = 1;
            label2.Text = "Tháng/Năm";
            // 
            // dtpNgayLapBaoCao
            // 
            dtpNgayLapBaoCao.Cursor = Cursors.Hand;
            dtpNgayLapBaoCao.CustomFormat = "MM/yyyy";
            dtpNgayLapBaoCao.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dtpNgayLapBaoCao.Format = DateTimePickerFormat.Custom;
            dtpNgayLapBaoCao.Location = new Point(223, 34);
            dtpNgayLapBaoCao.Margin = new Padding(3, 2, 3, 2);
            dtpNgayLapBaoCao.Name = "dtpNgayLapBaoCao";
            dtpNgayLapBaoCao.Size = new Size(211, 29);
            dtpNgayLapBaoCao.TabIndex = 0;
            // 
            // grbKetQuaBaoCao
            // 
            grbKetQuaBaoCao.Controls.Add(dgvBaoCaoDoanhThu);
            grbKetQuaBaoCao.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            grbKetQuaBaoCao.Location = new Point(10, 132);
            grbKetQuaBaoCao.Margin = new Padding(3, 2, 3, 2);
            grbKetQuaBaoCao.Name = "grbKetQuaBaoCao";
            grbKetQuaBaoCao.Padding = new Padding(3, 2, 3, 2);
            grbKetQuaBaoCao.Size = new Size(901, 262);
            grbKetQuaBaoCao.TabIndex = 2;
            grbKetQuaBaoCao.TabStop = false;
            grbKetQuaBaoCao.Text = "Kết quả báo cáo";
            // 
            // dgvBaoCaoDoanhThu
            // 
            dgvBaoCaoDoanhThu.AllowUserToAddRows = false;
            dgvBaoCaoDoanhThu.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvBaoCaoDoanhThu.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBaoCaoDoanhThu.Dock = DockStyle.Fill;
            dgvBaoCaoDoanhThu.Location = new Point(3, 21);
            dgvBaoCaoDoanhThu.Margin = new Padding(3, 2, 3, 2);
            dgvBaoCaoDoanhThu.Name = "dgvBaoCaoDoanhThu";
            dgvBaoCaoDoanhThu.ReadOnly = true;
            dgvBaoCaoDoanhThu.RightToLeft = RightToLeft.No;
            dgvBaoCaoDoanhThu.RowHeadersWidth = 51;
            dgvBaoCaoDoanhThu.RowTemplate.Height = 29;
            dgvBaoCaoDoanhThu.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvBaoCaoDoanhThu.Size = new Size(895, 239);
            dgvBaoCaoDoanhThu.TabIndex = 0;
            // 
            // btnLapBaoCao
            // 
            btnLapBaoCao.BackColor = Color.Teal;
            btnLapBaoCao.Cursor = Cursors.Hand;
            btnLapBaoCao.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnLapBaoCao.ForeColor = Color.White;
            btnLapBaoCao.Location = new Point(629, 66);
            btnLapBaoCao.Margin = new Padding(3, 2, 3, 2);
            btnLapBaoCao.Name = "btnLapBaoCao";
            btnLapBaoCao.Size = new Size(140, 62);
            btnLapBaoCao.TabIndex = 3;
            btnLapBaoCao.Text = "Lập Báo Cáo";
            btnLapBaoCao.UseVisualStyleBackColor = false;
            btnLapBaoCao.Click += btnLapBaoCao_Click;
            // 
            // btnXuatBaoCao
            // 
            btnXuatBaoCao.BackColor = Color.Teal;
            btnXuatBaoCao.Cursor = Cursors.Hand;
            btnXuatBaoCao.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnXuatBaoCao.ForeColor = Color.White;
            btnXuatBaoCao.Location = new Point(772, 66);
            btnXuatBaoCao.Margin = new Padding(3, 2, 3, 2);
            btnXuatBaoCao.Name = "btnXuatBaoCao";
            btnXuatBaoCao.Size = new Size(140, 62);
            btnXuatBaoCao.TabIndex = 4;
            btnXuatBaoCao.Text = "Xuất Báo Cáo";
            btnXuatBaoCao.UseVisualStyleBackColor = false;
            btnXuatBaoCao.Click += btnXuatBaoCao_Click;
            // 
            // btnThoat
            // 
            btnThoat.BackColor = Color.Teal;
            btnThoat.Cursor = Cursors.Hand;
            btnThoat.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnThoat.ForeColor = Color.White;
            btnThoat.Location = new Point(174, 410);
            btnThoat.Margin = new Padding(3, 2, 3, 2);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(560, 41);
            btnThoat.TabIndex = 5;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = false;
            btnThoat.Click += btnThoat_Click;
            // 
            // frmBaoCaoDoanhThuThang
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(922, 460);
            ControlBox = false;
            Controls.Add(btnThoat);
            Controls.Add(btnXuatBaoCao);
            Controls.Add(btnLapBaoCao);
            Controls.Add(grbKetQuaBaoCao);
            Controls.Add(grbNgayLapBaoCao);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            Name = "frmBaoCaoDoanhThuThang";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Báo Cáo Doanh Thu Tháng";
            grbNgayLapBaoCao.ResumeLayout(false);
            grbNgayLapBaoCao.PerformLayout();
            grbKetQuaBaoCao.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvBaoCaoDoanhThu).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private GroupBox grbNgayLapBaoCao;
        private GroupBox grbKetQuaBaoCao;
        private Button btnLapBaoCao;
        private Button btnXuatBaoCao;
        private Button btnThoat;
        private Label label2;
        private DateTimePicker dtpNgayLapBaoCao;
        private DataGridView dgvBaoCaoDoanhThu;
    }
}