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
    public partial class FrmDanhMucDoiTuong : Form
    {
        public FrmDanhMucDoiTuong()
        {
            InitializeComponent();
        }
     
        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DanhMuc.FrmEditDanhMucDoiTuong frm = new DanhMuc.FrmEditDanhMucDoiTuong();
            frm.lc.LuaChon = "Add";
            frm.ShowDialog();
            LoadGridView();

        }

        private void FrmDanhMucDoiTuong_Load(object sender, EventArgs e)
        {
            LoadGridView();
        }

        public void LoadGridView()
        {         
             grvDanhSachDoiTuong.DataSource = DoiTuong_BUS.loadListObjects();
        }
        
        private void btnNap_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            LoadGridView();
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
            
            if (MessageBox.Show("Bạn chắc chắn muốn xóa ?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string madt = gridViewDanhMucDoiTuong.GetRowCellValue(gridViewDanhMucDoiTuong.FocusedRowHandle, colMaDt).ToString();
                DataTable dt = DoiTuong_BUS.kiemTraChungTuCuaDoiTuong(madt);
                if (dt.Rows.Count > 0)
                    MessageBox.Show("Không xóa đối tượng đã có nghiệp vụ thu chi!");
                else
                {
                    try
                    {
                        DoiTuong_BUS.deleteObject(madt);
                        LoadGridView();
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
            FrmEditDanhMucDoiTuong frm = new FrmEditDanhMucDoiTuong();

            frm.lc.LuaChon = "Edit";

            frm.obj.MaDt = gridViewDanhMucDoiTuong.GetRowCellValue(gridViewDanhMucDoiTuong.FocusedRowHandle, colMaDt).ToString();
            frm.obj.TenDt = gridViewDanhMucDoiTuong.GetRowCellValue(gridViewDanhMucDoiTuong.FocusedRowHandle, colTenDt).ToString();
            frm.obj.MaNhom = gridViewDanhMucDoiTuong.GetRowCellValue(gridViewDanhMucDoiTuong.FocusedRowHandle, colNhomDt).ToString();
            frm.obj.DiaChi = gridViewDanhMucDoiTuong.GetRowCellValue(gridViewDanhMucDoiTuong.FocusedRowHandle, colDiaChi).ToString();
            frm.obj.DienThoai = gridViewDanhMucDoiTuong.GetRowCellValue(gridViewDanhMucDoiTuong.FocusedRowHandle, colDienThoai).ToString();
            frm.obj.Email = gridViewDanhMucDoiTuong.GetRowCellValue(gridViewDanhMucDoiTuong.FocusedRowHandle, colEmail).ToString();
            frm.obj.Mst = gridViewDanhMucDoiTuong.GetRowCellValue(gridViewDanhMucDoiTuong.FocusedRowHandle, colMst).ToString();
            frm.obj.SoTknh = gridViewDanhMucDoiTuong.GetRowCellValue(gridViewDanhMucDoiTuong.FocusedRowHandle, colSotk).ToString();
            frm.obj.TenNh = gridViewDanhMucDoiTuong.GetRowCellValue(gridViewDanhMucDoiTuong.FocusedRowHandle, colTenNh).ToString();
            frm.obj.ChiNhanh = gridViewDanhMucDoiTuong.GetRowCellValue(gridViewDanhMucDoiTuong.FocusedRowHandle, colChiNhanh).ToString();
            
            frm.ShowDialog();
            LoadGridView();
        }

        private void btnIn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            BaoCao.DanhSachDoiTuong.FrmrptThamSoBaoCao frm = new BaoCao.DanhSachDoiTuong.FrmrptThamSoBaoCao();           
            frm.ShowDialog();
        }

        private void btnXuatEx_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gridViewDanhMucDoiTuong.ShowPrintPreview();
        }
            
              
    }
}
