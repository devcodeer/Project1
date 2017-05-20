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
    public partial class FrmGiayBaoCo : Form
    {
        public LuaChon_DTO luaChon = new LuaChon_DTO();
        public ChungTu_DTO chungTu = new ChungTu_DTO();
        private int soDongGoc;
        private static int MA_SO_GIAY_BAO_CO = 4;

        public FrmGiayBaoCo()
        {
            InitializeComponent();
            loadLookUpEditDoiTuong();
            loadLookUpEditLoaiDoiTuong();
            loadLookUpEditTienTe();
            loadLookUpEditTaiKhoanNganHang();

            groupControl4.Enabled = false;
            groupControl2.Enabled = false;
            lookUpEditLoaiDt.Enabled = false;
            groupControl3.Enabled = false;
            txtDiaChi.Enabled = false;
        }

        private void FrmGiayBaoCo_Load(object sender, EventArgs e)
        {

            if (luaChon.LuaChon == "Edit")
            {
                TruyenDuLieu();
                DisableControl();
                btnIn.Enabled = true;
                groupControl3.Enabled = true;
                groupControl4.Enabled = true;
                groupControl2.Enabled = true;
                lookUpEditLoaiDt.Enabled = true;
            }
            else if (luaChon.LuaChon == "Add")
            {
                groupControl3.Enabled = true;
                groupControl4.Enabled = true;
                groupControl2.Enabled = true;
                lookUpEditLoaiDt.Enabled = true;
                txtSoCt.Text = Function.Funtion.randomSoChungTu(4);
                dateEditNgayCt.DateTime = DateTime.Today;
                dateEditNgayGhiSo.DateTime = DateTime.Today;
                lookUpEditLoaiTien.Text = "VND";
                txtTyGia.Text = "1";
                Init_ChiTietPhieu();
                btnIn.Enabled = false;
                btnSua.Enabled = false;
            }

            LoadLookUpEditTkNo_Co(); 
        }



        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (luaChon.LuaChon == "Add")
            {
                try
                {
                    doInsertChungTu();
                    MessageBox.Show("Thêm mới thành công !");
                    DisableControl();
                    btnIn.Enabled = true;
                    btnSua.Enabled = true;

                }
                catch(Exception ex)
                {
                    MessageBox.Show("Không thêm được, kiểm tra lại dữ liệu ! " + ex.Message);
                }
            }
            else if (luaChon.LuaChon == "Edit")
            {
                try
                {
                    doUpdateChungTu();
                    MessageBox.Show("Sửa thành công ! ");
                    DisableControl();
                    btnIn.Enabled = true;
                    btnSua.Enabled = true;
                }
                catch
                {
                    MessageBox.Show("Sửa không thành công, kiểm tra lại dữ liệu !");

                }
            }
        }

        private void btnLuuVaMoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            btnIn.Enabled = false;
            ResetControl();
            EnableConTrol();
            luaChon.LuaChon = "Add"; 
        }

        private void btnDong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void Init_ChiTietPhieu()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("TkNo", typeof(string));
            dt.Columns.Add("TkCo", typeof(string));
            dt.Columns.Add("NoiDung", typeof(string));
            dt.Columns.Add("SoTienNT", typeof(decimal));
            dt.Columns.Add("SoTien", typeof(decimal));
            grvChiTiet.DataSource = dt;

        }
        private void loadLookUpEditTienTe()
        {
            lookUpEditLoaiTien.Properties.DataSource = TienTe_BUS.loadDanhMucTienTe();
            lookUpEditLoaiTien.Properties.DisplayMember = "MaTien";
            lookUpEditLoaiTien.Properties.ValueMember = "MaTien";
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

        private void loadLookUpEditLoaiDoiTuong()
        {
            DataTable dt = NhomDoiTuong_BUS.loadDanhSachNhomDoiTuong();

            dt.Rows.Add("NV", "Nhân Viên");

            lookUpEditLoaiDt.Properties.DataSource = dt;
            lookUpEditLoaiDt.Properties.DisplayMember = "TenNhom";
            lookUpEditLoaiDt.Properties.ValueMember = "MaNhom";
        }

        private void loadLookUpEditDoiTuong()
        {
            lookUpEditDT.Properties.DataSource = DoiTuong_BUS.loadListCustomerProviderEmployee();
            lookUpEditDT.Properties.DisplayMember = "Ma";
            lookUpEditDT.Properties.ValueMember = "Ma";
        }

        private void LoadlookupeditDtTheoNhom()
        {
            if (lookUpEditLoaiDt.GetColumnValue("MaNhom").ToString() == "NV")
            {
                lookUpEditDT.Properties.DataSource = NhanVien_BUS.loadListEmployee();
                lookUpEditDT.Properties.DisplayMember = "Ma";
                lookUpEditDT.Properties.ValueMember = "Ma";
            }

            else
            {
                lookUpEditDT.Properties.DataSource = DoiTuong_BUS.loadListCustomerOrProvider(lookUpEditLoaiDt.GetColumnValue("MaNhom").ToString());
                lookUpEditDT.Properties.DisplayMember = "Ma";
                lookUpEditDT.Properties.ValueMember = "Ma";
            }

        }

        private void loadLookUpEditTaiKhoanNganHang()
        {
            lookUpEditTaiKhoanNH.Properties.DataSource = TaiKhoanNganHang_BUS.loadDanhMucTaiKhoanNganHang();
            lookUpEditTaiKhoanNH.Properties.DisplayMember = "SoTknh";
            lookUpEditTaiKhoanNH.Properties.ValueMember = "SoTknh";
        }

        private void lookUpEditLoaiDt_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                LoadlookupeditDtTheoNhom();
                txtTenDoiTuong.Text = "";
                txtDiaChi.Text = "";
            }
            catch
            { 
            }
        }

        private void lookUpEditDT_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                txtTenDoiTuong.Text = lookUpEditDT.GetColumnValue("Ten").ToString();
                txtDiaChi.Text = lookUpEditDT.GetColumnValue("DiaChi").ToString();
            }
            catch
            { 
            }
        }

        private void lookUpEditTaiKhoanNH_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                txtTenTknh.Text = lookUpEditTaiKhoanNH.GetColumnValue("TenTknh").ToString();
            }
            catch
            { }
        }


        private void doInsertChungTu()
        {
            string soct = txtSoCt.Text;
            DateTime ngayct = dateEditNgayCt.DateTime;
            DateTime ngayghiso = dateEditNgayGhiSo.DateTime;

            string tknhden = lookUpEditTaiKhoanNH.GetColumnValue("SoTknh").ToString();
            
            string madt = lookUpEditDT.GetColumnValue("Ma").ToString();
            string diachi = txtDiaChi.Text;
            string lydo = txtLyDo.Text;
            string matien = lookUpEditLoaiTien.GetColumnValue("MaTien").ToString();
            float tygia = float.Parse(txtTyGia.Text);

            ChungTu_DTO chungtu = new ChungTu_DTO(soct, 4, ngayct, ngayghiso, madt, "", diachi, lydo, "", matien, tygia,"", tknhden, false);
            ChungTu_BUS.insertChungTu(chungtu);

            string tkno;
            string tkco;
            string noidung;
            decimal sotien=0 ;
            decimal sotiennt=0 ;
            int rowcount = GridViewChiTiet.RowCount;
            for (int i = 0; i < rowcount - 1; i++)
            {

                tkno = GridViewChiTiet.GetRowCellDisplayText(i, colTkNo).ToString();
                tkco = GridViewChiTiet.GetRowCellDisplayText(i, colTkCo).ToString();
                noidung = GridViewChiTiet.GetRowCellDisplayText(i, colNoiDung).ToString();

                if (matien == "VND")
                {
                    sotiennt = 0;
                    sotien = Decimal.Parse(GridViewChiTiet.GetRowCellDisplayText(i, colSoTien).ToString());
                }
                else if (matien != "VND")
                {
                    sotiennt = Decimal.Parse(GridViewChiTiet.GetRowCellDisplayText(i, colSoTienNt).ToString());
                    sotien = sotiennt * decimal.Parse(tygia.ToString());
                }

                ChiTietChungTu_DTO chiTietChungTu = new ChiTietChungTu_DTO(soct, tkno, tkco, noidung,sotiennt,sotien);
                ChiTietCT_BUS.insertChiTietChungTu(chiTietChungTu);
            }              

        }

        private void doUpdateChungTu()
        {
            string soct = txtSoCt.Text;
            DateTime ngayct = dateEditNgayCt.DateTime;
            DateTime ngayghiso = dateEditNgayGhiSo.DateTime;
            string tknhden = lookUpEditTaiKhoanNH.GetColumnValue("SoTknh").ToString();                       
            string madt = lookUpEditDT.GetColumnValue("Ma").ToString();
            string diachi = txtDiaChi.Text;
            string lydo = txtLyDo.Text;
            string matien = lookUpEditLoaiTien.GetColumnValue("MaTien").ToString();
            float tygia = float.Parse(txtTyGia.Text);
            bool trangthai = chungTu.TrangThai;
            ChungTu_DTO chungtu = new ChungTu_DTO(soct, 4, ngayct, ngayghiso, madt, "", diachi, lydo, "", matien, tygia,"", tknhden, trangthai);
            ChungTu_BUS.updateChungTu(chungTu.SoCt, chungtu);

            int id;
            string tkno;
            string tkco;
            string noidung;
            decimal sotien=0;
            decimal sotiennt=0;
            int rowcount = GridViewChiTiet.RowCount;
            if (soDongGoc <= rowcount)
            {
                for (int i = 0; i < soDongGoc - 1; i++)
                {
                    id = int.Parse(GridViewChiTiet.GetRowCellDisplayText(i, colId).ToString());
                    tkno = GridViewChiTiet.GetRowCellDisplayText(i, colTkNo).ToString();
                    tkco = GridViewChiTiet.GetRowCellDisplayText(i, colTkCo).ToString();
                    noidung = GridViewChiTiet.GetRowCellDisplayText(i, colNoiDung).ToString();
                    if (matien == "VND")
                    {
                        sotiennt = 0;
                        sotien = Decimal.Parse(GridViewChiTiet.GetRowCellDisplayText(i, colSoTien).ToString());
                    }
                    else if (matien != "VND")
                    {
                        sotiennt = Decimal.Parse(GridViewChiTiet.GetRowCellDisplayText(i, colSoTienNt).ToString());
                        sotien = sotiennt * decimal.Parse(tygia.ToString());
                    }
                    ChiTietChungTu_DTO ct = new ChiTietChungTu_DTO(soct, tkno, tkco, noidung, sotiennt,sotien);
                    ChiTietCT_BUS.updateChiTietChungTu(id, ct);
                }

                for (int i = soDongGoc - 1; i < (rowcount - 1); i++)
                {
                    tkno = GridViewChiTiet.GetRowCellDisplayText(i, colTkNo).ToString();
                    tkco = GridViewChiTiet.GetRowCellDisplayText(i, colTkCo);
                    noidung = GridViewChiTiet.GetRowCellDisplayText(i, colNoiDung).ToString();
                    if (matien == "VND")
                    {
                        sotiennt = 0;
                        sotien = Decimal.Parse(GridViewChiTiet.GetRowCellDisplayText(i, colSoTien).ToString());
                    }
                    else if (matien != "VND")
                    {
                        sotiennt = Decimal.Parse(GridViewChiTiet.GetRowCellDisplayText(i, colSoTienNt).ToString());
                        sotien = sotiennt * decimal.Parse(tygia.ToString());
                    }
                    ChiTietChungTu_DTO ct = new ChiTietChungTu_DTO(soct, tkno, tkco, noidung, sotiennt,sotien);
                    ChiTietCT_BUS.insertChiTietChungTu(ct);
                }
            }
            else if (soDongGoc > rowcount)
            {
                for (int i = 0; i < rowcount - 1; i++)
                {
                    id = int.Parse(GridViewChiTiet.GetRowCellDisplayText(i, colId).ToString());
                    tkno = GridViewChiTiet.GetRowCellDisplayText(i, colTkNo).ToString();
                    tkco = GridViewChiTiet.GetRowCellDisplayText(i, colTkCo).ToString();
                    noidung = GridViewChiTiet.GetRowCellDisplayText(i, colNoiDung).ToString();
                    if (matien == "VND")
                    {
                        sotiennt = 0;
                        sotien = Decimal.Parse(GridViewChiTiet.GetRowCellDisplayText(i, colSoTien).ToString());
                    }
                    else if (matien != "VND")
                    {
                        sotiennt = Decimal.Parse(GridViewChiTiet.GetRowCellDisplayText(i, colSoTienNt).ToString());
                        sotien = sotiennt * decimal.Parse(tygia.ToString());
                    }
                    ChiTietChungTu_DTO ct = new ChiTietChungTu_DTO(soct, tkno, tkco, noidung, sotiennt,sotien);
                    ChiTietCT_BUS.updateChiTietChungTu(id, ct);
                }
            }
                   


        }

        private void TruyenDuLieu()
        {
            loadLookUpEditTaiKhoanNganHang();
            lookUpEditTaiKhoanNH.Text = chungTu.TknhDen;
            lookUpEditDT.Text = chungTu.MaDt;
            txtDiaChi.Text = chungTu.DiaChi;
            txtLyDo.Text = chungTu.LyDo;            
            txtSoCt.Text = chungTu.SoCt;
            dateEditNgayCt.DateTime = chungTu.NgayCt;
            dateEditNgayGhiSo.DateTime = chungTu.NgayGhiSo;
            loadLookUpEditTienTe();
            lookUpEditLoaiTien.Text = chungTu.MaTien;
            txtTyGia.Text = chungTu.TyGia.ToString();

            grvChiTiet.DataSource = ChiTietCT_BUS.LoadChiTietCT(chungTu.SoCt);
            soDongGoc = GridViewChiTiet.RowCount;

        }

        private void btnXoaDong_Click(object sender, EventArgs e)
        {
            try
            {
                int idDelete = int.Parse(GridViewChiTiet.GetRowCellValue(GridViewChiTiet.FocusedRowHandle, colId).ToString());
                doUpdateChungTu();
                ChiTietCT_BUS.deleteChiTietChungTu(idDelete);
                grvChiTiet.DataSource = ChiTietCT_BUS.LoadChiTietCT(chungTu.SoCt);
                soDongGoc = GridViewChiTiet.RowCount;

            }
            catch
            {
                GridViewChiTiet.DeleteRow(GridViewChiTiet.FocusedRowHandle);
            }
        }

        private void ResetControl()
        {
            lookUpEditDT.EditValue = "";
            lookUpEditLoaiDt.EditValue= "";
            txtTenDoiTuong.Text = "";
            txtDiaChi.Text = "";
            txtTenTknh.Text = "";
            txtLyDo.Text = "";
            txtTyGia.Text = "";
            txtSoCt.Text = Function.Funtion.randomSoChungTu(MA_SO_GIAY_BAO_CO);
            lookUpEditLoaiTien.EditValue = "";
            lookUpEditTaiKhoanNH.EditValue = "";
            
            dateEditNgayCt.DateTime = DateTime.Today;
            dateEditNgayGhiSo.DateTime = DateTime.Today;
            Init_ChiTietPhieu();
            lookUpEditLoaiDt.Focus();

        }

        private void lookUpEditLoaiTien_EditValueChanged(object sender, EventArgs e)
        {
            if (lookUpEditLoaiTien.Text == "VND")
            {
                txtTyGia.Text = "1";
                colSoTienNt.Visible = false;
                colSoTien.OptionsColumn.ReadOnly = false;
            }
            else
            {
                colSoTienNt.Visible = true;
                colSoTien.OptionsColumn.ReadOnly = true;
                
            }
        }

        private void btnIn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DataTable dt = ChungTu_BUS.loadChungTuBySoChungTu(txtSoCt.Text);
            string tentien = dt.Rows[0]["MaTien"].ToString();
            decimal sotien=0;
            string tienchu="";
            if (tentien == "VND")
            {
                try
                {
                    sotien = decimal.Parse(dt.Rows[0]["SoTien"].ToString());
                    tienchu = Function.Funtion.DecimalToString(sotien) + " đồng chẵn";
                }
                catch
                { }
            }
            else
            {
                try
                {
                    sotien = decimal.Parse(dt.Rows[0]["SoTienNt"].ToString());
                    tienchu = Function.Funtion.DecimalToString(sotien) + " đô la Mỹ";
                }
                catch (FormatException ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            BaoCao.GiayBaoNganHang.RptGiayBaoNganHang rpt = new BaoCao.GiayBaoNganHang.RptGiayBaoNganHang();
            rpt.DataSource = ChiTietCT_BUS.LoadChiTietCtLenGB(txtSoCt.Text);
            rpt.DataMember = "Table";
            rpt.lblTenPhieu.Text = "GIẤY BÁO CÓ";
            rpt.lblTenNguoiGd.Text = "Người nộp tiền:";
            rpt.colSoTienNguyenTe.Text = "Số tiền nguyên tệ (" + tentien + ")";
            rpt.ptDiaChi.Value = txtDiaChi.Text;
            rpt.ptSoCt.Value = txtSoCt.Text;
            rpt.ptNgayCt.Value = dateEditNgayCt.DateTime;
            rpt.ptNguoiGd.Value = txtTenDoiTuong.Text;
            rpt.ptLyDo.Value = txtLyDo.Text;
            rpt.ptLoaiTien.Value = lookUpEditLoaiTien.GetColumnValue("MaTien").ToString();
            rpt.ptTaiKhoan.Value = GridViewChiTiet.GetRowCellDisplayText(0, colTkNo).ToString();
            rpt.ptSoTien.Value = sotien;
            rpt.ptTienChu.Value = tienchu;

            rpt.ptDiaChi.Visible = false;
            rpt.ptLoaiTien.Visible = false;
            rpt.ptLyDo.Visible = false;
            rpt.ptSoCt.Visible = false;
            rpt.ptTaiKhoan.Visible = false;
            rpt.ptSoTien.Visible = false;
            rpt.ptTienChu.Visible = false;
            rpt.ptNgayCt.Visible = false;
            rpt.ptNguoiGd.Visible = false;
          //  rpt.ShowPreview();
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            EnableConTrol();
            luaChon.LuaChon = "Edit";
            btnIn.Enabled = false;
            btnSua.Enabled = false;
            chungTu.SoCt = txtSoCt.Text;
            grvChiTiet.DataSource = ChiTietCT_BUS.LoadChiTietCT(chungTu.SoCt);
            soDongGoc = GridViewChiTiet.RowCount;
        }
        private void DisableControl()
        {

            lookUpEditLoaiDt.Properties.ReadOnly = true;
            lookUpEditLoaiTien.Properties.ReadOnly = true;
            lookUpEditDT.Properties.ReadOnly = true;
            txtTenDoiTuong.ReadOnly = true;
            lookUpEditTaiKhoanNH.Properties.ReadOnly = true;
            txtTenTknh.ReadOnly = true;
            txtDiaChi.ReadOnly = true;
            txtLyDo.ReadOnly = true;            
            txtSoCt.ReadOnly = true;
            dateEditNgayCt.Properties.ReadOnly = true;
            dateEditNgayGhiSo.Properties.ReadOnly = true;
            txtTyGia.Properties.ReadOnly = true;
            GridViewChiTiet.OptionsBehavior.ReadOnly = true;
        }

        private void EnableConTrol()
        {

            lookUpEditLoaiDt.Properties.ReadOnly = false;
            lookUpEditLoaiTien.Properties.ReadOnly = false;
            lookUpEditDT.Properties.ReadOnly = false;
            txtTenDoiTuong.ReadOnly = false;
            lookUpEditTaiKhoanNH.Properties.ReadOnly = false;
            txtTenTknh.ReadOnly = false;
            txtDiaChi.ReadOnly = false;
            txtLyDo.ReadOnly = false;
            txtSoCt.ReadOnly = false;
            dateEditNgayCt.Properties.ReadOnly = false;
            dateEditNgayGhiSo.Properties.ReadOnly = false;
            txtTyGia.Properties.ReadOnly = false;
            GridViewChiTiet.OptionsBehavior.ReadOnly = false;

            groupControl3.Enabled = true;
            groupControl4.Enabled = true;
            groupControl2.Enabled = true;
            lookUpEditLoaiDt.Enabled = true;
        }


       

    }
}
