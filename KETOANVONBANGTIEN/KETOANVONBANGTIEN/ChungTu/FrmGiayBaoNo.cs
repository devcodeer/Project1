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
    public partial class FrmGiayBaoNo : Form
    {
        public FrmGiayBaoNo()
        {
            InitializeComponent();
            LoadlookupeditDT();
            LoadlookUpEditLoaiDoiTuong();
            LoadLookUpEditTienTe();
            LoadlookupeditTknh();
        }

        private void FrmGiayBaoNo_Load(object sender, EventArgs e)
        {

            if (lc.LuaChon == "Edit")
            {
                TruyenDuLieu();                
                DisableControl();
                btnIn.Enabled = true;
                btnInGiayBao.Enabled = true;
            }
            else if (lc.LuaChon == "Add")
            {
                btnIn.Enabled = false;
                btnInGiayBao.Enabled = false;
                btnSua.Enabled = false;
                txtSoCt.Text = Function.Funtion.randomSoChungTu(3);
                dateEditNgayCt.DateTime = DateTime.Today;
                dateEditNgayGhiSo.DateTime = DateTime.Today;
                lookUpEditLoaiTien.Text = "VND";
                txtTyGia.Text = "1";
                Init_ChiTietPhieu();

            }

            LoadLookUpEditTkNo_Co();       
        }
        
        
        public LuaChon_DTO lc = new LuaChon_DTO();
        public ChungTu_DTO obj = new ChungTu_DTO();
        private int sodonggoc;



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
                    btnInGiayBao.Enabled = true;
                    btnSua.Enabled = true;

                }
                catch
                {
                    MessageBox.Show("Không thêm được,kiểm tra lại dữ liệu !");

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
                    btnInGiayBao.Enabled = true;
                    btnSua.Enabled = true;
                }
                catch
                {
                    MessageBox.Show("Không sửa được, kiểm tra lại dữ liệu !");

                }
            }
        }

        private void btnLuuVaMoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            btnIn.Enabled = false;
            btnInGiayBao.Enabled = false;
            ResetControl();
            EnableConTrol();
            lc.LuaChon = "Add";
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

        private void LoadlookupeditTknh()
        {
            lookUpEditTaiKhoanNH.Properties.DataSource = TaiKhoanNganHang_BUS.loadDanhMucTaiKhoanNganHang();
            lookUpEditTaiKhoanNH.Properties.DisplayMember = "SoTknh";
            lookUpEditTaiKhoanNH.Properties.ValueMember = "SoTknh";
        }
                 

        private void lookUpEditLoaiDt_EditValueChanged_1(object sender, EventArgs e)
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
                txtTkDen.Text = lookUpEditDT.GetColumnValue("SoTknh").ToString();
            }
            catch
            { }

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

        private void ThemMoi()
        {
            string soct = txtSoCt.Text;
            DateTime ngayct = dateEditNgayCt.DateTime;
            DateTime ngayghiso = dateEditNgayGhiSo.DateTime;
            
            string tknhdi = lookUpEditTaiKhoanNH.GetColumnValue("SoTknh").ToString();
            string tknhden = txtTkDen.Text;
            string madt = lookUpEditDT.GetColumnValue("Ma").ToString();
            string diachi = txtDiaChi.Text;            
            string lydo = txtLyDo.Text;           
            string matien = lookUpEditLoaiTien.GetColumnValue("MaTien").ToString();
            float tygia = float.Parse(txtTyGia.Text);

            ChungTu_DTO chungtu = new ChungTu_DTO(soct, 3, ngayct, ngayghiso, madt, "", diachi, lydo, "", matien, tygia, tknhdi,tknhden,false);
            ChungTu_BUS.insertChungTu(chungtu);

            string tkno;
            string tkco;
            string noidung;
            decimal sotien=0;
            decimal sotiennt=0;
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

                ChiTietChungTu_DTO ct = new ChiTietChungTu_DTO(soct, tkno, tkco, noidung, sotiennt,sotien);
                ChiTietCT_BUS.insertChiTietChungTu(ct);
            }

        }

        private void Sua()
        {
            string soct = txtSoCt.Text;
            DateTime ngayct = dateEditNgayCt.DateTime;
            DateTime ngayghiso = dateEditNgayGhiSo.DateTime;

            string tknhdi = lookUpEditTaiKhoanNH.GetColumnValue("SoTknh").ToString();
            string tknhden = txtTkDen.Text;
            string madt = lookUpEditDT.GetColumnValue("Ma").ToString();
            string diachi = txtDiaChi.Text;
            string lydo = txtLyDo.Text;
            string matien = lookUpEditLoaiTien.GetColumnValue("MaTien").ToString();
            float tygia = float.Parse(txtTyGia.Text);
            bool trangthai = obj.TrangThai;
            ChungTu_DTO chungtu = new ChungTu_DTO(soct, 3, ngayct, ngayghiso, madt, "", diachi, lydo, "", matien, tygia, tknhdi, tknhden, trangthai);
            ChungTu_BUS.updateChungTu(obj.SoCt, chungtu);

            int id;
            string tkno;
            string tkco;
            string noidung;
            decimal sotien=0;
            decimal sotiennt=0;
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
                    ChiTietChungTu_DTO ct = new ChiTietChungTu_DTO(soct, tkno, tkco, noidung, sotiennt,sotien);
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
                        sotien = Decimal.Parse(GridViewChiTiet.GetRowCellDisplayText(i, colSoTien));
                    }
                    else if (matien!="VND")
                    {
                        sotiennt = Decimal.Parse(GridViewChiTiet.GetRowCellDisplayText(i, colSoTienNt));
                        sotien = sotiennt * decimal.Parse(tygia.ToString());
                    }

                    ChiTietChungTu_DTO ct = new ChiTietChungTu_DTO(soct, tkno, tkco, noidung, sotiennt,sotien);
                    ChiTietCT_BUS.insertChiTietChungTu(ct);
                }
            }
            else if(sodonggoc>rowcount)  
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
            LoadlookupeditTknh();
            lookUpEditTaiKhoanNH.Text = obj.TknhDi;
            lookUpEditDT.Text = obj.MaDt;            
            txtDiaChi.Text = obj.DiaChi;
            txtLyDo.Text = obj.LyDo;
            txtTkDen.Text = obj.TknhDen;            
            txtSoCt.Text = obj.SoCt;
            dateEditNgayCt.DateTime = obj.NgayCt;
            dateEditNgayGhiSo.DateTime = obj.NgayGhiSo;
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
            lookUpEditTaiKhoanNH.EditValue = "";
            txtTenDoiTuong.Text = "";
            txtDiaChi.Text = "";
            txtTenTknh.Text = "";
            txtLyDo.Text = "";
            txtTyGia.Text = "";
            txtTkDen.Text = "";
            txtSoCt.Text = Function.Funtion.randomSoChungTu(3);
            lookUpEditLoaiTien.EditValue = "";
            dateEditNgayCt.DateTime = DateTime.Today;
            dateEditNgayGhiSo.DateTime = DateTime.Today;
            Init_ChiTietPhieu();

        }

        private void lookUpEditLoaiTien_EditValueChanged(object sender, EventArgs e)
        {
            
           
                if (lookUpEditLoaiTien.Text == "VND")
                {
                    colSoTienNt.Visible = false;
                    txtTyGia.Text = "1";
                    colSoTien.OptionsColumn.ReadOnly = false;
                }
                else
                {
                    colSoTienNt.Visible = true;
                    colSoTien.OptionsColumn.ReadOnly = true;
                }
                  
        }     

        private void btnInGiayBao_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
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
                catch { }
            }
            else
            {
                try
                {
                    sotien = decimal.Parse(dt.Rows[0]["SoTienNt"].ToString());
                    tienchu = Function.Funtion.DecimalToString(sotien) + " đô la Mỹ";
                }
                catch { }
            }
            BaoCao.GiayBaoNganHang.RptGiayBaoNganHang rpt = new BaoCao.GiayBaoNganHang.RptGiayBaoNganHang();
            rpt.DataSource = ChiTietCT_BUS.LoadChiTietCtLenGB(txtSoCt.Text);
            rpt.DataMember = "Table";
            rpt.lblTenPhieu.Text = "GIẤY BÁO NỢ";
            rpt.lblTenNguoiGd.Text = "Người nhận tiền:";
            rpt.colSoTienNguyenTe.Text = "Số tiền nguyên tệ ("+tentien+")";
            rpt.ptDiaChi.Value = txtDiaChi.Text;
            rpt.ptSoCt.Value = txtSoCt.Text;
            rpt.ptNgayCt.Value = dateEditNgayCt.DateTime;
            rpt.ptNguoiGd.Value = txtTenDoiTuong.Text;
            rpt.ptLyDo.Value = txtLyDo.Text;
            rpt.ptLoaiTien.Value= lookUpEditLoaiTien.GetColumnValue("MaTien").ToString();
            rpt.ptTaiKhoan.Value = GridViewChiTiet.GetRowCellDisplayText(0, colTkCo).ToString();
            rpt.ptSoTien.Value=sotien;
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
         //   rpt.ShowPreview();

        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            EnableConTrol();
            lc.LuaChon = "Edit";
            btnIn.Enabled = false;
            btnInGiayBao.Enabled = false;
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
            lookUpEditTaiKhoanNH.Properties.ReadOnly = true;
            txtDiaChi.ReadOnly = true;
            txtLyDo.ReadOnly = true;
            txtTenTknh.ReadOnly = true;
            txtTkDen.ReadOnly = true;
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
            txtDiaChi.ReadOnly = false;
            txtLyDo.ReadOnly = false;
            txtTenTknh.ReadOnly = false;
            txtTkDen.ReadOnly = false;
            txtSoCt.ReadOnly = false;
            dateEditNgayCt.Properties.ReadOnly = false;
            dateEditNgayGhiSo.Properties.ReadOnly = false;
            txtTyGia.Properties.ReadOnly = false;
            GridViewChiTiet.OptionsBehavior.ReadOnly = false;
        }

        private void btnInMauACB_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
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
                catch { }
            }
            else
            {
                try
                {
                    sotien = decimal.Parse(dt.Rows[0]["SoTienNt"].ToString());
                    tienchu = Function.Funtion.DecimalToString(sotien) + " đô la Mỹ";
                }
                catch
                { }
            }          
            
            
            BaoCao.UyNhiemChi.RptUyNhiemChi rpt = new BaoCao.UyNhiemChi.RptUyNhiemChi();
            DataSet ds = new DataSet();
            ds.Tables.Add(dt);
            rpt.DataSource = ds;
            rpt.DataMember = "Table";

            rpt.TenTknhDi.Value = lookUpEditTaiKhoanNH.GetColumnValue("TenNh").ToString();
            rpt.ChiNhanh1.Value = lookUpEditTaiKhoanNH.GetColumnValue("ChiNhanh").ToString();
            rpt.TenNhDen.Value = lookUpEditDT.GetColumnValue("TenNh").ToString();
            rpt.ChiNhanhNhDen.Value = lookUpEditDT.GetColumnValue("ChiNhanh").ToString();
            rpt.SoTien.Value = sotien;
            rpt.TienChu.Value = tienchu;

            rpt.TenTknhDi.Visible = false;
            rpt.ChiNhanh1.Visible = false;
            rpt.TenNhDen.Visible = false;
            rpt.ChiNhanhNhDen.Visible = false;
            rpt.SoTien.Visible = false;
            rpt.TienChu.Visible = false;

          //  rpt.ShowPreview();
        }

        private void btnInAgr_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            BaoCao.UyNhiemChi.RptUyNhiemChiAgribank rpt = new BaoCao.UyNhiemChi.RptUyNhiemChiAgribank();
            rpt.lblSoCt.Text = txtSoCt.Text;
            rpt.lblTknhDi.Text = lookUpEditTaiKhoanNH.GetColumnValue("SoTknh").ToString();
            rpt.lblNganHangDi.Text = lookUpEditTaiKhoanNH.GetColumnValue("TenNh").ToString();
            rpt.lblChiNhanhDi.Text = lookUpEditTaiKhoanNH.GetColumnValue("ChiNhanh").ToString();
            rpt.lblTenDtNhanTien.Text = txtTenDoiTuong.Text;
            rpt.lblTknhDen.Text = txtTkDen.Text;
            rpt.lblNganHangDen.Text = lookUpEditDT.GetColumnValue("TenNh").ToString();
            rpt.lblChiNhanhDen.Text = lookUpEditDT.GetColumnValue("ChiNhanh").ToString();
            rpt.lblLyDo.Text = txtLyDo.Text;

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
                catch
                { }
            }

            rpt.Ngay.Value = dateEditNgayCt.DateTime;
            rpt.Ngay.Visible = false;
            rpt.SoTien.Value = sotien;
            rpt.lblTienChu.Text = tienchu;
            rpt.SoTien.Visible = false;
         //   rpt.ShowPreview();
        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }
      
    }
}
