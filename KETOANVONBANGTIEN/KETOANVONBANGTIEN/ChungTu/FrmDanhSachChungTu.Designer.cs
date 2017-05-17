namespace KETOANVONBANGTIEN.ChungTu
{
    partial class FrmDanhSachChungTu
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDanhSachChungTu));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btnThem = new DevExpress.XtraBars.BarButtonItem();
            this.btnSua = new DevExpress.XtraBars.BarButtonItem();
            this.btnXoa = new DevExpress.XtraBars.BarButtonItem();
            this.btnIn = new DevExpress.XtraBars.BarButtonItem();
            this.btnNap = new DevExpress.XtraBars.BarButtonItem();
            this.btnGhiSo = new DevExpress.XtraBars.BarButtonItem();
            this.btnBoGhi = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.grvDanhSachPhieuThu = new DevExpress.XtraGrid.GridControl();
            this.gridViewDsPhieuThu = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colSoCt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNgayCt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNgayghiso = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMaDt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNguoiGd = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDiaChi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLyDo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKemTheo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMaTien = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTyGia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSoTien = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTrangThai = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTkNhDi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTknhDen = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvDanhSachPhieuThu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewDsPhieuThu)).BeginInit();
            this.SuspendLayout();
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnThem,
            this.btnSua,
            this.btnXoa,
            this.btnIn,
            this.btnNap,
            this.btnGhiSo,
            this.btnBoGhi});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 8;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnThem),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnSua),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnXoa),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnIn),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnNap),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnGhiSo),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnBoGhi)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // btnThem
            // 
            this.btnThem.Caption = "Mới";
            this.btnThem.Glyph = ((System.Drawing.Image)(resources.GetObject("btnThem.Glyph")));
            this.btnThem.Id = 0;
            this.btnThem.Name = "btnThem";
            this.btnThem.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnThem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThem_ItemClick);
            // 
            // btnSua
            // 
            this.btnSua.Caption = "Sửa";
            this.btnSua.Glyph = ((System.Drawing.Image)(resources.GetObject("btnSua.Glyph")));
            this.btnSua.Id = 1;
            this.btnSua.Name = "btnSua";
            this.btnSua.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnSua.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSua_ItemClick);
            // 
            // btnXoa
            // 
            this.btnXoa.Caption = "Xóa";
            this.btnXoa.Glyph = ((System.Drawing.Image)(resources.GetObject("btnXoa.Glyph")));
            this.btnXoa.Id = 2;
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnXoa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnXoa_ItemClick);
            // 
            // btnIn
            // 
            this.btnIn.Caption = "In";
            this.btnIn.Glyph = ((System.Drawing.Image)(resources.GetObject("btnIn.Glyph")));
            this.btnIn.Id = 3;
            this.btnIn.Name = "btnIn";
            this.btnIn.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnIn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnIn_ItemClick);
            // 
            // btnNap
            // 
            this.btnNap.Caption = "Nạp";
            this.btnNap.Glyph = ((System.Drawing.Image)(resources.GetObject("btnNap.Glyph")));
            this.btnNap.Id = 4;
            this.btnNap.Name = "btnNap";
            this.btnNap.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnNap.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnNap_ItemClick);
            // 
            // btnGhiSo
            // 
            this.btnGhiSo.Caption = "Ghi sổ";
            this.btnGhiSo.Glyph = ((System.Drawing.Image)(resources.GetObject("btnGhiSo.Glyph")));
            this.btnGhiSo.Id = 6;
            this.btnGhiSo.Name = "btnGhiSo";
            this.btnGhiSo.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnGhiSo.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnGhiSo_ItemClick);
            // 
            // btnBoGhi
            // 
            this.btnBoGhi.Caption = "Bỏ ghi";
            this.btnBoGhi.Glyph = ((System.Drawing.Image)(resources.GetObject("btnBoGhi.Glyph")));
            this.btnBoGhi.Id = 7;
            this.btnBoGhi.Name = "btnBoGhi";
            this.btnBoGhi.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnBoGhi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnBoGhi_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(711, 40);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 337);
            this.barDockControlBottom.Size = new System.Drawing.Size(711, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 40);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 297);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(711, 40);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 297);
            // 
            // grvDanhSachPhieuThu
            // 
            this.grvDanhSachPhieuThu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grvDanhSachPhieuThu.Location = new System.Drawing.Point(0, 40);
            this.grvDanhSachPhieuThu.MainView = this.gridViewDsPhieuThu;
            this.grvDanhSachPhieuThu.MenuManager = this.barManager1;
            this.grvDanhSachPhieuThu.Name = "grvDanhSachPhieuThu";
            this.grvDanhSachPhieuThu.Size = new System.Drawing.Size(711, 297);
            this.grvDanhSachPhieuThu.TabIndex = 4;
            this.grvDanhSachPhieuThu.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewDsPhieuThu});
            this.grvDanhSachPhieuThu.DoubleClick += new System.EventHandler(this.grvDanhSachPhieuThu_DoubleClick);
            // 
            // gridViewDsPhieuThu
            // 
            this.gridViewDsPhieuThu.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colSoCt,
            this.colNgayCt,
            this.colNgayghiso,
            this.colMaDt,
            this.colNguoiGd,
            this.colDiaChi,
            this.colLyDo,
            this.colKemTheo,
            this.colMaTien,
            this.colTyGia,
            this.colSoTien,
            this.colTrangThai,
            this.colTkNhDi,
            this.colTknhDen});
            this.gridViewDsPhieuThu.GridControl = this.grvDanhSachPhieuThu;
            this.gridViewDsPhieuThu.Name = "gridViewDsPhieuThu";
            this.gridViewDsPhieuThu.OptionsBehavior.Editable = false;
            // 
            // colSoCt
            // 
            this.colSoCt.Caption = "Số CT";
            this.colSoCt.FieldName = "SoCt";
            this.colSoCt.Name = "colSoCt";
            this.colSoCt.Visible = true;
            this.colSoCt.VisibleIndex = 0;
            // 
            // colNgayCt
            // 
            this.colNgayCt.Caption = "Ngày chứng từ";
            this.colNgayCt.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.colNgayCt.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colNgayCt.FieldName = "NgayCt";
            this.colNgayCt.Name = "colNgayCt";
            this.colNgayCt.Visible = true;
            this.colNgayCt.VisibleIndex = 1;
            // 
            // colNgayghiso
            // 
            this.colNgayghiso.Caption = "Ngày ghi sổ";
            this.colNgayghiso.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.colNgayghiso.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colNgayghiso.FieldName = "NgayGhiSo";
            this.colNgayghiso.Name = "colNgayghiso";
            this.colNgayghiso.Visible = true;
            this.colNgayghiso.VisibleIndex = 2;
            // 
            // colMaDt
            // 
            this.colMaDt.Caption = "Mã đối tượng";
            this.colMaDt.FieldName = "MaDt";
            this.colMaDt.Name = "colMaDt";
            this.colMaDt.Visible = true;
            this.colMaDt.VisibleIndex = 3;
            // 
            // colNguoiGd
            // 
            this.colNguoiGd.Caption = "Người giao dịch";
            this.colNguoiGd.FieldName = "NguoiGd";
            this.colNguoiGd.Name = "colNguoiGd";
            this.colNguoiGd.Visible = true;
            this.colNguoiGd.VisibleIndex = 4;
            // 
            // colDiaChi
            // 
            this.colDiaChi.Caption = "Địa chỉ";
            this.colDiaChi.FieldName = "DiaChi";
            this.colDiaChi.Name = "colDiaChi";
            this.colDiaChi.Visible = true;
            this.colDiaChi.VisibleIndex = 5;
            // 
            // colLyDo
            // 
            this.colLyDo.Caption = "Lý do";
            this.colLyDo.FieldName = "LyDo";
            this.colLyDo.Name = "colLyDo";
            this.colLyDo.Visible = true;
            this.colLyDo.VisibleIndex = 6;
            // 
            // colKemTheo
            // 
            this.colKemTheo.Caption = "Kèm theo";
            this.colKemTheo.FieldName = "KemTheo";
            this.colKemTheo.Name = "colKemTheo";
            // 
            // colMaTien
            // 
            this.colMaTien.Caption = "Mã Tiền";
            this.colMaTien.FieldName = "MaTien";
            this.colMaTien.Name = "colMaTien";
            // 
            // colTyGia
            // 
            this.colTyGia.Caption = "Tỷ Giá";
            this.colTyGia.FieldName = "TyGia";
            this.colTyGia.Name = "colTyGia";
            // 
            // colSoTien
            // 
            this.colSoTien.Caption = "Số Tiền";
            this.colSoTien.DisplayFormat.FormatString = "n0";
            this.colSoTien.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colSoTien.FieldName = "SoTien";
            this.colSoTien.ImageAlignment = System.Drawing.StringAlignment.Far;
            this.colSoTien.Name = "colSoTien";
            this.colSoTien.Visible = true;
            this.colSoTien.VisibleIndex = 7;
            // 
            // colTrangThai
            // 
            this.colTrangThai.Caption = "Trạng Thái";
            this.colTrangThai.FieldName = "TrangThai";
            this.colTrangThai.Name = "colTrangThai";
            this.colTrangThai.Visible = true;
            this.colTrangThai.VisibleIndex = 8;
            // 
            // colTkNhDi
            // 
            this.colTkNhDi.FieldName = "TknhDi";
            this.colTkNhDi.Name = "colTkNhDi";
            // 
            // colTknhDen
            // 
            this.colTknhDen.FieldName = "TknhDen";
            this.colTknhDen.Name = "colTknhDen";
            // 
            // FrmDanhSachChungTu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 337);
            this.Controls.Add(this.grvDanhSachPhieuThu);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "FrmDanhSachChungTu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmDanhSachPhieuThu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvDanhSachPhieuThu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewDsPhieuThu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarButtonItem btnThem;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem btnSua;
        private DevExpress.XtraBars.BarButtonItem btnXoa;
        private DevExpress.XtraBars.BarButtonItem btnIn;
        private DevExpress.XtraBars.BarButtonItem btnNap;
        private DevExpress.XtraGrid.GridControl grvDanhSachPhieuThu;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewDsPhieuThu;
        private DevExpress.XtraGrid.Columns.GridColumn colSoCt;
        private DevExpress.XtraGrid.Columns.GridColumn colNgayCt;
        private DevExpress.XtraGrid.Columns.GridColumn colNgayghiso;
        private DevExpress.XtraGrid.Columns.GridColumn colMaDt;
        private DevExpress.XtraGrid.Columns.GridColumn colNguoiGd;
        private DevExpress.XtraGrid.Columns.GridColumn colLyDo;
        private DevExpress.XtraGrid.Columns.GridColumn colMaTien;
        private DevExpress.XtraGrid.Columns.GridColumn colTyGia;
        private DevExpress.XtraGrid.Columns.GridColumn colSoTien;
        private DevExpress.XtraGrid.Columns.GridColumn colTrangThai;
        private DevExpress.XtraGrid.Columns.GridColumn colDiaChi;
        private DevExpress.XtraGrid.Columns.GridColumn colKemTheo;
        private DevExpress.XtraGrid.Columns.GridColumn colTkNhDi;
        private DevExpress.XtraGrid.Columns.GridColumn colTknhDen;
        private DevExpress.XtraBars.BarButtonItem btnGhiSo;
        private DevExpress.XtraBars.BarButtonItem btnBoGhi;
    }
}