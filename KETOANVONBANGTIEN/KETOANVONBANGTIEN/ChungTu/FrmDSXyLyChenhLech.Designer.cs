using System.Windows.Forms;

namespace KETOANVONBANGTIEN.ChungTu
{
    partial class FrmDSXyLyChenhLech : Form
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
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btnThem = new DevExpress.XtraBars.BarButtonItem();
            this.btnSua = new DevExpress.XtraBars.BarButtonItem();
            this.btnXoa = new DevExpress.XtraBars.BarButtonItem();
            this.btnIn = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.btnNap = new DevExpress.XtraBars.BarButtonItem();
            this.btnGhiSo = new DevExpress.XtraBars.BarButtonItem();
            this.btnBoGhi = new DevExpress.XtraBars.BarButtonItem();
            this.grvDanhSachXuLyChenhLech = new DevExpress.XtraGrid.GridControl();
            this.gridViewDsPhieuThu = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colmaXuLy = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSoCt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNgayCt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTkCo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTkNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSoTien = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEditTkCo = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.repositoryItemLookUpEditTkNo = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvDanhSachXuLyChenhLech)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewDsPhieuThu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEditTkCo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEditTkNo)).BeginInit();
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
            new DevExpress.XtraBars.LinkPersistInfo(this.btnIn)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // btnThem
            // 
            this.btnThem.Caption = "Mới";
            this.btnThem.Id = 0;
            this.btnThem.ImageOptions.Image = global::KETOANVONBANGTIEN.Properties.Resources.add_icon32;
            this.btnThem.Name = "btnThem";
            this.btnThem.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnThem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThem_ItemClick);
            // 
            // btnSua
            // 
            this.btnSua.Caption = "Sửa";
            this.btnSua.Id = 1;
            this.btnSua.ImageOptions.Image = global::KETOANVONBANGTIEN.Properties.Resources._1332999366_Pencil3;
            this.btnSua.Name = "btnSua";
            this.btnSua.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnSua.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSua_ItemClick);
            // 
            // btnXoa
            // 
            this.btnXoa.Caption = "Xóa";
            this.btnXoa.Id = 2;
            this.btnXoa.ImageOptions.Image = global::KETOANVONBANGTIEN.Properties.Resources._1332999407_button_cancel;
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // btnIn
            // 
            this.btnIn.Caption = "In";
            this.btnIn.Id = 3;
            this.btnIn.ImageOptions.Image = global::KETOANVONBANGTIEN.Properties.Resources._1332999513_printer;
            this.btnIn.Name = "btnIn";
            this.btnIn.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnIn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnIn_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(810, 40);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 337);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(810, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 40);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 297);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(810, 40);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 297);
            // 
            // btnNap
            // 
            this.btnNap.Caption = "Nạp";
            this.btnNap.Id = 4;
            this.btnNap.Name = "btnNap";
            this.btnNap.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // btnGhiSo
            // 
            this.btnGhiSo.Caption = "Ghi sổ";
            this.btnGhiSo.Id = 6;
            this.btnGhiSo.Name = "btnGhiSo";
            this.btnGhiSo.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // btnBoGhi
            // 
            this.btnBoGhi.Caption = "Bỏ ghi";
            this.btnBoGhi.Id = 7;
            this.btnBoGhi.Name = "btnBoGhi";
            this.btnBoGhi.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // grvDanhSachXuLyChenhLech
            // 
            this.grvDanhSachXuLyChenhLech.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grvDanhSachXuLyChenhLech.Location = new System.Drawing.Point(0, 40);
            this.grvDanhSachXuLyChenhLech.MainView = this.gridViewDsPhieuThu;
            this.grvDanhSachXuLyChenhLech.MenuManager = this.barManager1;
            this.grvDanhSachXuLyChenhLech.Name = "grvDanhSachXuLyChenhLech";
            this.grvDanhSachXuLyChenhLech.Size = new System.Drawing.Size(810, 297);
            this.grvDanhSachXuLyChenhLech.TabIndex = 5;
            this.grvDanhSachXuLyChenhLech.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewDsPhieuThu});
            // 
            // gridViewDsPhieuThu
            // 
            this.gridViewDsPhieuThu.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colmaXuLy,
            this.colSoCt,
            this.colNgayCt,
            this.colTkCo,
            this.colTkNo,
            this.colSoTien});
            this.gridViewDsPhieuThu.GridControl = this.grvDanhSachXuLyChenhLech;
            this.gridViewDsPhieuThu.Name = "gridViewDsPhieuThu";
            this.gridViewDsPhieuThu.OptionsBehavior.Editable = false;

            //
            // maXuLy
            //
            this.colmaXuLy.Caption = "Mã xử lý";
            this.colmaXuLy.FieldName = "maXuLy";
            this.colmaXuLy.Name = "colmaXuLy";
            this.colmaXuLy.Visible = true;
            this.colmaXuLy.VisibleIndex = 0;

            // 
            // colSoCt
            // 
            this.colSoCt.Caption = "Số CT";
            this.colSoCt.FieldName = "SoCt";
            this.colSoCt.Name = "colSoCt";
            this.colSoCt.Visible = true;
            this.colSoCt.VisibleIndex = 1;
            // 
            // colNgayCt
            // 
            this.colNgayCt.Caption = "Ngày chứng từ";
            this.colNgayCt.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.colNgayCt.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colNgayCt.FieldName = "Nam";
            this.colNgayCt.Name = "colNgayCt";
            this.colNgayCt.Visible = true;
            this.colNgayCt.VisibleIndex = 2;
            // 
            // colTkCo
            // 
            this.colTkCo.Caption = "TK Có";
            this.colTkCo.FieldName = "taiKhoanCo";
            this.colTkCo.Name = "colTkCo";
            this.colTkCo.Visible = true;
            this.colTkCo.VisibleIndex = 3;
            this.colTkCo.Width = 173;
            // 
            // colTkNo
            // 
            this.colTkNo.Caption = "TK Nợ";
            this.colTkNo.FieldName = "taiKhoanNo";
            this.colTkNo.Name = "colTkNo";
            this.colTkNo.Visible = true;
            this.colTkNo.VisibleIndex = 4;
            this.colTkNo.Width = 173;
            // 
            // colSoTien
            // 
            this.colSoTien.Caption = "Số Tiền";
            this.colSoTien.DisplayFormat.FormatString = "n0";
            this.colSoTien.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colSoTien.FieldName = "soTien";
            this.colSoTien.ImageAlignment = System.Drawing.StringAlignment.Far;
            this.colSoTien.Name = "colSoTien";
            this.colSoTien.Visible = true;
            this.colSoTien.VisibleIndex = 5;
            // 
            // repositoryItemLookUpEditTkCo
            // 
            this.repositoryItemLookUpEditTkCo.AutoHeight = false;
            this.repositoryItemLookUpEditTkCo.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEditTkCo.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MaTk", 30, "Mã TK"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("TenTk", 120, "Tên TK")});
            this.repositoryItemLookUpEditTkCo.Name = "repositoryItemLookUpEditTkCo";
            this.repositoryItemLookUpEditTkCo.NullText = "";
            this.repositoryItemLookUpEditTkCo.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            // 
            // repositoryItemLookUpEditTkNo
            // 
            this.repositoryItemLookUpEditTkNo.AutoHeight = false;
            this.repositoryItemLookUpEditTkNo.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEditTkNo.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MaTk", 30, "Mã TK"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("TenTk", 120, "Tên TK")});
            this.repositoryItemLookUpEditTkNo.Name = "repositoryItemLookUpEditTkNo";
            this.repositoryItemLookUpEditTkNo.NullText = "";
            this.repositoryItemLookUpEditTkNo.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            // 
            // FrmDSXyLyChenhLech
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 337);
            this.Controls.Add(this.grvDanhSachXuLyChenhLech);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "FrmDSXyLyChenhLech";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmDSXyLyChenhLech_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvDanhSachXuLyChenhLech)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewDsPhieuThu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEditTkCo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEditTkNo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private DevExpress.XtraGrid.GridControl grvDanhSachXuLyChenhLech;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewDsPhieuThu;
        private DevExpress.XtraGrid.Columns.GridColumn colmaXuLy;
        private DevExpress.XtraGrid.Columns.GridColumn colSoCt;
        private DevExpress.XtraGrid.Columns.GridColumn colNgayCt;
        private DevExpress.XtraGrid.Columns.GridColumn colTkNo;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEditTkNo;
        private DevExpress.XtraGrid.Columns.GridColumn colTkCo;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEditTkCo;
        private DevExpress.XtraGrid.Columns.GridColumn colSoTien;
        private DevExpress.XtraBars.BarButtonItem btnGhiSo;
        private DevExpress.XtraBars.BarButtonItem btnBoGhi;
    }
}