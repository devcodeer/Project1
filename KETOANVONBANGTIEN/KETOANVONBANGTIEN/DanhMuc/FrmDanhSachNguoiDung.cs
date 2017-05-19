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
using DevExpress.XtraGrid.Views.Base;

namespace KETOANVONBANGTIEN.DanhMuc
{
    public partial class FrmDanhSachNguoiDung : Form
    {
        public FrmDanhSachNguoiDung()
        {
            InitializeComponent();
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmEditNguoiDung frm = new FrmEditNguoiDung();
            frm.ShowDialog();
            LoadGridView();
        }

        private void FrmDanhSachNguoiDung_Load(object sender, EventArgs e)
        {
            LoadGridView();
        }

        private void LoadGridView()
        {
            grvDanhMucNguoiDung.DataSource = NguoiDung_BUS.getListUser();
        }

        private void btnNap_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            LoadGridView();
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string matk = gridViewDanhSachNguoiDung.GetRowCellValue(gridViewDanhSachNguoiDung.FocusedRowHandle,colTenTk).ToString();
            NguoiDung_BUS.deleteUser(matk);
            LoadGridView();
        }


        private void grvDanhMucNguoiDung_Click(object sender, EventArgs e)
        {
        }
    }
}
