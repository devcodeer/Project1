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

namespace KETOANVONBANGTIEN.ChungTu
{
    public partial class FrmDanhSachChungTu : Form
    {
        public FrmDanhSachChungTu()
        {
            InitializeComponent();
           
        }

        private void FrmDanhSachPhieuThu_Load(object sender, EventArgs e)
        {
            if (luachonds.LuaChon == "DanhSachPhieuThu")
            {
                this.Text = "Danh sách phiếu thu";
                maloaict = 1;

            }

             if (luachonds.LuaChon == "DanhSachPhieuChi")
            {
                this.Text = "Danh sách phiếu chi";
                maloaict = 2;
            }

            if (luachonds.LuaChon=="DanhSachGiayBaoNo")
            {
                this.Text = "Danh sách giấy báo nợ";
                maloaict = 3;
            }

            if (luachonds.LuaChon =="DanhSachGiayBaoCo")
            {
                this.Text = "Danh sách giấy báo có";
                maloaict = 4;
            }

            LoadDanhSach();
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
            if (luachonds.LuaChon == "DanhSachPhieuThu")
            {
                ChungTu.FrmPhieuThuChi frm = new ChungTu.FrmPhieuThuChi();
                frm.lc.LuaChon = "Add";
                frm.chonloaiphieu.LuaChon = "PhieuThu";
                frm.ShowDialog();
                LoadDanhSach();
            }

             if (luachonds.LuaChon == "DanhSachPhieuChi")
            {
                ChungTu.FrmPhieuThuChi frm = new ChungTu.FrmPhieuThuChi();
                frm.lc.LuaChon = "Add";
                frm.chonloaiphieu.LuaChon = "PhieuChi";
                frm.ShowDialog();
                LoadDanhSach();
            }

            if (luachonds.LuaChon == "DanhSachGiayBaoNo")
            {
                ChungTu.FrmGiayBaoNo frm = new ChungTu.FrmGiayBaoNo();
                frm.lc.LuaChon = "Add";
                frm.ShowDialog();
                LoadDanhSach();
            }

            if (luachonds.LuaChon == "DanhSachGiayBaoCo")
            {
                ChungTu.FrmGiayBaoCo frm = new ChungTu.FrmGiayBaoCo();
                frm.lc.LuaChon = "Add";                
                frm.ShowDialog();
                LoadDanhSach();
            }
            

        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
            if (luachonds.LuaChon == "DanhSachPhieuThu")
            {
                ChungTu.FrmPhieuThuChi frm = new ChungTu.FrmPhieuThuChi();
                frm.lc.LuaChon = "Edit";
                LayDuLieu(frm.obj);
                frm.chonloaiphieu.LuaChon = "PhieuThu";
                frm.ShowDialog();
                LoadDanhSach();
            }

             if (luachonds.LuaChon == "DanhSachPhieuChi")
            {
                ChungTu.FrmPhieuThuChi frm = new ChungTu.FrmPhieuThuChi();
                frm.lc.LuaChon = "Edit";
                frm.chonloaiphieu.LuaChon = "PhieuChi";
                LayDuLieu(frm.obj);
                frm.ShowDialog();
                LoadDanhSach();
            }

            if (luachonds.LuaChon == "DanhSachGiayBaoNo")
            {
                ChungTu.FrmGiayBaoNo frm = new ChungTu.FrmGiayBaoNo();
                frm.lc.LuaChon = "Edit";
                LayDuLieu(frm.obj);
                frm.ShowDialog();
                LoadDanhSach();
            }

            if (luachonds.LuaChon == "DanhSachGiayBaoCo")
            {
                ChungTu.FrmGiayBaoCo frm = new ChungTu.FrmGiayBaoCo();
                frm.lc.LuaChon = "Edit";
                LayDuLieu(frm.obj);
                
                frm.ShowDialog();
                LoadDanhSach();
            }

            
           
        }

