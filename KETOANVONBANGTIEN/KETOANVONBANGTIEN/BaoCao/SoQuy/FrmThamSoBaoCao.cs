using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BUS;

namespace KETOANVONBANGTIEN.BaoCao.SoQuy
{
    public partial class FrmThamSoBaoCao : Form
    {
        public FrmThamSoBaoCao()
        {
            InitializeComponent();
        }

        private void FrmThamSoBaoCao_Load(object sender, EventArgs e)
        {
            lookUpEditTk.Properties.DataSource = TaiKhoan_BUS.LoadTkTienMat();
            lookUpEditTk.Properties.DisplayMember = "MaTk";
            lookUpEditTk.Properties.ValueMember = "MaTk";
        }
     

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDongY_Click(object sender, EventArgs e)
        {
            try
            {
                BaoCao.SoQuy.rptSoQuy rpt = new BaoCao.SoQuy.rptSoQuy();
                string matk = lookUpEditTk.GetColumnValue("MaTk").ToString();
                DateTime ngaybd = deNgayBatDau.DateTime;
                DateTime ngaykt = deNgayKetThuc.DateTime;
                rpt.ltlTenTk.Text = "Tài khoản:  " + matk + " - " + lookUpEditTk.GetColumnValue("TenTk").ToString();
                rpt.parameterNgayBd.Value = ngaybd;
                rpt.parameterNgayBd.Visible = false;
                rpt.parameterNgayKt.Value = ngaykt;
                rpt.parameterNgayKt.Visible = false;
                rpt.DataSource = BaoCao_BUS.SoQuy(matk,ngaybd, ngaykt);
                rpt.DataMember = "Table";
                rpt.ShowPreview();

            }
            catch
            {
                MessageBox.Show("Kiểm tra lại tham số báo cáo !");
            }
        }

     
    }
}
