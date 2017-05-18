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
    public partial class FrmEditDanhMucTienTe : Form
    {
        public FrmEditDanhMucTienTe()
        {
            InitializeComponent();
        }

        private void FrmEditDanhMucTienTe_Load(object sender, EventArgs e)
        {
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
                    MessageBox.Show("Thêm mới không thành công ");
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
                txtMaTien.Focus();
            }
            catch
            {
                MessageBox.Show("Thêm mới không thành công ");
            }
        }
        private void ThemMoi()
        {
            string matien = txtMaTien.Text;
            string tentien = txtTenTien.Text;
            TienTe_DTO tt = new TienTe_DTO(matien, tentien);
            TienTe_BUS.insertCurrency(tt);
        }

        private void Sua()
        {
            string matien = txtMaTien.Text;
            string tentien = txtTenTien.Text;
            TienTe_DTO tiente = new TienTe_DTO(matien, tentien);
            TienTe_BUS.updateCurrency(obj.MaTien, tiente);
        }

        private void ResetControl()
        {
            txtMaTien.Text = "";
            txtTenTien.Text = "";
        }

        public LuaChon_DTO lc = new LuaChon_DTO();
        public TienTe_DTO obj = new TienTe_DTO();
        private void TruyenDuLieu(TienTe_DTO tt)
        {
            txtMaTien.Text = tt.MaTien;
            txtTenTien.Text = tt.TenTien;
        
        }
        
    }
}
