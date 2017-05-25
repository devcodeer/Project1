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
using DevExpress.LookAndFeel;

namespace KETOANVONBANGTIEN.ChungTu
{
    public partial class FrmDanhSachXyLyChenhLech : Form
    {
        public FrmDanhSachXyLyChenhLech()
        {
            InitializeComponent();

            groupControl4.Enabled = false;
            groupControl2.Enabled = false;
            lookUpEditLoaiDt.Enabled = false;
            groupControl3.Enabled = false;
            txtDiaChi.Enabled = false;

            LoadLookUpEditTienTe();
            LoadlookupeditDT();
            LoadlookUpEditLoaiDoiTuong();
        }

        private void FrmPhieuThu_Load(object sender, EventArgs e)
        {
            // txtTyGia.Enabled = false;
            if (chonloaiphieu.LuaChon == "PhieuThu")
            {
                this.Text = "Phiếu Thu";
                maphieu = 1;
                lblNguoiGiaoDich.Text = "Người nộp";

            }

            else if (chonloaiphieu.LuaChon == "PhieuChi")
            {
                this.Text = "Phiếu Chi";
                maphieu = 2;
                lblNguoiGiaoDich.Text = "Người nhận";
            }

            if (lc.LuaChon == "Edit")
            {
                TruyenDuLieu();
                DisableControl();
                btnIn.Enabled = true;


            }
            else if (lc.LuaChon == "Add")
            {
                try
                {
                    txtSoCt.Text = Function.Funtion.randomSoChungTu(maphieu);
                }
                catch
                { }
                dateEditNgayCt.DateTime = DateTime.Today;
                dateEditNgayGs.DateTime = DateTime.Today;
                lookUpEditLoaiTien.Text = "VND";
                txtTyGia.Text = "1";
                Init_ChiTietPhieu();
                btnIn.Enabled = false;
                btnSua.Enabled = false;
            }

            LoadLookUpEditTkNo_Co();
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
        private void LoadLookUpEditTienTe()
        {
            lookUpEditLoaiTien.Properties.DataSource = TienTe_BUS.loadDanhMucTienTe();
            lookUpEditLoaiTien.Properties.DisplayMember = "MaTien";
            lookUpEditLoaiTien.Properties.ValueMember = "MaTien";

            lookUpEditLoaiTien.EditValue = "VND";
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

        private void LoadlookUpEditLoaiDoiTuong()
        {
            DataTable dt = NhomDoiTuong_BUS.loadDanhSachNhomDoiTuong();

            dt.Rows.Add("NV", "Nhân Viên");

            lookUpEditLoaiDt.Properties.DataSource = dt;
            lookUpEditLoaiDt.Properties.DisplayMember = "TenNhom";
            lookUpEditLoaiDt.Properties.ValueMember = "MaNhom";


        }
        private void LoadlookupeditDT()
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

        private void lookUpEditLoaiDt_EditValueChanged(object sender, EventArgs e)
        {

            try
            {
                LoadlookupeditDtTheoNhom();
                txtTenDoiTuong.Text = "";
                txtDiaChi.Text = "";
            }
            catch
            { }
        }

        private void lookUpEditDT_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                txtTenDoiTuong.Text = lookUpEditDT.GetColumnValue("Ten").ToString();
                txtDiaChi.Text = lookUpEditDT.GetColumnValue("DiaChi").ToString();
            }
            catch
            { }
        }


