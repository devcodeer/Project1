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
    public partial class FrmEditDanhMucNhanVien : Form
    {
        public FrmEditDanhMucNhanVien()
        {
            InitializeComponent();
        }

        private void FrmEditDanhMucNhanVien_Load(object sender, EventArgs e)
        {
            LoadlookUpEditPhongBan();
            if (lc.LuaChon == "Edit")
            {
                TruyenDuLieu(obj);
                btnLuuVaMoi.Enabled = false;
            }
        }
        private void btnDong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
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
                    MessageBox.Show("Thêm mới không thành công !");
                }
            }
            else if (lc.LuaChon == "Edit")
            {
                try
                {
                    Sua();
                    this.Close();
                }
                catch
                {
                    MessageBox.Show("Sửa không thành công ! ");
                }

            
            }
        }

        private void btnLuuVaMoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                ThemMoi();
                ResetControl();
                txtManv.Focus();
            }
            catch
            {
                MessageBox.Show("Thêm mới không thành công ");
            }
        }

        private void LoadlookUpEditPhongBan()
        {
            lookUpEditPhongBan.Properties.DataSource = PhongBan_BUS.LoadDanhSachPhongBan();
            lookUpEditPhongBan.Properties.DisplayMember="TenPb";
            lookUpEditPhongBan.Properties.ValueMember="MaPb";
        }

        private void ThemMoi()
        { 
            string manv = txtManv.Text;
            string tennv = txtTennv.Text;
            string mapb = lookUpEditPhongBan.GetColumnValue("MaPb").ToString();
            string chucvu = txtChucvu.Text;
            string diachi = txtDiachi.Text;
            string email = txtEmail.Text;
            string dienthoai = txtDienthoai.Text;
            NhanVien_DTO nv = new NhanVien_DTO(manv,tennv,diachi,dienthoai,email,mapb,chucvu);
            NhanVien_BUS.ThemMoiNhanVien(nv);

        }

        private void Sua()
        {
            string manv = txtManv.Text;
            string tennv = txtTennv.Text;
            string mapb = lookUpEditPhongBan.GetColumnValue("MaPb").ToString();
            string chucvu = txtChucvu.Text;
            string diachi = txtDiachi.Text;
            string email = txtEmail.Text;
            string dienthoai = txtDienthoai.Text;
            NhanVien_DTO nhanvien = new NhanVien_DTO(manv, tennv, diachi, dienthoai, email, mapb, chucvu);
            NhanVien_BUS.SuaNhanVien(obj.MaNv, nhanvien);

        }
              
        private void ResetControl()
        {
            txtManv.Text="";
            txtTennv.Text="";
            txtChucvu.Text="";
            txtDiachi.Text="";
            txtDienthoai.Text="";
            txtEmail.Text="";
        }

        public LuaChon_DTO lc = new LuaChon_DTO();
        public NhanVien_DTO obj = new NhanVien_DTO();
        private void TruyenDuLieu( NhanVien_DTO nv)
        {
            txtManv.Text = nv.MaNv;
            txtTennv.Text = nv.TenNv;
            lookUpEditPhongBan.Text = nv.MaPb;
            txtDiachi.Text = nv.DiaChi;
            txtDienthoai.Text = nv.DienThoai;
            txtEmail.Text = nv.Email;
            txtChucvu.Text = nv.ChucVu;

        }
    }
}
