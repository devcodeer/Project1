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
    public partial class FrmDanhMucTaiKhoan : Form
    {
        public FrmDanhMucTaiKhoan()
        {
            InitializeComponent();
        }

        private void FrmDanhMucTaiKhoan_Load(object sender, EventArgs e)
        {
            LoadGridView();
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DanhMuc.FrmEditDanhMucTaiKhoan frm = new DanhMuc.FrmEditDanhMucTaiKhoan();
            frm.lc.LuaChon = "Add";
            frm.ShowDialog();
            LoadGridView();
        }

      

        private void LoadGridView()
        {
            grvDanhMucTaiKhoan.DataSource = TaiKhoan_BUS.LoadDanhMucTaiKhoan();
        }

        private void btnNap_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            LoadGridView();
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MessageBox.Show("Bạn muốn xóa ", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    TaiKhoan_BUS.Xoa1TaiKhoan(gridViewDMTK.GetRowCellValue(gridViewDMTK.FocusedRowHandle, colMaTk).ToString());
                    LoadGridView();
                }
                catch
                {
                    MessageBox.Show("Xóa không thành công");
                }
            }

        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmEditDanhMucTaiKhoan frm = new FrmEditDanhMucTaiKhoan();
            frm.lc.LuaChon = "Edit";
            frm.obj.MaTk = gridViewDMTK.GetRowCellValue(gridViewDMTK.FocusedRowHandle, colMaTk).ToString();
            frm.obj.TenTk = gridViewDMTK.GetRowCellValue(gridViewDMTK.FocusedRowHandle, colTentk).ToString();
            frm.obj.LoaiTk = gridViewDMTK.GetRowCellValue(gridViewDMTK.FocusedRowHandle, colLoaitk).ToString();
            frm.obj.CapTk = int.Parse(gridViewDMTK.GetRowCellValue(gridViewDMTK.FocusedRowHandle, colCaptk).ToString());
            frm.obj.TkCha = gridViewDMTK.GetRowCellValue(gridViewDMTK.FocusedRowHandle, colTkCha).ToString();
            frm.obj.MaNt = gridViewDMTK.GetRowCellValue(gridViewDMTK.FocusedRowHandle, colMaNt).ToString();
            frm.ShowDialog();
            LoadGridView();

        }

        private void btnXuatEx_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gridViewDMTK.ShowPrintPreview();
        }
    }
}
