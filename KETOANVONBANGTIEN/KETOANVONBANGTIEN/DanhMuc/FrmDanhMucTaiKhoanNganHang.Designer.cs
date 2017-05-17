namespace KETOANVONBANGTIEN.DanhMuc
{
    partial class FrmDanhMucTaiKhoanNganHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDanhMucTaiKhoanNganHang));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btnThem = new DevExpress.XtraBars.BarButtonItem();
            this.btnSua = new DevExpress.XtraBars.BarButtonItem();
            this.btnXoa = new DevExpress.XtraBars.BarButtonItem();
            this.btnNap = new DevExpress.XtraBars.BarButtonItem();
            this.btnXuatEx = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.barButtonItem4 = new DevExpress.XtraBars.BarButtonItem();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.grvDanhMucTKNH = new DevExpress.XtraGrid.GridControl();
            this.gridViewDanhMucTKNH = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colSotk = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTentk = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colManh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTennh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colChinhanh = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grvDanhMucTKNH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewDanhMucTKNH)).BeginInit();
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
            this.barButtonItem4,
            this.btnNap,
            this.btnXuatEx});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 6;
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
            new DevExpress.XtraBars.LinkPersistInfo(this.btnXuatEx)});
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
            this.btnThem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThem_ItemClick_1);
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
            this.btnNap.Id = 4;
            this.btnNap.Name = "btnNap";
            this.btnNap.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnNap.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnNap_ItemClick);
            // 
            // btnXuatEx
            // 
            this.btnXuatEx.Caption = "Xuất dữ liệu";
            this.btnXuatEx.Glyph = ((System.Drawing.Image)(resources.GetObject("btnXuatEx.Glyph")));
            this.btnXuatEx.Id = 5;
            this.btnXuatEx.Name = "btnXuatEx";
            this.btnXuatEx.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnXuatEx.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnXuatEx_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(678, 32);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 349);
            this.barDockControlBottom.Size = new System.Drawing.Size(678, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 32);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 317);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(678, 32);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 317);
            // 
            // barButtonItem4
            // 
            this.barButtonItem4.Caption = "barButtonItem4";
            this.barButtonItem4.Id = 3;
            this.barButtonItem4.Name = "barButtonItem4";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.grvDanhMucTKNH);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 32);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(678, 317);
            this.groupControl1.TabIndex = 10;
            this.groupControl1.Text = "Danh mục tài khoản ngân hàng";
            // 
            // grvDanhMucTKNH
            // 
            this.grvDanhMucTKNH.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grvDanhMucTKNH.Location = new System.Drawing.Point(2, 21);
            this.grvDanhMucTKNH.MainView = this.gridViewDanhMucTKNH;
            this.grvDanhMucTKNH.MenuManager = this.barManager1;
            this.grvDanhMucTKNH.Name = "grvDanhMucTKNH";
            this.grvDanhMucTKNH.Size = new System.Drawing.Size(674, 294);
            this.grvDanhMucTKNH.TabIndex = 6;
            this.grvDanhMucTKNH.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewDanhMucTKNH});
            // 
            // gridViewDanhMucTKNH
            // 
            this.gridViewDanhMucTKNH.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colSotk,
            this.colTentk,
            this.colManh,
            this.colTennh,
            this.colChinhanh});
            this.gridViewDanhMucTKNH.GridControl = this.grvDanhMucTKNH;
            this.gridViewDanhMucTKNH.Name = "gridViewDanhMucTKNH";
            this.gridViewDanhMucTKNH.OptionsBehavior.Editable = false;
            this.gridViewDanhMucTKNH.OptionsBehavior.ReadOnly = true;
            // 
            // colSotk
            // 
            this.colSotk.Caption = "Số tài khoản";
            this.colSotk.FieldName = "SoTknh";
            this.colSotk.Name = "colSotk";
            this.colSotk.Visible = true;
            this.colSotk.VisibleIndex = 0;
            this.colSotk.Width = 70;
            // 
            // colTentk
            // 
            this.colTentk.Caption = "Tên tài khoản";
            this.colTentk.FieldName = "TenTknh";
            this.colTentk.Name = "colTentk";
            this.colTentk.Visible = true;
            this.colTentk.VisibleIndex = 1;
            this.colTentk.Width = 146;
            // 
            // colManh
            // 
            this.colManh.Caption = "Mã ngân hàng";
            this.colManh.FieldName = "MaNh";
            this.colManh.Name = "colManh";
            this.colManh.Visible = true;
            this.colManh.VisibleIndex = 2;
            this.colManh.Width = 146;
            // 
            // colTennh
            // 
            this.colTennh.Caption = "Tên ngân hàng";
            this.colTennh.FieldName = "TenNh";
            this.colTennh.Name = "colTennh";
            this.colTennh.Visible = true;
            this.colTennh.VisibleIndex = 3;
            this.colTennh.Width = 146;
            // 
            // colChinhanh
            // 
            this.colChinhanh.Caption = "Chi nhánh";
            this.colChinhanh.FieldName = "ChiNhanh";
            this.colChinhanh.Name = "colChinhanh";
            this.colChinhanh.Visible = true;
            this.colChinhanh.VisibleIndex = 4;
            this.colChinhanh.Width = 150;
            // 
            // FrmDanhMucTaiKhoanNganHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 349);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "FrmDanhMucTaiKhoanNganHang";
            this.Text = "Danh mục tài khoản ngân hàng";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmDanhMucTaiKhoanNganHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grvDanhMucTKNH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewDanhMucTKNH)).EndInit();
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
        private DevExpress.XtraBars.BarButtonItem barButtonItem4;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraGrid.GridControl grvDanhMucTKNH;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewDanhMucTKNH;
        private DevExpress.XtraGrid.Columns.GridColumn colSotk;
        private DevExpress.XtraGrid.Columns.GridColumn colTentk;
        private DevExpress.XtraGrid.Columns.GridColumn colManh;
        private DevExpress.XtraGrid.Columns.GridColumn colTennh;
        private DevExpress.XtraGrid.Columns.GridColumn colChinhanh;
    }
}