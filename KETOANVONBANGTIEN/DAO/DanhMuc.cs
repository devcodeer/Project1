using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using DTO;
namespace DAO
{
   

    public class NguoiDung_DAO
    {
        public static DataTable doLogin(string tentk, string matkhau)
        {
            SqlConnection connection = Connector.getConnection();
            SqlCommand cmd = new SqlCommand("sp_NguoiDung_Select", connection);
            cmd.CommandType = CommandType.StoredProcedure;

            // Khai bao bien
            cmd.Parameters.Add(new SqlParameter("@tentk", SqlDbType.VarChar, 50));
            cmd.Parameters.Add(new SqlParameter("@matkhau", SqlDbType.VarChar, 50));
            // Gan gia tri
            cmd.Parameters["@tentk"].Value = tentk;
            cmd.Parameters["@matkhau"].Value = matkhau;

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        //Load
        public static DataTable getListUser()
        {
            SqlConnection connection = Connector.getConnection();
            SqlCommand cmd = new SqlCommand("sp_NguoiDung_SelectAll", connection);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        //Kiem tra tài khoản đã tồn tại chưa
        public static DataTable checkUsernameIsExist(string tentk)
        {
            SqlConnection cnn = Connector.getConnection();
            SqlCommand cmd = new SqlCommand("sp_NguoiDung_KiemTra", cnn);
            cmd.CommandType = CommandType.StoredProcedure;

            // Khai bao bien
            cmd.Parameters.Add(new SqlParameter("@tentk", SqlDbType.VarChar, 50));            
            // Gan gia tri
            cmd.Parameters["@tentk"].Value = tentk;         

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }


        //Them nguoi dung
        public static void insertUser(NguoiDung_DTO nd)
        {
            SqlConnection cnn = Connector.getConnection();
            SqlCommand cmd = new SqlCommand("sp_NguoiDung_Insert", cnn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add(new SqlParameter("@tentk", SqlDbType.VarChar, 50));
            cmd.Parameters.Add(new SqlParameter("@matkhau", SqlDbType.VarChar, 50));
            cmd.Parameters.Add(new SqlParameter("@quyen", SqlDbType.Int));
            cmd.Parameters["@tentk"].Value = nd.TenTk;
            cmd.Parameters["@matkhau"].Value = nd.MatKhau;
            cmd.Parameters["@quyen"].Value = nd.Quyen;

            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
        }

        //Xoa nguoi dung
        public static void deleteUser(string tentk)
        {
            SqlConnection cnn = Connector.getConnection();
            SqlCommand cmd = new SqlCommand("sp_NguoiDung_Delete", cnn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add(new SqlParameter("@tentk", SqlDbType.VarChar, 50));
            cmd.Parameters["@tentk"].Value = tentk;

            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
        }

        //Doi mat khau
        public static void updatePassword(string tentk, string matkhau)
        {
            SqlConnection cnn = Connector.getConnection();
            SqlCommand cmd = new SqlCommand("sp_NguoiDung_Update", cnn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add(new SqlParameter("@tentk", SqlDbType.VarChar, 50));
            cmd.Parameters.Add(new SqlParameter("@matkhau", SqlDbType.VarChar, 50));
            cmd.Parameters["@tentk"].Value = tentk;
            cmd.Parameters["@matkhau"].Value = matkhau;

            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();

        }
    }

    public class DoiTuong_DAO
    {
        // Load danh sach tat ca DOI TUONG: khach hang, nha cung cap
        public static DataTable loadListObjects()
        {
            SqlConnection cnn = Connector.getConnection();
            SqlCommand cmd = new SqlCommand("sp_DoiTuong_SelectAll", cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;

        }
        // Load danh sach khách hàng hoặc nhà cung cấp...
        public static DataTable loadListCustomerOrProvider(string manhom)
        {
            SqlConnection cnn = Connector.getConnection();
            SqlCommand cmd = new SqlCommand("sp_KhachHangOrNcc_SelectAll", cnn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add(new SqlParameter("@manhom", SqlDbType.VarChar, 10));
            cmd.Parameters["@manhom"].Value = manhom;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;

        }

        // Load danh sach khách hàng , nhà cung câp, nhân viên
        public static DataTable loadListCustomerProviderEmployee()
        {
            SqlConnection cnn = Connector.getConnection();
            SqlCommand cmd = new SqlCommand("sp_KhachHangNccNhanVien_SelectAll", cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;

        }

        // Chon doi tuong theo ma
        public static DataTable getObjectById(string madt)
        {
            SqlConnection cnn = Connector.getConnection();
            SqlCommand cmd = new SqlCommand("sp_KhachHangNccNhanVien_SelectOneTheoMadt", cnn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add(new SqlParameter("@madt", SqlDbType.VarChar, 10));
            cmd.Parameters["@madt"].Value = madt;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;

        }

        // kiem tra doi tuong truoc khi xoa
        public static DataTable kiemTraChungTuCuaDoiTuong( string madt)
        {
            SqlConnection cnn = Connector.getConnection();
            SqlCommand cmd = new SqlCommand("sp_CHUNGTU_SelectTheoMadt", cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@madt", SqlDbType.VarChar, 10));
            cmd.Parameters["@madt"].Value = madt;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;

        }

        // Thêm mới 1 đối tượng
        public static void insertObject(DoiTuong_DTO doituong)
        {
            SqlConnection cnn = Connector.getConnection();
            SqlCommand cmd = new SqlCommand("sp_DoiTuong_Insert", cnn);
            cmd.CommandType = CommandType.StoredProcedure;

            // khai bao bien
            cmd.Parameters.Add(new SqlParameter("@madt", SqlDbType.VarChar, 10));
            cmd.Parameters.Add(new SqlParameter("@manhom", SqlDbType.VarChar,10));
            cmd.Parameters.Add(new SqlParameter("@tendt", SqlDbType.NVarChar, 200));
            cmd.Parameters.Add(new SqlParameter("@diachi", SqlDbType.NVarChar, 200));
            cmd.Parameters.Add(new SqlParameter("@email", SqlDbType.VarChar, 100));
            cmd.Parameters.Add(new SqlParameter("@dienthoai", SqlDbType.VarChar, 15));
            cmd.Parameters.Add(new SqlParameter("@mst", SqlDbType.VarChar, 13));
            cmd.Parameters.Add(new SqlParameter("@sotknh", SqlDbType.VarChar, 20));
            cmd.Parameters.Add(new SqlParameter("@tennh", SqlDbType.NVarChar, 200));
            cmd.Parameters.Add(new SqlParameter("@chinhanh", SqlDbType.NVarChar, 200));
            // gan gia tri
            cmd.Parameters["@madt"].Value = doituong.MaDt;
            cmd.Parameters["@manhom"].Value = doituong.MaNhom;
            cmd.Parameters["@tendt"].Value = doituong.TenDt;
            cmd.Parameters["@diachi"].Value = doituong.DiaChi;
            cmd.Parameters["@email"].Value = doituong.Email;
            cmd.Parameters["@dienthoai"].Value = doituong.DienThoai;
            cmd.Parameters["@mst"].Value = doituong.Mst;
            cmd.Parameters["@sotknh"].Value = doituong.SoTknh;
            cmd.Parameters["@tennh"].Value = doituong.TenNh;
            cmd.Parameters["@chinhanh"].Value = doituong.ChiNhanh;

            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
        }

        // Xóa 1 đối tượng

        public static void deleteObject( string madt)
        {
            SqlConnection cnn = Connector.getConnection();
            SqlCommand cmd = new SqlCommand("sp_DoiTuong_Delete", cnn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add(new SqlParameter("@madt", SqlDbType.VarChar, 10));
            cmd.Parameters["@madt"].Value = madt;

            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
        }

        // Update 1 đối tượng
        public static void updateObject(string magoc,DoiTuong_DTO doituong)
        {
            SqlConnection cnn = Connector.getConnection();
            SqlCommand cmd = new SqlCommand("sp_DoiTuong_Update", cnn);
            cmd.CommandType = CommandType.StoredProcedure;

            // khai bao bien
            cmd.Parameters.Add(new SqlParameter("@magoc", SqlDbType.VarChar, 10));
            cmd.Parameters.Add(new SqlParameter("@madt", SqlDbType.VarChar, 10));
            cmd.Parameters.Add(new SqlParameter("@manhom", SqlDbType.VarChar, 10));
            cmd.Parameters.Add(new SqlParameter("@tendt", SqlDbType.NVarChar, 200));
            cmd.Parameters.Add(new SqlParameter("@diachi", SqlDbType.NVarChar, 200));
            cmd.Parameters.Add(new SqlParameter("@email", SqlDbType.VarChar, 100));
            cmd.Parameters.Add(new SqlParameter("@dienthoai", SqlDbType.VarChar, 15));
            cmd.Parameters.Add(new SqlParameter("@mst", SqlDbType.VarChar, 13));
            cmd.Parameters.Add(new SqlParameter("@sotknh", SqlDbType.VarChar, 20));
            cmd.Parameters.Add(new SqlParameter("@tennh", SqlDbType.NVarChar, 200));
            cmd.Parameters.Add(new SqlParameter("@chinhanh", SqlDbType.NVarChar, 200));
            // gan gia tri
            cmd.Parameters["@magoc"].Value = magoc;
            cmd.Parameters["@madt"].Value = doituong.MaDt;
            cmd.Parameters["@manhom"].Value = doituong.MaNhom;
            cmd.Parameters["@tendt"].Value = doituong.TenDt;
            cmd.Parameters["@diachi"].Value = doituong.DiaChi;
            cmd.Parameters["@email"].Value = doituong.Email;
            cmd.Parameters["@dienthoai"].Value = doituong.DienThoai;
            cmd.Parameters["@mst"].Value = doituong.Mst;
            cmd.Parameters["@sotknh"].Value = doituong.SoTknh;
            cmd.Parameters["@tennh"].Value = doituong.TenNh;
            cmd.Parameters["@chinhanh"].Value = doituong.ChiNhanh;

            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
        }
      
    }

    public class NhomDoiTuong_DAO
    {
        // Load danh sach nhóm đối tượng
        public static DataTable loadDanhSachNhomDoiTuong()
        {
            SqlConnection cnn = Connector.getConnection();
            SqlCommand cmd = new SqlCommand("sp_NhomDt_SelectAll", cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;

        }
    
        // Thêm mới nhóm đối tượng
        public static void insertNhomDoiTuong(NhomDoiTuong_DTO nhomdt)
        {
            SqlConnection cnn = Connector.getConnection();
            SqlCommand cmd = new SqlCommand("sp_NhomDt_Insert", cnn);
            cmd.CommandType = CommandType.StoredProcedure;

            // khai bao bien
            cmd.Parameters.Add(new SqlParameter("@manhom", SqlDbType.VarChar, 10));
            cmd.Parameters.Add(new SqlParameter("@tennhom", SqlDbType.NVarChar, 50));
            
            // gan gia tri
            cmd.Parameters["@manhom"].Value = nhomdt.MaNhom;
            cmd.Parameters["@tennhom"].Value = nhomdt.TenNhom;
           

            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
        }

        // Sửa nhóm đối tượng
        public static void updateNhomDoiTuong(string magoc, NhomDoiTuong_DTO nhomdt)
        {
            SqlConnection cnn = Connector.getConnection();
            SqlCommand cmd = new SqlCommand("sp_NhomDt_Update", cnn);
            cmd.CommandType = CommandType.StoredProcedure;

            // khai bao bien
            cmd.Parameters.Add(new SqlParameter("@magoc", SqlDbType.VarChar, 10));
            cmd.Parameters.Add(new SqlParameter("@manhom", SqlDbType.VarChar, 10));
            cmd.Parameters.Add(new SqlParameter("@tennhom", SqlDbType.NVarChar, 50));

            // gan gia tri
            cmd.Parameters["@magoc"].Value = magoc;
            cmd.Parameters["@manhom"].Value = nhomdt.MaNhom;
            cmd.Parameters["@tennhom"].Value = nhomdt.TenNhom;


            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
        }

        // Xóa 
        public static void deleteNhomDoiTuong(string manhom)
        {
            SqlConnection cnn = Connector.getConnection();
            SqlCommand cmd = new SqlCommand("sp_NhomDt_Delete", cnn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add(new SqlParameter("@manhom", SqlDbType.VarChar, 10));
            cmd.Parameters["@manhom"].Value = manhom;

            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
        }
        
    }

    public class NhanVien_DAO
    { 
        // Load danh sách nhân viên
        public static DataTable loadListEmployee()
        {
            SqlConnection cnn = Connector.getConnection();
            SqlCommand cmd = new SqlCommand("sp_NhanVien_SelectAll", cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        // Load danh sách nhân viên theo phong ban
        public static DataTable loadEmployeeByDepartmentId( string mapb)
        {
            SqlConnection cnn = Connector.getConnection();
            SqlCommand cmd = new SqlCommand("sp_NhanVienTheoPb_SelectAll", cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@mapb", SqlDbType.VarChar, 10));
            cmd.Parameters["@mapb"].Value = mapb;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;

        }

        // kiem tra nhan vien truoc khi xoa
        public static DataTable kiemTraChungTuCuaNhanVien(string madt)
        {
            SqlConnection cnn = Connector.getConnection();
            SqlCommand cmd = new SqlCommand("sp_CHUNGTU_SelectTheoMadt", cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@madt", SqlDbType.VarChar, 10));
            cmd.Parameters["@madt"].Value = madt;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;

        }

        // Thêm mới
        public static void insertEmployee(NhanVien_DTO nhanvien)
        {
            SqlConnection cnn = Connector.getConnection();
            SqlCommand cmd = new SqlCommand("sp_NhanVien_Insert", cnn);
            cmd.CommandType = CommandType.StoredProcedure;

            // khai bao bien
            
            cmd.Parameters.Add(new SqlParameter("@manv", SqlDbType.VarChar, 10));
            cmd.Parameters.Add(new SqlParameter("@tennv", SqlDbType.NVarChar, 50));
            cmd.Parameters.Add(new SqlParameter("@diachi", SqlDbType.NVarChar, 200));
            cmd.Parameters.Add(new SqlParameter("@email", SqlDbType.VarChar, 100));
            cmd.Parameters.Add(new SqlParameter("@dienthoai", SqlDbType.VarChar, 15));
            cmd.Parameters.Add(new SqlParameter("@mapb", SqlDbType.VarChar, 10));
            cmd.Parameters.Add(new SqlParameter("@chucvu", SqlDbType.NVarChar, 100));
            
            // gan gia tri
            cmd.Parameters["@manv"].Value = nhanvien.MaNv;
            cmd.Parameters["@tennv"].Value = nhanvien.TenNv;
            cmd.Parameters["@diachi"].Value = nhanvien.DiaChi;
            cmd.Parameters["@email"].Value = nhanvien.Email;
            cmd.Parameters["@dienthoai"].Value = nhanvien.DienThoai;
            cmd.Parameters["@mapb"].Value = nhanvien.MaPb;
            cmd.Parameters["@chucvu"].Value = nhanvien.ChucVu;
            

            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
        }

        // Xóa 
        public static void deleteEmployee(string manv)
        {
            SqlConnection cnn = Connector.getConnection();
            SqlCommand cmd = new SqlCommand("sp_NhanVien_Delete", cnn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add(new SqlParameter("@manv", SqlDbType.VarChar, 10));
            cmd.Parameters["@manv"].Value = manv;

            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
        }

        // Sửa
        public static void updateEmployee(string magoc, NhanVien_DTO nhanvien)
        {
            SqlConnection cnn = Connector.getConnection();
            SqlCommand cmd = new SqlCommand("sp_NhanVien_Update", cnn);
            cmd.CommandType = CommandType.StoredProcedure;

            // khai bao bien
            cmd.Parameters.Add(new SqlParameter("@magoc", SqlDbType.VarChar, 10));
            cmd.Parameters.Add(new SqlParameter("@manv", SqlDbType.VarChar, 10));
            cmd.Parameters.Add(new SqlParameter("@tennv", SqlDbType.NVarChar, 50));
            cmd.Parameters.Add(new SqlParameter("@diachi", SqlDbType.NVarChar, 200));
            cmd.Parameters.Add(new SqlParameter("@email", SqlDbType.VarChar, 100));
            cmd.Parameters.Add(new SqlParameter("@dienthoai", SqlDbType.VarChar, 15));
            cmd.Parameters.Add(new SqlParameter("@mapb", SqlDbType.VarChar, 10));
            cmd.Parameters.Add(new SqlParameter("@chucvu", SqlDbType.NVarChar, 100));

            // gan gia tri
            cmd.Parameters["@magoc"].Value = magoc;
            cmd.Parameters["@manv"].Value = nhanvien.MaNv;
            cmd.Parameters["@tennv"].Value = nhanvien.TenNv;
            cmd.Parameters["@diachi"].Value = nhanvien.DiaChi;
            cmd.Parameters["@email"].Value = nhanvien.Email;
            cmd.Parameters["@dienthoai"].Value = nhanvien.DienThoai;
            cmd.Parameters["@mapb"].Value = nhanvien.MaPb;
            cmd.Parameters["@chucvu"].Value = nhanvien.ChucVu;


            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
        }
    }

    public class NganHang_DAO
    {
        //Load danh sách ngân hàng
        public static DataTable loadListBank()
        {
            SqlConnection cnn = Connector.getConnection();
            SqlCommand cmd = new SqlCommand("sp_NganHang_SelectAll",cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        //Thêm mới
        public static void insertBank(NganHang_DTO nganhang)
        {
            SqlConnection cnn = Connector.getConnection();
            SqlCommand cmd = new SqlCommand("sp_NganHang_Insert", cnn);
            cmd.CommandType = CommandType.StoredProcedure;

            // khai bao bien
            cmd.Parameters.Add(new SqlParameter("@manh", SqlDbType.VarChar, 10));
            cmd.Parameters.Add(new SqlParameter("@tennh", SqlDbType.NVarChar, 200));
            

            // gan gia tri
            cmd.Parameters["@manh"].Value = nganhang.MaNh;
            cmd.Parameters["@tennh"].Value = nganhang.TenNh;
           
            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
        }

        //Xóa 
        public static void deleteBankById(string manh)
        {
            SqlConnection cnn = Connector.getConnection();
            SqlCommand cmd = new SqlCommand("sp_NganHang_Delete", cnn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add(new SqlParameter("@manh", SqlDbType.VarChar, 10));
            cmd.Parameters["@manh"].Value = manh;

            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
        }

        //Update
        public static void updateBank(string magoc,NganHang_DTO nganhang)
        {
            SqlConnection cnn = Connector.getConnection();
            SqlCommand cmd = new SqlCommand("sp_NganHang_Update", cnn);
            cmd.CommandType = CommandType.StoredProcedure;

            // khai bao bien
            cmd.Parameters.Add(new SqlParameter("@magoc", SqlDbType.VarChar, 10));
            cmd.Parameters.Add(new SqlParameter("@manh", SqlDbType.VarChar, 10));
            cmd.Parameters.Add(new SqlParameter("@tennh", SqlDbType.NVarChar, 200));


            // gan gia tri
            cmd.Parameters["@magoc"].Value = magoc;
            cmd.Parameters["@manh"].Value = nganhang.MaNh;
            cmd.Parameters["@tennh"].Value = nganhang.TenNh;

            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
        }

    }

    public class PhongBan_DAO
    { 
        //Load danh mục phòng ban
        public static DataTable loadListDepartment()
        {
            SqlConnection cnn = Connector.getConnection();
            SqlCommand cmd = new SqlCommand("sp_PhongBan_SelectAll", cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        // Thêm mới phòng ban
        public static void insertDepartment(PhongBan_DTO phongban)
        {
            SqlConnection cnn = Connector.getConnection();
            SqlCommand cmd = new SqlCommand("sp_PhongBan_Insert", cnn);
            cmd.CommandType = CommandType.StoredProcedure;

            // khai bao bien
            cmd.Parameters.Add(new SqlParameter("@mapb", SqlDbType.VarChar, 10));
            cmd.Parameters.Add(new SqlParameter("@tenpb", SqlDbType.NVarChar, 100));
            cmd.Parameters.Add(new SqlParameter("@dienthoai", SqlDbType.VarChar, 15));
            cmd.Parameters.Add(new SqlParameter("@fax", SqlDbType.VarChar,15));


            // gan gia tri
            cmd.Parameters["@mapb"].Value = phongban.MaPb;
            cmd.Parameters["@tenpb"].Value = phongban.TenPb;
            cmd.Parameters["@dienthoai"].Value = phongban.DienThoai;
            cmd.Parameters["@fax"].Value = phongban.Fax;
            
            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
        }

        // Sửa
        public static void updateDepartment( string magoc,PhongBan_DTO phongban)
        {
            SqlConnection cnn = Connector.getConnection();
            SqlCommand cmd = new SqlCommand("sp_PhongBan_Update", cnn);
            cmd.CommandType = CommandType.StoredProcedure;

            // khai bao bien
            cmd.Parameters.Add(new SqlParameter("@magoc", SqlDbType.VarChar, 10));
            cmd.Parameters.Add(new SqlParameter("@mapb", SqlDbType.VarChar, 10));
            cmd.Parameters.Add(new SqlParameter("@tenpb", SqlDbType.NVarChar, 100));
            cmd.Parameters.Add(new SqlParameter("@dienthoai", SqlDbType.VarChar, 15));
            cmd.Parameters.Add(new SqlParameter("@fax", SqlDbType.VarChar, 15));


            // gan gia tri
            cmd.Parameters["@magoc"].Value = magoc;
            cmd.Parameters["@mapb"].Value = phongban.MaPb;
            cmd.Parameters["@tenpb"].Value = phongban.TenPb;
            cmd.Parameters["@dienthoai"].Value = phongban.DienThoai;
            cmd.Parameters["@fax"].Value = phongban.Fax;

            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
        }


        // Xóa 
        public static void deleteDepartmentById(string mapb)
        {
            SqlConnection cnn = Connector.getConnection();
            SqlCommand cmd = new SqlCommand("sp_PhongBan_Delete", cnn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add(new SqlParameter("@mapb", SqlDbType.VarChar, 10));
            cmd.Parameters["@mapb"].Value = mapb;

            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
        }
    }

    public class TienTe_DAO
    {
        //Load danh mục 
        public static DataTable loadDanhMucTienTe()
        {
            SqlConnection cnn = Connector.getConnection();
            SqlCommand cmd = new SqlCommand("sp_TienTe_SelectAll", cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        // Thêm mới 
        public static void insertCurrency(TienTe_DTO tiente)
        {
            SqlConnection cnn = Connector.getConnection();
            SqlCommand cmd = new SqlCommand("sp_TienTe_Insert", cnn);
            cmd.CommandType = CommandType.StoredProcedure;
                        
            cmd.Parameters.Add(new SqlParameter("@matien", SqlDbType.VarChar, 5));
            cmd.Parameters.Add(new SqlParameter("@tentien", SqlDbType.NVarChar, 100));

            cmd.Parameters["@matien"].Value = tiente.MaTien;
            cmd.Parameters["@tentien"].Value = tiente.TenTien;
            
            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
        }

        // Sửa
        public static void updateCurrency(string magoc ,TienTe_DTO tiente)
        {
            SqlConnection cnn = Connector.getConnection();
            SqlCommand cmd = new SqlCommand("sp_TienTe_Update", cnn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add(new SqlParameter("@magoc", SqlDbType.VarChar, 5));
            cmd.Parameters.Add(new SqlParameter("@matien", SqlDbType.VarChar, 5));
            cmd.Parameters.Add(new SqlParameter("@tentien", SqlDbType.NVarChar, 100));

            cmd.Parameters["@magoc"].Value = magoc;
            cmd.Parameters["@matien"].Value = tiente.MaTien;
            cmd.Parameters["@tentien"].Value = tiente.TenTien;

            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
        }

        // Xóa 
        public static void deleteCurrency(string matien)
        {
            SqlConnection cnn = Connector.getConnection();
            SqlCommand cmd = new SqlCommand("sp_TienTe_Delete", cnn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add(new SqlParameter("@matien", SqlDbType.VarChar, 5));
            cmd.Parameters["@matien"].Value = matien; 

            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
        }
    }

    public class TaiKhoanNganHang_DAO
    {
        //Load danh mục tài khoản ngân hàng
        public static DataTable loadDanhMucTaiKhoanNganHang()
        {
            SqlConnection cnn = Connector.getConnection();
            SqlCommand cmd = new SqlCommand("sp_TaiKhoanNganHang_SelectAll", cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        // kiem tra tai khoan truoc khi xoa
        public static DataTable kiemTraChungTuCuaTaiKhoanNganHang(string sotknh)
        {
            SqlConnection cnn = Connector.getConnection();
            SqlCommand cmd = new SqlCommand("sp_CHUNGTU_SelectTheoTknh", cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@tknh", SqlDbType.VarChar, 20));
            cmd.Parameters["@tknh"].Value = sotknh;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        //Lấy 1 tài khoản
        public static DataTable loadBankAccountInfo(string sotk)
        {
            SqlConnection cnn = Connector.getConnection();
            SqlCommand cmd = new SqlCommand("sp_TaiKhoanNganHang_SelectOne", cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@sotk", SqlDbType.VarChar, 20));
            cmd.Parameters["@sotk"].Value = sotk;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        // Thêm mới tài khoản ngân hàng
        public static void insertBankAccount( TaiKhoanNganHang_DTO tknh)
        {
            SqlConnection cnn = Connector.getConnection();
            SqlCommand cmd = new SqlCommand("sp_TaiKhoanNganHang_Insert", cnn);
            cmd.CommandType = CommandType.StoredProcedure;
                  
            cmd.Parameters.Add(new SqlParameter("@sotknh", SqlDbType.VarChar, 20));
            cmd.Parameters.Add(new SqlParameter("@tentknh", SqlDbType.NVarChar, 200));
            cmd.Parameters.Add(new SqlParameter("@manh", SqlDbType.VarChar, 10));
            cmd.Parameters.Add(new SqlParameter("@chinhanh", SqlDbType.NVarChar, 200));

            cmd.Parameters["@sotknh"].Value = tknh.SoTknh;
            cmd.Parameters["@tentknh"].Value = tknh.TenTknh;
            cmd.Parameters["@manh"].Value = tknh.MaNh;
            cmd.Parameters["@chinhanh"].Value = tknh.ChiNhanh;

            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
        }

        // Sửa
        public static void updateBankAccount(string sotknhgoc,TaiKhoanNganHang_DTO tknh)
        {
            SqlConnection cnn = Connector.getConnection();
            SqlCommand cmd = new SqlCommand("sp_TaiKhoanNganHang_Update", cnn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add(new SqlParameter("@sotknhgoc", SqlDbType.VarChar, 20));
            cmd.Parameters.Add(new SqlParameter("@sotknh", SqlDbType.VarChar, 20));
            cmd.Parameters.Add(new SqlParameter("@tentknh", SqlDbType.NVarChar, 200));
            cmd.Parameters.Add(new SqlParameter("@manh", SqlDbType.VarChar, 10));
            cmd.Parameters.Add(new SqlParameter("@chinhanh", SqlDbType.NVarChar, 200));

            cmd.Parameters["@sotknhgoc"].Value = sotknhgoc;
            cmd.Parameters["@sotknh"].Value = tknh.SoTknh;
            cmd.Parameters["@tentknh"].Value = tknh.TenTknh;
            cmd.Parameters["@manh"].Value = tknh.MaNh;
            cmd.Parameters["@chinhanh"].Value = tknh.ChiNhanh;

            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
        }

        // Xóa 
        public static void deleteBankAccount(string sotknh)
        {
            SqlConnection cnn = Connector.getConnection();
            SqlCommand cmd = new SqlCommand("sp_TaiKhoanNganHang_Delete", cnn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add(new SqlParameter("@sotknh", SqlDbType.VarChar, 20));
            cmd.Parameters["@sotknh"].Value = sotknh;

            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
        }
    }

    public class TaiKhoan_DAO
    {
        //Load danh mục tài khoản kế toán
        public static DataTable loadListTaiKhoanKeToan()
        {
            SqlConnection cnn = Connector.getConnection();
            SqlCommand cmd = new SqlCommand("sp_TaiKhoan_SelectAll", cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        // tk tien mặt
        public static DataTable loadListTaiKhoanVaTienMat()
        {
            SqlConnection cnn = Connector.getConnection();
            SqlCommand cmd = new SqlCommand("sp_TaiKhoan_SelectTkTienMat", cnn);
            cmd.CommandType = CommandType.StoredProcedure;           
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        // tk tien gui
        public static DataTable loadTaiKhoanTienGui()
        {
            SqlConnection cnn = Connector.getConnection();
            SqlCommand cmd = new SqlCommand("sp_TaiKhoan_SelectTkTienGui", cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        } 

        // Kiem tra tai khoan la tk tong hop 
        public static DataTable kiemTraLaTaiKhoanTongHop(string matk)
        {
            SqlConnection cnn = Connector.getConnection();
            SqlCommand cmd = new SqlCommand("sp_TaiKhoanCapCha_Select", cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@matk", SqlDbType.VarChar, 7));
            cmd.Parameters["@matk"].Value = matk;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        } 

        // Update so du
        public static void capNhatSoDuTaiKhoan(string matk, decimal dunont, decimal ducont, decimal duno, decimal duco)
        {
            SqlConnection cnn = Connector.getConnection();
            SqlCommand cmd = new SqlCommand("sp_SoDuTaiKhoan_Update", cnn);
            cmd.CommandType = CommandType.StoredProcedure;

            // khai bao bien
            cmd.Parameters.Add(new SqlParameter("@matk", SqlDbType.VarChar, 7));
            cmd.Parameters.Add(new SqlParameter("@sodunont", SqlDbType.Decimal));
            cmd.Parameters.Add(new SqlParameter("@soducont", SqlDbType.Decimal));
            cmd.Parameters.Add(new SqlParameter("@soduno", SqlDbType.Decimal));
            cmd.Parameters.Add(new SqlParameter("@soduco", SqlDbType.Decimal));


            // gan gia tri
            cmd.Parameters["@matk"].Value = matk;
            cmd.Parameters["@sodunont"].Value = dunont;
            cmd.Parameters["@soducont"].Value = ducont;
            cmd.Parameters["@soduno"].Value = duno;
            cmd.Parameters["@soduco"].Value = duco;
            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
        }

        //Thêm mới tài khoản kế toán
        public static void insertAccount(TaiKhoan_DTO taikhoan)
        {
            SqlConnection cnn = Connector.getConnection();
            SqlCommand cmd = new SqlCommand("sp_TaiKhoan_Insert", cnn);
            cmd.CommandType = CommandType.StoredProcedure;

            // khai bao bien
            cmd.Parameters.Add(new SqlParameter("@matk", SqlDbType.VarChar, 7));
            cmd.Parameters.Add(new SqlParameter("@tentk", SqlDbType.NVarChar, 200));
            cmd.Parameters.Add(new SqlParameter("@loaitk", SqlDbType.NVarChar, 200));
            cmd.Parameters.Add(new SqlParameter("@captk", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@tkcha", SqlDbType.VarChar, 7));
            cmd.Parameters.Add(new SqlParameter("@mant", SqlDbType.VarChar, 7));

            // gan gia tri
            cmd.Parameters["@matk"].Value = taikhoan.MaTk;
            cmd.Parameters["@tentk"].Value = taikhoan.TenTk;
            cmd.Parameters["@loaitk"].Value = taikhoan.LoaiTk;
            cmd.Parameters["@captk"].Value = taikhoan.CapTk;
            cmd.Parameters["@tkcha"].Value = taikhoan.TkCha;
            cmd.Parameters["@mant"].Value = taikhoan.MaNt;
     
            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
        }

        //Xóa 1 tài khoản
        public static void deleteAccount(String matk)
        {
            SqlConnection cnn = Connector.getConnection();
            SqlCommand cmd = new SqlCommand("sp_TaiKhoan_Delete", cnn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add(new SqlParameter("@matk", SqlDbType.VarChar, 7));
            cmd.Parameters["@matk"].Value = matk;

            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
        }

        //Sửa 1 tài khoản
        public static void updateAccount(string magoc, TaiKhoan_DTO taikhoan)
        {
            SqlConnection cnn = Connector.getConnection();
            SqlCommand cmd = new SqlCommand("sp_TaiKhoan_Update", cnn);
            cmd.CommandType = CommandType.StoredProcedure;

            // khai bao bien
            cmd.Parameters.Add(new SqlParameter("@magoc", SqlDbType.VarChar, 7));
            cmd.Parameters.Add(new SqlParameter("@matk", SqlDbType.VarChar, 7));
            cmd.Parameters.Add(new SqlParameter("@tentk", SqlDbType.NVarChar, 200));
            cmd.Parameters.Add(new SqlParameter("@loaitk", SqlDbType.NVarChar, 200));
            cmd.Parameters.Add(new SqlParameter("@captk", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@tkcha", SqlDbType.VarChar, 7));
            cmd.Parameters.Add(new SqlParameter("@mant", SqlDbType.VarChar, 7));
            // gan gia tri

            cmd.Parameters["@magoc"].Value = magoc;
            cmd.Parameters["@matk"].Value = taikhoan.MaTk;
            cmd.Parameters["@tentk"].Value = taikhoan.TenTk;
            cmd.Parameters["@loaitk"].Value = taikhoan.LoaiTk;
            cmd.Parameters["@captk"].Value = taikhoan.CapTk;
            cmd.Parameters["@tkcha"].Value = taikhoan.TkCha;
            cmd.Parameters["@mant"].Value = taikhoan.MaNt;
            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
        }


    }

    public class PhanTich_DAO
    {
        public static DataTable loadPhanTichThuChi()
        {
            SqlConnection cnn = Connector.getConnection();
            SqlCommand cmd = new SqlCommand("sp_PhanTich_ThuChi", cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public static DataTable TinhTienTon()
        {
            SqlConnection cnn = Connector.getConnection();
            SqlCommand cmd = new SqlCommand("sp_TinhTienTon", cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public static DataTable ThuChiCacThang()
        {
            SqlConnection cnn = Connector.getConnection();
            SqlCommand cmd = new SqlCommand("sp_ThuChiCacThang", cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        
    }

    
}
