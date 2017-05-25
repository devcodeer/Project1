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
            lookUpEditTk.Properties.DataSource = TaiKhoan_BUS.loadListTaiKhoanVaTienMat();
            lookUpEditTk.Properties.DisplayMember = "MaTk";
            lookUpEditTk.Properties.ValueMember = "MaTk";
        }
     

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public int check;
        private void btnDongY_Click(object sender, EventArgs e)
        {
            try
            {
                if (check == 1)
                {
                    BaoCao.SoQuy.rptSoQuy rpt = new BaoCao.SoQuy.rptSoQuy();
                    string matk = lookUpEditTk.GetColumnValue("MaTk").ToString();
                    DateTime ngaybd = deNgayBatDau.DateTime;
                    DateTime ngaykt = deNgayKetThuc.DateTime;
                    rpt.ltlTenTk.Text = "Tài khoản:  " + matk + " - " + lookUpEditTk.GetColumnValue("TenTk").ToString();
                    rpt.ltlTen.Text = "Sổ Cái";
                    rpt.parameterNgayBd.Value = ngaybd;
                    rpt.parameterNgayBd.Visible = false;
                    rpt.parameterNgayKt.Value = ngaykt;
                    rpt.parameterNgayKt.Visible = false;
                    rpt.DataSource = BaoCao_BUS.SoCai(matk, ngaybd, ngaykt);
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
                }
               
                if (check == 2)
                {
                    DataTable dt1 = ChungTu_BUS.SELECT_PC(deNgayBatDau.Text.ToString(), deNgayKetThuc.Text.ToString());
                    decimal sotien = 0;
                    decimal sotiennt = 0;
                    try
                    {
                        sotien = decimal.Parse(dt1.Rows[0]["SoTien"].ToString());
                        sotiennt = decimal.Parse(dt1.Rows[0]["SoTienNt"].ToString());

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    };
                    string tentien = dt1.Rows[0]["MaTien"].ToString();
                    string nguoigd = dt1.Rows[0]["NguoiGd"].ToString();
                    string tendt = dt1.Rows[0]["TenDt"].ToString();
                    if (tendt != "")
                    {
                        nguoigd = nguoigd + " - " + tendt;
                    }
                    string tkno = "";
                    string tkco = "";
                    BaoCao.PhieuThuChi.rptPHIEUTHU rpt = new BaoCao.PhieuThuChi.rptPHIEUTHU();

                    DataSet ds = new DataSet();
                    ds.Tables.Add(dt1);
                    string tienchu = Function.Funtion.DecimalToString(sotien);
                    tienchu = tienchu + " đồng chẵn";

                    rpt.DataSource = ds;
                    rpt.DataMember = "Table";
                    //if (maphieu == 1)
                    //{
                    //    rpt.lblTenPhieu.Text = "PHIẾU THU";
                    //    rpt.lblTenNguoiGd.Text = "Họ và tên người nộp tiền:";
                    //    rpt.lblNguoigd.Text = "Người nộp tiền";

                    //}
                    //else if (maphieu == 2)
                    //{
                        rpt.lblTenPhieu.Text = "PHIẾU CHI";
                        rpt.lblTenNguoiGd.Text = "Họ và tên người nhận tiền:";
                        rpt.lblNguoigd.Text = "Người nhận tiền";
                    //}
                    rpt.parameterTenDt.Value = nguoigd;
                    rpt.parameterTenDt.Visible = false;
                    rpt.TienChu.Value = tienchu;
                    rpt.TienChu.Visible = false;
                    rpt.TkNo.Value = tkno;
                    rpt.TkNo.Visible = false;
                    rpt.TkCo.Value = tkco;
                    rpt.TkCo.Visible = false;
                    rpt.CreateLayoutViewDocument();

                    // //-- Trong: 21-May-2017 ---// //
                    // block code print report //
                    using (DevExpress.XtraReports.UI.ReportPrintTool printTool = new DevExpress.XtraReports.UI.ReportPrintTool(rpt))
                    {
                        // Invoke the Ribbon Print Preview form modally, 
                        // and load the report document into it.
                        printTool.ShowRibbonPreviewDialog();

                        // Invoke the Ribbon Print Preview form
                        // with the specified look and feel setting.
                        // printTool.ShowRibbonPreviewDialog(UserLookAndFeel.Default);
                    }
                }
                if (check == 3)
                {
                    DataTable dt1 = ChungTu_BUS.SELECT_PT(deNgayBatDau.Text.ToString(), deNgayKetThuc.Text.ToString());
                    decimal sotien = 0;
                    decimal sotiennt = 0;
                    try
                    {
                        sotien = decimal.Parse(dt1.Rows[0]["SoTien"].ToString());
                        sotiennt = decimal.Parse(dt1.Rows[0]["SoTienNt"].ToString());

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    };
                    string tentien = dt1.Rows[0]["MaTien"].ToString();
                    string nguoigd = dt1.Rows[0]["NguoiGd"].ToString();
                    string tendt = dt1.Rows[0]["TenDt"].ToString();
                    if (tendt != "")
                    {
                        nguoigd = nguoigd + " - " + tendt;
                    }
                    string tkno = "";
                    string tkco = "";
                    BaoCao.PhieuThuChi.rptPHIEUTHU rpt = new BaoCao.PhieuThuChi.rptPHIEUTHU();

                    DataSet ds = new DataSet();
                    ds.Tables.Add(dt1);
                    string tienchu = Function.Funtion.DecimalToString(sotien);
                    tienchu = tienchu + " đồng chẵn";

                    rpt.DataSource = ds;
                    rpt.DataMember = "Table";
                    //if (maphieu == 1)
                    //{
                    //    rpt.lblTenPhieu.Text = "PHIẾU THU";
                    //    rpt.lblTenNguoiGd.Text = "Họ và tên người nộp tiền:";
                    //    rpt.lblNguoigd.Text = "Người nộp tiền";

                    //}
                    //else if (maphieu == 2)
                    //{
                    rpt.lblTenPhieu.Text = "PHIẾU THU";
                    rpt.lblTenNguoiGd.Text = "Họ và tên người nhận tiền:";
                    rpt.lblNguoigd.Text = "Người nhận tiền";
                    //}
                    rpt.parameterTenDt.Value = nguoigd;
                    rpt.parameterTenDt.Visible = false;
                    rpt.TienChu.Value = tienchu;
                    rpt.TienChu.Visible = false;
                    rpt.TkNo.Value = tkno;
                    rpt.TkNo.Visible = false;
                    rpt.TkCo.Value = tkco;
                    rpt.TkCo.Visible = false;
                    rpt.CreateLayoutViewDocument();

                    // //-- Trong: 21-May-2017 ---// //
                    // block code print report //
                    using (DevExpress.XtraReports.UI.ReportPrintTool printTool = new DevExpress.XtraReports.UI.ReportPrintTool(rpt))
                    {
                        // Invoke the Ribbon Print Preview form modally, 
                        // and load the report document into it.
                        printTool.ShowRibbonPreviewDialog();

                        // Invoke the Ribbon Print Preview form
                        // with the specified look and feel setting.
                        // printTool.ShowRibbonPreviewDialog(UserLookAndFeel.Default);
                    }
                }
                if(check ==4)
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
                    rpt.DataSource = BaoCao_BUS.SoQuy(matk, ngaybd, ngaykt);
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
                }
              

            //    rpt.ShowPreview();

            }
            catch
            {
                MessageBox.Show("Kiểm tra lại tham số báo cáo !");
            }
        }

     
    }
}
