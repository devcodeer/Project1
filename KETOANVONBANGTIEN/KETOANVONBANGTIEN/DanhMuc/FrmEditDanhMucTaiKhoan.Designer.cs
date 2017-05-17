namespace KETOANVONBANGTIEN.DanhMuc
{
    partial class FrmEditDanhMucTaiKhoan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEditDanhMucTaiKhoan));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btnLuuVaDong = new DevExpress.XtraBars.BarButtonItem();
            this.btnLuuVaMoi = new DevExpress.XtraBars.BarButtonItem();
            this.btnDong = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.lookUpEditTkCha = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtLoaiTk = new System.Windows.Forms.TextBox();
            this.txtCapTk = new System.Windows.Forms.TextBox();
            this.txtTenTk = new System.Windows.Forms.TextBox();
            this.txtMaTk = new System.Windows.Forms.TextBox();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.lblMaTk = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.lookUpEditLoaiTien = new DevExpress.XtraEditors.LookUpEdit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditTkCha.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditLoaiTien.Properties)).BeginInit();
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
            this.btnLuuVaDong,
            this.btnLuuVaMoi,
            this.btnDong});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 3;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnLuuVaDong),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnLuuVaMoi),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnDong)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // btnLuuVaDong
            // 
            this.btnLuuVaDong.Caption = "Lưu và đóng";
            this.btnLuuVaDong.Glyph = ((System.Drawing.Image)(resources.GetObject("btnLuuVaDong.Glyph")));
            this.btnLuuVaDong.Id = 0;
            this.btnLuuVaDong.Name = "btnLuuVaDong";
            this.btnLuuVaDong.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnLuuVaDong.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnLuuVaDong_ItemClick);
            // 
            // btnLuuVaMoi
            // 
            this.btnLuuVaMoi.Caption = "Lưu và mới";
            this.btnLuuVaMoi.Glyph = ((System.Drawing.Image)(resources.GetObject("btnLuuVaMoi.Glyph")));
            this.btnLuuVaMoi.Id = 1;
            this.btnLuuVaMoi.Name = "btnLuuVaMoi";
            this.btnLuuVaMoi.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnLuuVaMoi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnLuuVaMoi_ItemClick);
            // 
            // btnDong
            // 
            this.btnDong.Caption = "Đóng";
            this.btnDong.Glyph = ((System.Drawing.Image)(resources.GetObject("btnDong.Glyph")));
            this.btnDong.Id = 2;
            this.btnDong.Name = "btnDong";
            this.btnDong.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnDong.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDong_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(536, 32);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 273);
            this.barDockControlBottom.Size = new System.Drawing.Size(536, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 32);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 241);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(536, 32);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 241);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.lookUpEditLoaiTien);
            this.groupControl1.Controls.Add(this.labelControl6);
            this.groupControl1.Controls.Add(this.lookUpEditTkCha);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.txtLoaiTk);
            this.groupControl1.Controls.Add(this.txtCapTk);
            this.groupControl1.Controls.Add(this.txtTenTk);
            this.groupControl1.Controls.Add(this.txtMaTk);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.lblMaTk);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 32);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(536, 241);
            this.groupControl1.TabIndex = 5;
            this.groupControl1.Text = "Thông tin";
            // 
            // lookUpEditTkCha
            // 
            this.lookUpEditTkCha.Location = new System.Drawing.Point(150, 147);
            this.lookUpEditTkCha.MenuManager = this.barManager1;
            this.lookUpEditTkCha.Name = "lookUpEditTkCha";
            this.lookUpEditTkCha.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEditTkCha.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MaTk", "Mã tài khoản"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("TenTk", "Tên tài khoản")});
            this.lookUpEditTkCha.Properties.NullText = "";
            this.lookUpEditTkCha.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.lookUpEditTkCha.Size = new System.Drawing.Size(100, 20);
            this.lookUpEditTkCha.TabIndex = 10;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(17, 154);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(66, 13);
            this.labelControl5.TabIndex = 9;
            this.labelControl5.Text = "Tài khoản cha";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(17, 171);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(0, 13);
            this.labelControl1.TabIndex = 8;
            // 
            // txtLoaiTk
            // 
            this.txtLoaiTk.Location = new System.Drawing.Point(150, 116);
            this.txtLoaiTk.Name = "txtLoaiTk";
            this.txtLoaiTk.Size = new System.Drawing.Size(252, 20);
            this.txtLoaiTk.TabIndex = 7;
            // 
            // txtCapTk
            // 
            this.txtCapTk.Location = new System.Drawing.Point(150, 87);
            this.txtCapTk.Name = "txtCapTk";
            this.txtCapTk.Size = new System.Drawing.Size(70, 20);
            this.txtCapTk.TabIndex = 6;
            this.txtCapTk.TextChanged += new System.EventHandler(this.txtCapTk_TextChanged);
            // 
            // txtTenTk
            // 
            this.txtTenTk.Location = new System.Drawing.Point(150, 59);
            this.txtTenTk.Name = "txtTenTk";
            this.txtTenTk.Size = new System.Drawing.Size(252, 20);
            this.txtTenTk.TabIndex = 5;
            // 
            // txtMaTk
            // 
            this.txtMaTk.Location = new System.Drawing.Point(150, 34);
            this.txtMaTk.Name = "txtMaTk";
            this.txtMaTk.Size = new System.Drawing.Size(70, 20);
            this.txtMaTk.TabIndex = 4;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(17, 123);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(66, 13);
            this.labelControl4.TabIndex = 3;
            this.labelControl4.Text = "Loại tài khoản";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(17, 94);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(64, 13);
            this.labelControl3.TabIndex = 2;
            this.labelControl3.Text = "cấp tài khoản";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(17, 66);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(65, 13);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Tên tài khoản";
            // 
            // lblMaTk
            // 
            this.lblMaTk.Location = new System.Drawing.Point(17, 34);
            this.lblMaTk.Name = "lblMaTk";
            this.lblMaTk.Size = new System.Drawing.Size(61, 13);
            this.lblMaTk.TabIndex = 0;
            this.lblMaTk.Text = "Mã tài khoản";
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(17, 190);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(30, 13);
            this.labelControl6.TabIndex = 11;
            this.labelControl6.Text = "Mã NT";
            // 
            // lookUpEditLoaiTien
            // 
            this.lookUpEditLoaiTien.Location = new System.Drawing.Point(150, 183);
            this.lookUpEditLoaiTien.Name = "lookUpEditLoaiTien";
            this.lookUpEditLoaiTien.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEditLoaiTien.Properties.NullText = "";
            this.lookUpEditLoaiTien.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.lookUpEditLoaiTien.Size = new System.Drawing.Size(100, 20);
            this.lookUpEditLoaiTien.TabIndex = 12;
            // 
            // FrmEditDanhMucTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 273);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "FrmEditDanhMucTaiKhoan";
            this.Text = "Danh mục tài khoản";
            this.Load += new System.EventHandler(this.FrmEditDanhMucTaiKhoan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditTkCha.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditLoaiTien.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem btnLuuVaDong;
        private DevExpress.XtraBars.BarButtonItem btnLuuVaMoi;
        private DevExpress.XtraBars.BarButtonItem btnDong;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.TextBox txtLoaiTk;
        private System.Windows.Forms.TextBox txtCapTk;
        private System.Windows.Forms.TextBox txtTenTk;
        private System.Windows.Forms.TextBox txtMaTk;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl lblMaTk;
        private DevExpress.XtraEditors.LookUpEdit lookUpEditTkCha;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LookUpEdit lookUpEditLoaiTien;
    }
}