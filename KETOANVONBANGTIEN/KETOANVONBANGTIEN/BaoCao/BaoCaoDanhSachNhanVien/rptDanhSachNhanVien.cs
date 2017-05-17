using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using DTO;

namespace KETOANVONBANGTIEN.BaoCao.BaoCaoDanhSachNhanVien
{
    public partial class rptDanhSachNhanVien : DevExpress.XtraReports.UI.XtraReport
    {
        public rptDanhSachNhanVien()
        {
            InitializeComponent();
        }
        public void BindData()
        {
            Ma.DataBindings.Add("Text", DataSource, "Ma");
            Ten.DataBindings.Add("Text", DataSource, "Ten");
            TenPb.DataBindings.Add("Text", DataSource, "TenPb");
            ChucVu.DataBindings.Add("Text", DataSource, "ChucVu");
            DienThoai.DataBindings.Add("Text", DataSource, "DienThoai");

        }
        int STT;

        private void Detail_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {

            STT++;
            Stt.Text = STT.ToString();
        }
        public LuaChon_DTO luachon = new LuaChon_DTO();

        private void GroupHeader1_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            lblDanhSachNhanVien.Text = "Danh sách " + luachon.LuaChon;
        }
    }
}
