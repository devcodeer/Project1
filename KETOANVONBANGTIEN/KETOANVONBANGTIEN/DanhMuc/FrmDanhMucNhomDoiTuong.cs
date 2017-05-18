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
    public partial class FrmDanhMucNhomDoiTuong : Form
    {
        public FrmDanhMucNhomDoiTuong()
        {
            InitializeComponent();
        }

        private void FrmDanhMucNhomDoiTuong_Load(object sender, EventArgs e)
        {
            LoadGridView();
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DanhMuc.FrmEditNhomDoiTuong frm = new DanhMuc.FrmEditNhomDoiTuong();
            frm.lc.LuaChon = "Add";
            frm.ShowDialog();
            LoadGridView();
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DanhMuc.FrmEditNhomDoiTuong frm = new DanhMuc.FrmEditNhomDoiTuong();
            frm.lc.LuaChon = "Edit";
            frm.obj.MaNhom = gridViewDanhMucNhomDoiTuong.GetRowCellValue(gridViewDanhMucNhomDoiTuong.FocusedRowHandle, colMaNhom).ToString();
            frm.obj.TenNhom = gridViewDanhMucNhomDoiTuong.GetRowCellValue(gridViewDanhMucNhomDoiTuong.FocusedRowHandle, colTenhom).ToString();

            frm.ShowDialog();
            LoadGridView();
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MessageBox.Show("Bạn chắc chắn muốn xóa ?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    NhomDoiTuong_BUS.deleteNhomDoiTuong(gridViewDanhMucNhomDoiTuong.GetRowCellValue(gridViewDanhMucNhomDoiTuong.FocusedRowHandle,colMaNhom).ToString());
                    LoadGridView();
                }
                catch
                {
                    MessageBox.Show("Xóa không thành công !");
                }
            }
        }

        private void btnNap_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            LoadGridView();
        }

        private void LoadGridView()
        {
            grvDanhMucNhomDoiTuong.DataSource= NhomDoiTuong_BUS.loadDanhSachNhomDoiTuong();
        }

        private void btnXuatEx_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gridViewDanhMucNhomDoiTuong.ShowPrintPreview();
        }

      

      

     
    }
}
 