        private void LayDuLieu(ChungTu_DTO ct)
        {
            ct.SoCt = gridViewDsPhieuThu.GetRowCellValue(gridViewDsPhieuThu.FocusedRowHandle, colSoCt).ToString();
            ct.NgayCt = DateTime.Parse(gridViewDsPhieuThu.GetRowCellValue(gridViewDsPhieuThu.FocusedRowHandle, colNgayCt).ToString());
            ct.NgayGhiSo = DateTime.Parse(gridViewDsPhieuThu.GetRowCellValue(gridViewDsPhieuThu.FocusedRowHandle, colNgayghiso).ToString());
            ct.MaDt = gridViewDsPhieuThu.GetRowCellValue(gridViewDsPhieuThu.FocusedRowHandle, colMaDt).ToString();
            ct.NguoiGd = gridViewDsPhieuThu.GetRowCellValue(gridViewDsPhieuThu.FocusedRowHandle, colNguoiGd).ToString();
            ct.DiaChi = gridViewDsPhieuThu.GetRowCellValue(gridViewDsPhieuThu.FocusedRowHandle, colDiaChi).ToString();
            ct.LyDo = gridViewDsPhieuThu.GetRowCellValue(gridViewDsPhieuThu.FocusedRowHandle, colLyDo).ToString();
            ct.KemTheo = gridViewDsPhieuThu.GetRowCellValue(gridViewDsPhieuThu.FocusedRowHandle, colKemTheo).ToString();
            ct.MaTien = gridViewDsPhieuThu.GetRowCellValue(gridViewDsPhieuThu.FocusedRowHandle, colMaTien).ToString();
            ct.TyGia = float.Parse(gridViewDsPhieuThu.GetRowCellValue(gridViewDsPhieuThu.FocusedRowHandle, colTyGia).ToString());
            ct.TknhDi = gridViewDsPhieuThu.GetRowCellValue(gridViewDsPhieuThu.FocusedRowHandle, colTkNhDi).ToString();
            ct.TknhDen = gridViewDsPhieuThu.GetRowCellValue(gridViewDsPhieuThu.FocusedRowHandle, colTknhDen).ToString();
            ct.TrangThai = bool.Parse(gridViewDsPhieuThu.GetRowCellValue(gridViewDsPhieuThu.FocusedRowHandle, colTrangThai).ToString());
        
        }


        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MessageBox.Show("Bạn chắc chắn muốn xóa ?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    ChungTu_BUS.Xoa1ChungTu(gridViewDsPhieuThu.GetRowCellValue(gridViewDsPhieuThu.FocusedRowHandle, colSoCt).ToString());
                    LoadDanhSach();
                }
                catch
                {
                    MessageBox.Show("Xóa không thành công !");
                }
            }
        }

        private void btnNap_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            LoadDanhSach();
        }

        private void LoadDanhSach()
        {
            grvDanhSachPhieuThu.DataSource = ChungTu_BUS.LoadDanhSachCtTheoLoai(maloaict);    
        }

        public LuaChon_DTO luachonds = new LuaChon_DTO();
        int maloaict;

        private void btnIn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            BaoCao.BaoCaoDanhSachChungTu.rptDanhSachChungTu  rpt = new BaoCao.BaoCaoDanhSachChungTu.rptDanhSachChungTu();
            rpt.DataSource = ChungTu_BUS.LoadDanhSachCtTheoLoai(maloaict);
            rpt.DataMember = "Table";
            rpt.loaidanhsach.LuaChon = maloaict.ToString();
           // rpt.ShowPreview();
        }

        private void btnGhiSo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string soct = gridViewDsPhieuThu.GetRowCellValue(gridViewDsPhieuThu.FocusedRowHandle, colSoCt).ToString();    
            string tt= gridViewDsPhieuThu.GetRowCellValue(gridViewDsPhieuThu.FocusedRowHandle, colTrangThai).ToString();
            if (tt == "True")
            {
                MessageBox.Show("Chứng từ " + soct + " đã ghi sổ !");
            }
            else
            {
                ChungTu_BUS.UpdateTrangThai(soct, true);
                LoadDanhSach();
            }
        }

        private void btnBoGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string soct = gridViewDsPhieuThu.GetRowCellValue(gridViewDsPhieuThu.FocusedRowHandle, colSoCt).ToString();
            string tt = gridViewDsPhieuThu.GetRowCellValue(gridViewDsPhieuThu.FocusedRowHandle, colTrangThai).ToString();
            if (tt == "False")
            {
                MessageBox.Show("Chứng từ " + soct + " chưa ghi sổ !");
            }
            else
            {
                ChungTu_BUS.UpdateTrangThai(soct,false);
                LoadDanhSach();
            }
        }

        private void grvDanhSachPhieuThu_DoubleClick(object sender, EventArgs e)
        {

            if (luachonds.LuaChon == "DanhSachPhieuThu")
            {
                ChungTu.FrmPhieuThuChi frm = new ChungTu.FrmPhieuThuChi();
                frm.lc.LuaChon = "Edit";
                LayDuLieu(frm.obj);
                frm.chonloaiphieu.LuaChon = "PhieuThu";
                frm.ShowDialog();
                LoadDanhSach();
            }

            if (luachonds.LuaChon == "DanhSachPhieuChi")
            {
                ChungTu.FrmPhieuThuChi frm = new ChungTu.FrmPhieuThuChi();
                frm.lc.LuaChon = "Edit";
                frm.chonloaiphieu.LuaChon = "PhieuChi";
                LayDuLieu(frm.obj);
                frm.ShowDialog();
                LoadDanhSach();
            }

            if (luachonds.LuaChon == "DanhSachGiayBaoNo")
            {
                ChungTu.FrmGiayBaoNo frm = new ChungTu.FrmGiayBaoNo();
                frm.lc.LuaChon = "Edit";
                LayDuLieu(frm.obj);
                frm.ShowDialog();
                LoadDanhSach();
            }

            if (luachonds.LuaChon == "DanhSachGiayBaoCo")
            {
                ChungTu.FrmGiayBaoCo frm = new ChungTu.FrmGiayBaoCo();
                frm.lc.LuaChon = "Edit";
                LayDuLieu(frm.obj);

                frm.ShowDialog();
                LoadDanhSach();
            }
        }

    }
}
