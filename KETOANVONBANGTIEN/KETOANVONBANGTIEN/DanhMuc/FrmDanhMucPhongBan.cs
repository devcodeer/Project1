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
    public partial class FrmDanhMucPhongBan : Form
    {
        public FrmDanhMucPhongBan()
        {
            InitializeComponent();
        }

        private void FrmDanhMucPhongBan_Load(object sender, EventArgs e)
        {
            LoadGridview();
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DanhMuc.FrmEditDanhMucPhongBan frm = new DanhMuc.FrmEditDanhMucPhongBan();
            frm.lc.LuaChon = "Add";
            frm.ShowDialog();
            LoadGridview();
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmEditDanhMucPhongBan frm = new FrmEditDanhMucPhongBan();
            frm.lc.LuaChon = "Edit";
            frm.obj.MaPb=gridViewDanhMucPhongBan.GetRowCellValue(gridViewDanhMucPhongBan.FocusedRowHandle,colMapb).ToString();
            frm.obj.TenPb = gridViewDanhMucPhongBan.GetRowCellValue(gridViewDanhMucPhongBan.FocusedRowHandle, colTenPb).ToString();
            frm.obj.DienThoai = gridViewDanhMucPhongBan.GetRowCellValue(gridViewDanhMucPhongBan.FocusedRowHandle, colDienThoai).ToString();
            frm.obj.Fax = gridViewDanhMucPhongBan.GetRowCellValue(gridViewDanhMucPhongBan.FocusedRowHandle, colFax).ToString();
            frm.ShowDialog();
            LoadGridview();

        }
             
        private void btnNap_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            LoadGridview();
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MessageBox.Show("Bạn chắc chắn muốn xóa?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    PhongBan_BUS.Xoa1PhongBan(gridViewDanhMucPhongBan.GetRowCellValue(gridViewDanhMucPhongBan.FocusedRowHandle, colMapb).ToString());
                    LoadGridview();
                }
                catch
                {
                    MessageBox.Show("Xóa không thành công !");
                }
            }
        }


        private void LoadGridview()
        {
            grvDanhMucPhongBan.DataSource = PhongBan_BUS.LoadDanhSachPhongBan();
        }

        private void btnXuatEx_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gridViewDanhMucPhongBan.ShowPrintPreview();
        }
        

    }
}
