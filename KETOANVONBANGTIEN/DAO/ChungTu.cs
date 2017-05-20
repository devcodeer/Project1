using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using DTO;

namespace DAO
{
    public class ChungTu_DAO
    {
        public static DataTable loadTyGiaHienTai()
        {
            SqlConnection cnn = Connector.getConnection();
            SqlCommand cmd = new SqlCommand("TinhTyGia", cnn);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        // Load danh sach chứng từ
        public static DataTable LoadDSChungTu(int loaict)
        {
            SqlConnection cnn = Connector.getConnection();
            SqlCommand cmd = new SqlCommand("sp_CHUNGTU_SelectAll", cnn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add(new SqlParameter("@loaict", SqlDbType.Int));
            cmd.Parameters["@loaict"].Value = loaict; 
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;

        }

        // Lay1 chung tu
        public static DataTable loadChungTuBySoChungTu( string soct)
        {
            SqlConnection cnn = Connector.getConnection();
            SqlCommand cmd = new SqlCommand("[sp_CHUNGTU_SelectOne]", cnn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add(new SqlParameter("@soct", SqlDbType.VarChar,10));
            cmd.Parameters["@soct"].Value = soct;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;

        }


        // Thêm mới 1 chứng từ
        public static void Them1ChungTu(ChungTu_DTO ct)
        {
            SqlConnection cnn = Connector.getConnection();
            SqlCommand cmd = new SqlCommand("sp_CHUNGTU_Insert", cnn);
            cmd.CommandType = CommandType.StoredProcedure;
       
            // khai bao bien
            cmd.Parameters.Add(new SqlParameter("@soct", SqlDbType.VarChar, 10));
            cmd.Parameters.Add(new SqlParameter("@maloaict", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@ngayct", SqlDbType.DateTime));
            cmd.Parameters.Add(new SqlParameter("@ngayghiso", SqlDbType.DateTime));
            cmd.Parameters.Add(new SqlParameter("@madt", SqlDbType.NVarChar, 10));
            cmd.Parameters.Add(new SqlParameter("@nguoigd", SqlDbType.NVarChar, 50));
            cmd.Parameters.Add(new SqlParameter("@diachi", SqlDbType.NVarChar, 200));
            cmd.Parameters.Add(new SqlParameter("@lydo", SqlDbType.NVarChar, 200));
            cmd.Parameters.Add(new SqlParameter("@kemtheo", SqlDbType.VarChar, 20));
            cmd.Parameters.Add(new SqlParameter("@matien", SqlDbType.VarChar, 5));
            cmd.Parameters.Add(new SqlParameter("@tygia", SqlDbType.Float));
            cmd.Parameters.Add(new SqlParameter("@tknhdi", SqlDbType.VarChar, 20));
            cmd.Parameters.Add(new SqlParameter("@tknhden", SqlDbType.VarChar, 20));
            cmd.Parameters.Add(new SqlParameter("@trangthai", SqlDbType.Bit));
            // gan gia tri
            cmd.Parameters["@soct"].Value = ct.SoCt;
            cmd.Parameters["@maloaict"].Value = ct.MaLoaiCt;
            cmd.Parameters["@ngayct"].Value = ct.NgayCt;
            cmd.Parameters["@ngayghiso"].Value = ct.NgayGhiSo;
            cmd.Parameters["@madt"].Value = ct.MaDt;
            cmd.Parameters["@nguoigd"].Value = ct.NguoiGd;
            cmd.Parameters["@diachi"].Value = ct.DiaChi;
            cmd.Parameters["@lydo"].Value = ct.LyDo;
            cmd.Parameters["@kemtheo"].Value = ct.KemTheo;
            cmd.Parameters["@matien"].Value = ct.MaTien;
            cmd.Parameters["@tygia"].Value = ct.TyGia;
            cmd.Parameters["@tknhdi"].Value = ct.TknhDi;
            cmd.Parameters["@tknhden"].Value = ct.TknhDen;
            cmd.Parameters["@trangthai"].Value = ct.TrangThai;
            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
        }
        
        // Sửa 1 chứng từ
        public static void Sua1ChungTu(string magoc,ChungTu_DTO ct)
        {
            SqlConnection cnn = Connector.getConnection();
            SqlCommand cmd = new SqlCommand("sp_CHUNGTU_Update", cnn);
            cmd.CommandType = CommandType.StoredProcedure;

            // khai bao bien
            cmd.Parameters.Add(new SqlParameter("@magoc", SqlDbType.VarChar, 10));
            cmd.Parameters.Add(new SqlParameter("@soct", SqlDbType.VarChar, 10));
            cmd.Parameters.Add(new SqlParameter("@maloaict", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@ngayct", SqlDbType.DateTime));
            cmd.Parameters.Add(new SqlParameter("@ngayghiso", SqlDbType.DateTime));
            cmd.Parameters.Add(new SqlParameter("@madt", SqlDbType.NVarChar, 10));
            cmd.Parameters.Add(new SqlParameter("@nguoigd", SqlDbType.NVarChar, 50));
            cmd.Parameters.Add(new SqlParameter("@diachi", SqlDbType.NVarChar, 200));
            cmd.Parameters.Add(new SqlParameter("@lydo", SqlDbType.NVarChar, 200));
            cmd.Parameters.Add(new SqlParameter("@kemtheo", SqlDbType.VarChar, 20));
            cmd.Parameters.Add(new SqlParameter("@matien", SqlDbType.VarChar, 5));
            cmd.Parameters.Add(new SqlParameter("@tygia", SqlDbType.Float));
            cmd.Parameters.Add(new SqlParameter("@tknhdi", SqlDbType.VarChar, 20));
            cmd.Parameters.Add(new SqlParameter("@tknhden", SqlDbType.VarChar, 20));
            cmd.Parameters.Add(new SqlParameter("@trangthai", SqlDbType.Bit));
            // gan gia tri
            cmd.Parameters["@magoc"].Value = magoc;
            cmd.Parameters["@soct"].Value = ct.SoCt;
            cmd.Parameters["@maloaict"].Value = ct.MaLoaiCt;
            cmd.Parameters["@ngayct"].Value = ct.NgayCt;
            cmd.Parameters["@ngayghiso"].Value = ct.NgayGhiSo;
            cmd.Parameters["@madt"].Value = ct.MaDt;
            cmd.Parameters["@nguoigd"].Value = ct.NguoiGd;
            cmd.Parameters["@diachi"].Value = ct.DiaChi;
            cmd.Parameters["@lydo"].Value = ct.LyDo;
            cmd.Parameters["@kemtheo"].Value = ct.KemTheo;
            cmd.Parameters["@matien"].Value = ct.MaTien;
            cmd.Parameters["@tygia"].Value = ct.TyGia;
            cmd.Parameters["@tknhdi"].Value = ct.TknhDi;
            cmd.Parameters["@tknhden"].Value = ct.TknhDen;
            cmd.Parameters["@trangthai"].Value = ct.TrangThai;
            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
        }

        //Xóa
        public static void Xoa1ChungTu(string soct)
        {
            SqlConnection cnn = Connector.getConnection();
            SqlCommand cmd = new SqlCommand("sp_CHUNGTU_Delete", cnn);
            cmd.CommandType = CommandType.StoredProcedure;

            // khai bao bien
            cmd.Parameters.Add(new SqlParameter("@soct", SqlDbType.VarChar, 10));

            cmd.Parameters["@soct"].Value = soct;
            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
        }
        
        //Update trang thai
        public static void UpdateTrangThai(string soct, bool trangthai)
        {
            SqlConnection cnn = Connector.getConnection();
            SqlCommand cmd = new SqlCommand("sp_TRANGTHAI_CHUNGTU_Update", cnn);
            cmd.CommandType = CommandType.StoredProcedure;

            // khai bao bien
            cmd.Parameters.Add(new SqlParameter("@soct", SqlDbType.VarChar, 10));
            cmd.Parameters.Add(new SqlParameter("@trangthai", SqlDbType.Bit));
            cmd.Parameters["@soct"].Value = soct;
            cmd.Parameters["@trangthai"].Value = trangthai;
            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
        }
    }

    public class ChiTietChungTu_DAO
    {
        // Load chi tiết chứng từ
        public static DataTable LoadChiTietCt( string soct)
        {
            SqlConnection cnn = Connector.getConnection();
            SqlCommand cmd = new SqlCommand("sp_ChiTietCT_Select", cnn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add(new SqlParameter("@soct", SqlDbType.VarChar,10));
            cmd.Parameters["@soct"].Value = soct;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;

        }

        // Load chi tiết chứng từ lên giấy báo ngân hàng
        public static DataTable LoadChiTietCtLenGB(string soct)
        {
            SqlConnection cnn = Connector.getConnection();
            SqlCommand cmd = new SqlCommand("sp_ChiTietCT_LenGBNH", cnn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add(new SqlParameter("@soct", SqlDbType.VarChar, 10));
            cmd.Parameters["@soct"].Value = soct;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;

        }

        // Thêm chi tiết chứng từ
        public static void themChiTietChungTu(ChiTietChungTu_DTO ct)
        {
            SqlConnection cnn = Connector.getConnection();
            SqlCommand cmd = new SqlCommand("sp_ChiTietCT_Insert", cnn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add(new SqlParameter("@soct", SqlDbType.VarChar, 10));
            cmd.Parameters.Add(new SqlParameter("@tkno", SqlDbType.VarChar, 7));
            cmd.Parameters.Add(new SqlParameter("@tkco", SqlDbType.VarChar, 7));
            cmd.Parameters.Add(new SqlParameter("@noidung", SqlDbType.NVarChar, 100));
            cmd.Parameters.Add(new SqlParameter("@sotien", SqlDbType.Decimal ));
            cmd.Parameters.Add(new SqlParameter("@sotiennt", SqlDbType.Decimal));

            cmd.Parameters["@soct"].Value = ct.SoCt;
            cmd.Parameters["@tkno"].Value = ct.TkNo;
            cmd.Parameters["@tkco"].Value = ct.TkCo;
            cmd.Parameters["@noidung"].Value = ct.NoiDung;
            cmd.Parameters["@sotien"].Value = ct.SoTien;
            cmd.Parameters["@sotiennt"].Value = ct.SoTienNT;
            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();

        }

        // Sửa tiết chứng từ
        public static void updateChiTietChungTu(int magoc,ChiTietChungTu_DTO ct)
        {
            SqlConnection cnn = Connector.getConnection();
            SqlCommand cmd = new SqlCommand("sp_ChiTietCT_Update", cnn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add(new SqlParameter("@id",SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@soct", SqlDbType.VarChar, 10));
            cmd.Parameters.Add(new SqlParameter("@tkno", SqlDbType.VarChar, 7));
            cmd.Parameters.Add(new SqlParameter("@tkco", SqlDbType.VarChar, 7));
            cmd.Parameters.Add(new SqlParameter("@noidung", SqlDbType.NVarChar, 100));
            cmd.Parameters.Add(new SqlParameter("@sotien", SqlDbType.Decimal));
            cmd.Parameters.Add(new SqlParameter("@sotiennt", SqlDbType.Decimal));
            cmd.Parameters["@id"].Value = magoc;
            cmd.Parameters["@soct"].Value = ct.SoCt;
            cmd.Parameters["@tkno"].Value = ct.TkNo;
            cmd.Parameters["@tkco"].Value = ct.TkCo;
            cmd.Parameters["@noidung"].Value = ct.NoiDung;
            cmd.Parameters["@sotien"].Value = ct.SoTien;
            cmd.Parameters["@sotiennt"].Value = ct.SoTienNT;

            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();

        }

        // Xoa Chi tiet chung tu
        public static void deleteChiTietChungTu(int id)
        {
            SqlConnection cnn = Connector.getConnection();
            SqlCommand cmd = new SqlCommand("[sp_ChiTietCT_Delete]", cnn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add(new SqlParameter("@id", SqlDbType.Int));

            cmd.Parameters["@id"].Value = id;
         
            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();

        }
    }
}
