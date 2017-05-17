namespace KETOANVONBANGTIEN.DanhMuc
{
    partial class FrmDanhMucDoiTuong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDanhMucDoiTuong));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btnThem = new DevExpress.XtraBars.BarButtonItem();
            this.btnSua = new DevExpress.XtraBars.BarButtonItem();
            this.btnXoa = new DevExpress.XtraBars.BarButtonItem();
            this.btnNap = new DevExpress.XtraBars.BarButtonItem();
            this.btnXuatEx = new DevExpress.XtraBars.BarButtonItem();
            this.btnIn = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.barStaticItem1 = new DevExpress.XtraBars.BarStaticItem();
            this.repositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.repositoryItemFontEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemFontEdit();
            this.grvDanhSachDoiTuong = new DevExpress.XtraGrid.GridControl();
            this.gridViewDanhMucDoiTuong = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMaDt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNhomDt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenDt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDiaChi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDienThoai = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEmail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMst = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSotk = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenNh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colChiNhanh = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemFontEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvDanhSachDoiTuong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewDanhMucDoiTuong)).BeginInit();
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
            this.btnNap,
            this.btnXuatEx,
            this.barStaticItem1,
            this.btnIn});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 10;
            this.barManager1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemTextEdit1,
            this.repositoryItemFontEdit1});
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
            new DevExpress.XtraBars.LinkPersistInfo(this.btnNap),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnXuatEx),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnIn)});
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
            // btnNap
            // 
            this.btnNap.Caption = "Nạp";
            this.btnNap.Glyph = ((System.Drawing.Image)(resources.GetObject("btnNap.Glyph")));
            this.btnNap.Id = 3;
            this.btnNap.Name = "btnNap";
            this.btnNap.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnNap.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnNap_ItemClick);
            // 
            // btnXuatEx
            // 
            this.btnXuatEx.Caption = "Xuất dữ liệu";
            this.btnXuatEx.Glyph = ((System.Drawing.Image)(resources.GetObject("btnXuatEx.Glyph")));
            this.btnXuatEx.Id = 4;
            this.btnXuatEx.Name = "btnXuatEx";
            this.btnXuatEx.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnXuatEx.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnXuatEx_ItemClick);
            // 
            // btnIn
            // 
            this.btnIn.Caption = "In";
            this.btnIn.Glyph = ((System.Drawing.Image)(resources.GetObject("btnIn.Glyph")));
            this.btnIn.Id = 9;
            this.btnIn.Name = "btnIn";
            this.btnIn.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnIn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnIn_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(768, 32);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 403);
            this.barDockControlBottom.Size = new System.Drawing.Size(768, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 32);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 371);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(768, 32);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 371);
            // 
            // barStaticItem1
            // 
            this.barStaticItem1.Caption = "barStaticItem1";
            this.barStaticItem1.Id = 8;
            this.barStaticItem1.Name = "barStaticItem1";
            this.barStaticItem1.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // repositoryItemTextEdit1
            // 
            this.repositoryItemTextEdit1.AutoHeight = false;
            this.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1";
            // 
            // repositoryItemFontEdit1
            // 
            this.repositoryItemFontEdit1.AutoHeight = false;
            this.repositoryItemFontEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemFontEdit1.Name = "repositoryItemFontEdit1";
            // 
            // grvDanhSachDoiTuong
            // 
            this.grvDanhSachDoiTuong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grvDanhSachDoiTuong.Location = new System.Drawing.Point(0, 32);
            this.grvDanhSachDoiTuong.MainView = this.gridViewDanhMucDoiTuong;
            this.grvDanhSachDoiTuong.MenuManager = this.barManager1;
            this.grvDanhSachDoiTuong.Name = "grvDanhSachDoiTuong";
            this.grvDanhSachDoiTuong.Size = new System.Drawing.Size(768, 371);
            this.grvDanhSachDoiTuong.TabIndex = 24;
            this.grvDanhSachDoiTuong.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewDanhMucDoiTuong});
            // 
            // gridViewDanhMucDoiTuong
            // 
            this.gridViewDanhMucDoiTuong.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMaDt,
            this.colNhomDt,
            this.colTenDt,
            this.colDiaChi,
            this.colDienThoai,
            this.colEmail,
            this.colMst,
            this.colSotk,
            this.colTenNh,
            this.colChiNhanh});
            this.gridViewDanhMucDoiTuong.GridControl = this.grvDanhSachDoiTuong;
            this.gridViewDanhMucDoiTuong.Name = "gridViewDanhMucDoiTuong";
            this.gridViewDanhMucDoiTuong.OptionsBehavior.Editable = false;
            // 
            // colMaDt
            // 
            this.colMaDt.Caption = "Mã đối tượng";
            this.colMaDt.FieldName = "Ma";
            this.colMaDt.Name = "colMaDt";
            this.colMaDt.Visible = true;
            this.colMaDt.VisibleIndex = 0;
            this.colMaDt.Width = 80;
            // 
            // colNhomDt
            // 
            this.colNhomDt.Caption = "Nhóm đối tượng";
            this.colNhomDt.FieldName = "TenNhom";
            this.colNhomDt.Name = "colNhomDt";
            this.colNhomDt.Visible = true;
            this.colNhomDt.VisibleIndex = 1;
            this.colNhomDt.Width = 100;
            // 
            // colTenDt
            // 
            this.colTenDt.Caption = "Tên đối tượng";
            this.colTenDt.FieldName = "Ten";
            this.colTenDt.Name = "colTenDt";
            this.colTenDt.Visible = true;
            this.colTenDt.VisibleIndex = 2;
            this.colTenDt.Width = 150;
            // 
            // colDiaChi
            // 
            this.colDiaChi.Caption = "Địa chỉ";
            this.colDiaChi.FieldName = "DiaChi";
            this.colDiaChi.Name = "colDiaChi";
            this.colDiaChi.Visible = true;
            this.colDiaChi.VisibleIndex = 3;
            this.colDiaChi.Width = 150;
            // 
            // colDienThoai
            // 
            this.colDienThoai.Caption = "Điện thoại";
            this.colDienThoai.FieldName = "DienThoai";
            this.colDienThoai.Name = "colDienThoai";
            this.colDienThoai.Visible = true;
            this.colDienThoai.VisibleIndex = 4;
            this.colDienThoai.Width = 90;
            // 
            // colEmail
            // 
            this.colEmail.Caption = "Email";
            this.colEmail.FieldName = "Email";
            this.colEmail.Name = "colEmail";
            this.colEmail.Visible = true;
            this.colEmail.VisibleIndex = 5;
            this.colEmail.Width = 100;
            // 
            // colMst
            // 
            this.colMst.Caption = "Mã số thuế";
            this.colMst.FieldName = "MST";
            this.colMst.Name = "colMst";
            this.colMst.Visible = true;
            this.colMst.VisibleIndex = 6;
            this.colMst.Width = 90;
            // 
            // colSotk
            // 
            this.colSotk.Caption = "Số Tài khoản NH";
            this.colSotk.FieldName = "SoTknh";
            this.colSotk.Name = "colSotk";
            this.colSotk.Visible = true;
            this.colSotk.VisibleIndex = 7;
            this.colSotk.Width = 100;
            // 
            // colTenNh
            // 
            this.colTenNh.Caption = "Tên ngân hàng";
            this.colTenNh.FieldName = "TenNh";
            this.colTenNh.Name = "colTenNh";
            this.colTenNh.Width = 100;
            // 
            // colChiNhanh
            // 
            this.colChiNhanh.Caption = "Chi nhánh";
            this.colChiNhanh.FieldName = "ChiNhanh";
            this.colChiNhanh.Name = "colChiNhanh";
            this.colChiNhanh.Width = 97;
            // 
            // FrmDanhMucDoiTuong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 403);
            this.Controls.Add(this.grvDanhSachDoiTuong);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "FrmDanhMucDoiTuong";
            this.Text = "Danh mục đối tượng";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmDanhMucDoiTuong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemFontEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvDanhSachDoiTuong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewDanhMucDoiTuong)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarButtonItem btnThem;
        private DevExpress.XtraBars.BarButtonItem btnSua;
        private DevExpress.XtraBars.BarButtonItem btnXoa;
        private DevExpress.XtraBars.BarButtonItem btnNap;
        private DevExpress.XtraBars.BarButtonItem btnXuatEx;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit1;
        private DevExpress.XtraBars.BarStaticItem barStaticItem1;
        private DevExpress.XtraEditors.Repository.RepositoryItemFontEdit repositoryItemFontEdit1;
        private DevExpress.XtraGrid.GridControl grvDanhSachDoiTuong;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewDanhMucDoiTuong;
        private DevExpress.XtraGrid.Columns.GridColumn colMaDt;
        private DevExpress.XtraGrid.Columns.GridColumn colNhomDt;
        private DevExpress.XtraGrid.Columns.GridColumn colTenDt;
        private DevExpress.XtraGrid.Columns.GridColumn colDiaChi;
        private DevExpress.XtraGrid.Columns.GridColumn colDienThoai;
        private DevExpress.XtraGrid.Columns.GridColumn colEmail;
        private DevExpress.XtraGrid.Columns.GridColumn colMst;
        private DevExpress.XtraGrid.Columns.GridColumn colSotk;
        private DevExpress.XtraGrid.Columns.GridColumn colTenNh;
        private DevExpress.XtraGrid.Columns.GridColumn colChiNhanh;
        private DevExpress.XtraBars.BarButtonItem btnIn;
    }
}