using BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace KETOANVONBANGTIEN.ChungTu
{
    public partial class FrmXuLyChenhLechNT : Form
    {
        public FrmXuLyChenhLechNT()
        {
            InitializeComponent();
            LoadLookUpEditTienTe();
            LoadLookUpEditTkNo_Co();
            Init_ChiTietPhieu();
        }

        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {

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

        private void Init_ChiTietPhieu()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("TkNo", typeof(string));
            dt.Columns.Add("TkCo", typeof(string));
            dt.Columns.Add("NoiDung", typeof(string));
            dt.Columns.Add("SoTien", typeof(decimal));
            grvChiTiet.DataSource = dt;

        }

        private void LoadLookUpEditTienTe()
        {
            lookUpEditLoaiTien.Properties.DataSource = BUS.TienTe_BUS.loadDanhMucTienTe();
            lookUpEditLoaiTien.Properties.DisplayMember = "MaTien";
            lookUpEditLoaiTien.Properties.ValueMember = "MaTien";

            lookUpEditLoaiTien.EditValue = "VND";
        }

        private void FrmXuLyChenhLechNT_Load(object sender, EventArgs e)
        {
            txtSoCt.Text = Function.Funtion.randomSoChungTu(4);
            dateEditNgayCt.DateTime = DateTime.Today;
            dateEditNgayGhiSo.DateTime = DateTime.Today;
        }

        private void lookUpEditLoaiTien_EditValueChanged(object sender, EventArgs e)
        {
            if (lookUpEditLoaiTien.EditValue.ToString() == "VND")
            {
                txtTiGiaGhiSo.Text = "1";
                txtTiGiaThucTe.Text = "1";
                txtTiGiaGhiSo.Enabled = false;
                txtTiGiaThucTe.Enabled = false;
            }
            else
            {
                txtTiGiaGhiSo.Text = "1";
                txtTiGiaThucTe.Text = "1";
                txtTiGiaGhiSo.Enabled = true;
                txtTiGiaThucTe.Enabled = true;
            }
        }
    }
}
