using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DTO;
using BUS;
namespace KETOANVONBANGTIEN.DanhMuc
{
    public partial class FrmEditDanhMucTaiKhoanNganHang : Form
    {
        public FrmEditDanhMucTaiKhoanNganHang()
        {
            InitializeComponent();
        }

        private void FrmEditDanhMucTaiKhoanNganHang_Load(object sender, EventArgs e)
        {
            loadlookUpEditNganHang();
            if (lc.LuaChon == "Edit")
            {
                TruyenDuLieu(obj);
                btnLuuVaMoi.Enabled = false;
            }
        }

        private void loadlookUpEditNganHang()
        {
            lookUpEditNganHang.Properties.DataSource = NganHang_BUS.LoadDanhSachNganHang();
            lookUpEditNganHang.Properties.DisplayMember = "MaNh";
            lookUpEditNganHang.Properties.ValueMember = "MaNh";
        }

        private void btnLuuVaDong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (lc.LuaChon == "Add")
            {
                try
                {
                    ThemMoi();
                    this.Close();
                }
                catch
                {
                    MessageBox.Show("Thêm mới không thành công ");
                }
            }

            else if (lc.LuaChon=="Edit")
            {
                      try
                {
                    Sua();
                    this.Close();
                }
                catch
                {
                    MessageBox.Show("Sửa không thành công ");
                }
            
            }
        }

        private void btnLuuVaMoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                ThemMoi();
                ResetControl();
                txtSotknh.Focus();
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

        private void ThemMoi()
        {
            string sotknh = txtSotknh.Text;
            string tentknh = txtTentknh.Text;
            string chinhanh = txtChiNhanh.Text;
            string manh = lookUpEditNganHang.GetColumnValue("MaNh").ToString();
            TaiKhoanNganHang_DTO obj = new TaiKhoanNganHang_DTO(sotknh, tentknh, manh, chinhanh);
            TaiKhoanNganHang_BUS.Them1TaiKhoanNganHang(obj);
        }

        private void Sua()
        {
            string sotknh = txtSotknh.Text;
            string tentknh = txtTentknh.Text;
            string chinhanh = txtChiNhanh.Text;
            string manh = lookUpEditNganHang.GetColumnValue("MaNh").ToString();
            TaiKhoanNganHang_DTO tknh = new TaiKhoanNganHang_DTO(sotknh, tentknh, manh, chinhanh);
            TaiKhoanNganHang_BUS.Sua1TaiKhoanNganHang(obj.SoTknh, tknh);
        }

        private void ResetControl()
        {
            txtSotknh.Text = "";
            txtTentknh.Text = "";
            txtChiNhanh.Text = "";
            lookUpEditNganHang.Text = "";
        }

        public LuaChon_DTO lc = new LuaChon_DTO();
        public TaiKhoanNganHang_DTO obj = new TaiKhoanNganHang_DTO();

        private void TruyenDuLieu(TaiKhoanNganHang_DTO tk)
        {
            txtSotknh.Text = tk.SoTknh;
            txtTentknh.Text = tk.TenTknh;
            txtChiNhanh.Text = tk.ChiNhanh;
            lookUpEditNganHang.Text = tk.MaNh;

        }

        private void lookUpEditNganHang_EditValueChanged(object sender, EventArgs e)
        {

        }

       
    }
}
