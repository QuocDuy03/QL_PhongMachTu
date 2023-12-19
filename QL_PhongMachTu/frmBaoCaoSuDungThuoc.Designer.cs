using System.Drawing;
using System.Windows.Forms;

namespace QL_PhongMachTu
{
    partial class frmBaoCaoSuDungThuoc
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
            grbNgayThang = new GroupBox();
            dtpNgayLapBaoCao = new DateTimePicker();
            label2 = new Label();
            grbKetQuaBaoCao = new GroupBox();
            dgvBaoCaoSuDungThuoc = new DataGridView();
            btnLapBaoCao = new Button();
            btnXuatBaoCao = new Button();
            btnThoat = new Button();
            grbNgayThang.SuspendLayout();
            grbKetQuaBaoCao.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBaoCaoSuDungThuoc).BeginInit();
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
            label1.Size = new Size(906, 35);
            label1.TabIndex = 0;
            label1.Text = "Báo Cáo Sử Dụng Thuốc";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // grbNgayThang
            // 
            grbNgayThang.Controls.Add(dtpNgayLapBaoCao);
            grbNgayThang.Controls.Add(label2);
            grbNgayThang.Location = new Point(10, 38);
            grbNgayThang.Margin = new Padding(3, 2, 3, 2);
            grbNgayThang.Name = "grbNgayThang";
            grbNgayThang.Padding = new Padding(3, 2, 3, 2);
            grbNgayThang.Size = new Size(557, 88);
            grbNgayThang.TabIndex = 1;
            grbNgayThang.TabStop = false;
            // 
            // dtpNgayLapBaoCao
            // 
            dtpNgayLapBaoCao.Cursor = Cursors.Hand;
            dtpNgayLapBaoCao.CustomFormat = "MM/yyyy";
            dtpNgayLapBaoCao.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dtpNgayLapBaoCao.Format = DateTimePickerFormat.Custom;
            dtpNgayLapBaoCao.Location = new Point(213, 35);
            dtpNgayLapBaoCao.Margin = new Padding(3, 2, 3, 2);
            dtpNgayLapBaoCao.Name = "dtpNgayLapBaoCao";
            dtpNgayLapBaoCao.Size = new Size(246, 29);
            dtpNgayLapBaoCao.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(74, 37);
            label2.Name = "label2";
            label2.Size = new Size(118, 25);
            label2.TabIndex = 0;
            label2.Text = "Tháng/Năm";
            // 
            // grbKetQuaBaoCao
            // 
            grbKetQuaBaoCao.Controls.Add(dgvBaoCaoSuDungThuoc);
            grbKetQuaBaoCao.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            grbKetQuaBaoCao.Location = new Point(10, 130);
            grbKetQuaBaoCao.Margin = new Padding(3, 2, 3, 2);
            grbKetQuaBaoCao.Name = "grbKetQuaBaoCao";
            grbKetQuaBaoCao.Padding = new Padding(3, 2, 3, 2);
            grbKetQuaBaoCao.Size = new Size(886, 274);
            grbKetQuaBaoCao.TabIndex = 2;
            grbKetQuaBaoCao.TabStop = false;
            grbKetQuaBaoCao.Text = "Kết quả báo cáo";
            // 
            // dgvBaoCaoSuDungThuoc
            // 
            dgvBaoCaoSuDungThuoc.AllowUserToAddRows = false;
            dgvBaoCaoSuDungThuoc.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvBaoCaoSuDungThuoc.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBaoCaoSuDungThuoc.Dock = DockStyle.Fill;
            dgvBaoCaoSuDungThuoc.Location = new Point(3, 21);
            dgvBaoCaoSuDungThuoc.Margin = new Padding(3, 2, 3, 2);
            dgvBaoCaoSuDungThuoc.Name = "dgvBaoCaoSuDungThuoc";
            dgvBaoCaoSuDungThuoc.ReadOnly = true;
            dgvBaoCaoSuDungThuoc.RowHeadersWidth = 51;
            dgvBaoCaoSuDungThuoc.RowTemplate.Height = 29;
            dgvBaoCaoSuDungThuoc.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvBaoCaoSuDungThuoc.Size = new Size(880, 251);
            dgvBaoCaoSuDungThuoc.TabIndex = 0;
            // 
            // btnLapBaoCao
            // 
            btnLapBaoCao.BackColor = Color.Teal;
            btnLapBaoCao.Cursor = Cursors.Hand;
            btnLapBaoCao.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnLapBaoCao.ForeColor = Color.White;
            btnLapBaoCao.Location = new Point(592, 60);
            btnLapBaoCao.Margin = new Padding(3, 2, 3, 2);
            btnLapBaoCao.Name = "btnLapBaoCao";
            btnLapBaoCao.Size = new Size(137, 66);
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
            btnXuatBaoCao.Location = new Point(756, 60);
            btnXuatBaoCao.Margin = new Padding(3, 2, 3, 2);
            btnXuatBaoCao.Name = "btnXuatBaoCao";
            btnXuatBaoCao.Size = new Size(137, 66);
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
            btnThoat.Location = new Point(184, 420);
            btnThoat.Margin = new Padding(3, 2, 3, 2);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(544, 34);
            btnThoat.TabIndex = 5;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = false;
            btnThoat.Click += btnThoat_Click;
            // 
            // frmBaoCaoSuDungThuoc
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(906, 463);
            ControlBox = false;
            Controls.Add(btnThoat);
            Controls.Add(btnXuatBaoCao);
            Controls.Add(btnLapBaoCao);
            Controls.Add(grbKetQuaBaoCao);
            Controls.Add(grbNgayThang);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            Name = "frmBaoCaoSuDungThuoc";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Báo cáo sử dụng thuốc";
            grbNgayThang.ResumeLayout(false);
            grbNgayThang.PerformLayout();
            grbKetQuaBaoCao.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvBaoCaoSuDungThuoc).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private GroupBox grbNgayThang;
        private GroupBox grbKetQuaBaoCao;
        private Button btnLapBaoCao;
        private Button btnXuatBaoCao;
        private Button btnThoat;
        private DateTimePicker dtpNgayLapBaoCao;
        private Label label2;
        private DataGridView dgvBaoCaoSuDungThuoc;
    }
}