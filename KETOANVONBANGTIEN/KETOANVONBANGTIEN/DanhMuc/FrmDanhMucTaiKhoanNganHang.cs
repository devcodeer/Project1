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
    public partial class FrmDanhMucTaiKhoanNganHang : Form
    {
        public FrmDanhMucTaiKhoanNganHang()
        {
            InitializeComponent();
        }
              

        private void btnThem_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DanhMuc.FrmEditDanhMucTaiKhoanNganHang frm = new DanhMuc.FrmEditDanhMucTaiKhoanNganHang();
            frm.lc.LuaChon = "Add";
            frm.ShowDialog();
            LoadGridVieW();

        }

        private void FrmDanhMucTaiKhoanNganHang_Load(object sender, EventArgs e)
        {
            LoadGridVieW();
        }

        private void LoadGridVieW()
        {
            grvDanhMucTKNH.DataSource = TaiKhoanNganHang_BUS.LoadDanhMucTaiKhoanNganHang();        
        }

        private void btnNap_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            LoadGridVieW();
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MessageBox.Show("Bạn chắc chắn muốn xóa?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string sotknh = gridViewDanhMucTKNH.GetRowCellValue(gridViewDanhMucTKNH.FocusedRowHandle, colSotk).ToString();
                DataTable dt = TaiKhoanNganHang_BUS.kiemtra(sotknh);
                if (dt.Rows.Count > 0)
                    MessageBox.Show("Không xóa tài khoản đã sử dụng trong kỳ!");
                else
                {
                    try
                    {
                        TaiKhoanNganHang_BUS.Xoa1TaiKhoanNganHang(sotknh);
                        LoadGridVieW();
                    }
                    catch
                    {
                        MessageBox.Show("Xóa không thành công !");
                    }
                }
            }
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DanhMuc.FrmEditDanhMucTaiKhoanNganHang frm = new DanhMuc.FrmEditDanhMucTaiKhoanNganHang();
            frm.lc.LuaChon = "Edit";
            frm.obj.SoTknh = gridViewDanhMucTKNH.GetRowCellValue(gridViewDanhMucTKNH.FocusedRowHandle, colSotk).ToString();
            frm.obj.TenTknh = gridViewDanhMucTKNH.GetRowCellValue(gridViewDanhMucTKNH.FocusedRowHandle, colTentk).ToString();
            frm.obj.MaNh = gridViewDanhMucTKNH.GetRowCellValue(gridViewDanhMucTKNH.FocusedRowHandle, colManh).ToString();
            frm.obj.ChiNhanh = gridViewDanhMucTKNH.GetRowCellValue(gridViewDanhMucTKNH.FocusedRowHandle, colChinhanh).ToString();

            frm.ShowDialog();
            LoadGridVieW();

        }

        private void btnXuatEx_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gridViewDanhMucTKNH.ShowPrintPreview();
        }
    }
}
