namespace KETOANVONBANGTIEN.DanhMuc
{
    partial class FrmSoDuTaiKhoan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSoDuTaiKhoan));
            this.grvDanhMucTaiKhoan = new DevExpress.XtraGrid.GridControl();
            this.gridViewDMTK = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMaTk = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTentk = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSoDuNoNt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSoDuCoNt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDuNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDuCo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btnNap = new DevExpress.XtraBars.BarButtonItem();
            this.btnXuatEx = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.barButtonItem4 = new DevExpress.XtraBars.BarButtonItem();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.txtDuCoNt = new DevExpress.XtraEditors.TextEdit();
            this.txtDuNoNt = new DevExpress.XtraEditors.TextEdit();
            this.txtDuCo = new DevExpress.XtraEditors.TextEdit();
            this.txtDuNo = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtMaTk = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btnCapNhat = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.grvDanhMucTaiKhoan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewDMTK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDuCoNt.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDuNoNt.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDuCo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDuNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaTk.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // grvDanhMucTaiKhoan
            // 
            this.grvDanhMucTaiKhoan.Dock = System.Windows.Forms.DockStyle.Top;
            this.grvDanhMucTaiKhoan.Location = new System.Drawing.Point(2, 21);
            this.grvDanhMucTaiKhoan.MainView = this.gridViewDMTK;
            this.grvDanhMucTaiKhoan.MenuManager = this.barManager1;
            this.grvDanhMucTaiKhoan.Name = "grvDanhMucTaiKhoan";
            this.grvDanhMucTaiKhoan.Size = new System.Drawing.Size(749, 276);
            this.grvDanhMucTaiKhoan.TabIndex = 5;
            this.grvDanhMucTaiKhoan.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewDMTK});
            this.grvDanhMucTaiKhoan.Click += new System.EventHandler(this.grvDanhMucTaiKhoan_Click);
            // 
            // gridViewDMTK
            // 
            this.gridViewDMTK.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMaTk,
            this.colTentk,
            this.colSoDuNoNt,
            this.colSoDuCoNt,
            this.colDuNo,
            this.colDuCo});
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
            this.colMaTk.Width = 72;
            // 
            // colTentk
            // 
            this.colTentk.Caption = "Tên tài khoản";
            this.colTentk.FieldName = "TenTk";
            this.colTentk.Name = "colTentk";
            this.colTentk.Visible = true;
            this.colTentk.VisibleIndex = 1;
            this.colTentk.Width = 207;
            // 
            // colSoDuNoNt
            // 
            this.colSoDuNoNt.Caption = "Dư nợ ngoại tệ";
            this.colSoDuNoNt.DisplayFormat.FormatString = "n";
            this.colSoDuNoNt.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colSoDuNoNt.FieldName = "DuNoNt";
            this.colSoDuNoNt.Name = "colSoDuNoNt";
            this.colSoDuNoNt.Visible = true;
            this.colSoDuNoNt.VisibleIndex = 2;
            // 
            // colSoDuCoNt
            // 
            this.colSoDuCoNt.Caption = "Dư có ngoại tệ";
            this.colSoDuCoNt.DisplayFormat.FormatString = "n";
            this.colSoDuCoNt.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colSoDuCoNt.FieldName = "DuCoNt";
            this.colSoDuCoNt.Name = "colSoDuCoNt";
            this.colSoDuCoNt.Visible = true;
            this.colSoDuCoNt.VisibleIndex = 3;
            // 
            // colDuNo
            // 
            this.colDuNo.Caption = "Dư Nợ";
            this.colDuNo.DisplayFormat.FormatString = "n0";
            this.colDuNo.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colDuNo.FieldName = "DuNoDk";
            this.colDuNo.GroupFormat.FormatString = "0,0";
            this.colDuNo.Name = "colDuNo";
            this.colDuNo.Visible = true;
            this.colDuNo.VisibleIndex = 4;
            this.colDuNo.Width = 108;
            // 
            // colDuCo
            // 
            this.colDuCo.Caption = "Dư Có";
            this.colDuCo.DisplayFormat.FormatString = "n0";
            this.colDuCo.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colDuCo.FieldName = "DuCoDk";
            this.colDuCo.Name = "colDuCo";
            this.colDuCo.Visible = true;
            this.colDuCo.VisibleIndex = 5;
            this.colDuCo.Width = 112;
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
            new DevExpress.XtraBars.LinkPersistInfo(this.btnNap),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnXuatEx)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
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
            this.barDockControlTop.Size = new System.Drawing.Size(753, 32);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 537);
            this.barDockControlBottom.Size = new System.Drawing.Size(753, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 32);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 505);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(753, 32);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 505);
            // 
            // barButtonItem4
            // 
            this.barButtonItem4.Caption = "barButtonItem4";
            this.barButtonItem4.Id = 3;
            this.barButtonItem4.Name = "barButtonItem4";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.groupControl2);
            this.groupControl1.Controls.Add(this.grvDanhMucTaiKhoan);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 32);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(753, 505);
            this.groupControl1.TabIndex = 10;
            this.groupControl1.Text = "Danh mục tài khoản";
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.txtDuCoNt);
            this.groupControl2.Controls.Add(this.txtDuNoNt);
            this.groupControl2.Controls.Add(this.txtDuCo);
            this.groupControl2.Controls.Add(this.txtDuNo);
            this.groupControl2.Controls.Add(this.labelControl5);
            this.groupControl2.Controls.Add(this.labelControl4);
            this.groupControl2.Controls.Add(this.labelControl3);
            this.groupControl2.Controls.Add(this.labelControl2);
            this.groupControl2.Controls.Add(this.txtMaTk);
            this.groupControl2.Controls.Add(this.labelControl1);
            this.groupControl2.Controls.Add(this.btnCapNhat);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(2, 297);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(749, 206);
            this.groupControl2.TabIndex = 6;
            // 
            // txtDuCoNt
            // 
            this.txtDuCoNt.Location = new System.Drawing.Point(400, 107);
            this.txtDuCoNt.MenuManager = this.barManager1;
            this.txtDuCoNt.Name = "txtDuCoNt";
            this.txtDuCoNt.Properties.DisplayFormat.FormatString = "n";
            this.txtDuCoNt.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtDuCoNt.Properties.EditFormat.FormatString = "n";
            this.txtDuCoNt.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtDuCoNt.Properties.Mask.EditMask = "n";
            this.txtDuCoNt.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtDuCoNt.Size = new System.Drawing.Size(100, 20);
            this.txtDuCoNt.TabIndex = 10;
            // 
            // txtDuNoNt
            // 
            this.txtDuNoNt.Location = new System.Drawing.Point(400, 75);
            this.txtDuNoNt.MenuManager = this.barManager1;
            this.txtDuNoNt.Name = "txtDuNoNt";
            this.txtDuNoNt.Properties.DisplayFormat.FormatString = "n";
            this.txtDuNoNt.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtDuNoNt.Properties.EditFormat.FormatString = "n";
            this.txtDuNoNt.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtDuNoNt.Properties.Mask.EditMask = "n";
            this.txtDuNoNt.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtDuNoNt.Size = new System.Drawing.Size(100, 20);
            this.txtDuNoNt.TabIndex = 9;
            // 
            // txtDuCo
            // 
            this.txtDuCo.Location = new System.Drawing.Point(131, 107);
            this.txtDuCo.MenuManager = this.barManager1;
            this.txtDuCo.Name = "txtDuCo";
            this.txtDuCo.Properties.DisplayFormat.FormatString = "n0";
            this.txtDuCo.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtDuCo.Properties.EditFormat.FormatString = "n0";
            this.txtDuCo.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtDuCo.Properties.Mask.EditMask = "n0";
            this.txtDuCo.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtDuCo.Size = new System.Drawing.Size(100, 20);
            this.txtDuCo.TabIndex = 8;
            // 
            // txtDuNo
            // 
            this.txtDuNo.Location = new System.Drawing.Point(131, 75);
            this.txtDuNo.MenuManager = this.barManager1;
            this.txtDuNo.Name = "txtDuNo";
            this.txtDuNo.Properties.DisplayFormat.FormatString = "n0";
            this.txtDuNo.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtDuNo.Properties.EditFormat.FormatString = "n0";
            this.txtDuNo.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtDuNo.Properties.Mask.EditMask = "n0";
            this.txtDuNo.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtDuNo.Size = new System.Drawing.Size(100, 20);
            this.txtDuNo.TabIndex = 7;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(311, 110);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(70, 13);
            this.labelControl5.TabIndex = 6;
            this.labelControl5.Text = "Dư có ngoại tệ";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(311, 78);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(71, 13);
            this.labelControl4.TabIndex = 5;
            this.labelControl4.Text = "Dư nợ ngoại tệ";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(39, 110);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(28, 13);
            this.labelControl3.TabIndex = 4;
            this.labelControl3.Text = "Dư có";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(39, 78);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(29, 13);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "Dư nợ";
            // 
            // txtMaTk
            // 
            this.txtMaTk.Location = new System.Drawing.Point(131, 39);
            this.txtMaTk.MenuManager = this.barManager1;
            this.txtMaTk.Name = "txtMaTk";
            this.txtMaTk.Properties.ReadOnly = true;
            this.txtMaTk.Size = new System.Drawing.Size(100, 20);
            this.txtMaTk.TabIndex = 2;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(39, 46);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(28, 13);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Mã Tk";
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Location = new System.Drawing.Point(605, 104);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(75, 23);
            this.btnCapNhat.TabIndex = 0;
            this.btnCapNhat.Text = "Cập nhật";
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // FrmSoDuTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 537);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "FrmSoDuTaiKhoan";
            this.Text = "Số dư các tài khoản";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmSoDuTaiKhoan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grvDanhMucTaiKhoan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewDMTK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDuCoNt.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDuNoNt.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDuCo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDuNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaTk.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl grvDanhMucTaiKhoan;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewDMTK;
        private DevExpress.XtraGrid.Columns.GridColumn colMaTk;
        private DevExpress.XtraGrid.Columns.GridColumn colTentk;
        private DevExpress.XtraGrid.Columns.GridColumn colSoDuNoNt;
        private DevExpress.XtraGrid.Columns.GridColumn colSoDuCoNt;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarButtonItem btnNap;
        private DevExpress.XtraBars.BarButtonItem btnXuatEx;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem4;
        private DevExpress.XtraGrid.Columns.GridColumn colDuNo;
        private DevExpress.XtraGrid.Columns.GridColumn colDuCo;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.TextEdit txtDuCoNt;
        private DevExpress.XtraEditors.TextEdit txtDuNoNt;
        private DevExpress.XtraEditors.TextEdit txtDuCo;
        private DevExpress.XtraEditors.TextEdit txtDuNo;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtMaTk;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btnCapNhat;
    }
}