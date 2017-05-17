using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using DTO;
namespace KETOANVONBANGTIEN.BaoCao.DanhSachDoiTuong
{
    public partial class rptDanhSachDoiTuong : DevExpress.XtraReports.UI.XtraReport
    {
        public rptDanhSachDoiTuong()
        {
            InitializeComponent();
            
        }
        public void BindData()
        {
            

            MaDt.DataBindings.Add("Text", DataSource, "Ma");
            TenDt.DataBindings.Add("Text", DataSource, "Ten");
            DiaChi.DataBindings.Add("Text", DataSource, "DiaChi");
            DienThoai.DataBindings.Add("Text", DataSource, "DienThoai");
        }
        int STT ;
 

        private void Detail_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            STT++;
            Stt.Text = STT.ToString();
            
        }

        public LuaChon_DTO luachon = new LuaChon_DTO();

        private void GroupHeader1_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            lblDanhSachDoiTuong.Text = "Danh sách "+ luachon.LuaChon;
        }
        


    }
}
