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


        private void btnLuuVaDong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //if (lc.LuaChon == "Add")
            //{
            //    try
            //    {
            //        ThemMoi();
            //        MessageBox.Show("Thêm mới thành công !");
            //        DisableControl();
            //        btnIn.Enabled = true;
            //        btnSua.Enabled = true;

            //    }
            //    catch (Exception ex)
            //    {
            //        MessageBox.Show("Không thêm được, kiểm tra lại dữ liệu! " + ex.Message);

            //    }
            //}
            //else if (lc.LuaChon == "Edit")
            //{
            //    try
            //    {
            //        Sua();
            //        MessageBox.Show("Sửa thành công !");
            //        DisableControl();
            //        btnIn.Enabled = true;
            //        btnSua.Enabled = true;
            //    }
            //    catch (Exception ex)
            //    {
            //        MessageBox.Show("Không sửa được, kiểm tra lại dữ liệu! " + ex.Message);

            //    }
            //}

        }
        private void ThemMoi()
        {
            //string soct = txtSoCt.Text;
            //DateTime ngayct = dateEditNgayCt.DateTime;
            //DateTime ngayghiso = dateEditNgayGs.DateTime;
            //string madt = lookUpEditDT.GetColumnValue("Ma").ToString();
            //string diachi = txtDiaChi.Text;
            //string nguoigd = txtNguoiGd.Text;
            //string lydo = txtLyDo.Text;
            //string kemtheo = txtKemTheo.Text;
            //string matien = lookUpEditLoaiTien.GetColumnValue("MaTien").ToString();
            //float tygia = float.Parse(txtTyGia.Text);

            //ChungTu_DTO chungtu = new ChungTu_DTO(soct, maphieu, ngayct, ngayghiso, madt, nguoigd, diachi, lydo, kemtheo, matien, tygia, "", "", false);
            //ChungTu_BUS.insertChungTu(chungtu);

            //Store sp_XuLyChenhLech
            /*
             * @soct	varchar(10),		
		        @tkno	varchar(7),		
		        @tkco	varchar(7),
		        @noidung nvarchar(100),
		        @sotiennt numeric(18,2),
		        @sotien		numeric(18,0),
		        @tiGiaGhiSo nvarchar(50),
		        @tiGiaThucTe nvarchar(50)
             */




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
                   // txtTyGia.Text = ChungTu_BUS.getTyGiaHienTai().ToString();
                   // GridViewChiTiet.Columns[4].Visible = true;
                }
            //else
            //{
            //    txtTiGiaGhiSo.Text = "1";
            //    txtTiGiaThucTe.Text = "1";
            //    txtTiGiaGhiSo.Enabled = true;
            //    txtTiGiaThucTe.Enabled = true;
            //}
            //if (chonloaiphieu.LuaChon == "PhieuThu")
            //{
            //    if (lookUpEditLoaiTien.EditValue.ToString() == "VND")
            //    {
            //        txtTyGia.Text = "1";
            //        GridViewChiTiet.Columns[4].Visible = false;
            //        txtTyGia.Enabled = false;
            //    }
            //    else
            //    {
            //        GridViewChiTiet.Columns[4].Visible = true;
            //        txtTyGia.Enabled = true;
            //        txtTyGia.Text = "";
            //    }
            //}
            //else
            //{
            //    txtTyGia.Enabled = false;
            //    if (lookUpEditLoaiTien.EditValue.ToString() == "VND")
            //    {
            //        txtTyGia.Text = "1";
            //        GridViewChiTiet.Columns[4].Visible = false;
            //    }
            //    else
            //    {
            //        txtTyGia.Text = ChungTu_BUS.getTyGiaHienTai().ToString();
            //        GridViewChiTiet.Columns[4].Visible = true;
            //    }
            //}

        }

        private void txtTonQuy_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
