namespace KETOANVONBANGTIEN.BaoCao.BaoCaoDanhSachNhanVien
{
    partial class rptDanhSachNhanVien
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.xrTable2 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow2 = new DevExpress.XtraReports.UI.XRTableRow();
            this.Stt = new DevExpress.XtraReports.UI.XRTableCell();
            this.Ma = new DevExpress.XtraReports.UI.XRTableCell();
            this.Ten = new DevExpress.XtraReports.UI.XRTableCell();
            this.TenPb = new DevExpress.XtraReports.UI.XRTableCell();
            this.ChucVu = new DevExpress.XtraReports.UI.XRTableCell();
            this.DienThoai = new DevExpress.XtraReports.UI.XRTableCell();
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.GroupHeader1 = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.xrTable1 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow1 = new DevExpress.XtraReports.UI.XRTableRow();
            this.colStt = new DevExpress.XtraReports.UI.XRTableCell();
            this.colMaNv = new DevExpress.XtraReports.UI.XRTableCell();
            this.colTenNv = new DevExpress.XtraReports.UI.XRTableCell();
            this.colPhongBan = new DevExpress.XtraReports.UI.XRTableCell();
            this.colChucVu = new DevExpress.XtraReports.UI.XRTableCell();
            this.colDienThoai = new DevExpress.XtraReports.UI.XRTableCell();
            this.lblDanhSachNhanVien = new DevExpress.XtraReports.UI.XRLabel();
            this.GroupFooter1 = new DevExpress.XtraReports.UI.GroupFooterBand();
            this.xrLabel1 = new DevExpress.XtraReports.UI.XRLabel();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // Detail
            // 
            this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrTable2});
            this.Detail.HeightF = 25F;
            this.Detail.Name = "Detail";
            this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.Detail.BeforePrint += new System.Drawing.Printing.PrintEventHandler(this.Detail_BeforePrint);
            // 
            // xrTable2
            // 
            this.xrTable2.BorderColor = System.Drawing.Color.Silver;
            this.xrTable2.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top)
                        | DevExpress.XtraPrinting.BorderSide.Right)
                        | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTable2.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.xrTable2.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrTable2.Name = "xrTable2";
            this.xrTable2.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow2});
            this.xrTable2.SizeF = new System.Drawing.SizeF(650F, 25F);
            this.xrTable2.StylePriority.UseBorderColor = false;
            this.xrTable2.StylePriority.UseBorders = false;
            this.xrTable2.StylePriority.UseFont = false;
            // 
            // xrTableRow2
            // 
            this.xrTableRow2.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.Stt,
            this.Ma,
            this.Ten,
            this.TenPb,
            this.ChucVu,
            this.DienThoai});
            this.xrTableRow2.Name = "xrTableRow2";
            this.xrTableRow2.Weight = 1D;
            // 
            // Stt
            // 
            this.Stt.Name = "Stt";
            this.Stt.StylePriority.UseTextAlignment = false;
            this.Stt.Text = "STT";
            this.Stt.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.Stt.Weight = 0.16666664123535152D;
            // 
            // Ma
            // 
            this.Ma.Name = "Ma";
            this.Ma.StylePriority.UseTextAlignment = false;
            this.Ma.Text = "Mã nhân viên";
            this.Ma.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.Ma.Weight = 0.45352542583759003D;
            // 
            // Ten
            // 
            this.Ten.Name = "Ten";
            this.Ten.StylePriority.UseTextAlignment = false;
            this.Ten.Text = "Tên nhân viên";
            this.Ten.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.Ten.Weight = 0.814903948857234D;
            // 
            // TenPb
            // 
            this.TenPb.Name = "TenPb";
            this.TenPb.StylePriority.UseTextAlignment = false;
            this.TenPb.Text = "Phòng ban";
            this.TenPb.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.TenPb.Weight = 0.57451932320227983D;
            // 
            // ChucVu
            // 
            this.ChucVu.Name = "ChucVu";
            this.ChucVu.StylePriority.UseTextAlignment = false;
            this.ChucVu.Text = "Chức vụ";
            this.ChucVu.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.ChucVu.Weight = 0.54086554233844475D;
            // 
            // DienThoai
            // 
            this.DienThoai.Name = "DienThoai";
            this.DienThoai.StylePriority.UseTextAlignment = false;
            this.DienThoai.Text = "Điện thoại";
            this.DienThoai.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.DienThoai.Weight = 0.44951911852909965D;
            // 
            // TopMargin
            // 
            this.TopMargin.Name = "TopMargin";
            this.TopMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // BottomMargin
            // 
            this.BottomMargin.Name = "BottomMargin";
            this.BottomMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // GroupHeader1
            // 
            this.GroupHeader1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrTable1,
            this.lblDanhSachNhanVien});
            this.GroupHeader1.Name = "GroupHeader1";
            this.GroupHeader1.BeforePrint += new System.Drawing.Printing.PrintEventHandler(this.GroupHeader1_BeforePrint);
            // 
            // xrTable1
            // 
            this.xrTable1.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top)
                        | DevExpress.XtraPrinting.BorderSide.Right)
                        | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTable1.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.xrTable1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 75F);
            this.xrTable1.Name = "xrTable1";
            this.xrTable1.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow1});
            this.xrTable1.SizeF = new System.Drawing.SizeF(650F, 25F);
            this.xrTable1.StylePriority.UseBorders = false;
            this.xrTable1.StylePriority.UseFont = false;
            // 
            // xrTableRow1
            // 
            this.xrTableRow1.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.colStt,
            this.colMaNv,
            this.colTenNv,
            this.colPhongBan,
            this.colChucVu,
            this.colDienThoai});
            this.xrTableRow1.Name = "xrTableRow1";
            this.xrTableRow1.Weight = 1D;
            // 
            // colStt
            // 
            this.colStt.Name = "colStt";
            this.colStt.StylePriority.UseTextAlignment = false;
            this.colStt.Text = "STT";
            this.colStt.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            this.colStt.Weight = 0.16666664123535152D;
            // 
            // colMaNv
            // 
            this.colMaNv.Name = "colMaNv";
            this.colMaNv.StylePriority.UseTextAlignment = false;
            this.colMaNv.Text = "Mã nhân viên";
            this.colMaNv.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            this.colMaNv.Weight = 0.45352542583759003D;
            // 
            // colTenNv
            // 
            this.colTenNv.Name = "colTenNv";
            this.colTenNv.StylePriority.UseTextAlignment = false;
            this.colTenNv.Text = "Tên nhân viên";
            this.colTenNv.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            this.colTenNv.Weight = 0.814903948857234D;
            // 
            // colPhongBan
            // 
            this.colPhongBan.Name = "colPhongBan";
            this.colPhongBan.StylePriority.UseTextAlignment = false;
            this.colPhongBan.Text = "Phòng ban";
            this.colPhongBan.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            this.colPhongBan.Weight = 0.57451932320227983D;
            // 
            // colChucVu
            // 
            this.colChucVu.Name = "colChucVu";
            this.colChucVu.StylePriority.UseTextAlignment = false;
            this.colChucVu.Text = "Chức vụ";
            this.colChucVu.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            this.colChucVu.Weight = 0.54086554233844475D;
            // 
            // colDienThoai
            // 
            this.colDienThoai.Name = "colDienThoai";
            this.colDienThoai.StylePriority.UseTextAlignment = false;
            this.colDienThoai.Text = "Điện thoại";
            this.colDienThoai.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            this.colDienThoai.Weight = 0.44951911852909965D;
            // 
            // lblDanhSachNhanVien
            // 
            this.lblDanhSachNhanVien.Font = new System.Drawing.Font("Times New Roman", 24F);
            this.lblDanhSachNhanVien.LocationFloat = new DevExpress.Utils.PointFloat(151.0417F, 10.00001F);
            this.lblDanhSachNhanVien.Name = "lblDanhSachNhanVien";
            this.lblDanhSachNhanVien.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lblDanhSachNhanVien.SizeF = new System.Drawing.SizeF(337.5F, 45.91667F);
            this.lblDanhSachNhanVien.StylePriority.UseFont = false;
            this.lblDanhSachNhanVien.StylePriority.UseTextAlignment = false;
            this.lblDanhSachNhanVien.Text = "Danh sách nhân viên";
            this.lblDanhSachNhanVien.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // GroupFooter1
            // 
            this.GroupFooter1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel1});
            this.GroupFooter1.Name = "GroupFooter1";
            // 
            // xrLabel1
            // 
            this.xrLabel1.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.xrLabel1.LocationFloat = new DevExpress.Utils.PointFloat(421.875F, 51.04167F);
            this.xrLabel1.Name = "xrLabel1";
            this.xrLabel1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel1.SizeF = new System.Drawing.SizeF(187.5F, 23F);
            this.xrLabel1.StylePriority.UseFont = false;
            this.xrLabel1.Text = "Công ty cổ phần In La Bàn";
            // 
            // rptDanhSachNhanVien
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.TopMargin,
            this.BottomMargin,
            this.GroupHeader1,
            this.GroupFooter1});
            this.Version = "11.2";
            ((System.ComponentModel.ISupportInitialize)(this.xrTable2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
        private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
        private DevExpress.XtraReports.UI.GroupHeaderBand GroupHeader1;
        private DevExpress.XtraReports.UI.GroupFooterBand GroupFooter1;
        private DevExpress.XtraReports.UI.XRLabel lblDanhSachNhanVien;
        private DevExpress.XtraReports.UI.XRTable xrTable2;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow2;
        private DevExpress.XtraReports.UI.XRTableCell Stt;
        private DevExpress.XtraReports.UI.XRTableCell Ma;
        private DevExpress.XtraReports.UI.XRTableCell Ten;
        private DevExpress.XtraReports.UI.XRTableCell TenPb;
        private DevExpress.XtraReports.UI.XRTableCell ChucVu;
        private DevExpress.XtraReports.UI.XRTableCell DienThoai;
        private DevExpress.XtraReports.UI.XRTable xrTable1;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow1;
        private DevExpress.XtraReports.UI.XRTableCell colStt;
        private DevExpress.XtraReports.UI.XRTableCell colMaNv;
        private DevExpress.XtraReports.UI.XRTableCell colTenNv;
        private DevExpress.XtraReports.UI.XRTableCell colPhongBan;
        private DevExpress.XtraReports.UI.XRTableCell colChucVu;
        private DevExpress.XtraReports.UI.XRTableCell colDienThoai;
        private DevExpress.XtraReports.UI.XRLabel xrLabel1;
    }
}
