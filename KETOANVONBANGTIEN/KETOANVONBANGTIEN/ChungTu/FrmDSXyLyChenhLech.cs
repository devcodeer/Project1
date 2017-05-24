using BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KETOANVONBANGTIEN.ChungTu
{
    public partial class FrmDSXyLyChenhLech : Form
    {
        public FrmDSXyLyChenhLech()
        {
            InitializeComponent();
           
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ChungTu.FrmXuLyChenhLechNT frm = new ChungTu.FrmXuLyChenhLechNT();
            frm.lc.LuaChon = "Add";
            frm.ShowDialog();
        }


        private void LoadDanhSach()
        {
            grvDanhSachXuLyChenhLech.DataSource = ChungTu_BUS.getDSXyLyChenhLech();
        }

        private void LoadLookUpEditTkNo_Co()
        {

            repositoryItemLookUpEditTkNo.DataSource = TaiKhoan_BUS.loadListTaiKhoanKeToan();
            repositoryItemLookUpEditTkNo.DisplayMember = "MaTk";
            repositoryItemLookUpEditTkNo.ValueMember = "MaTk";

            repositoryItemLookUpEditTkCo.DataSource = TaiKhoan_BUS.loadListTaiKhoanKeToan();
            repositoryItemLookUpEditTkCo.DisplayMember = "MaTk";
            repositoryItemLookUpEditTkCo.ValueMember = "MaTk";

        }

        private void FrmDSXyLyChenhLech_Load(object sender, EventArgs e)
        {
            LoadDanhSach();
        }

        private void btnIn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //DataTable dt1 = ChungTu_BUS.loadChungTuBySoChungTu(txtSoCt.Text);

            //decimal sotien = 0;
            //decimal sotiennt = 0;
            //try
            //{
            //    sotien = decimal.Parse(dt1.Rows[0]["SoTien"].ToString());
            //    sotiennt = decimal.Parse(dt1.Rows[0]["SoTienNt"].ToString());

            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //};

            //string nguoigd = dt1.Rows[0]["NguoiGd"].ToString();
            //string tendt = dt1.Rows[0]["TenDt"].ToString();
            //if (tendt != "")
            //{
            //    nguoigd = nguoigd + " - " + tendt;
            //}

            //string tkno = "";
            //string tkco = "";
            //int rowcount = GridViewChiTiet.RowCount;

            //for (int i = 0; i < rowcount - 1; i++)
            //{
            //    if (tkno == "")
            //    {
            //        tkno = tkno + GridViewChiTiet.GetRowCellDisplayText(i, colTkNo).ToString();
            //        tkco = tkco + GridViewChiTiet.GetRowCellDisplayText(i, colTkCo).ToString();
            //    }
            //    else
            //    {
            //        tkno = tkno + ", " + GridViewChiTiet.GetRowCellDisplayText(i, colTkNo).ToString();
            //        tkco = tkco + ", " + GridViewChiTiet.GetRowCellDisplayText(i, colTkCo).ToString();
            //    }
            //}

            //string tentien = dt1.Rows[0]["MaTien"].ToString();
            //if (tentien == "VND")
            //{
            //    BaoCao.PhieuThuChi.rptPHIEUTHU rpt = new BaoCao.PhieuThuChi.rptPHIEUTHU();

            //    DataSet ds = new DataSet();
            //    ds.Tables.Add(dt1);
            //    string tienchu = Function.Funtion.DecimalToString(sotien);
            //    tienchu = tienchu + " đồng chẵn";

            //    rpt.DataSource = ds;
            //    rpt.DataMember = "Table";
            //    if (maphieu == 1)
            //    {
            //        rpt.lblTenPhieu.Text = "PHIẾU THU";
            //        rpt.lblTenNguoiGd.Text = "Họ và tên người nộp tiền:";
            //        rpt.lblNguoigd.Text = "Người nộp tiền";

            //    }
            //    else if (maphieu == 2)
            //    {
            //        rpt.lblTenPhieu.Text = "PHIẾU CHI";
            //        rpt.lblTenNguoiGd.Text = "Họ và tên người nhận tiền:";
            //        rpt.lblNguoigd.Text = "Người nhận tiền";
            //    }
            //    rpt.parameterTenDt.Value = nguoigd;
            //    rpt.parameterTenDt.Visible = false;
            //    rpt.TienChu.Value = tienchu;
            //    rpt.TienChu.Visible = false;
            //    rpt.TkNo.Value = tkno;
            //    rpt.TkNo.Visible = false;
            //    rpt.TkCo.Value = tkco;
            //    rpt.TkCo.Visible = false;
            //    rpt.CreateLayoutViewDocument();

            //    // //-- Trong: 21-May-2017 ---// //
            //    // block code print report //
            //    using (DevExpress.XtraReports.UI.ReportPrintTool printTool = new DevExpress.XtraReports.UI.ReportPrintTool(rpt))
            //    {
            //        // Invoke the Ribbon Print Preview form modally, 
            //        // and load the report document into it.
            //        printTool.ShowRibbonPreviewDialog();

            //        // Invoke the Ribbon Print Preview form
            //        // with the specified look and feel setting.
            //        // printTool.ShowRibbonPreviewDialog(UserLookAndFeel.Default);
            //    }
            //}

            //else if (tentien == "USD")
            //{
            //    BaoCao.PhieuThuChi.RptPhieuThuChiNt rpt1 = new BaoCao.PhieuThuChi.RptPhieuThuChiNt();
            //    DataSet ds = new DataSet();
            //    ds.Tables.Add(dt1);
            //    string tienchu = Function.Funtion.DecimalToString(sotiennt);
            //    tienchu = tienchu + " đô la Mỹ";

            //    rpt1.DataSource = ds;
            //    rpt1.DataMember = "Table";
            //    if (maphieu == 1)
            //    {
            //        rpt1.lblTenPhieu.Text = "PHIẾU THU";
            //        rpt1.lblTenNguoiGd.Text = "Họ và tên người nộp tiền:";
            //        rpt1.lblNguoigd.Text = "Người nộp tiền";

            //    }
            //    else if (maphieu == 2)
            //    {
            //        rpt1.lblTenPhieu.Text = "PHIẾU CHI";
            //        rpt1.lblTenNguoiGd.Text = "Họ và tên người nhận tiền:";
            //        rpt1.lblNguoigd.Text = "Người nhận tiền";
            //    }
            //    rpt1.parameterTenDt.Value = nguoigd;
            //    rpt1.parameterTenDt.Visible = false;
            //    rpt1.TienChu.Value = tienchu;
            //    rpt1.TienChu.Visible = false;
            //    rpt1.TkNo.Value = tkno;
            //    rpt1.TkNo.Visible = false;
            //    rpt1.TkCo.Value = tkco;
            //    rpt1.TkCo.Visible = false;

            //    using (DevExpress.XtraReports.UI.ReportPrintTool printTool = new DevExpress.XtraReports.UI.ReportPrintTool(rpt1))
            //    {
            //        // Invoke the Ribbon Print Preview form modally, 
            //        // and load the report document into it.
            //        printTool.ShowRibbonPreviewDialog();

            //        // Invoke the Ribbon Print Preview form
            //        // with the specified look and feel setting.
            //        // printTool.ShowRibbonPreviewDialog(UserLookAndFeel.Default);
            //    }
            //    //rpt1.ShowPrintStatusDialog();
            //    //rpt1.CreateLayoutViewDocument();
            //}
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ChungTu.FrmXuLyChenhLechNT frm = new ChungTu.FrmXuLyChenhLechNT();
            frm.lc.LuaChon = "Edit";
            frm.ShowDialog();
        }
    }
}
