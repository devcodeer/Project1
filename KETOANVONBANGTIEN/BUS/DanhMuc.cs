using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using DAO;
using DTO;
namespace BUS
{
    public class DoiTuong_BUS
    {
        //Load danh sach doi tuong
        public static DataTable LoadDanhSachDoiTuong()
        {
            return DoiTuong_DAO.LoadDSDoiTuong();
        }   

        //Load danh sach kh hoặc ncc..
        public static DataTable LoadDsKh_Ncc(string manhom)
        {
            return DoiTuong_DAO.LoadDsKh_Ncc(manhom);
        }

        //Load danh sach khách hàng, nhà cung cấp, nhân viên
        public static DataTable LoadDsKhachHang_Ncc_NhanVien()
        {
            return DoiTuong_DAO.LoadDSKhachHang_Ncc_NhanVien();
        }

        
        // Chon doi tuong theo ma
        public static DataTable ChonDtTheoMa(string madt)
        {
            return DoiTuong_DAO.ChonDtTheoMa(madt);
        }

         // kiem tra doi tuong truoc khi xoa
        public static DataTable kiemtra(string madt)
        {
            return DoiTuong_DAO.kiemtra(madt);
        }

        //Them 1 doi tuong
        public static void Them1DoiTuong(DoiTuong_DTO dt)
        {
            DoiTuong_DAO.Them1doituong(dt);
        }

        //Xóa 1 đối tượng
        public static void Xoa1DoiTuong(string madt)
        {
            DoiTuong_DAO.Xoa1DoiTuong(madt);
        }

        //Sửa 1 đối tượng
        public static void Sua1DoiTuong(string magoc,DoiTuong_DTO dt)
        {
            DoiTuong_DAO.Sua1doituong(magoc,dt);
        }
    }

    public class NhomDt_BUS
    {
        //Load danh sach nhóm đối tượng
        public static DataTable LoadDanhSachNhomDt()
        {
            return NhomDt_DAO.LoadDSNhomDt();
        }

        //Thêm mới
        public static void Them1NhomDoiTuong(NhomDt_DTO nhomdt)
        {
            NhomDt_DAO.Them1NhomDoiTuong(nhomdt);
        }

         // Sửa nhóm đối tượng
        public static void Sua1NhomDoiTuong(string magoc, NhomDt_DTO nhomdt)
        {
            NhomDt_DAO.Sua1NhomDoiTuong(magoc, nhomdt);
        }

         // Xóa 
        public static void Xoa1NhomDoiTuong(string manhom)
        {
            NhomDt_DAO.Xoa1NhomDoiTuong(manhom);
        }
    }

    public class NGUOI_DUNG_BUS
    {
        
      //Dang nhap
        public static DataTable KiemTraDangNhap(string tentk, string matkhau)
        {
            return NGUOI_DUNG_DAO.KiemTraDangNhap(tentk, matkhau);
        }

        //Load
        public static DataTable DanhSachNguoiDung()
        {
            return NGUOI_DUNG_DAO.DanhSachNguoiDung();
        }

         //Kiem tra tài khoản đã tồn tại chưa
        public static DataTable KiemTraTk(string tentk)
        {
            return NGUOI_DUNG_DAO.KiemTraTk(tentk);
        }
        //Them nguoi dung
        public static void ThemNguoiDung(NguoiDung_DTO nd)
        {
            NGUOI_DUNG_DAO.ThemNguoiDung(nd);
        }

        //Xoa nguoi dung
        public static void XoaNguoiDung(string tentk)
        {
            NGUOI_DUNG_DAO.XoaNguoiDung(tentk);
        }
         //Doi mat khau
        public static void DoiMatKhau(string tentk, string matkhau)
        {
            NGUOI_DUNG_DAO.DoiMatKhau(tentk, matkhau);
        }
    }

    public class NhanVien_BUS
    { 
        //Load danh sách nhân viên
        public static DataTable LoadDanhSachNhanVien()
        {
            return NhanVien_DAO.LoadDSNhanVien();
        }
        
        // Load danh sach nhan vien theo phong ban

        public static DataTable LoadDanhSachNhanVienTheoPb(string mapb)
        {

            return NhanVien_DAO.LoadDanhSachNhanVienTheoPb(mapb);

        }

         // kiem tra nhan vien truoc khi xoa
        public static DataTable kiemtra(string madt)
        {
           return NhanVien_DAO.kiemtra(madt); 
        }

        //Thêm mới
        public static void ThemMoiNhanVien(NhanVien_DTO nv)
        {
            NhanVien_DAO.Them1NhanVien(nv);
        }

        //Xóa
        public static void XoaNhanVien(string manv)
        {
            NhanVien_DAO.Xoa1Nhanvien(manv);
        }

        //Sửa
        public static void SuaNhanVien(string magoc, NhanVien_DTO nhanvien)
        {
            NhanVien_DAO.Sua1NhanVien(magoc, nhanvien);
        }
    }

    public class NganHang_BUS
    { 
        //Load danh sách ngân hàng
        public static DataTable LoadDanhSachNganHang()
        {
            return NganHang_DAO.LoadDSNganHang();
        }

        //Thêm mới 1 ngân hàng

