namespace KETOANVONBANGTIEN.DanhMuc
{
    partial class FrmDanhMucTaiKhoan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDanhMucTaiKhoan));
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
            this.grvDanhMucTaiKhoan = new DevExpress.XtraGrid.GridControl();
            this.gridViewDMTK = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMaTk = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTentk = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLoaitk = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCaptk = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTkCha = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMaNt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grvDanhMucTaiKhoan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewDMTK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
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
            this.barDockControlTop.Size = new System.Drawing.Size(653, 32);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 479);
            this.barDockControlBottom.Size = new System.Drawing.Size(653, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 32);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 447);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(653, 32);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 447);
            // 
            // barButtonItem4
            // 
            this.barButtonItem4.Caption = "barButtonItem4";
            this.barButtonItem4.Id = 3;
            this.barButtonItem4.Name = "barButtonItem4";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.grvDanhMucTaiKhoan);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 32);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(653, 397);
            this.groupControl1.TabIndex = 9;
            this.groupControl1.Text = "Danh mục tài khoản";
            // 
            // grvDanhMucTaiKhoan
            // 
            this.grvDanhMucTaiKhoan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grvDanhMucTaiKhoan.Location = new System.Drawing.Point(2, 21);
            this.grvDanhMucTaiKhoan.MainView = this.gridViewDMTK;
            this.grvDanhMucTaiKhoan.MenuManager = this.barManager1;
            this.grvDanhMucTaiKhoan.Name = "grvDanhMucTaiKhoan";
            this.grvDanhMucTaiKhoan.Size = new System.Drawing.Size(649, 374);
            this.grvDanhMucTaiKhoan.TabIndex = 5;
            this.grvDanhMucTaiKhoan.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewDMTK});
            // 
            // gridViewDMTK
            // 
            this.gridViewDMTK.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMaTk,
            this.colTentk,
            this.colLoaitk,
            this.colCaptk,
            this.colTkCha,
            this.colMaNt});
            this.gridViewDMTK.GridControl = this.grvDanhMucTaiKhoan;
            this.gridViewDMTK.Name = "gridViewDMTK";
            this.gridViewDMTK.OptionsBehavior.Editable = false;
            // 
            // colMaTk
            // 
            this.colMaTk.Caption = "Mã TK";
            this.colMaTk.FieldName = "MaTk";
            this.colMaTk.Name = "colMaTk";
            this.colMaTk.Visible = true;
            this.colMaTk.VisibleIndex = 0;
            this.colMaTk.Width = 95;
            // 
            // colTentk
            // 
            this.colTentk.Caption = "Tên tài khoản";
            this.colTentk.FieldName = "TenTk";
            this.colTentk.Name = "colTentk";
            this.colTentk.Visible = true;
            this.colTentk.VisibleIndex = 1;
            this.colTentk.Width = 250;
            // 
            // colLoaitk
            // 
            this.colLoaitk.Caption = "Loại Tk";
            this.colLoaitk.FieldName = "LoaiTk";
            this.colLoaitk.Name = "colLoaitk";
            this.colLoaitk.Visible = true;
            this.colLoaitk.VisibleIndex = 2;
            this.colLoaitk.Width = 150;
            // 
            // colCaptk
            // 
            this.colCaptk.Caption = "Cấp Tk";
            this.colCaptk.FieldName = "CapTk";
            this.colCaptk.ImageAlignment = System.Drawing.StringAlignment.Center;
            this.colCaptk.Name = "colCaptk";
            this.colCaptk.Visible = true;
            this.colCaptk.VisibleIndex = 3;
            this.colCaptk.Width = 71;
            // 
            // colTkCha
            // 
            this.colTkCha.Caption = "Tk Cha";
            this.colTkCha.FieldName = "TkCha";
            this.colTkCha.ImageAlignment = System.Drawing.StringAlignment.Far;
            this.colTkCha.Name = "colTkCha";
            this.colTkCha.Visible = true;
            this.colTkCha.VisibleIndex = 4;
            this.colTkCha.Width = 100;
            // 
            // colMaNt
            // 
            this.colMaNt.Caption = "Mã NT";
            this.colMaNt.FieldName = "MaNt";
            this.colMaNt.Name = "colMaNt";
            this.colMaNt.Visible = true;
            this.colMaNt.VisibleIndex = 5;
            // 
            // groupControl2
            // 
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(0, 429);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(653, 50);
            this.groupControl2.TabIndex = 14;
            // 
            // FrmDanhMucTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 479);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "FrmDanhMucTaiKhoan";
            this.Text = "Danh mục tài khoản";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmDanhMucTaiKhoan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grvDanhMucTaiKhoan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewDMTK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
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
        private DevExpress.XtraBars.BarButtonItem barButtonItem4;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraGrid.GridControl grvDanhMucTaiKhoan;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewDMTK;
        private DevExpress.XtraGrid.Columns.GridColumn colMaTk;
        private DevExpress.XtraGrid.Columns.GridColumn colTentk;
        private DevExpress.XtraGrid.Columns.GridColumn colLoaitk;
        private DevExpress.XtraGrid.Columns.GridColumn colCaptk;
        private DevExpress.XtraGrid.Columns.GridColumn colTkCha;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraGrid.Columns.GridColumn colMaNt;
    }
}