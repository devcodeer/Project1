using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BUS;

namespace KETOANVONBANGTIEN.BaoCao.BaoCaoDanhSachNhanVien
{
    public partial class FrmThamSoBaoCao : Form
    {
        public FrmThamSoBaoCao()
        {
            InitializeComponent();
        }

        private void FrmThamSoBaoCao_Load(object sender, EventArgs e)
        {
            DataTable dt = PhongBan_BUS.loadListDepartment();
            dt.Rows.Add("All", "Tất cả phòng ban");
            lookUpEditPhongBan.Properties.DataSource = dt;
            lookUpEditPhongBan.Properties.DisplayMember = ("TenPb");
            lookUpEditPhongBan.Properties.ValueMember = ("MaPb");
        }
        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDongy_Click(object sender, EventArgs e)
        {
            try
            {
                
                string mapb = lookUpEditPhongBan.GetColumnValue("MaPb").ToString();
                string tenpb = lookUpEditPhongBan.GetColumnValue("TenPb").ToString();
                

                rptDanhSachNhanVien rpt = new rptDanhSachNhanVien();
                if (mapb == "All")
                {
                    rpt.DataSource = NhanVien_BUS.loadListEmployee();
                    rpt.luachon.LuaChon = "nhân viên ";
                }
                else
                {
                    rpt.DataSource = NhanVien_BUS.loadEmployeeByDepartmentId(mapb);
                    rpt.luachon.LuaChon = "nhân viên phòng " + tenpb;
                }
                rpt.BindData();
              //  rpt.ShowPreview();
                
            }
            catch
            {
                MessageBox.Show("Bạn chưa chọn tham số để in !");
            }
        }

      
    }
}
