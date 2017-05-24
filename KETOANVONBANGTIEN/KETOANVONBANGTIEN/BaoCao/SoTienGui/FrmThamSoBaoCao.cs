using System;
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
                using (DevExpress.XtraReports.UI.ReportPrintTool printTool = new DevExpress.XtraReports.UI.ReportPrintTool(rpt))
                {
                    // Invoke the Ribbon Print Preview form modally, 
                    // and load the report document into it.
                    printTool.ShowRibbonPreviewDialog();

                    // Invoke the Ribbon Print Preview form
                    // with the specified look and feel setting.
                    // printTool.ShowRibbonPreviewDialog(UserLookAndFeel.Default);
                }
              //  rpt.ShowPreview();

            }
            catch
            {
                MessageBox.Show("Kiểm tra lại ngày báo cáo !");
            }
        }

        private void FrmThamSoBaoCao_Load(object sender, EventArgs e)
        {
            lookUpEditTk.Properties.DataSource = TaiKhoan_BUS.loadTaiKhoanTienGui();
            lookUpEditTk.Properties.DisplayMember = "MaTk";
            lookUpEditTk.Properties.ValueMember = "MaTk";
        }
    }
}
