namespace KETOANVONBANGTIEN.DanhMuc
{
    partial class FrmEditDanhMucTaiKhoanNganHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEditDanhMucTaiKhoanNganHang));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btnLuuVaDong = new DevExpress.XtraBars.BarButtonItem();
            this.btnLuuVaMoi = new DevExpress.XtraBars.BarButtonItem();
            this.btnDong = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.txtChiNhanh = new System.Windows.Forms.TextBox();
            this.txtTentknh = new System.Windows.Forms.TextBox();
            this.txtSotknh = new System.Windows.Forms.TextBox();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.lookUpEditNganHang = new DevExpress.XtraEditors.LookUpEdit();
            this.lblMaTk = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditNganHang.Properties)).BeginInit();
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
            this.barDockControlTop.Size = new System.Drawing.Size(503, 32);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 234);
            this.barDockControlBottom.Size = new System.Drawing.Size(503, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 32);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 202);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(503, 32);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 202);
            // 
            // txtChiNhanh
            // 
            this.txtChiNhanh.Location = new System.Drawing.Point(150, 135);
            this.txtChiNhanh.Name = "txtChiNhanh";
            this.txtChiNhanh.Size = new System.Drawing.Size(158, 20);
            this.txtChiNhanh.TabIndex = 7;
            // 
            // txtTentknh
            // 
            this.txtTentknh.Location = new System.Drawing.Point(150, 69);
            this.txtTentknh.Name = "txtTentknh";
            this.txtTentknh.Size = new System.Drawing.Size(252, 20);
            this.txtTentknh.TabIndex = 5;
            // 
            // txtSotknh
            // 
            this.txtSotknh.Location = new System.Drawing.Point(150, 34);
            this.txtSotknh.Name = "txtSotknh";
            this.txtSotknh.Size = new System.Drawing.Size(158, 20);
            this.txtSotknh.TabIndex = 4;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(17, 138);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(48, 13);
            this.labelControl4.TabIndex = 3;
            this.labelControl4.Text = "Chi nhánh";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(17, 69);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(65, 13);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Tên tài khoản";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(17, 103);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(72, 13);
            this.labelControl3.TabIndex = 2;
            this.labelControl3.Text = "Tên ngân hàng";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.lookUpEditNganHang);
            this.groupControl1.Controls.Add(this.txtChiNhanh);
            this.groupControl1.Controls.Add(this.txtTentknh);
            this.groupControl1.Controls.Add(this.txtSotknh);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.lblMaTk);
            this.groupControl1.Location = new System.Drawing.Point(12, 38);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(479, 178);
            this.groupControl1.TabIndex = 6;
            this.groupControl1.Text = "Thông tin";
            // 
            // lookUpEditNganHang
            // 
            this.lookUpEditNganHang.Location = new System.Drawing.Point(150, 95);
            this.lookUpEditNganHang.MenuManager = this.barManager1;
            this.lookUpEditNganHang.Name = "lookUpEditNganHang";
            this.lookUpEditNganHang.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEditNganHang.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MaNh", "Mã ngân hàng"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("TenNh", "Tên ngân hàng")});
            this.lookUpEditNganHang.Properties.NullText = "";
            this.lookUpEditNganHang.Properties.ShowDropDown = DevExpress.XtraEditors.Controls.ShowDropDown.Never;
            this.lookUpEditNganHang.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.lookUpEditNganHang.Size = new System.Drawing.Size(158, 20);
            this.lookUpEditNganHang.TabIndex = 6;
            this.lookUpEditNganHang.EditValueChanged += new System.EventHandler(this.lookUpEditNganHang_EditValueChanged);
            // 
            // lblMaTk
            // 
            this.lblMaTk.Location = new System.Drawing.Point(17, 34);
            this.lblMaTk.Name = "lblMaTk";
            this.lblMaTk.Size = new System.Drawing.Size(59, 13);
            this.lblMaTk.TabIndex = 0;
            this.lblMaTk.Text = "Số tài khoản";
            // 
            // FrmEditDanhMucTaiKhoanNganHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 234);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "FrmEditDanhMucTaiKhoanNganHang";
            this.Text = "Danh mục tài khoản ngân hàng";
            this.Load += new System.EventHandler(this.FrmEditDanhMucTaiKhoanNganHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditNganHang.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarButtonItem btnLuuVaDong;
        private DevExpress.XtraBars.BarButtonItem btnLuuVaMoi;
        private DevExpress.XtraBars.BarButtonItem btnDong;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.TextBox txtChiNhanh;
        private System.Windows.Forms.TextBox txtTentknh;
        private System.Windows.Forms.TextBox txtSotknh;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl lblMaTk;
        private DevExpress.XtraEditors.LookUpEdit lookUpEditNganHang;
    }
}