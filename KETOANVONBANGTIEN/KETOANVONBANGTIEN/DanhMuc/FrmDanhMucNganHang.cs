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
    public partial class FrmDanhMucNganHang : Form
    {
        public FrmDanhMucNganHang()
        {
            InitializeComponent();
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DanhMuc.FrmEditDanhMucNganHang frm = new DanhMuc.FrmEditDanhMucNganHang();
            frm.lc.LuaChon = "Add";
            frm.ShowDialog();
            LoadGridView();
        }

        private void FrmDanhMucNganHang_Load(object sender, EventArgs e)
        {
            LoadGridView();
        }      

        private void btnNap_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            LoadGridView();
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MessageBox.Show("Bạn chắc chắn muốn xóa ?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    NganHang_BUS.Xoa1NganHang(gridViewDanhMucNganHang.GetRowCellValue(gridViewDanhMucNganHang.FocusedRowHandle, colMaNh).ToString());
                    LoadGridView();
                }
                catch
                {
                    MessageBox.Show("Xóa không thành công !");
                }
            }

        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmEditDanhMucNganHang frm = new FrmEditDanhMucNganHang();
            frm.lc.LuaChon = "Edit";
            frm.obj.MaNh = gridViewDanhMucNganHang.GetRowCellValue(gridViewDanhMucNganHang.FocusedRowHandle, colMaNh).ToString();
            frm.obj.TenNh = gridViewDanhMucNganHang.GetRowCellValue(gridViewDanhMucNganHang.FocusedRowHandle, colTenNh).ToString();
            frm.ShowDialog();
            LoadGridView();
        }

     

        private void LoadGridView()
        {
            grvDanhMucNganHang.DataSource = NganHang_BUS.LoadDanhSachNganHang();
        }

        private void btnXuatEx_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gridViewDanhMucNganHang.ShowPrintPreview();
        }
    }
}
