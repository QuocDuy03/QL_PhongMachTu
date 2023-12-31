﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_PhongMachTu
{
    public partial class frmMenuQuanLyThuoc : Form
    {
        public frmMenuQuanLyThuoc()
        {
            InitializeComponent();
            this.ControlBox = false;
        }
        private void frmMenuQuanLyThuoc_Load(object sender, EventArgs e)
        {
            // khi load form tùy loại người dùng để ẩn hiện các chức năng 
            // user thường không được dùng chức năng Lập Phiếu Nhập Thuốc
            if (TaiKhoan.loaiTaiKhoan == 2)
            {
               
                button1.Enabled = false;
                button1.ForeColor = Color.White;
                button1.BackColor = Color.LightSlateGray;
            }
           
        }
        private void button2_Click(object sender, EventArgs e)
        {
            frmQuanLyThuoc QuanLyThuoc = new frmQuanLyThuoc();
            QuanLyThuoc.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmQuanLyDonVi QLDonVi = new frmQuanLyDonVi();
            QLDonVi.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmQuanLyCachDung QLCachDung = new frmQuanLyCachDung();
            QLCachDung.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmLapPhieuNhapThuoc fLapPhieuNhapThuoc = new frmLapPhieuNhapThuoc();
            fLapPhieuNhapThuoc.Show();
            this.Close();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            frmMain fMain = new frmMain();
            fMain.Show();
            this.Close();
        }

       
    }
}
