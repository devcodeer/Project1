using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.Skins;
using DevExpress.LookAndFeel;
using DevExpress.UserSkins;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraBars.Helpers;
using BUS;
using DTO;
using System.Data.SqlClient;

namespace KETOANVONBANGTIEN
{
    public partial class MainForm : Form
    {
        public NguoiDung_DTO currentUser;


        public MainForm()
        {
            InitializeComponent();
            InitSkinGallery();
        }

        public MainForm(NguoiDung_DTO currentUser)
        {
            InitializeComponent();
            InitSkinGallery();
            this.currentUser = currentUser;

            if (this.currentUser.Quyen != 1)
                navBarItemNguoiDung.Enabled = false ;
        }

        private void InitSkinGallery()
        {
            SkinHelper.InitSkinGallery(SkinsGallery, true);

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            if (currentUser.Quyen == 1)
            {
                barBtnTaoTaiKhoan.Enabled = true;
            }
            else
            {
                barBtnTaoTaiKhoan.Enabled = false;
                
            }
            foreach (Form f in MdiChildren)
            {
                f.Close();
            }
            DanhMuc.FrmPhanTichThuChi frm = new DanhMuc.FrmPhanTichThuChi();
            frm.MdiParent = this;
            frm.Show();
        }

        private void barBtnSoTienMat_ItemClick(object sender, ItemClickEventArgs e)
        {
            BaoCao.SoQuy.FrmThamSoBaoCao frm = new BaoCao.SoQuy.FrmThamSoBaoCao();
            frm.ShowDialog();
            
            
        }

        private void navBarItemNhanVien_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
          
            foreach (Form f in MdiChildren)
            {
                f.Close();
            }
            DanhMuc.FrmDanhMucNhanVien frm = new DanhMuc.FrmDanhMucNhanVien();
            frm.MdiParent = this;
            frm.Show();
        }

