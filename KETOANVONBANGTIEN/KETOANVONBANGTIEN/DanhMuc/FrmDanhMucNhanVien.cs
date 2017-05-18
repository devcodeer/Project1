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
    public partial class FrmDanhMucNhanVien : Form
    {
        public FrmDanhMucNhanVien()
        {
            InitializeComponent();
        }

        private void FrmDanhMucNhanVien_Load(object sender, EventArgs e)
        {
            LoadGridView();
        }

        private void btnThemMoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DanhMuc.FrmEditDanhMucNhanVien frm = new DanhMuc.FrmEditDanhMucNhanVien();
            frm.lc.LuaChon = "Add";
            frm.ShowDialog();
            LoadGridView();
        }

      

        private void LoadGridView()
        {
            grvDanhSachNhanVien.DataSource = NhanVien_BUS.loadListEmployee();      
        }
          

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
                if (MessageBox.Show("Bạn chắc chắn muốn xóa ?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string manv = gridViewDanhMucNhanVien.GetRowCellValue(gridViewDanhMucNhanVien.FocusedRowHandle, colMaNv).ToString();
                    DataTable dt = NhanVien_BUS.kiemTraChungTuCuaNhanVien(manv);
                    if (dt.Rows.Count > 0)
                        MessageBox.Show("Không xóa nhân viên đã có nghiệp vụ thu chi trong kỳ!");
                    else
                    {
                        try
                        {
                            NhanVien_BUS.deleteEmployee(manv);
                            LoadGridView();
                        }
                        catch
                        {
                        MessageBox.Show("Xóa không thành công !");
                        }
                    }
                }
        }

        private void btnNap_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            LoadGridView();
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmEditDanhMucNhanVien frm = new FrmEditDanhMucNhanVien();
            frm.lc.LuaChon = "Edit";
            frm.obj.MaNv = gridViewDanhMucNhanVien.GetRowCellValue(gridViewDanhMucNhanVien.FocusedRowHandle, colMaNv).ToString();
            frm.obj.TenNv = gridViewDanhMucNhanVien.GetRowCellValue(gridViewDanhMucNhanVien.FocusedRowHandle, colTenNv).ToString();
            frm.obj.MaPb = gridViewDanhMucNhanVien.GetRowCellValue(gridViewDanhMucNhanVien.FocusedRowHandle, colPb).ToString();
            frm.obj.DiaChi = gridViewDanhMucNhanVien.GetRowCellValue(gridViewDanhMucNhanVien.FocusedRowHandle, colDiaChi).ToString();
            frm.obj.DienThoai = gridViewDanhMucNhanVien.GetRowCellValue(gridViewDanhMucNhanVien.FocusedRowHandle, colDienThoai).ToString();
            frm.obj.DiaChi = gridViewDanhMucNhanVien.GetRowCellValue(gridViewDanhMucNhanVien.FocusedRowHandle, colEmail).ToString();
            frm.obj.ChucVu = gridViewDanhMucNhanVien.GetRowCellValue(gridViewDanhMucNhanVien.FocusedRowHandle, colChucVu).ToString();
            frm.obj.Email = gridViewDanhMucNhanVien.GetRowCellValue(gridViewDanhMucNhanVien.FocusedRowHandle, colEmail).ToString();

            frm.ShowDialog();
            LoadGridView();

        }

        private void btnIn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            BaoCao.BaoCaoDanhSachNhanVien.FrmThamSoBaoCao frm = new BaoCao.BaoCaoDanhSachNhanVien.FrmThamSoBaoCao();
            frm.ShowDialog();
        }

        private void btnXuatEx_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gridViewDanhMucNhanVien.ShowPrintPreview();
        }

    }
}
