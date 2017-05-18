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
    public partial class FrmEditDanhMucPhongBan : Form
    {
        public FrmEditDanhMucPhongBan()
        {
            InitializeComponent();
        }

        private void FrmEditDanhMucPhongBan_Load(object sender, EventArgs e)
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
                    ThemMoi();
                    this.Close();
                }
                catch
                {
                    MessageBox.Show("Thêm mới không thành công");
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
                    MessageBox.Show("Sửa không thành công");
                }
            }
        }

        private void btnLuuVaMoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                ThemMoi();
                ResetControl();                
            }
            catch
            {
                MessageBox.Show("Thêm mới không thành công");
            }
        }

        private void btnDong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void ThemMoi()
        {
            string maphong = txtMaPhong.Text;
            string tenphong = txtTenPhong.Text;
            string dienthoai = txtDienThoai.Text;
            string fax = txtFax.Text;

            PhongBan_DTO phongban = new PhongBan_DTO(maphong, tenphong, dienthoai, fax);
            PhongBan_BUS.insertDepartment(phongban);
        }

        private void Sua()
        {
            string maphong = txtMaPhong.Text;
            string tenphong = txtTenPhong.Text;
            string dienthoai = txtDienThoai.Text;
            string fax = txtFax.Text;
            PhongBan_DTO phongban = new PhongBan_DTO(maphong, tenphong, dienthoai, fax);
            PhongBan_BUS.updateDepartment(obj.MaPb, phongban);

        }

        private void ResetControl()
        {
            txtMaPhong.Text = "";
            txtTenPhong.Text = "";
            txtDienThoai.Text = "";
            txtFax.Text = "";
        }     

        public LuaChon_DTO lc = new LuaChon_DTO();
        public PhongBan_DTO obj = new PhongBan_DTO();
        private void TruyenDuLieu(PhongBan_DTO pb)
        {
            txtMaPhong.Text = pb.MaPb;
            txtTenPhong.Text = pb.TenPb;
            txtDienThoai.Text = pb.DienThoai;
            txtFax.Text = pb.Fax;
        }

      
    }
}
