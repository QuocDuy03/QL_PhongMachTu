using System.Windows.Forms;

namespace QL_PhongMachTu
{
    partial class frmMain
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
            panel1 = new Panel();
            menuStrip1 = new MenuStrip();
            tipQLKhamBenh = new ToolStripMenuItem();
            thêmBệnhNhânToolStripMenuItem = new ToolStripMenuItem();
            lậpPhiếuKhámBệnhToolStripMenuItem = new ToolStripMenuItem();
            traCứuBệnhNhânToolStripMenuItem = new ToolStripMenuItem();
            thôngTinLoạiBệnhToolStripMenuItem = new ToolStripMenuItem();
            tipQLThuoc = new ToolStripMenuItem();
            lậpPhiếuNhậpThuốcToolStripMenuItem = new ToolStripMenuItem();
            xemThôngTinThuốcToolStripMenuItem = new ToolStripMenuItem();
            xemThôngTinĐơnVịToolStripMenuItem = new ToolStripMenuItem();
            xemThôngTinCáchDùngToolStripMenuItem = new ToolStripMenuItem();
            tipLapHoaDon = new ToolStripMenuItem();
            tipLapBaoCao = new ToolStripMenuItem();
            lậpBáoCáoDoanhThuThángToolStripMenuItem = new ToolStripMenuItem();
            lậpBáoCáoSửDụngThuốcToolStripMenuItem = new ToolStripMenuItem();
            tipAdmin = new ToolStripMenuItem();
            quảnLýTàiKhoảnToolStripMenuItem = new ToolStripMenuItem();
            thayĐổiQuyĐịnhToolStripMenuItem = new ToolStripMenuItem();
            tipTaiKhoan = new ToolStripMenuItem();
            thayĐổiThôngTinToolStripMenuItem = new ToolStripMenuItem();
            tipItemDangXuat = new ToolStripMenuItem();
            tipItemThoat = new ToolStripMenuItem();
            picQLKhamBenh = new PictureBox();
            picLapBaoCao = new PictureBox();
            picQLThuoc = new PictureBox();
            picLapHoaDon = new PictureBox();
            btnQLKhamBenh = new Button();
            btnQLThuoc = new Button();
            btnLapHoaDon = new Button();
            btnLapBaoCao = new Button();
            toolStripMenuItem1 = new ToolStripMenuItem();
            panel1.SuspendLayout();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picQLKhamBenh).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picLapBaoCao).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picQLThuoc).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picLapHoaDon).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(menuStrip1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new System.Drawing.Point(0, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(789, 35);
            panel1.TabIndex = 0;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            menuStrip1.Dock = DockStyle.Fill;
            menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { tipQLKhamBenh, tipQLThuoc, tipLapHoaDon, tipLapBaoCao, tipAdmin, tipTaiKhoan, toolStripMenuItem1 });
            menuStrip1.Location = new System.Drawing.Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(5, 0, 0, 0);
            menuStrip1.Size = new System.Drawing.Size(789, 35);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // tipQLKhamBenh
            // 
            tipQLKhamBenh.DropDownItems.AddRange(new ToolStripItem[] { thêmBệnhNhânToolStripMenuItem, lậpPhiếuKhámBệnhToolStripMenuItem, traCứuBệnhNhânToolStripMenuItem, thôngTinLoạiBệnhToolStripMenuItem });
            tipQLKhamBenh.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            tipQLKhamBenh.ForeColor = System.Drawing.Color.Black;
            tipQLKhamBenh.Name = "tipQLKhamBenh";
            tipQLKhamBenh.Size = new System.Drawing.Size(148, 35);
            tipQLKhamBenh.Text = "Quản Lý Khám Bệnh";
            // 
            // thêmBệnhNhânToolStripMenuItem
            // 
            thêmBệnhNhânToolStripMenuItem.Name = "thêmBệnhNhânToolStripMenuItem";
            thêmBệnhNhânToolStripMenuItem.Size = new System.Drawing.Size(239, 24);
            thêmBệnhNhânToolStripMenuItem.Text = "Thêm Bệnh Nhân";
            thêmBệnhNhânToolStripMenuItem.Click += thêmBệnhNhânToolStripMenuItem_Click;
            // 
            // lậpPhiếuKhámBệnhToolStripMenuItem
            // 
            lậpPhiếuKhámBệnhToolStripMenuItem.Name = "lậpPhiếuKhámBệnhToolStripMenuItem";
            lậpPhiếuKhámBệnhToolStripMenuItem.Size = new System.Drawing.Size(239, 24);
            lậpPhiếuKhámBệnhToolStripMenuItem.Text = "Lập Phiếu Khám Bệnh";
            lậpPhiếuKhámBệnhToolStripMenuItem.Click += lậpPhiếuKhámBệnhToolStripMenuItem_Click;
            // 
            // traCứuBệnhNhânToolStripMenuItem
            // 
            traCứuBệnhNhânToolStripMenuItem.Name = "traCứuBệnhNhânToolStripMenuItem";
            traCứuBệnhNhânToolStripMenuItem.Size = new System.Drawing.Size(239, 24);
            traCứuBệnhNhânToolStripMenuItem.Text = "Tra Cứu Bệnh Nhân";
            traCứuBệnhNhânToolStripMenuItem.Click += traCứuBệnhNhânToolStripMenuItem_Click;
            // 
            // thôngTinLoạiBệnhToolStripMenuItem
            // 
            thôngTinLoạiBệnhToolStripMenuItem.Name = "thôngTinLoạiBệnhToolStripMenuItem";
            thôngTinLoạiBệnhToolStripMenuItem.Size = new System.Drawing.Size(239, 24);
            thôngTinLoạiBệnhToolStripMenuItem.Text = "Xem Thông Tin Loại Bệnh";
            thôngTinLoạiBệnhToolStripMenuItem.Click += thôngTinLoạiBệnhToolStripMenuItem_Click;
            // 
            // tipQLThuoc
            // 
            tipQLThuoc.DropDownItems.AddRange(new ToolStripItem[] { lậpPhiếuNhậpThuốcToolStripMenuItem, xemThôngTinThuốcToolStripMenuItem, xemThôngTinĐơnVịToolStripMenuItem, xemThôngTinCáchDùngToolStripMenuItem });
            tipQLThuoc.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            tipQLThuoc.Name = "tipQLThuoc";
            tipQLThuoc.Size = new System.Drawing.Size(116, 35);
            tipQLThuoc.Text = "Quản Lý Thuốc";
            // 
            // lậpPhiếuNhậpThuốcToolStripMenuItem
            // 
            lậpPhiếuNhậpThuốcToolStripMenuItem.Name = "lậpPhiếuNhậpThuốcToolStripMenuItem";
            lậpPhiếuNhậpThuốcToolStripMenuItem.Size = new System.Drawing.Size(247, 24);
            lậpPhiếuNhậpThuốcToolStripMenuItem.Text = "Lập Phiếu Nhập Thuốc";
            lậpPhiếuNhậpThuốcToolStripMenuItem.Click += lậpPhiếuNhậpThuốcToolStripMenuItem_Click;
            // 
            // xemThôngTinThuốcToolStripMenuItem
            // 
            xemThôngTinThuốcToolStripMenuItem.Name = "xemThôngTinThuốcToolStripMenuItem";
            xemThôngTinThuốcToolStripMenuItem.Size = new System.Drawing.Size(247, 24);
            xemThôngTinThuốcToolStripMenuItem.Text = "Xem Thông Tin Thuốc";
            xemThôngTinThuốcToolStripMenuItem.Click += xemThôngTinThuốcToolStripMenuItem_Click;
            // 
            // xemThôngTinĐơnVịToolStripMenuItem
            // 
            xemThôngTinĐơnVịToolStripMenuItem.Name = "xemThôngTinĐơnVịToolStripMenuItem";
            xemThôngTinĐơnVịToolStripMenuItem.Size = new System.Drawing.Size(247, 24);
            xemThôngTinĐơnVịToolStripMenuItem.Text = "Xem Thông Tin Đơn Vị";
            xemThôngTinĐơnVịToolStripMenuItem.Click += xemThôngTinĐơnVịToolStripMenuItem_Click;
            // 
            // xemThôngTinCáchDùngToolStripMenuItem
            // 
            xemThôngTinCáchDùngToolStripMenuItem.Name = "xemThôngTinCáchDùngToolStripMenuItem";
            xemThôngTinCáchDùngToolStripMenuItem.Size = new System.Drawing.Size(247, 24);
            xemThôngTinCáchDùngToolStripMenuItem.Text = "Xem Thông Tin Cách Dùng";
            xemThôngTinCáchDùngToolStripMenuItem.Click += xemThôngTinCáchDùngToolStripMenuItem_Click;
            // 
            // tipLapHoaDon
            // 
            tipLapHoaDon.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            tipLapHoaDon.Name = "tipLapHoaDon";
            tipLapHoaDon.Size = new System.Drawing.Size(103, 35);
            tipLapHoaDon.Text = "Lập Hóa Đơn";
            tipLapHoaDon.Click += tipLapHoaDon_Click;
            // 
            // tipLapBaoCao
            // 
            tipLapBaoCao.DropDownItems.AddRange(new ToolStripItem[] { lậpBáoCáoDoanhThuThángToolStripMenuItem, lậpBáoCáoSửDụngThuốcToolStripMenuItem });
            tipLapBaoCao.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            tipLapBaoCao.Name = "tipLapBaoCao";
            tipLapBaoCao.Size = new System.Drawing.Size(98, 35);
            tipLapBaoCao.Text = "Lập Báo Cáo";
            // 
            // lậpBáoCáoDoanhThuThángToolStripMenuItem
            // 
            lậpBáoCáoDoanhThuThángToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
            lậpBáoCáoDoanhThuThángToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            lậpBáoCáoDoanhThuThángToolStripMenuItem.Name = "lậpBáoCáoDoanhThuThángToolStripMenuItem";
            lậpBáoCáoDoanhThuThángToolStripMenuItem.Size = new System.Drawing.Size(271, 24);
            lậpBáoCáoDoanhThuThángToolStripMenuItem.Text = "Lập Báo Cáo Doanh Thu Tháng";
            lậpBáoCáoDoanhThuThángToolStripMenuItem.Click += lậpBáoCáoDoanhThuThángToolStripMenuItem_Click;
            // 
            // lậpBáoCáoSửDụngThuốcToolStripMenuItem
            // 
            lậpBáoCáoSửDụngThuốcToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
            lậpBáoCáoSửDụngThuốcToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            lậpBáoCáoSửDụngThuốcToolStripMenuItem.Name = "lậpBáoCáoSửDụngThuốcToolStripMenuItem";
            lậpBáoCáoSửDụngThuốcToolStripMenuItem.Size = new System.Drawing.Size(271, 24);
            lậpBáoCáoSửDụngThuốcToolStripMenuItem.Text = "Lập Báo Cáo Sử Dụng Thuốc";
            lậpBáoCáoSửDụngThuốcToolStripMenuItem.Click += lậpBáoCáoSửDụngThuốcToolStripMenuItem_Click;
            // 
            // tipAdmin
            // 
            tipAdmin.DropDownItems.AddRange(new ToolStripItem[] { quảnLýTàiKhoảnToolStripMenuItem, thayĐổiQuyĐịnhToolStripMenuItem });
            tipAdmin.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            tipAdmin.Name = "tipAdmin";
            tipAdmin.Size = new System.Drawing.Size(62, 35);
            tipAdmin.Text = "Admin";
            // 
            // quảnLýTàiKhoảnToolStripMenuItem
            // 
            quảnLýTàiKhoảnToolStripMenuItem.Name = "quảnLýTàiKhoảnToolStripMenuItem";
            quảnLýTàiKhoảnToolStripMenuItem.Size = new System.Drawing.Size(198, 24);
            quảnLýTàiKhoảnToolStripMenuItem.Text = "Quản Lý Tài Khoản";
            quảnLýTàiKhoảnToolStripMenuItem.Click += quảnLýTàiKhoảnToolStripMenuItem_Click;
            // 
            // thayĐổiQuyĐịnhToolStripMenuItem
            // 
            thayĐổiQuyĐịnhToolStripMenuItem.Name = "thayĐổiQuyĐịnhToolStripMenuItem";
            thayĐổiQuyĐịnhToolStripMenuItem.Size = new System.Drawing.Size(198, 24);
            thayĐổiQuyĐịnhToolStripMenuItem.Text = "Thay Đổi Quy Định";
            thayĐổiQuyĐịnhToolStripMenuItem.Click += thayĐổiQuyĐịnhToolStripMenuItem_Click;
            // 
            // tipTaiKhoan
            // 
            tipTaiKhoan.DropDownItems.AddRange(new ToolStripItem[] { thayĐổiThôngTinToolStripMenuItem, tipItemDangXuat, tipItemThoat });
            tipTaiKhoan.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            tipTaiKhoan.Name = "tipTaiKhoan";
            tipTaiKhoan.Size = new System.Drawing.Size(136, 35);
            tipTaiKhoan.Text = "Tài Khoản (admin)";
            // 
            // thayĐổiThôngTinToolStripMenuItem
            // 
            thayĐổiThôngTinToolStripMenuItem.Name = "thayĐổiThôngTinToolStripMenuItem";
            thayĐổiThôngTinToolStripMenuItem.Size = new System.Drawing.Size(202, 24);
            thayĐổiThôngTinToolStripMenuItem.Text = "Thay Đổi Thông Tin";
            thayĐổiThôngTinToolStripMenuItem.Click += thayĐổiThôngTinToolStripMenuItem_Click;
            // 
            // tipItemDangXuat
            // 
            tipItemDangXuat.Name = "tipItemDangXuat";
            tipItemDangXuat.Size = new System.Drawing.Size(202, 24);
            tipItemDangXuat.Text = "Đăng Xuất";
            tipItemDangXuat.Click += tipItemDangXuat_Click;
            // 
            // tipItemThoat
            // 
            tipItemThoat.Name = "tipItemThoat";
            tipItemThoat.Size = new System.Drawing.Size(202, 24);
            tipItemThoat.Text = "Thoát";
            tipItemThoat.Click += tipItemThoat_Click;
            // 
            // picQLKhamBenh
            // 
            picQLKhamBenh.BorderStyle = BorderStyle.Fixed3D;
            picQLKhamBenh.Image = Properties.Resources.KhamBenh;
            picQLKhamBenh.Location = new System.Drawing.Point(135, 69);
            picQLKhamBenh.Margin = new Padding(3, 2, 3, 2);
            picQLKhamBenh.Name = "picQLKhamBenh";
            picQLKhamBenh.Size = new System.Drawing.Size(194, 139);
            picQLKhamBenh.SizeMode = PictureBoxSizeMode.StretchImage;
            picQLKhamBenh.TabIndex = 1;
            picQLKhamBenh.TabStop = false;
            // 
            // picLapBaoCao
            // 
            picLapBaoCao.Image = Properties.Resources.report;
            picLapBaoCao.Location = new System.Drawing.Point(470, 284);
            picLapBaoCao.Margin = new Padding(3, 2, 3, 2);
            picLapBaoCao.Name = "picLapBaoCao";
            picLapBaoCao.Size = new System.Drawing.Size(193, 138);
            picLapBaoCao.SizeMode = PictureBoxSizeMode.StretchImage;
            picLapBaoCao.TabIndex = 2;
            picLapBaoCao.TabStop = false;
            // 
            // picQLThuoc
            // 
            picQLThuoc.BorderStyle = BorderStyle.Fixed3D;
            picQLThuoc.Image = Properties.Resources.Medicine;
            picQLThuoc.Location = new System.Drawing.Point(470, 69);
            picQLThuoc.Margin = new Padding(3, 2, 3, 2);
            picQLThuoc.Name = "picQLThuoc";
            picQLThuoc.Size = new System.Drawing.Size(194, 139);
            picQLThuoc.SizeMode = PictureBoxSizeMode.StretchImage;
            picQLThuoc.TabIndex = 3;
            picQLThuoc.TabStop = false;
            // 
            // picLapHoaDon
            // 
            picLapHoaDon.BorderStyle = BorderStyle.Fixed3D;
            picLapHoaDon.Image = Properties.Resources.invoice1;
            picLapHoaDon.Location = new System.Drawing.Point(135, 284);
            picLapHoaDon.Margin = new Padding(3, 2, 3, 2);
            picLapHoaDon.Name = "picLapHoaDon";
            picLapHoaDon.Size = new System.Drawing.Size(194, 139);
            picLapHoaDon.SizeMode = PictureBoxSizeMode.StretchImage;
            picLapHoaDon.TabIndex = 4;
            picLapHoaDon.TabStop = false;
            // 
            // btnQLKhamBenh
            // 
            btnQLKhamBenh.BackColor = System.Drawing.SystemColors.MenuHighlight;
            btnQLKhamBenh.Cursor = Cursors.Hand;
            btnQLKhamBenh.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnQLKhamBenh.ForeColor = System.Drawing.Color.White;
            btnQLKhamBenh.Location = new System.Drawing.Point(134, 212);
            btnQLKhamBenh.Margin = new Padding(3, 2, 3, 2);
            btnQLKhamBenh.Name = "btnQLKhamBenh";
            btnQLKhamBenh.Size = new System.Drawing.Size(193, 33);
            btnQLKhamBenh.TabIndex = 5;
            btnQLKhamBenh.Text = "Quản Lý Khám Bệnh";
            btnQLKhamBenh.UseVisualStyleBackColor = false;
            btnQLKhamBenh.Click += btnQLKhamBenh_Click;
            // 
            // btnQLThuoc
            // 
            btnQLThuoc.BackColor = System.Drawing.SystemColors.MenuHighlight;
            btnQLThuoc.Cursor = Cursors.Hand;
            btnQLThuoc.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnQLThuoc.ForeColor = System.Drawing.Color.White;
            btnQLThuoc.Location = new System.Drawing.Point(470, 212);
            btnQLThuoc.Margin = new Padding(3, 2, 3, 2);
            btnQLThuoc.Name = "btnQLThuoc";
            btnQLThuoc.Size = new System.Drawing.Size(193, 33);
            btnQLThuoc.TabIndex = 6;
            btnQLThuoc.Text = "Quản Lý Thuốc";
            btnQLThuoc.UseVisualStyleBackColor = false;
            btnQLThuoc.Click += btnQLThuoc_Click;
            // 
            // btnLapHoaDon
            // 
            btnLapHoaDon.BackColor = System.Drawing.SystemColors.MenuHighlight;
            btnLapHoaDon.Cursor = Cursors.Hand;
            btnLapHoaDon.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnLapHoaDon.ForeColor = System.Drawing.Color.White;
            btnLapHoaDon.Location = new System.Drawing.Point(134, 426);
            btnLapHoaDon.Margin = new Padding(3, 2, 3, 2);
            btnLapHoaDon.Name = "btnLapHoaDon";
            btnLapHoaDon.Size = new System.Drawing.Size(193, 33);
            btnLapHoaDon.TabIndex = 7;
            btnLapHoaDon.Text = "Lập Hóa Đơn";
            btnLapHoaDon.UseVisualStyleBackColor = false;
            btnLapHoaDon.Click += btnLapHoaDon_Click;
            // 
            // btnLapBaoCao
            // 
            btnLapBaoCao.BackColor = System.Drawing.SystemColors.MenuHighlight;
            btnLapBaoCao.Cursor = Cursors.Hand;
            btnLapBaoCao.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnLapBaoCao.ForeColor = System.Drawing.Color.White;
            btnLapBaoCao.Location = new System.Drawing.Point(470, 426);
            btnLapBaoCao.Margin = new Padding(3, 2, 3, 2);
            btnLapBaoCao.Name = "btnLapBaoCao";
            btnLapBaoCao.Size = new System.Drawing.Size(193, 33);
            btnLapBaoCao.TabIndex = 8;
            btnLapBaoCao.Text = "Lập Báo Cáo";
            btnLapBaoCao.UseVisualStyleBackColor = false;
            btnLapBaoCao.Click += btnLapBaoCao_Click;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new System.Drawing.Size(12, 35);
            // 
            // frmMain
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = System.Drawing.Color.White;
            ClientSize = new System.Drawing.Size(789, 489);
            Controls.Add(btnLapBaoCao);
            Controls.Add(btnLapHoaDon);
            Controls.Add(btnQLThuoc);
            Controls.Add(btnQLKhamBenh);
            Controls.Add(picLapHoaDon);
            Controls.Add(picQLThuoc);
            Controls.Add(picLapBaoCao);
            Controls.Add(picQLKhamBenh);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            Name = "frmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Trang Chủ";
            Load += frmMain_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picQLKhamBenh).EndInit();
            ((System.ComponentModel.ISupportInitialize)picLapBaoCao).EndInit();
            ((System.ComponentModel.ISupportInitialize)picQLThuoc).EndInit();
            ((System.ComponentModel.ISupportInitialize)picLapHoaDon).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem tipQLKhamBenh;
        private ToolStripMenuItem thêmBệnhNhânToolStripMenuItem;
        private ToolStripMenuItem lậpPhiếuKhámBệnhToolStripMenuItem;
        private ToolStripMenuItem traCứuBệnhNhânToolStripMenuItem;
        private ToolStripMenuItem tipQLThuoc;
        private ToolStripMenuItem lậpPhiếuNhậpThuốcToolStripMenuItem;
        private ToolStripMenuItem xemThôngTinThuốcToolStripMenuItem;
        private ToolStripMenuItem tipLapHoaDon;
        private ToolStripMenuItem tipLapBaoCao;
        private ToolStripMenuItem tipAdmin;
        private ToolStripMenuItem tipTaiKhoan;
        private ToolStripMenuItem lậpBáoCáoDoanhThuThángToolStripMenuItem;
        private ToolStripMenuItem lậpBáoCáoSửDụngThuốcToolStripMenuItem;
        private ToolStripMenuItem thayĐổiThôngTinToolStripMenuItem;
        private ToolStripMenuItem tipItemDangXuat;
        private ToolStripMenuItem tipItemThoat;
        private PictureBox picQLKhamBenh;
        private PictureBox picLapBaoCao;
        private PictureBox picLapHoaDon;
        private Button btnQLKhamBenh;
        private Button btnQLThuoc;
        private Button btnLapHoaDon;
        private Button btnLapBaoCao;
        public PictureBox picQLThuoc;
        private ToolStripMenuItem thôngTinLoạiBệnhToolStripMenuItem;
        private ToolStripMenuItem xemThôngTinĐơnVịToolStripMenuItem;
        private ToolStripMenuItem xemThôngTinCáchDùngToolStripMenuItem;
        private ToolStripMenuItem quảnLýTàiKhoảnToolStripMenuItem;
        private ToolStripMenuItem thayĐổiQuyĐịnhToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem1;
    }
}