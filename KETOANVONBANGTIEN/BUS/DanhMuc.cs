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
        public static DataTable loadListObjects()
        {
            return DoiTuong_DAO.loadListObjects();
        }   

        //Load danh sach kh hoặc ncc..
        public static DataTable loadListCustomerOrProvider(string manhom)
        {
            return DoiTuong_DAO.loadListCustomerOrProvider(manhom);
        }

        //Load danh sach khách hàng, nhà cung cấp, nhân viên
        public static DataTable loadListCustomerProviderEmployee()
        {
            return DoiTuong_DAO.loadListCustomerProviderEmployee();
        }

        
        // Chon doi tuong theo ma
        public static DataTable getObjectById(string madt)
        {
            return DoiTuong_DAO.getObjectById(madt);
        }

         // kiem tra doi tuong truoc khi xoa
        public static DataTable kiemTraChungTuCuaDoiTuong(string madt)
        {
            return DoiTuong_DAO.kiemTraChungTuCuaDoiTuong(madt);
        }

        //Them 1 doi tuong
        public static void insertObject(DoiTuong_DTO dt)
        {
            DoiTuong_DAO.insertObject(dt);
        }

        //Xóa 1 đối tượng
        public static void deleteObject(string madt)
        {
            DoiTuong_DAO.deleteObject(madt);
        }

        //Sửa 1 đối tượng
        public static void updateObject(string magoc,DoiTuong_DTO dt)
        {
            DoiTuong_DAO.updateObject(magoc,dt);
        }
    }

    public class NhomDoiTuong_BUS
    {
        //Load danh sach nhóm đối tượng
        public static DataTable loadDanhSachNhomDoiTuong()
        {
            return NhomDoiTuong_DAO.loadDanhSachNhomDoiTuong();
        }

        //Thêm mới
        public static void insertNhomDoiTuong(NhomDoiTuong_DTO nhomdt)
        {
            NhomDoiTuong_DAO.insertNhomDoiTuong(nhomdt);
        }

         // Sửa nhóm đối tượng
        public static void updateNhomDoiTuong(string magoc, NhomDoiTuong_DTO nhomdt)
        {
            NhomDoiTuong_DAO.updateNhomDoiTuong(magoc, nhomdt);
        }

         // Xóa 
        public static void deleteNhomDoiTuong(string manhom)
        {
            NhomDoiTuong_DAO.deleteNhomDoiTuong(manhom);
        }
    }

    public class NguoiDung_BUS
    {
        
      //Dang nhap
        public static DataTable doLogin(string tentk, string matkhau)
        {
            return NguoiDung_DAO.doLogin(tentk, matkhau);
        }

        //Load
        public static DataTable getListUser()
        {
            return NguoiDung_DAO.getListUser();
        }

         //Kiem tra tài khoản đã tồn tại chưa
        public static DataTable checkUsernameIsExist(string tentk)
        {
            return NguoiDung_DAO.checkUsernameIsExist(tentk);
        }
        //Them nguoi dung
        public static void insertUser(NguoiDung_DTO nd)
        {
            NguoiDung_DAO.insertUser(nd);
        }

        //Xoa nguoi dung
        public static void deleteUser(string tentk)
        {
            NguoiDung_DAO.deleteUser(tentk);
        }
         //Doi mat khau
        public static void updatePassword(string tentk, string matkhau)
        {
            NguoiDung_DAO.updatePassword(tentk, matkhau);
        }
    }

    public class NhanVien_BUS
    { 
        //Load danh sách nhân viên
        public static DataTable loadListEmployee()
        {
            return NhanVien_DAO.loadListEmployee();
        }
        
        // Load danh sach nhan vien theo phong ban

        public static DataTable loadEmployeeByDepartmentId(string mapb)
        {

            return NhanVien_DAO.loadEmployeeByDepartmentId(mapb);

        }

         // kiem tra nhan vien truoc khi xoa
        public static DataTable kiemTraChungTuCuaNhanVien(string madt)
        {
           return NhanVien_DAO.kiemTraChungTuCuaNhanVien(madt); 
        }

        //Thêm mới
        public static void insertEmployee(NhanVien_DTO nv)
        {
            NhanVien_DAO.insertEmployee(nv);
        }

        //Xóa
        public static void deleteEmployee(string manv)
        {
            NhanVien_DAO.deleteEmployee(manv);
        }

        //Sửa
        public static void updateEmployee(string magoc, NhanVien_DTO nhanvien)
        {
            NhanVien_DAO.updateEmployee(magoc, nhanvien);
        }
    }

    public class NganHang_BUS
    { 
        //Load danh sách ngân hàng
        public static DataTable loadListBank()
        {
            return NganHang_DAO.loadListBank();
        }

        //Thêm mới 1 ngân hàng

        public static void insertBank(NganHang_DTO nganhang)
        {
            NganHang_DAO.insertBank(nganhang);
        }

        //Xóa 
        public static void deleteBankById(string manh)
        {
            NganHang_DAO.deleteBankById(manh);
        }

        //Sửa
        public static void updateBank(string magoc, NganHang_DTO nganhang)
        {
            NganHang_DAO.updateBank(magoc, nganhang);
        }

    }

    public class PhongBan_BUS
    { 
            //Load danh mục phong ban
        public static DataTable loadListDepartment()
        {
            return PhongBan_DAO.loadListDepartment();
        }

            // Thêm mới 1 phòng ban
        public static void insertDepartment(PhongBan_DTO phongban)
        {
            PhongBan_DAO.insertDepartment(phongban);        
        }

            // Sửa
        public static void updateDepartment(string magoc, PhongBan_DTO phongban)
        {
            PhongBan_DAO.updateDepartment(magoc, phongban);
        }

            // Xóa
        public static void deleteDepartmentById(string mapb)
        {
            PhongBan_DAO.deleteDepartmentById(mapb);
        }
    }

    public class TienTe_BUS
    {
        //Load danh mục phong ban
        public static DataTable loadDanhMucTienTe()
        {
            return TienTe_DAO.loadDanhMucTienTe();
        }

        //Thêm mới
        public static void insertCurrency(TienTe_DTO tiente)
        {
            TienTe_DAO.insertCurrency(tiente);
        }

        // Sửa
        public static void updateCurrency( string magoc,TienTe_DTO tiente)
        {
            TienTe_DAO.updateCurrency(magoc, tiente);
        }


        //Xóa
        public static void deleteCurrency(string matien)
        {
            TienTe_DAO.deleteCurrency(matien);
        }
    }

    public class TaiKhoanNganHang_BUS
    {
        //Load danh mục tài khoản ngân hàng
        public static DataTable loadDanhMucTaiKhoanNganHang()
        {
            return TaiKhoanNganHang_DAO.loadDanhMucTaiKhoanNganHang();
        }

        // kiem tra tai khoan truoc khi xoa
        public static DataTable kiemTraChungTuCuaTaiKhoanNganHang(string sotknh)
        {
            return TaiKhoanNganHang_DAO.kiemTraChungTuCuaTaiKhoanNganHang(sotknh);

        }

        
        //Lấy 1 tài khoản
        public static DataTable loadBankAccountInfo(string sotk)
        {
            return TaiKhoanNganHang_DAO.loadBankAccountInfo(sotk);
        }

        //Thêm mới
        public static void insertBankAccount(TaiKhoanNganHang_DTO tknh)
        {
            TaiKhoanNganHang_DAO.insertBankAccount(tknh);
        }

        //Sửa
        public static void updateBankAccount(string sotknhgoc, TaiKhoanNganHang_DTO tknh)
        {
            TaiKhoanNganHang_DAO.updateBankAccount(sotknhgoc, tknh);
        }

        //Xóa
        public static void deleteBankAccount(string sotknh)
        {
            TaiKhoanNganHang_DAO.deleteBankAccount(sotknh);
        }
    }

    public class TaiKhoan_BUS
    {
        //Load danh mục tài khoản 
        public static DataTable loadListTaiKhoanKeToan()
        {
            return TaiKhoan_DAO.loadListTaiKhoanKeToan();
        }

        // tk tien mặt
        public static DataTable loadListTaiKhoanVaTienMat()
        {
            return TaiKhoan_DAO.loadListTaiKhoanVaTienMat();
        }

        // tk tien gui
        public static DataTable loadTaiKhoanTienGui()
        {
            return TaiKhoan_DAO.loadTaiKhoanTienGui();
        }


        // Kiem tra tk la tk cha
        public static DataTable kiemTraLaTaiKhoanTongHop(string matk)
        {
            return TaiKhoan_DAO.kiemTraLaTaiKhoanTongHop(matk);
        }

         // Update so du
        public static void capNhatSoDuTaiKhoan(string matk, decimal dunont, decimal ducont, decimal duno, decimal duco)
        {
            TaiKhoan_DAO.capNhatSoDuTaiKhoan(matk, dunont, ducont, duno, duco);
        }

        //Thêm mới tài khoản
        public static void insertAccount(TaiKhoan_DTO tk)
        {
             TaiKhoan_DAO.insertAccount(tk);
        }

        //Xóa 1 tài khoản

        public static void deleteAccount(String matk)
        {
            TaiKhoan_DAO.deleteAccount(matk);
        }

        //Sửa

        public static void updateAccount(string magoc, TaiKhoan_DTO tk)
        {
            TaiKhoan_DAO.updateAccount(magoc, tk);
        }
    }

    public class PhanTich_BUS
    {
        public static DataTable loadPhanTichThuChi()
        {
            return PhanTich_DAO.loadPhanTichThuChi();
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
