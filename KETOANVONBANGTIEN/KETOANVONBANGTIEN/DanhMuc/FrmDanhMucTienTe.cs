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
    public partial class FrmDanhMucTienTe : Form
    {
        public FrmDanhMucTienTe()
        {
            InitializeComponent();
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DanhMuc.FrmEditDanhMucTienTe frm = new DanhMuc.FrmEditDanhMucTienTe();
            frm.lc.LuaChon = "Add";
            frm.ShowDialog();
            LoadGirdView();
        }

        private void FrmDanhMucTienTe_Load(object sender, EventArgs e)
        {
            LoadGirdView();
        }
        private void LoadGirdView()
        {
            grvDanhMucTienTe.DataSource = TienTe_BUS.loadDanhMucTienTe();
        }

        private void btnNap_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            LoadGirdView();
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MessageBox.Show("Bạn chắc chắn muốn xóa?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    TienTe_BUS.deleteCurrency(gridViewDanhMucTienTe.GetRowCellValue(gridViewDanhMucTienTe.FocusedRowHandle, colMatien).ToString());
                    LoadGirdView();                    
                }
                catch
                {
                    MessageBox.Show("Xóa không thành công !");
                }
            }
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DanhMuc.FrmEditDanhMucTienTe frm = new DanhMuc.FrmEditDanhMucTienTe();
            frm.lc.LuaChon = "Edit";
            frm.obj.MaTien = gridViewDanhMucTienTe.GetRowCellValue(gridViewDanhMucTienTe.FocusedRowHandle, colMatien).ToString();
            frm.obj.TenTien = gridViewDanhMucTienTe.GetRowCellValue(gridViewDanhMucTienTe.FocusedRowHandle, colTenTien).ToString();
            frm.ShowDialog();
            LoadGirdView();
        }

        private void btnXuatEx_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gridViewDanhMucTienTe.ShowPrintPreview();
        }
    }
}
