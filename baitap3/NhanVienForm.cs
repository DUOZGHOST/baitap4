﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace baitap4
{
    public partial class NhanVienForm : Form
    {
        public string MSNV { get; set; }
        public string TenNV { get; set; }
        public string LuongCB { get; set; }

        public NhanVienForm()
        {
            InitializeComponent();
        }

        private void NhanVienForm_Load(object sender, EventArgs e)
        {
            txtMa.Text = MSNV;
            txtTen.Text = TenNV;
            txtLuong.Text = LuongCB;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            MSNV = txtMa.Text;
            TenNV = txtTen.Text;
            LuongCB = txtLuong.Text;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
