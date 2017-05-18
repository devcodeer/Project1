using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BUS;
using DTO;
namespace KETOANVONBANGTIEN.DanhMuc
{
    public partial class FrmEditDanhMucNganHang : Form
    {
        public FrmEditDanhMucNganHang()
        {
            InitializeComponent();
        }

        private void FrmEditDanhMucNganHang_Load(object sender, EventArgs e)
        {
            if (lc.LuaChon == "Edit")
            {
                TruyenDuLieu(obj);
                btnLuuVaMoi.Enabled = false;
            }
        }

        private void btnLuuVaDong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (lc.LuaChon == "Add")
            {
                try
                {
                    ThemMoiNganHang();
                    this.Close();
                }
                catch
                {
                    MessageBox.Show("Thêm mới không thành công !");
                }
            }

            else if (lc.LuaChon == "Edit")
            {
                try
                {
                    EditNganHang();
                    this.Close();
                }
                catch
                {
                    MessageBox.Show("Sửa không thành công !");
                }
            }
        }

        private void btnLuuVaMoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                ThemMoiNganHang();
                ResetControl();
            }
            catch
            {
                MessageBox.Show("Thêm mới không thành công ");
            }
        } 

        private void btnDong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void ThemMoiNganHang()
        {
            string manh =  txtMaNh.Text;
            string tennh = txtTenNh.Text;
            NganHang_DTO obj = new NganHang_DTO(manh, tennh);
            NganHang_BUS.insertBank(obj);
        }

        private void EditNganHang()
        {
            string manh = txtMaNh.Text;
            string tennh = txtTenNh.Text;
            NganHang_DTO obj1 = new NganHang_DTO(manh, tennh);
            NganHang_BUS.updateBank(obj.MaNh, obj1);
        }

        private void ResetControl()
        {
            txtMaNh.Text="";
            txtTenNh.Text="";
        }

        public LuaChon_DTO lc = new LuaChon_DTO();
        public NganHang_DTO obj = new NganHang_DTO();
        private void TruyenDuLieu(NganHang_DTO nh)
        {
            txtMaNh.Text = nh.MaNh;
            txtTenNh.Text = nh.TenNh;

        }

       
    }
}
