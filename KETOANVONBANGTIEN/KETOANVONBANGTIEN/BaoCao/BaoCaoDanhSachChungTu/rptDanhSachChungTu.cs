using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using DTO;

namespace KETOANVONBANGTIEN.BaoCao.BaoCaoDanhSachChungTu
{
    public partial class rptDanhSachChungTu : DevExpress.XtraReports.UI.XtraReport
    {
        public rptDanhSachChungTu()
        {
            InitializeComponent();
        }
     
        int STT;
        public LuaChon_DTO loaidanhsach = new LuaChon_DTO();
        private void GroupHeader1_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            if (loaidanhsach.LuaChon == "1")
            {
                lbtTenDanhSach.Text = "Danh sách phiếu thu";
            }
            if (loaidanhsach.LuaChon == "2")
            {
                lbtTenDanhSach.Text = "Danh sách phiếu chi";
            }
            if (loaidanhsach.LuaChon == "3")
            {
                lbtTenDanhSach.Text = "Danh sách giấy báo nợ";
            }
            if (loaidanhsach.LuaChon == "4")
            {
                lbtTenDanhSach.Text = "Danh sách giấy báo có";
            }
        }

        private void Detail_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            STT++;
            Stt.Text = STT.ToString();
        }

     
    }
}
