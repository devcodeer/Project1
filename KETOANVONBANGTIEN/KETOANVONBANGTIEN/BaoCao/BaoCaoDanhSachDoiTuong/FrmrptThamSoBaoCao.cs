using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BUS;

namespace KETOANVONBANGTIEN.BaoCao.DanhSachDoiTuong
{
    public partial class FrmrptThamSoBaoCao : Form
    {
        public FrmrptThamSoBaoCao()
        {
            InitializeComponent();
        }

        private void FrmThamSoBaoCao_Load(object sender, EventArgs e)
        {
            LoadLookUpEdit();
        }
        private void LoadLookUpEdit()
        {
            DataTable dt = NhomDoiTuong_BUS.loadDanhSachNhomDoiTuong();

            dt.Rows.Add("All", "Tất cả đối tượng");
            lookUpEditNhomDt.Properties.DataSource = dt;
            lookUpEditNhomDt.Properties.DisplayMember = "TenNhom";
            lookUpEditNhomDt.Properties.ValueMember = "MaNhom";

            
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            try
            {
                
                string manhom = lookUpEditNhomDt.GetColumnValue("MaNhom").ToString();
                string tennhom = lookUpEditNhomDt.GetColumnValue("TenNhom").ToString();
                

                BaoCao.DanhSachDoiTuong.rptDanhSachDoiTuong rpt = new BaoCao.DanhSachDoiTuong.rptDanhSachDoiTuong();
                if (manhom == "All")
                {
                    rpt.DataSource = DoiTuong_BUS.loadListObjects();
                    rpt.luachon.LuaChon = "đối tượng";
                }
                else
                {
                    rpt.DataSource = DoiTuong_BUS.loadListCustomerOrProvider(manhom);
                    rpt.luachon.LuaChon = tennhom;
                }
                rpt.BindData();
             //   rpt.ShowPreview(); ;
            }
            catch
            {
                MessageBox.Show("Bạn chưa chọn tham số để in !");
            }
        }
    }
}
