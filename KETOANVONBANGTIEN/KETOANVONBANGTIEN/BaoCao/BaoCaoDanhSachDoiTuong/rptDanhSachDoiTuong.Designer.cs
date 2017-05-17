namespace KETOANVONBANGTIEN.BaoCao.DanhSachDoiTuong
{
    partial class rptDanhSachDoiTuong
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
            this.MaDt = new DevExpress.XtraReports.UI.XRTableCell();
            this.TenDt = new DevExpress.XtraReports.UI.XRTableCell();
            this.DiaChi = new DevExpress.XtraReports.UI.XRTableCell();
            this.DienThoai = new DevExpress.XtraReports.UI.XRTableCell();
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.GroupHeader1 = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.xrTable1 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow1 = new DevExpress.XtraReports.UI.XRTableRow();
            this.colStt = new DevExpress.XtraReports.UI.XRTableCell();
            this.colMaDt = new DevExpress.XtraReports.UI.XRTableCell();
            this.colTenDt = new DevExpress.XtraReports.UI.XRTableCell();
            this.colDiaChi = new DevExpress.XtraReports.UI.XRTableCell();
            this.colDienThoai = new DevExpress.XtraReports.UI.XRTableCell();
            this.lblDanhSachDoiTuong = new DevExpress.XtraReports.UI.XRLabel();
            this.GroupFooter1 = new DevExpress.XtraReports.UI.GroupFooterBand();
            this.xrLabel1 = new DevExpress.XtraReports.UI.XRLabel();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // Detail
            // 
            this.Detail.BorderColor = System.Drawing.Color.Silver;
            this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrTable2});
            this.Detail.HeightF = 25F;
            this.Detail.Name = "Detail";
            this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.Detail.StylePriority.UseBorderColor = false;
            this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.Detail.BeforePrint += new System.Drawing.Printing.PrintEventHandler(this.Detail_BeforePrint);
            // 
            // xrTable2
            // 
            this.xrTable2.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top)
                        | DevExpress.XtraPrinting.BorderSide.Right)
                        | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTable2.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.xrTable2.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrTable2.Name = "xrTable2";
            this.xrTable2.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 5, 5, 100F);
            this.xrTable2.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow2});
            this.xrTable2.SizeF = new System.Drawing.SizeF(650F, 25F);
            this.xrTable2.StylePriority.UseBorders = false;
            this.xrTable2.StylePriority.UseFont = false;
            this.xrTable2.StylePriority.UsePadding = false;
            this.xrTable2.StylePriority.UseTextAlignment = false;
            this.xrTable2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrTableRow2
            // 
            this.xrTableRow2.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.Stt,
            this.MaDt,
            this.TenDt,
            this.DiaChi,
            this.DienThoai});
            this.xrTableRow2.Name = "xrTableRow2";
            this.xrTableRow2.Weight = 1D;
            // 
            // Stt
            // 
            this.Stt.Name = "Stt";
            this.Stt.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 5, 5, 100F);
            this.Stt.StylePriority.UsePadding = false;
            this.Stt.StylePriority.UseTextAlignment = false;
            this.Stt.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.Stt.Weight = 0.22435894892765923D;
            // 
            // MaDt
            // 
            this.MaDt.Name = "MaDt";
            this.MaDt.StylePriority.UseTextAlignment = false;
            this.MaDt.Text = "Mã đối tượng";
            this.MaDt.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.MaDt.Weight = 0.46314082219050468D;
            // 
            // TenDt
            // 
            this.TenDt.Name = "TenDt";
            this.TenDt.StylePriority.UseTextAlignment = false;
            this.TenDt.Text = "Tên đối tượng";
            this.TenDt.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.TenDt.Weight = 0.68509629176213194D;
            // 
            // DiaChi
            // 
            this.DiaChi.Name = "DiaChi";
            this.DiaChi.StylePriority.UseTextAlignment = false;
            this.DiaChi.Text = "Địa chỉ";
            this.DiaChi.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.DiaChi.Weight = 1.0697117600074182D;
            // 
            // DienThoai
            // 
            this.DienThoai.Name = "DienThoai";
            this.DienThoai.StylePriority.UseTextAlignment = false;
            this.DienThoai.Text = "Điện thoại";
            this.DienThoai.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.DienThoai.Weight = 0.5576921771122858D;
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
            this.lblDanhSachDoiTuong});
            this.GroupHeader1.HeightF = 86.45834F;
            this.GroupHeader1.Name = "GroupHeader1";
            this.GroupHeader1.BeforePrint += new System.Drawing.Printing.PrintEventHandler(this.GroupHeader1_BeforePrint);
            // 
            // xrTable1
            // 
            this.xrTable1.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top)
                        | DevExpress.XtraPrinting.BorderSide.Right)
                        | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTable1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.xrTable1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 60.83333F);
            this.xrTable1.Name = "xrTable1";
            this.xrTable1.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 5, 5, 100F);
            this.xrTable1.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow1});
            this.xrTable1.SizeF = new System.Drawing.SizeF(650F, 25F);
            this.xrTable1.StylePriority.UseBorders = false;
            this.xrTable1.StylePriority.UseFont = false;
            this.xrTable1.StylePriority.UsePadding = false;
            // 
            // xrTableRow1
            // 
            this.xrTableRow1.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.colStt,
            this.colMaDt,
            this.colTenDt,
            this.colDiaChi,
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
            this.colStt.Weight = 0.22435894892765923D;
            // 
            // colMaDt
            // 
            this.colMaDt.Name = "colMaDt";
            this.colMaDt.StylePriority.UseTextAlignment = false;
            this.colMaDt.Text = "Mã ĐT";
            this.colMaDt.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            this.colMaDt.Weight = 0.46314082219050468D;
            // 
            // colTenDt
            // 
            this.colTenDt.Name = "colTenDt";
            this.colTenDt.StylePriority.UseTextAlignment = false;
            this.colTenDt.Text = "Tên đối tượng";
            this.colTenDt.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            this.colTenDt.Weight = 0.68509629176213194D;
            // 
            // colDiaChi
            // 
            this.colDiaChi.Name = "colDiaChi";
            this.colDiaChi.StylePriority.UseTextAlignment = false;
            this.colDiaChi.Text = "Địa chỉ";
            this.colDiaChi.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            this.colDiaChi.Weight = 1.0697117600074182D;
            // 
            // colDienThoai
            // 
            this.colDienThoai.Name = "colDienThoai";
            this.colDienThoai.StylePriority.UseTextAlignment = false;
            this.colDienThoai.Text = "Điện thoại";
            this.colDienThoai.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            this.colDienThoai.Weight = 0.5576921771122858D;
            // 
            // lblDanhSachDoiTuong
            // 
            this.lblDanhSachDoiTuong.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold);
            this.lblDanhSachDoiTuong.LocationFloat = new DevExpress.Utils.PointFloat(150F, 0F);
            this.lblDanhSachDoiTuong.Name = "lblDanhSachDoiTuong";
            this.lblDanhSachDoiTuong.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lblDanhSachDoiTuong.SizeF = new System.Drawing.SizeF(337.5F, 45.91667F);
            this.lblDanhSachDoiTuong.StylePriority.UseFont = false;
            this.lblDanhSachDoiTuong.StylePriority.UseTextAlignment = false;
            this.lblDanhSachDoiTuong.Text = "Danh sách đối tượng";
            this.lblDanhSachDoiTuong.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // GroupFooter1
            // 
            this.GroupFooter1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel1});
            this.GroupFooter1.HeightF = 102.0833F;
            this.GroupFooter1.Name = "GroupFooter1";
            // 
            // xrLabel1
            // 
            this.xrLabel1.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.xrLabel1.LocationFloat = new DevExpress.Utils.PointFloat(430.2083F, 53.08335F);
            this.xrLabel1.Name = "xrLabel1";
            this.xrLabel1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel1.SizeF = new System.Drawing.SizeF(187.5F, 23F);
            this.xrLabel1.StylePriority.UseFont = false;
            this.xrLabel1.Text = "Công ty cổ phần In La Bàn";
            // 
            // rptDanhSachDoiTuong
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
        private DevExpress.XtraReports.UI.XRLabel lblDanhSachDoiTuong;
        private DevExpress.XtraReports.UI.GroupFooterBand GroupFooter1;
        private DevExpress.XtraReports.UI.XRTable xrTable1;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow1;
        private DevExpress.XtraReports.UI.XRTableCell colStt;
        private DevExpress.XtraReports.UI.XRTableCell colMaDt;
        private DevExpress.XtraReports.UI.XRTableCell colTenDt;
        private DevExpress.XtraReports.UI.XRTableCell colDiaChi;
        private DevExpress.XtraReports.UI.XRLabel xrLabel1;
        private DevExpress.XtraReports.UI.XRTable xrTable2;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow2;
        private DevExpress.XtraReports.UI.XRTableCell Stt;
        private DevExpress.XtraReports.UI.XRTableCell MaDt;
        private DevExpress.XtraReports.UI.XRTableCell TenDt;
        private DevExpress.XtraReports.UI.XRTableCell DiaChi;
        private DevExpress.XtraReports.UI.XRTableCell DienThoai;
        private DevExpress.XtraReports.UI.XRTableCell colDienThoai;
    }
}
