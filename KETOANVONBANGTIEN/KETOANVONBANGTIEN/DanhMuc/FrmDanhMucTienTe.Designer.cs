namespace KETOANVONBANGTIEN.DanhMuc
{
    partial class FrmDanhMucTienTe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDanhMucTienTe));
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
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.grvDanhMucTienTe = new DevExpress.XtraGrid.GridControl();
            this.gridViewDanhMucTienTe = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMatien = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenTien = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grvDanhMucTienTe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewDanhMucTienTe)).BeginInit();
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
            this.btnXuatEx});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 5;
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
            this.btnThem.Caption = "Thêm";
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
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(611, 32);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 325);
            this.barDockControlBottom.Size = new System.Drawing.Size(611, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 32);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 293);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(611, 32);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 293);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.grvDanhMucTienTe);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 32);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(611, 293);
            this.groupControl1.TabIndex = 9;
            this.groupControl1.Text = "Danh mục tiền tệ";
            // 
            // grvDanhMucTienTe
            // 
            this.grvDanhMucTienTe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grvDanhMucTienTe.Location = new System.Drawing.Point(2, 21);
            this.grvDanhMucTienTe.MainView = this.gridViewDanhMucTienTe;
            this.grvDanhMucTienTe.MenuManager = this.barManager1;
            this.grvDanhMucTienTe.Name = "grvDanhMucTienTe";
            this.grvDanhMucTienTe.Size = new System.Drawing.Size(607, 270);
            this.grvDanhMucTienTe.TabIndex = 5;
            this.grvDanhMucTienTe.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewDanhMucTienTe});
            // 
            // gridViewDanhMucTienTe
            // 
            this.gridViewDanhMucTienTe.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMatien,
            this.colTenTien});
            this.gridViewDanhMucTienTe.GridControl = this.grvDanhMucTienTe;
            this.gridViewDanhMucTienTe.Name = "gridViewDanhMucTienTe";
            this.gridViewDanhMucTienTe.OptionsBehavior.Editable = false;
            this.gridViewDanhMucTienTe.OptionsBehavior.ReadOnly = true;
            // 
            // colMatien
            // 
            this.colMatien.Caption = "Mã tiền";
            this.colMatien.FieldName = "MaTien";
            this.colMatien.Name = "colMatien";
            this.colMatien.Visible = true;
            this.colMatien.VisibleIndex = 0;
            this.colMatien.Width = 50;
            // 
            // colTenTien
            // 
            this.colTenTien.Caption = "Tên Loại Tiền";
            this.colTenTien.FieldName = "TenTien";
            this.colTenTien.Name = "colTenTien";
            this.colTenTien.Visible = true;
            this.colTenTien.VisibleIndex = 1;
            this.colTenTien.Width = 543;
            // 
            // FrmDanhMucTienTe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 325);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "FrmDanhMucTienTe";
            this.Text = "Danh mục tiền tệ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmDanhMucTienTe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grvDanhMucTienTe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewDanhMucTienTe)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem btnThem;
        private DevExpress.XtraBars.BarButtonItem btnSua;
        private DevExpress.XtraBars.BarButtonItem btnXoa;
        private DevExpress.XtraBars.BarButtonItem btnNap;
        private DevExpress.XtraBars.BarButtonItem btnXuatEx;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraGrid.GridControl grvDanhMucTienTe;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewDanhMucTienTe;
        private DevExpress.XtraGrid.Columns.GridColumn colMatien;
        private DevExpress.XtraGrid.Columns.GridColumn colTenTien;
    }
}