﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace App
{
    public partial class frmHome : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-2PT5DI6;Initial Catalog=PROJECT;Integrated Security=True");

        public frmHome()
        {
            InitializeComponent();
        }

        private void mnuLogOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLogin login = new frmLogin();
            login.ShowDialog();
            this.Close();

        }
        private void mnuKhachHang_Click(object sender, EventArgs e)
        {
            frmTableKhachHang tableKhachHang = new frmTableKhachHang();
            tableKhachHang.ShowDialog();

        }

        private void mnuNhanVien_Click(object sender, EventArgs e)
        {
            frmTableNhanSu tableNhanSu = new frmTableNhanSu();
            tableNhanSu.ShowDialog();
        }

        private void frmHome_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show("Do you want to close?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void mnuDanhsachDonHang_Click(object sender, EventArgs e)
        {
            frmTableDonHang tableDonHang = new frmTableDonHang();
            tableDonHang.ShowDialog();

        }

        private void mnuNewDonHang_Click(object sender, EventArgs e)
        {
            frmChanceDonHang chanceDonHang = new frmChanceDonHang();
            chanceDonHang.Text = "Đơn hàng mới";
            chanceDonHang.ShowDialog();
        }

        private void mnuPhongBan_Click(object sender, EventArgs e)
        {
            frmTable_PhongBan chancePhongBan = new frmTable_PhongBan();
            chancePhongBan.ShowDialog();
        }
    }
}
