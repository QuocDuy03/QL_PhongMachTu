using System.Drawing;
using System.Windows.Forms;

namespace QL_PhongMachTu
{
    partial class frmMenuLapBaoCao
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
            btnBC_DoanhThuThang = new Button();
            btnBC_SuDungThuoc = new Button();
            btnThoat = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = Color.Teal;
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(591, 34);
            label1.TabIndex = 0;
            label1.Text = "Mời Bạn Lựa Chọn";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // btnBC_DoanhThuThang
            // 
            btnBC_DoanhThuThang.BackColor = Color.Teal;
            btnBC_DoanhThuThang.Cursor = Cursors.Hand;
            btnBC_DoanhThuThang.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            btnBC_DoanhThuThang.ForeColor = Color.White;
            btnBC_DoanhThuThang.Location = new Point(38, 60);
            btnBC_DoanhThuThang.Margin = new Padding(3, 2, 3, 2);
            btnBC_DoanhThuThang.Name = "btnBC_DoanhThuThang";
            btnBC_DoanhThuThang.Size = new Size(250, 106);
            btnBC_DoanhThuThang.TabIndex = 1;
            btnBC_DoanhThuThang.Text = "Lập Báo Cáo Doanh Thu Tháng";
            btnBC_DoanhThuThang.UseVisualStyleBackColor = false;
            btnBC_DoanhThuThang.Click += btnBC_DoanhThuThang_Click;
            // 
            // btnBC_SuDungThuoc
            // 
            btnBC_SuDungThuoc.BackColor = Color.Teal;
            btnBC_SuDungThuoc.Cursor = Cursors.Hand;
            btnBC_SuDungThuoc.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            btnBC_SuDungThuoc.ForeColor = Color.White;
            btnBC_SuDungThuoc.Location = new Point(303, 60);
            btnBC_SuDungThuoc.Margin = new Padding(3, 2, 3, 2);
            btnBC_SuDungThuoc.Name = "btnBC_SuDungThuoc";
            btnBC_SuDungThuoc.Size = new Size(250, 106);
            btnBC_SuDungThuoc.TabIndex = 2;
            btnBC_SuDungThuoc.Text = "Lập Báo Cáo Sử Dụng Thuốc";
            btnBC_SuDungThuoc.UseVisualStyleBackColor = false;
            btnBC_SuDungThuoc.Click += btnBC_SuDungThuoc_Click;
            // 
            // btnThoat
            // 
            btnThoat.BackColor = Color.Teal;
            btnThoat.Cursor = Cursors.Hand;
            btnThoat.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            btnThoat.ForeColor = Color.White;
            btnThoat.Location = new Point(38, 184);
            btnThoat.Margin = new Padding(3, 2, 3, 2);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(514, 39);
            btnThoat.TabIndex = 3;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = false;
            btnThoat.Click += btnThoat_Click;
            // 
            // frmMenuLapBaoCao
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(591, 246);
            ControlBox = false;
            Controls.Add(btnThoat);
            Controls.Add(btnBC_SuDungThuoc);
            Controls.Add(btnBC_DoanhThuThang);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            MaximumSize = new Size(607, 285);
            MinimumSize = new Size(607, 285);
            Name = "frmMenuLapBaoCao";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menu Lập Báo Cáo";
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Button btnBC_DoanhThuThang;
        private Button btnBC_SuDungThuoc;
        private Button btnThoat;
    }
}