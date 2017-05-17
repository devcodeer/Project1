﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BUS;

namespace KETOANVONBANGTIEN.BaoCao.SoTienGui
{
    public partial class FrmThamSoBaoCao : Form
    {
        public FrmThamSoBaoCao()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDongY_Click(object sender, EventArgs e)
        {
            try
            {
                BaoCao.SoTienGui.rptSoTienGuiNganHang rpt = new rptSoTienGuiNganHang();


                DateTime ngaybd = deNgayBatDau.DateTime;
                DateTime ngaykt = deNgayKetThuc.DateTime;
                string matk = lookUpEditTk.GetColumnValue("MaTk").ToString();
                rpt.lblTenTk.Text = "Tài khoản:  " + matk + " - " + lookUpEditTk.GetColumnValue("TenTk").ToString();
                rpt.parameterNgayBd.Value = ngaybd;
                rpt.parameterNgayBd.Value = ngaybd;
                rpt.parameterNgayBd.Visible = false;
                rpt.parameterNgayKt.Value = ngaykt;
                rpt.parameterNgayKt.Visible = false;
                rpt.DataSource = BaoCao_BUS.SoTienGui(matk,ngaybd, ngaykt);
                rpt.DataMember = "Table";
                rpt.ShowPreview();

            }
            catch
            {
                MessageBox.Show("Kiểm tra lại ngày báo cáo !");
            }
        }

        private void FrmThamSoBaoCao_Load(object sender, EventArgs e)
        {
            lookUpEditTk.Properties.DataSource = TaiKhoan_BUS.LoadTkTienGui();
            lookUpEditTk.Properties.DisplayMember = "MaTk";
            lookUpEditTk.Properties.ValueMember = "MaTk";
        }
    }
}