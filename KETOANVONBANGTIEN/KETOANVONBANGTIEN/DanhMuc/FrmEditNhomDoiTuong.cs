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
    public partial class FrmEditNhomDoiTuong : Form
    {
        public FrmEditNhomDoiTuong()
        {
            InitializeComponent();
        }

        private void FrmEditNhomDoiTuong_Load(object sender, EventArgs e)
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
                    Themmoi();
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
                Themmoi();
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

        private void Themmoi()
        {
            string manhom = txtMaNhom.Text;
            string tennhom = txtTenNhom.Text;
            NhomDt_DTO nhomdt = new NhomDt_DTO(manhom, tennhom);
            NhomDt_BUS.Them1NhomDoiTuong(nhomdt);
        }

        private void Sua()
        {
            string manhom = txtMaNhom.Text;
            string tennhom = txtTenNhom.Text;
            NhomDt_DTO nhomdt = new NhomDt_DTO(manhom, tennhom);
            NhomDt_BUS.Sua1NhomDoiTuong(obj.MaNhom, nhomdt);
        }

        private void ResetControl()
        {
            txtMaNhom.Text = "";
            txtTenNhom.Text = "";
        }

        public LuaChon_DTO lc = new LuaChon_DTO();
        public NhomDt_DTO obj = new NhomDt_DTO();

        private void TruyenDuLieu(NhomDt_DTO nhomdt)
        {
            txtMaNhom.Text = nhomdt.MaNhom;
            txtTenNhom.Text = nhomdt.TenNhom;
        }



    
    }
}