        private void btnLuuVaDong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (lc.LuaChon == "Add")
            {
                try
                {
                    ThemMoi();
                    MessageBox.Show("Thêm mới thành công !");
                    DisableControl();
                    btnIn.Enabled = true;
                    btnSua.Enabled = true;

                }
                catch(Exception ex)
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
                    DisableControl();
                    btnIn.Enabled = true;
                    btnSua.Enabled = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Không sửa được, kiểm tra lại dữ liệu! " + ex.Message);

                }
            }
        }

        private void btnLuuVaMoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            btnIn.Enabled = false;

            ResetControl();
            EnableConTrol();
            groupControl4.Enabled = true;
            groupControl2.Enabled = true;
            lookUpEditLoaiDt.Enabled = true;
            groupControl3.Enabled = true;
            txtDiaChi.Enabled = true;
            lc.LuaChon = "Add";
        }

        private void btnDong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void ThemMoi()
        {
            string soct = txtSoCt.Text;
            string ngayct = dateEditNgayCt.Text.ToString();
            string ngayghiso = dateEditNgayGs.Text.ToString();
            string madt = lookUpEditDT.GetColumnValue("Ma").ToString();
            string diachi = txtDiaChi.Text;
            string nguoigd = txtNguoiGd.Text;
            string lydo = txtLyDo.Text;
            string kemtheo = txtKemTheo.Text;
            string matien = lookUpEditLoaiTien.GetColumnValue("MaTien").ToString();
            float tygia = float.Parse(txtTyGia.Text);

            ChungTu_DTO chungtu = new ChungTu_DTO(soct, maphieu, ngayct, ngayghiso, madt, nguoigd, diachi, lydo, kemtheo, matien, tygia, "", "", false);
            ChungTu_BUS.insertChungTu(chungtu);

            string tkno;
            string tkco;
            string noidung;
            decimal sotien = 0;
            decimal sotiennt = 0;
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
                else
                    if (matien == "USD")
                    {
                        sotiennt = Decimal.Parse(GridViewChiTiet.GetRowCellDisplayText(i, colSoTienNt).ToString());
                        sotien = sotiennt * decimal.Parse(tygia.ToString());
                    }

                ChiTietChungTu_DTO ct = new ChiTietChungTu_DTO(soct, tkno, tkco, noidung, sotiennt, sotien);
                ChiTietCT_BUS.insertChiTietChungTu(ct);
            }

        }

        private void Sua()
        {
            string soct = txtSoCt.Text;
            string ngayct = dateEditNgayCt.Text;
            string ngayghiso = dateEditNgayGs.Text;
            string madt = lookUpEditDT.GetColumnValue("Ma").ToString();
            string diachi = txtDiaChi.Text;
            string nguoigd = txtNguoiGd.Text;
            string lydo = txtLyDo.Text;
            string kemtheo = txtKemTheo.Text;
            string matien = lookUpEditLoaiTien.GetColumnValue("MaTien").ToString();
            float tygia = float.Parse(txtTyGia.Text);
            bool trangthai = obj.TrangThai;
            ChungTu_DTO chungtu = new ChungTu_DTO(soct, maphieu, ngayct, ngayghiso, madt, nguoigd, diachi, lydo, kemtheo, matien, tygia, "", "", trangthai);
            ChungTu_BUS.updateChungTu(obj.SoCt, chungtu);

            int id;
            string tkno;
            string tkco;
            string noidung;
            decimal sotien = 0;
            decimal sotiennt = 0;
            int rowcount = GridViewChiTiet.RowCount;

            if (sodonggoc <= rowcount)
            {
                for (int i = 0; i < sodonggoc - 1; i++)
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
                    ChiTietChungTu_DTO ct = new ChiTietChungTu_DTO(soct, tkno, tkco, noidung, sotiennt, sotien);
                    ChiTietCT_BUS.updateChiTietChungTu(id, ct);
                }
                for (int i = sodonggoc - 1; i < (rowcount - 1); i++)
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
                    ChiTietChungTu_DTO ct = new ChiTietChungTu_DTO(soct, tkno, tkco, noidung, sotiennt, sotien);
                    ChiTietCT_BUS.insertChiTietChungTu(ct);
                }
            }


        }



        public LuaChon_DTO chonloaiphieu = new LuaChon_DTO();
        public LuaChon_DTO lc = new LuaChon_DTO();
        private int maphieu;
        public ChungTu_DTO obj = new ChungTu_DTO();
        private int sodonggoc;

        private void TruyenDuLieu()
        {

            lookUpEditDT.Text = obj.MaDt;
            txtNguoiGd.Text = obj.NguoiGd;
            txtDiaChi.Text = obj.DiaChi;
            txtLyDo.Text = obj.LyDo;
            txtKemTheo.Text = obj.KemTheo;
            txtSoCt.Text = obj.SoCt;
            dateEditNgayCt.Text = obj.NgayCt;
            dateEditNgayGs.Text = obj.NgayGhiSo;
            LoadLookUpEditTienTe();
            lookUpEditLoaiTien.Text = obj.MaTien;
            txtTyGia.Text = obj.TyGia.ToString();

            grvChiTiet.DataSource = ChiTietCT_BUS.LoadChiTietCT(obj.SoCt);
            sodonggoc = GridViewChiTiet.RowCount;

        }

        private void btnXoaDong_Click(object sender, EventArgs e)
        {

            try
            {
                int idDelete = int.Parse(GridViewChiTiet.GetRowCellValue(GridViewChiTiet.FocusedRowHandle, colId).ToString());
                Sua();
                ChiTietCT_BUS.deleteChiTietChungTu(idDelete);
                grvChiTiet.DataSource = ChiTietCT_BUS.LoadChiTietCT(obj.SoCt);
                sodonggoc = GridViewChiTiet.RowCount;

            }
            catch
            {
                GridViewChiTiet.DeleteRow(GridViewChiTiet.FocusedRowHandle);
            }

        }

        private void ResetControl()
        {
            lookUpEditLoaiDt.EditValue = "";
            lookUpEditDT.EditValue = "";
            txtTenDoiTuong.Text = "";
            txtDiaChi.Text = "";
            txtNguoiGd.Text = "";
            txtLyDo.Text = "";
            txtKemTheo.Text = "";
            txtTyGia.Text = "";
            txtSoCt.Text = Function.Funtion.randomSoChungTu(maphieu);
            lookUpEditLoaiTien.EditValue = "";
            dateEditNgayCt.DateTime = DateTime.Today;
            dateEditNgayGs.DateTime = DateTime.Today;
            Init_ChiTietPhieu();

        }

        //private void lookUpEditLoaiTien_EditValueChanged(object sender, EventArgs e)
        //{
        //    if (lookUpEditLoaiTien.Text == "VND")
        //    {
        //        txtTyGia.Text = "1";
        //        colSoTienNt.Visible = false;
        //        colSoTien.OptionsColumn.ReadOnly = false;
        //    }
        //    else
        //    {
        //        colSoTienNt.Visible = true;
        //        colSoTien.OptionsColumn.ReadOnly = true;
        //    }
        //}

        private void btnIn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DataTable dt1 = ChungTu_BUS.loadChungTuBySoChungTu(txtSoCt.Text);

            decimal sotien = 0;
            decimal sotiennt = 0;
            try
            {
                sotien = decimal.Parse(dt1.Rows[0]["SoTien"].ToString());
                sotiennt = decimal.Parse(dt1.Rows[0]["SoTienNt"].ToString());

            }
            catch(Exception ex) {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            };

            string nguoigd = dt1.Rows[0]["NguoiGd"].ToString();
            string tendt = dt1.Rows[0]["TenDt"].ToString();
            if (tendt != "")
            {
                nguoigd = nguoigd + " - " + tendt;
            }

            string tkno = "";
            string tkco = "";
            int rowcount = GridViewChiTiet.RowCount;

            for (int i = 0; i < rowcount - 1; i++)
            {
                if (tkno == "")
                {
                    tkno = tkno + GridViewChiTiet.GetRowCellDisplayText(i, colTkNo).ToString();
                    tkco = tkco + GridViewChiTiet.GetRowCellDisplayText(i, colTkCo).ToString();
                }
                else
                {
                    tkno = tkno + ", " + GridViewChiTiet.GetRowCellDisplayText(i, colTkNo).ToString();
                    tkco = tkco + ", " + GridViewChiTiet.GetRowCellDisplayText(i, colTkCo).ToString();
                }
            }

            string tentien = dt1.Rows[0]["MaTien"].ToString();
            if (tentien == "VND")
            {
                BaoCao.PhieuThuChi.rptPHIEUTHU rpt = new BaoCao.PhieuThuChi.rptPHIEUTHU();

                DataSet ds = new DataSet();
                ds.Tables.Add(dt1);
                string tienchu = Function.Funtion.DecimalToString(sotien);
                tienchu = tienchu + " đồng chẵn";

                rpt.DataSource = ds;
                rpt.DataMember = "Table";
                if (maphieu == 1)
                {
                    rpt.lblTenPhieu.Text = "PHIẾU THU";
                    rpt.lblTenNguoiGd.Text = "Họ và tên người nộp tiền:";
                    rpt.lblNguoigd.Text = "Người nộp tiền";

                }
                else if (maphieu == 2)
                {
                    rpt.lblTenPhieu.Text = "PHIẾU CHI";
                    rpt.lblTenNguoiGd.Text = "Họ và tên người nhận tiền:";
                    rpt.lblNguoigd.Text = "Người nhận tiền";
                }
                rpt.parameterTenDt.Value = nguoigd;
                rpt.parameterTenDt.Visible = false;
                rpt.TienChu.Value = tienchu;
                rpt.TienChu.Visible = false;
                rpt.TkNo.Value = tkno;
                rpt.TkNo.Visible = false;
                rpt.TkCo.Value = tkco;
                rpt.TkCo.Visible = false;
                rpt.CreateLayoutViewDocument();

                // //-- Trong: 21-May-2017 ---// //
                // block code print report //
                using (DevExpress.XtraReports.UI.ReportPrintTool printTool = new DevExpress.XtraReports.UI.ReportPrintTool(rpt))
                {
                    // Invoke the Ribbon Print Preview form modally, 
                    // and load the report document into it.
                    printTool.ShowRibbonPreviewDialog();

                    // Invoke the Ribbon Print Preview form
                    // with the specified look and feel setting.
                   // printTool.ShowRibbonPreviewDialog(UserLookAndFeel.Default);
                }
            }

            else if (tentien == "USD")
            {
                BaoCao.PhieuThuChi.RptPhieuThuChiNt rpt1 = new BaoCao.PhieuThuChi.RptPhieuThuChiNt();
                DataSet ds = new DataSet();
                ds.Tables.Add(dt1);
                string tienchu = Function.Funtion.DecimalToString(sotiennt);
                tienchu = tienchu + " đô la Mỹ";

                rpt1.DataSource = ds;
                rpt1.DataMember = "Table";
                if (maphieu == 1)
                {
                    rpt1.lblTenPhieu.Text = "PHIẾU THU";
                    rpt1.lblTenNguoiGd.Text = "Họ và tên người nộp tiền:";
                    rpt1.lblNguoigd.Text = "Người nộp tiền";

                }
                else if (maphieu == 2)
                {
                    rpt1.lblTenPhieu.Text = "PHIẾU CHI";
                    rpt1.lblTenNguoiGd.Text = "Họ và tên người nhận tiền:";
                    rpt1.lblNguoigd.Text = "Người nhận tiền";
                }
                rpt1.parameterTenDt.Value = nguoigd;
                rpt1.parameterTenDt.Visible = false;
                rpt1.TienChu.Value = tienchu;
                rpt1.TienChu.Visible = false;
                rpt1.TkNo.Value = tkno;
                rpt1.TkNo.Visible = false;
                rpt1.TkCo.Value = tkco;
                rpt1.TkCo.Visible = false;

                using (DevExpress.XtraReports.UI.ReportPrintTool printTool = new DevExpress.XtraReports.UI.ReportPrintTool(rpt1))
                {
                    // Invoke the Ribbon Print Preview form modally, 
                    // and load the report document into it.
                    printTool.ShowRibbonPreviewDialog();

                    // Invoke the Ribbon Print Preview form
                    // with the specified look and feel setting.
                   // printTool.ShowRibbonPreviewDialog(UserLookAndFeel.Default);
                }
                //rpt1.ShowPrintStatusDialog();
                //rpt1.CreateLayoutViewDocument();
            }

        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            EnableConTrol();
            lc.LuaChon = "Edit";
            btnIn.Enabled = false;
            btnSua.Enabled = false;
            obj.SoCt = txtSoCt.Text;
            grvChiTiet.DataSource = ChiTietCT_BUS.LoadChiTietCT(obj.SoCt);
            sodonggoc = GridViewChiTiet.RowCount;
        }

        private void DisableControl()
        {

            lookUpEditLoaiDt.Properties.ReadOnly = true;
            lookUpEditLoaiTien.Properties.ReadOnly = true;
            lookUpEditDT.Properties.ReadOnly = true;
            txtTenDoiTuong.ReadOnly = true;
            txtNguoiGd.ReadOnly = true;
            txtDiaChi.ReadOnly = true;
            txtLyDo.ReadOnly = true;
            txtKemTheo.ReadOnly = true;
            txtSoCt.Properties.ReadOnly = true;
            dateEditNgayCt.Properties.ReadOnly = true;
            dateEditNgayGs.Properties.ReadOnly = true;
            txtTyGia.Properties.ReadOnly = true;
            GridViewChiTiet.OptionsBehavior.ReadOnly = true;
        }

        private void EnableConTrol()
        {
            lookUpEditLoaiDt.Properties.ReadOnly = false;
            lookUpEditLoaiTien.Properties.ReadOnly = false;
            lookUpEditDT.Properties.ReadOnly = false;
            txtTenDoiTuong.ReadOnly = false;
            txtNguoiGd.ReadOnly = false;
            txtDiaChi.ReadOnly = false;
            txtLyDo.ReadOnly = false;
            txtKemTheo.ReadOnly = false;
            txtSoCt.Properties.ReadOnly = false;
            dateEditNgayCt.Properties.ReadOnly = false;
            dateEditNgayGs.Properties.ReadOnly = false;
            txtTyGia.Properties.ReadOnly = false;
            GridViewChiTiet.OptionsBehavior.ReadOnly = false;
        }

        private void lookUpEditLoaiTien_TextChanged(object sender, EventArgs e)
        {

        }

        private void lookUpEditLoaiTien_EditValueChanged(object sender, EventArgs e)
        {
            if (chonloaiphieu.LuaChon == "PhieuThu")
            {
                if (lookUpEditLoaiTien.EditValue.ToString() == "VND")
                {
                    txtTyGia.Text = "1";
                    GridViewChiTiet.Columns[4].Visible = false;
                    txtTyGia.Enabled = false;
                }
                else
                {
                    GridViewChiTiet.Columns[4].Visible = true;
                    txtTyGia.Enabled = true;
                    txtTyGia.Text = "";
                }
            }
            else
            {
                txtTyGia.Enabled = false;
                if (lookUpEditLoaiTien.EditValue.ToString() == "VND")
                {
                    txtTyGia.Text = "1";
                    GridViewChiTiet.Columns[4].Visible = false;
                }
                else
                {
                    txtTyGia.Text = ChungTu_BUS.getTyGiaHienTai().ToString();
                    GridViewChiTiet.Columns[4].Visible = true;
                }
            }
        }

        // 20-May-2017 Trong
        private void tinhToanSoTienKhiInsertChiTietPhieu(object sender, EventArgs e)
        {
           
        }

        private void grvChiTiet_TextChanged(object sender, EventArgs e)
        {
            if(GridViewChiTiet.GetRowCellDisplayText(GridViewChiTiet.FocusedRowHandle, colSoTienNt) != null)
            {
                int soTienNgoaiTe = int.Parse(GridViewChiTiet.GetRowCellDisplayText(GridViewChiTiet.FocusedRowHandle, colSoTienNt).ToString());
                int soTien = (soTienNgoaiTe * (int.Parse(txtTyGia.Text.ToString())));
                GridViewChiTiet.SetFocusedRowCellValue(colSoTien, soTien);
            }
        }
    }
}