        private void navBarItemDoiTuong_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            foreach (Form f in MdiChildren)
            {
                f.Close();
            }
            DanhMuc.FrmDanhMucDoiTuong frm = new DanhMuc.FrmDanhMucDoiTuong();
            frm.MdiParent = this;
            frm.Show();
        }

        private void navBarItemNganHang_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            foreach (Form f in MdiChildren)
            {
                f.Close();
            }
            DanhMuc.FrmDanhMucNganHang frm = new DanhMuc.FrmDanhMucNganHang();
            frm.MdiParent = this;
            frm.Show();
        }

        private void barBtnTaiKhoan_ItemClick(object sender, ItemClickEventArgs e)
        {
            foreach (Form f in MdiChildren)
            {
                f.Close();
            }
            DanhMuc.FrmDanhMucTaiKhoan frm = new DanhMuc.FrmDanhMucTaiKhoan();
            frm.MdiParent = this;
            frm.Show();
        }

        private void barBtnKhNcc_ItemClick(object sender, ItemClickEventArgs e)
        {
            foreach (Form f in MdiChildren)
            {
                f.Close();
            }
            DanhMuc.FrmDanhMucDoiTuong frm = new DanhMuc.FrmDanhMucDoiTuong();
            frm.MdiParent = this;
            frm.Show();
        }

        private void barBtnNhanVien_ItemClick(object sender, ItemClickEventArgs e)
        {
            foreach (Form f in MdiChildren)
            {
                f.Close();
            }
            DanhMuc.FrmDanhMucNhanVien frm = new DanhMuc.FrmDanhMucNhanVien();
            frm.MdiParent = this;
            frm.Show();
        }

        private void barBtnNganHang_ItemClick(object sender, ItemClickEventArgs e)
        {
            foreach (Form f in MdiChildren)
            {
                f.Close();
            }
            DanhMuc.FrmDanhMucNganHang frm = new DanhMuc.FrmDanhMucNganHang();
            frm.MdiParent = this;
            frm.Show();
        }

        private void barBtnPhongBan_ItemClick(object sender, ItemClickEventArgs e)
        {
            foreach (Form f in MdiChildren)
            {
                f.Close();
            }
            DanhMuc.FrmDanhMucPhongBan frm = new DanhMuc.FrmDanhMucPhongBan();
            frm.MdiParent = this;
            frm.Show();
        }

        private void barBtnTienTe_ItemClick(object sender, ItemClickEventArgs e)
        {
            foreach (Form f in MdiChildren)
            {
                f.Close();
            }
            DanhMuc.FrmDanhMucTienTe frm = new DanhMuc.FrmDanhMucTienTe();
            frm.MdiParent = this;
            frm.Show();
        }

        private void navBarItemPhieuThu_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            foreach (Form f in MdiChildren)
            {
                f.Close();
            }
            ChungTu.FrmDanhSachChungTu frm = new ChungTu.FrmDanhSachChungTu();
            frm.luachonds.LuaChon = "DanhSachPhieuThu";
            frm.MdiParent = this;
            frm.Show();
        }

        private void barBtnPhieuThu_ItemClick(object sender, ItemClickEventArgs e)
        {
            foreach (Form f in MdiChildren)
            {
                f.Close();
            }
            ChungTu.FrmDanhSachChungTu frm = new ChungTu.FrmDanhSachChungTu();
            frm.luachonds.LuaChon = "DanhSachPhieuThu";
            frm.MdiParent = this;
            frm.Show();
        }

        private void navBarItemPhieuChi_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            foreach (Form f in MdiChildren)
            {
                f.Close();
            }
            ChungTu.FrmDanhSachChungTu frm = new ChungTu.FrmDanhSachChungTu();
            frm.luachonds.LuaChon = "DanhSachPhieuChi";
            frm.MdiParent = this;
            frm.Show();
        }

        private void barBtnPhieuChi_ItemClick(object sender, ItemClickEventArgs e)
        {
            foreach (Form f in MdiChildren)
            {
                f.Close();
            }
            ChungTu.FrmDanhSachChungTu frm = new ChungTu.FrmDanhSachChungTu();
            frm.luachonds.LuaChon = "DanhSachPhieuChi";
            frm.MdiParent = this;
            frm.Show();
        }

        private void navBarItemBaoNo_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            foreach (Form f in MdiChildren)
            {
                f.Close();
            }
            ChungTu.FrmDanhSachChungTu frm = new ChungTu.FrmDanhSachChungTu();
            frm.luachonds.LuaChon = "DanhSachGiayBaoNo";
            frm.MdiParent = this;
            frm.Show();
        }

        private void barBtnBaoNo_ItemClick(object sender, ItemClickEventArgs e)
        {
            foreach (Form f in MdiChildren)
            {
                f.Close();
            }
            ChungTu.FrmDanhSachChungTu frm = new ChungTu.FrmDanhSachChungTu();
            frm.luachonds.LuaChon = "DanhSachGiayBaoNo";
            frm.MdiParent = this;
            frm.Show();
        }

        private void navBarItemBaoCo_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            foreach (Form f in MdiChildren)
            {
                f.Close();
            }
            ChungTu.FrmDanhSachChungTu frm = new ChungTu.FrmDanhSachChungTu();
            frm.luachonds.LuaChon = "DanhSachGiayBaoCo";
            frm.MdiParent = this;
            frm.Show();
        }

        private void barBtnBaoCo_ItemClick(object sender, ItemClickEventArgs e)
        {
            foreach (Form f in MdiChildren)
            {
                f.Close();
            }
            ChungTu.FrmDanhSachChungTu frm = new ChungTu.FrmDanhSachChungTu();
            frm.luachonds.LuaChon = "DanhSachGiayBaoCo";
            frm.MdiParent = this;
            frm.Show();
        }

        private void barButtonTknh_ItemClick(object sender, ItemClickEventArgs e)
        {
            foreach (Form f in MdiChildren)
            {
                f.Close();
            }
            DanhMuc.FrmDanhMucTaiKhoanNganHang frm = new DanhMuc.FrmDanhMucTaiKhoanNganHang();
            frm.MdiParent = this;
            frm.Show();
        }

        private void barButtonItemNhomDoiTuong_ItemClick(object sender, ItemClickEventArgs e)
        {
            foreach (Form f in MdiChildren)
            {
                f.Close();
            }
            DanhMuc.FrmDanhMucNhomDoiTuong frm = new DanhMuc.FrmDanhMucNhomDoiTuong();
            frm.MdiParent = this;
            frm.Show();
        }

        private void barButtonItemSoDuBanDau_ItemClick(object sender, ItemClickEventArgs e)
        {
            foreach (Form f in MdiChildren)
            {
                f.Close();
            }
            DanhMuc.FrmSoDuTaiKhoan frm = new DanhMuc.FrmSoDuTaiKhoan();
            frm.MdiParent = this;
            frm.Show();
        }

        private void barBtnTinhTyGia_ItemClick(object sender, ItemClickEventArgs e)
        {
            
            foreach (Form f in MdiChildren)
            {
                f.Close();
            }
            ChungTu.FrmDSXyLyChenhLech frm = new ChungTu.FrmDSXyLyChenhLech();

            frm.MdiParent = this;
            frm.Show();
        }

        private void barBtnSoTienGui_ItemClick(object sender, ItemClickEventArgs e)
        {
            BaoCao.SoTienGui.FrmThamSoBaoCao frm = new BaoCao.SoTienGui.FrmThamSoBaoCao();
            frm.ShowDialog();
        }

        private void barBtnThoat_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.Close();
        }

        private void barButtonItem9_ItemClick(object sender, ItemClickEventArgs e)
        {
            foreach (Form f in MdiChildren)
            {
                f.Close();
            }
            DanhMuc.FrmPhanTichThuChi frm = new DanhMuc.FrmPhanTichThuChi();
            frm.MdiParent = this;
            frm.Show();
        }


        private void navBarItemSoTienMat_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            BaoCao.SoQuy.FrmThamSoBaoCao frm = new BaoCao.SoQuy.FrmThamSoBaoCao();
            frm.ShowDialog();
        }

        private void navBarItemSoTienGui_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            BaoCao.SoTienGui.FrmThamSoBaoCao frm = new BaoCao.SoTienGui.FrmThamSoBaoCao();
            frm.ShowDialog();
        }

        private void navBarItemPhanTich_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            foreach (Form f in MdiChildren)
            {
                f.Close();
            }
            DanhMuc.FrmPhanTichThuChi frm = new DanhMuc.FrmPhanTichThuChi();
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnBackUp_ItemClick(object sender, ItemClickEventArgs e)
        {
            SaveFileDialog sv = new SaveFileDialog();
            sv.Title = "Tên file";
            sv.Filter = ".bak|.bak";
            if (sv.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string duongdan = sv.FileName;
                    BaoCao_BUS.backup(duongdan);
                    MessageBox.Show("Sao lưu thành công !");
                }
                catch
                {
                    MessageBox.Show("Sao lưu thất bại !");
                }
            }
        }

        private void btnRestore_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Title = "File";
            op.Filter = ".bak|*.bak";
            if (op.ShowDialog() == DialogResult.OK)
            {               
                    try
                    {
                        string path = op.FileName;
                        string sqlRestore = "USE MASTER ALTER DATABASE [KTVBT] SET Single_User WITH Rollback Immediate ALTER DATABASE [KTVBT] SET Multi_User RESTORE DATABASE [KTVBT] FROM DISK = '" + path + "' WITH REPLACE";
                        SqlConnection con = new SqlConnection("Server =ALIENWARE-PC; uid=ailien; pwd=anhhoang; database=master");
                        con.Open();

                        SqlCommand cmd = new SqlCommand(sqlRestore, con);
                        cmd.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("Dữ liệu đã được phục hồi !");

                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show(ex.Message, "Restore Database");
                        return;
                    }
                    catch (Exception ex)
                    {
                    MessageBox.Show(ex.Message, "Restore Database");
                }

            }
        }

        private void barBtnTaoTaiKhoan_ItemClick(object sender, ItemClickEventArgs e)
        {
            foreach (Form f in MdiChildren)
            {
                f.Close();
            }
            DanhMuc.FrmDanhSachNguoiDung frm = new DanhMuc.FrmDanhSachNguoiDung();
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnThoat_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.Close();
        }



        private void barBtnDoiMatKhau_ItemClick(object sender, ItemClickEventArgs e)
        {
            DanhMuc.FrmDoiMatKhau frm = new DanhMuc.FrmDoiMatKhau();
            frm.tentk = currentUser.TenTk;
            frm.matkhau = currentUser.MatKhau;
            frm.ShowDialog();
        }

        private void navBarItemNguoiDung_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {

            foreach (Form f in MdiChildren)
            {
                f.Close();
            }
            DanhMuc.FrmDanhSachNguoiDung frm = new DanhMuc.FrmDanhSachNguoiDung();
            frm.MdiParent = this;
            frm.Show();
        }
    }
}
