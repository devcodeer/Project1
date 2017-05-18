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
    public partial class FrmEditDanhMucTaiKhoan : Form
    {
        public FrmEditDanhMucTaiKhoan()
        {
            InitializeComponent();
        }

        private void FrmEditDanhMucTaiKhoan_Load(object sender, EventArgs e)
        {
            LoadlookUpEditTkCha();
            LoadlookUpEditLoaiTien();
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
                    ThemMoiTaiKhoan();
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
                    SuaTaiKhoan();
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
                ThemMoiTaiKhoan();
                ResetControl();
                LoadlookUpEditTkCha();
                txtMaTk.Focus();
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

        private void ThemMoiTaiKhoan()
        {
            string matk = txtMaTk.Text;
            string tentk = txtTenTk.Text;
            int captk = int.Parse(txtCapTk.Text);
            string loaitk = txtLoaiTk.Text;
            string matien = lookUpEditLoaiTien.GetColumnValue("MaTien").ToString();
            string tkcha = "";
            if (captk !=1)
            {
                try
                {
                    tkcha = lookUpEditTkCha.GetColumnValue("MaTk").ToString();
                }
                catch
                {
                }
            }
            TaiKhoan_DTO taikhoan = new TaiKhoan_DTO(matk, tentk, loaitk, captk,tkcha,matien,0,0,0,0);
            TaiKhoan_BUS.insertAccount(taikhoan);
        }

        private void SuaTaiKhoan()
        {
            string matk = txtMaTk.Text;
            string tentk = txtTenTk.Text;
            string loaitk = txtLoaiTk.Text;
            string tkcha = "";
            int captk = int.Parse(txtCapTk.Text);
            string matien = lookUpEditLoaiTien.GetColumnValue("MaTien").ToString();
            if (captk != 1)
            {
                try
                {
                    tkcha = lookUpEditTkCha.GetColumnValue("MaTk").ToString();
                }
                catch
                {
                } 
            }
            
            
            
            TaiKhoan_DTO tk = new TaiKhoan_DTO(matk, tentk, loaitk, captk,tkcha,matien,0,0,0,0);
            TaiKhoan_BUS.updateAccount(obj.MaTk, tk);
        }

        private void ResetControl()
        { 
            txtMaTk.Text ="";
            txtTenTk.Text="";
            txtCapTk.Text="";
            txtLoaiTk.Text="";
            lookUpEditTkCha.EditValue = "";
            lookUpEditLoaiTien.EditValue = "";

        }

        public LuaChon_DTO lc = new LuaChon_DTO();
        public TaiKhoan_DTO obj = new TaiKhoan_DTO();
        private void TruyenDuLieu(TaiKhoan_DTO tk)
        {
            txtMaTk.Text = tk.MaTk;
            txtTenTk.Text = tk.TenTk;
            txtCapTk.Text = tk.CapTk.ToString();
            txtLoaiTk.Text = tk.LoaiTk;
            lookUpEditTkCha.Text = tk.TkCha;
            lookUpEditLoaiTien.Text = tk.MaNt;
        }
        private void LoadlookUpEditTkCha()
        {
            lookUpEditTkCha.Properties.DataSource = TaiKhoan_BUS.loadListTaiKhoanKeToan();
            lookUpEditTkCha.Properties.DisplayMember = "MaTk";
            lookUpEditTkCha.Properties.ValueMember = "MaTk";
        }

        private void LoadlookUpEditLoaiTien()
        {
            lookUpEditLoaiTien.Properties.DataSource = TienTe_BUS.loadDanhMucTienTe();
            lookUpEditLoaiTien.Properties.DisplayMember = "MaTien";
            lookUpEditLoaiTien.Properties.ValueMember = "MaTien";
        }

        private void txtCapTk_TextChanged(object sender, EventArgs e)
        {
            if (txtCapTk.Text == "1")
            {
                lookUpEditTkCha.Enabled = false;
            }
            else
            {
                lookUpEditTkCha.Enabled = true;
            }
        }


       
      
    }
}
