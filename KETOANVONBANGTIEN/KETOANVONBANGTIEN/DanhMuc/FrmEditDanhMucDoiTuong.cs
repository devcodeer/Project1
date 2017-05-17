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
    public partial class FrmEditDanhMucDoiTuong : Form
    {
        public FrmEditDanhMucDoiTuong()
        {
            InitializeComponent();
        }

        private void FrmEditDanhMucDoiTuong_Load(object sender, EventArgs e)
        {

            LoadlookUpEditNhomDt();
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
                    MessageBox.Show("Sửa không thành công !");
                }
            }
        } 

        private void btnLuuVaMoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
                try
                {
                    ThemMoi();                    
                    ResetControl();
                    txtMaDt.Focus();
                }
                catch
                {
                    MessageBox.Show("Thêm mới không thành công !");
                }
           

           
        }

        private void LoadlookUpEditNhomDt()
        {
            lookUpEditNhomDt.Properties.DataSource = NhomDt_BUS.LoadDanhSachNhomDt();
            lookUpEditNhomDt.Properties.DisplayMember = "TenNhom";
            lookUpEditNhomDt.Properties.ValueMember = "MaNhom";


        }
        private void ThemMoi()
        {
            string madt = txtMaDt.Text;
            string tendt = txtTenDt.Text;
            string manhom = lookUpEditNhomDt.GetColumnValue("MaNhom").ToString();
            string diachi = txtDiaChi.Text;
            string dienthoai = txtDienThoai.Text;
            string email = txtEmail.Text;
            string mst = txtMst.Text;
            string sotknh = txtSoTknh.Text;
            string tennh = txtTenNh.Text;
            string chinhanh = txtChiNhanh.Text;
            DoiTuong_DTO obj = new DoiTuong_DTO(madt, tendt, diachi, email, dienthoai, mst, sotknh, tennh, chinhanh, manhom);
            DoiTuong_BUS.Them1DoiTuong(obj);

        }
        private void Sua()
        {
            string madt1 = txtMaDt.Text;
            string tendt1 = txtTenDt.Text;
            string manhom1 = lookUpEditNhomDt.GetColumnValue("MaNhom").ToString();
            string diachi1 = txtDiaChi.Text;
            string dienthoai1 = txtDienThoai.Text;
            string email1 = txtEmail.Text;
            string mst1 = txtMst.Text;
            string sotknh1 = txtSoTknh.Text;
            string tennh1 = txtTenNh.Text;
            string chinhanh1 = txtChiNhanh.Text;
            DoiTuong_DTO obj1 = new DoiTuong_DTO(madt1, tendt1, diachi1, email1, dienthoai1, mst1, sotknh1, tennh1, chinhanh1, manhom1);
            DoiTuong_BUS.Sua1DoiTuong(obj.MaDt,obj1);

        }
        private void ResetControl()
        {
            txtMaDt.Text = "";
            txtTenDt.Text = "";
            lookUpEditNhomDt.EditValue = "";
            txtDiaChi.Text = "";
            txtDienThoai.Text = "";
            txtEmail.Text = "";
            txtMst.Text = "";
            txtSoTknh.Text = "";
            txtTenNh.Text = "";
            txtChiNhanh.Text = "";
            
        }
        public LuaChon_DTO lc = new LuaChon_DTO();
        public DoiTuong_DTO obj = new DoiTuong_DTO();
        private void TruyenDuLieu(DoiTuong_DTO dt)
        {
            txtMaDt.Text = dt.MaDt;
            txtTenDt.Text = dt.TenDt;
            lookUpEditNhomDt.Text = dt.MaNhom;
            txtDiaChi.Text = dt.DiaChi;
            txtDienThoai.Text = dt.DienThoai;
            txtEmail.Text = dt.Email;
            txtMst.Text = dt.Mst;
            txtSoTknh.Text = dt.SoTknh;
            txtTenNh.Text = dt.TenNh;
            txtChiNhanh.Text = dt.ChiNhanh;

        }
      
        
        
        
    }
}
