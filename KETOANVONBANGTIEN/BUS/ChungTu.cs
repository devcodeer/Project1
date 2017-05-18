using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using DTO;
using DAO;

namespace BUS
{
    public class ChungTu_BUS
    {
        // Load
        public static DataTable LoadDanhSachCtTheoLoai( int maloai)
        {
           return ChungTu_DAO.LoadDSChungTu(maloai);

        }

        // Lay1 chung tu
        public static DataTable Lay1ChungTu(string soct)
        {
            return ChungTu_DAO.Lay1ChungTu(soct);
        }


        // Thêm
        public static void Them1ChungTu(ChungTu_DTO ct)
        {
            ChungTu_DAO.Them1ChungTu(ct);
        }

        // Sửa
        public static void Sua1ChungTu(string magoc, ChungTu_DTO ct)
        {
            ChungTu_DAO.Sua1ChungTu(magoc, ct);
        }

        // Xóa
        public static void Xoa1ChungTu(string soct)
        {
            ChungTu_DAO.Xoa1ChungTu(soct);
        }

         //Update trang thai
        public static void UpdateTrangThai(string soct, bool trangthai)
        {
            ChungTu_DAO.UpdateTrangThai(soct, trangthai);
        }

    }

    public class ChiTietCT_BUS
    {
        //Load
        public static DataTable LoadChiTietCT(string soct)
        {
            return ChiTietChungTu_DAO.LoadChiTietCt(soct); ;

        }

          // Load chi tiết chứng từ lên giấy báo ngân hàng
        public static DataTable LoadChiTietCtLenGB(string soct)
        {
            return ChiTietChungTu_DAO.LoadChiTietCtLenGB(soct);
        }

      
        // Thêm
        public static void Them1ChiTietCt(ChiTietChungTu_DTO ct)
        {
            ChiTietChungTu_DAO.ThemChiTietCt(ct);
        }

        // Sửa
        public static void SuaChiTietCt(int magoc,ChiTietChungTu_DTO ct)
        {
            ChiTietChungTu_DAO.SuaChiTietCt(magoc, ct);
        }

        // Xoa Chi tiet chung tu
        public static void XoaChiTietCt(int id)
        {
            ChiTietChungTu_DAO.XoaChiTietCt(id);
        }
    
    }

}
