﻿namespace KETOANVONBANGTIEN.DanhMuc
{
    partial class FrmEditNguoiDung
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEditNguoiDung));
            this.txtTenTk = new System.Windows.Forms.TextBox();
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btnLuuVaDong = new DevExpress.XtraBars.BarButtonItem();
            this.btnLuuVaMoi = new DevExpress.XtraBars.BarButtonItem();
            this.btnDong = new DevExpress.XtraBars.BarButtonItem();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.lookUpEditQuyen = new DevExpress.XtraEditors.LookUpEdit();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.lblMaTk = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditQuyen.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTenTk
            // 
            this.txtTenTk.Location = new System.Drawing.Point(126, 34);
            this.txtTenTk.Name = "txtTenTk";
            this.txtTenTk.Size = new System.Drawing.Size(198, 20);
            this.txtTenTk.TabIndex = 4;
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
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(17, 69);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(44, 13);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Mật khẩu";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.lookUpEditQuyen);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.txtMatKhau);
            this.groupControl1.Controls.Add(this.txtTenTk);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.lblMaTk);
            this.groupControl1.Location = new System.Drawing.Point(12, 50);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(374, 159);
            this.groupControl1.TabIndex = 15;
            this.groupControl1.Text = "Thông tin";
            // 
            // lookUpEditQuyen
            // 
            this.lookUpEditQuyen.Location = new System.Drawing.Point(126, 96);
            this.lookUpEditQuyen.MenuManager = this.barManager1;
            this.lookUpEditQuyen.Name = "lookUpEditQuyen";
            this.lookUpEditQuyen.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEditQuyen.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Ma", "Mã"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Quyen", 50, "Quyền")});
            this.lookUpEditQuyen.Properties.NullText = "";
            this.lookUpEditQuyen.Size = new System.Drawing.Size(198, 20);
            this.lookUpEditQuyen.TabIndex = 7;
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
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(397, 32);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 221);
            this.barDockControlBottom.Size = new System.Drawing.Size(397, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 32);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 189);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(397, 32);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 189);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(17, 104);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(32, 13);
            this.labelControl1.TabIndex = 6;
            this.labelControl1.Text = "Quyền";
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.Location = new System.Drawing.Point(126, 69);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.Size = new System.Drawing.Size(198, 20);
            this.txtMatKhau.TabIndex = 5;
            // 
            // lblMaTk
            // 
            this.lblMaTk.Location = new System.Drawing.Point(17, 34);
            this.lblMaTk.Name = "lblMaTk";
            this.lblMaTk.Size = new System.Drawing.Size(65, 13);
            this.lblMaTk.TabIndex = 0;
            this.lblMaTk.Text = "Tên tài khoản";
            // 
            // FrmEditNguoiDung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 221);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "FrmEditNguoiDung";
            this.Text = "Người dùng";
            this.Load += new System.EventHandler(this.FrmEditNguoiDung_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditQuyen.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtTenTk;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarButtonItem btnLuuVaDong;
        private DevExpress.XtraBars.BarButtonItem btnLuuVaMoi;
        private DevExpress.XtraBars.BarButtonItem btnDong;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.TextBox txtMatKhau;
        private DevExpress.XtraEditors.LabelControl lblMaTk;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraEditors.LookUpEdit lookUpEditQuyen;
    }
}