        public static void ThemMoi1NganHang(NganHang_DTO nganhang)
        {
            NganHang_DAO.Them1NganHang(nganhang);
        }

        //Xóa 
        public static void Xoa1NganHang(string manh)
        {
            NganHang_DAO.Xoa1NganHang(manh);
        }

        //Sửa
        public static void Sua1NganHang(string magoc, NganHang_DTO nganhang)
        {
            NganHang_DAO.Sua1NganHang(magoc, nganhang);
        }

    }

    public class PhongBan_BUS
    { 
            //Load danh mục phong ban
        public static DataTable LoadDanhSachPhongBan()
        {
            return PhongBan_DAO.LoadDSPhongBan();
        }

            // Thêm mới 1 phòng ban
        public static void ThemMoi1PhongBan(PhongBan_DTO phongban)
        {
            PhongBan_DAO.Them1PhongBan(phongban);        
        }

            // Sửa
        public static void Sua1PhongBan(string magoc, PhongBan_DTO phongban)
        {
            PhongBan_DAO.Sua1PhongBan(magoc, phongban);
        }

            // Xóa
        public static void Xoa1PhongBan(string mapb)
        {
            PhongBan_DAO.Xoa1PhongBan(mapb);
        }
    }

    public class TienTe_BUS
    {
        //Load danh mục phong ban
        public static DataTable LoadDanhMucTienTe()
        {
            return TienTe_DAO.LoadDMTienTe();
        }

        //Thêm mới
        public static void Them1LoaiTien(TienTe_DTO tiente)
        {
            TienTe_DAO.Them1LoaiTien(tiente);
        }

        // Sửa
        public static void Sua1LoaiTien( string magoc,TienTe_DTO tiente)
        {
            TienTe_DAO.Sua1LoaiTien(magoc, tiente);
        }


        //Xóa
        public static void Xoa1LoaiTien(string matien)
        {
            TienTe_DAO.Xoa1LoaiTien(matien);
        }
    }

    public class TaiKhoanNganHang_BUS
    {
        //Load danh mục tài khoản ngân hàng
        public static DataTable LoadDanhMucTaiKhoanNganHang()
        {
            return TaiKhoanNganHang_DAO.LoadDMTaiKhoanNganHang();
        }

        // kiem tra tai khoan truoc khi xoa
        public static DataTable kiemtra(string sotknh)
        {
            return TaiKhoanNganHang_DAO.kiemtra(sotknh);

        }

        
        //Lấy 1 tài khoản
        public static DataTable Lay1Tk(string sotk)
        {
            return TaiKhoanNganHang_DAO.Lay1Tk(sotk);
        }

        //Thêm mới
        public static void Them1TaiKhoanNganHang(TaiKhoanNganHang_DTO tknh)
        {
            TaiKhoanNganHang_DAO.Them1TaiKhoanNganHang(tknh);
        }

        //Sửa
        public static void Sua1TaiKhoanNganHang(string sotknhgoc, TaiKhoanNganHang_DTO tknh)
        {
            TaiKhoanNganHang_DAO.Sua1TaiKhoanNganHang(sotknhgoc, tknh);
        }

        //Xóa
        public static void Xoa1TaiKhoanNganHang(string sotknh)
        {
            TaiKhoanNganHang_DAO.Xoa1TaiKhoanNganHang(sotknh);
        }
    }

    public class TaiKhoan_BUS
    {
        //Load danh mục tài khoản 
        public static DataTable LoadDanhMucTaiKhoan()
        {
            return TaiKhoan_DAO.LoadDMTaiKhoan();
        }

        // tk tien mặt
        public static DataTable LoadTkTienMat()
        {
            return TaiKhoan_DAO.LoadTkTienMat();
        }

        // tk tien gui
        public static DataTable LoadTkTienGui()
        {
            return TaiKhoan_DAO.LoadTkTienGui();
        }


        // Kiem tra tk la tk cha
        public static DataTable KiemTraTk(string matk)
        {
            return TaiKhoan_DAO.KiemTraTk(matk);
        }

         // Update so du
        public static void UpdateSoDu1TaiKhoan(string matk, decimal dunont, decimal ducont, decimal duno, decimal duco)
        {
            TaiKhoan_DAO.UpdateSoDu1TaiKhoan(matk, dunont, ducont, duno, duco);
        }

        //Thêm mới tài khoản
        public static void ThemMoiTaiKhoan(TaiKhoan_DTO tk)
        {
             TaiKhoan_DAO.Them1TaiKhoan(tk);
        }

        //Xóa 1 tài khoản

        public static void Xoa1TaiKhoan(String matk)
        {
            TaiKhoan_DAO.Xoa1TaiKhoan(matk);
        }

        //Sửa

        public static void Sua1TaiKhoan(string magoc, TaiKhoan_DTO tk)
        {
            TaiKhoan_DAO.Sua1TaiKhoan(magoc, tk);
        }
    }

    public class PhanTich_BUS
    {
        public static DataTable PhanTichThuChi()
        {
            return PhanTich_DAO.PhanTichThuChi();
        }
        public static DataTable TinhTienTon()
        {
            return PhanTich_DAO.TinhTienTon();
        }

        public static DataTable ThuChiCacThang()
        {
            return PhanTich_DAO.ThuChiCacThang();
        }
    }

}
