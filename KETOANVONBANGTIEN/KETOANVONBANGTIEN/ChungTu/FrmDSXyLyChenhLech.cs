using BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KETOANVONBANGTIEN.ChungTu
{
    public partial class FrmDSXyLyChenhLech : Form
    {
        public FrmDSXyLyChenhLech()
        {
            InitializeComponent();
           
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ChungTu.FrmXuLyChenhLechNT frm = new ChungTu.FrmXuLyChenhLechNT();
           // frm.lc.LuaChon = "Add";
            frm.ShowDialog();
        }

        private void LoadDanhSach()
        {
            grvDanhSachXuLyChenhLech.DataSource = ChungTu_BUS.getDSXyLyChenhLech();
        }

        private void LoadLookUpEditTkNo_Co()
        {

            repositoryItemLookUpEditTkNo.DataSource = TaiKhoan_BUS.loadListTaiKhoanKeToan();
            repositoryItemLookUpEditTkNo.DisplayMember = "MaTk";
            repositoryItemLookUpEditTkNo.ValueMember = "MaTk";

            repositoryItemLookUpEditTkCo.DataSource = TaiKhoan_BUS.loadListTaiKhoanKeToan();
            repositoryItemLookUpEditTkCo.DisplayMember = "MaTk";
            repositoryItemLookUpEditTkCo.ValueMember = "MaTk";

        }

        private void FrmDSXyLyChenhLech_Load(object sender, EventArgs e)
        {
            LoadDanhSach();
        }
    }
}
