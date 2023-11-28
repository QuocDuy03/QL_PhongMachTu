namespace QL_PhongMachTu
{
    partial class frmQLKB
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
            button1 = new Button();
            button2 = new Button();
            button4 = new Button();
            btnXemLoaiBenh = new Button();
            btnThoat = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = Color.Teal;
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(675, 63);
            label1.TabIndex = 0;
            label1.Text = "Mời bạn lựa chọn";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Teal;
            button1.Cursor = Cursors.Hand;
            button1.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(51, 100);
            button1.Name = "button1";
            button1.Size = new Size(257, 115);
            button1.TabIndex = 1;
            button1.Text = "Thêm Thông Tin Bệnh Nhân";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Teal;
            button2.Cursor = Cursors.Hand;
            button2.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.White;
            button2.Location = new Point(367, 100);
            button2.Name = "button2";
            button2.Size = new Size(257, 115);
            button2.TabIndex = 2;
            button2.Text = "Lập Phiếu Khám Bệnh";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.Teal;
            button4.Cursor = Cursors.Hand;
            button4.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            button4.ForeColor = Color.White;
            button4.Location = new Point(51, 247);
            button4.Name = "button4";
            button4.Size = new Size(257, 115);
            button4.TabIndex = 4;
            button4.Text = "Tra Cứu Bệnh Nhân";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // btnXemLoaiBenh
            // 
            btnXemLoaiBenh.BackColor = Color.Teal;
            btnXemLoaiBenh.Cursor = Cursors.Hand;
            btnXemLoaiBenh.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            btnXemLoaiBenh.ForeColor = Color.White;
            btnXemLoaiBenh.Location = new Point(367, 247);
            btnXemLoaiBenh.Name = "btnXemLoaiBenh";
            btnXemLoaiBenh.Size = new Size(257, 115);
            btnXemLoaiBenh.TabIndex = 6;
            btnXemLoaiBenh.Text = "Xem Thông Tin Loại Bệnh";
            btnXemLoaiBenh.UseVisualStyleBackColor = false;
            btnXemLoaiBenh.Click += btnXemLoaiBenh_Click;
            // 
            // btnThoat
            // 
            btnThoat.BackColor = Color.Teal;
            btnThoat.Cursor = Cursors.Hand;
            btnThoat.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            btnThoat.ForeColor = Color.White;
            btnThoat.Location = new Point(51, 400);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(573, 84);
            btnThoat.TabIndex = 7;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = false;
            btnThoat.Click += button6_Click;
            // 
            // frmQLKB
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(675, 517);
            Controls.Add(btnThoat);
            Controls.Add(btnXemLoaiBenh);
            Controls.Add(button4);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "frmQLKB";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menu Quản Lý Khám Bệnh";
            Load += frmQLKB_Load;
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Button button1;
        private Button button2;
        private Button button4;
        private Button btnXemLoaiBenh;
        private Button btnThoat;
    }
}