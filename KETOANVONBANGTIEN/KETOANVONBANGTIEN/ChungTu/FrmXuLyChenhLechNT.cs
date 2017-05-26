using BUS;
using DTO;
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

        public LuaChon_DTO lc = new LuaChon_DTO();
        public XuLyChenhLech_DTO objXuLyChenhLech = new XuLyChenhLech_DTO();
        public static string soct;

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


        private void btnLuuVaDong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (lc.LuaChon == "Add")
            {
                try
                {
                    ThemMoi();
                    MessageBox.Show("Thêm mới thành công !");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Không thêm được, kiểm tra lại dữ liệu! " + ex.Message);

                }
            }
            else if (lc.LuaChon == "Edit")
            {
                try
                {
                    Sua();
                    MessageBox.Show("Sửa thành công !");
                   
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Không sửa được, kiểm tra lại dữ liệu! " + ex.Message);

                }
            }

        }
        private void ThemMoi()
        {
            string soct = txtSoCt.Text;
            string ngayct = dateEditNgayCt.Text;
            string ngayghiso = dateEditNgayGhiSo.Text;
            string madt = "";
            string diachi = "";
            string nguoigd = "";
            string lydo = "Xu ly chenh lech";
            string kemtheo = "";
            string matien = lookUpEditLoaiTien.GetColumnValue("MaTien").ToString();
            float tygia = float.Parse(txtTiGiaGhiSo.Text);

            ChungTu_DTO chungtu = new ChungTu_DTO(soct, 1, ngayct, ngayghiso, madt, nguoigd, diachi, lydo, kemtheo, matien, tygia, "", "", false);
            ChungTu_BUS.insertChungTu(chungtu);


            string tkno = GridViewChiTiet.GetRowCellDisplayText(0, colTkNo).ToString();
            string tkco = GridViewChiTiet.GetRowCellDisplayText(0, colTkCo).ToString();
            string noidung = GridViewChiTiet.GetRowCellDisplayText(0, colNoiDung).ToString();

            int tonQuy = int.Parse(txtTonQuy.Text.ToString().Trim());
            int soTien = int.Parse(txtSoTien.Text.ToString().Trim());
            string tyGiaGhiSo = txtTiGiaGhiSo.Text.ToString().Trim();
            string tyGiaThucTe = txtTiGiaThucTe.Text.ToString().Trim();

            XuLyChenhLech_BUS.xuLyChenhLech(soct, tkno, tkco, noidung, tonQuy, soTien, tyGiaGhiSo, tyGiaThucTe);
        }

        private void Sua()
        {
            string soct = txtSoCt.Text;
            DateTime ngayct = dateEditNgayCt.DateTime;
            DateTime ngayghiso = dateEditNgayGhiSo.DateTime;
            float tygia = float.Parse(txtTiGiaGhiSo.Text);

            string tkno = GridViewChiTiet.GetRowCellDisplayText(0, colTkNo).ToString();
            string tkco = GridViewChiTiet.GetRowCellDisplayText(0, colTkCo).ToString();
            string noidung = GridViewChiTiet.GetRowCellDisplayText(0, colNoiDung).ToString();

            int tonQuy = int.Parse(txtTonQuy.Text.ToString().Trim());
            int soTien = int.Parse(txtSoTien.Text.ToString().Trim());
            string tyGiaGhiSo = txtTiGiaGhiSo.Text.ToString().Trim();
            string tyGiaThucTe = txtTiGiaThucTe.Text.ToString().Trim();

            objXuLyChenhLech.Tkco = tkco;
            objXuLyChenhLech.Tkno = tkno;
            objXuLyChenhLech.Noidung = noidung;
            objXuLyChenhLech.SoTien = soTien;
            objXuLyChenhLech.TyGiaGhiSo = tyGiaGhiSo;
            objXuLyChenhLech.TyGiaThucTe = tyGiaThucTe;

            int soTienNt;
            if (lookUpEditLoaiTien.EditValue.ToString() == "VND")
                soTienNt = 0;
            else
                soTienNt = soTien; // ko biet la gia tri gi
            XuLyChenhLech_BUS.updateXyLyChenhLech(objXuLyChenhLech, soct, soTienNt);

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
            txtSoCt.Text = Function.Funtion.randomSoChungTu(1);
            dateEditNgayCt.DateTime = DateTime.Today;
            dateEditNgayGhiSo.DateTime = DateTime.Today;
        }

        private void lookUpEditLoaiTien_EditValueChanged(object sender, EventArgs e)
        {
            if (lookUpEditLoaiTien.EditValue.ToString() == "VND")
            {
                txtTonQuy.Enabled = false;
                txtTonQuy.Text = ChungTu_BUS.getTonQuyVND().ToString();
                txtTiGiaGhiSo.Text = "1";
                txtTiGiaThucTe.Text = "1";
                txtTiGiaGhiSo.Enabled = false;
                txtTiGiaThucTe.Enabled = false;
            }
            else
                {
                    txtTonQuy.Enabled = false;
                    txtTonQuy.Text = ChungTu_BUS.getTonQuyUSD().ToString();
                    txtTiGiaGhiSo.Text = ChungTu_BUS.getTyGiaHienTai().ToString(); ;
                    txtTiGiaThucTe.Text = "";
                    txtTiGiaGhiSo.Enabled = false;
                    txtTiGiaThucTe.Enabled = true;
                }
        }

        private void TinhToanSoTien()
        {
            try
            {
                int tonQuy = int.Parse(txtTonQuy.Text);
                int thucTon = int.Parse(txtThucTon.Text);

                int tyGiaGhiSo = int.Parse(txtTiGiaGhiSo.Text);
                int tyGiaThuc = int.Parse(txtTiGiaThucTe.Text);

                int soTien = Math.Abs((tonQuy + thucTon) * tyGiaGhiSo - (tonQuy + thucTon) * tyGiaThuc);
                txtSoTien.Text = soTien.ToString();
                gridView1.SetRowCellValue(0, colSoTien, soTien.ToString());
            }
            catch (Exception ex)
            {

            }
        }

        private void txtThucTon_TextChanged(object sender, EventArgs e)
        {
            TinhToanSoTien();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtTiGiaThucTe_TextChanged(object sender, EventArgs e)
        {
            TinhToanSoTien();
        }

        private void btnDong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }
    }
}
