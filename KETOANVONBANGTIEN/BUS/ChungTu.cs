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
        public static DataTable getDSXyLyChenhLech()
        {
            return ChungTu_DAO.getDSXyLyChenhLech();
        }
        public static int getTyGiaHienTai()
        {
            DataTable dtb = ChungTu_DAO.loadTyGiaHienTai();
            int tyGiaHienTai = (int)dtb.Rows[0][0];
            return tyGiaHienTai;
        }
        public static int getTonQuyVND()
        {
            DataTable dtb = ChungTu_DAO.TinhTonQuy();
            int getTonQuyVND = (int)dtb.Rows[0][0];
            return getTonQuyVND;
        }
        public static int getTonQuyUSD()
        {
            DataTable dtb = ChungTu_DAO.TinhTonQuyUSD();
            int getTonQuyUSD = (int)dtb.Rows[0][0];
            return getTonQuyUSD;
        }

        // Load
        public static DataTable LoadDanhSachCtTheoLoai( int maloai)
        {
           return ChungTu_DAO.LoadDSChungTu(maloai);

        }

        // Lay1 chung tu
        public static DataTable loadChungTuBySoChungTu(string soct)
        {
            return ChungTu_DAO.loadChungTuBySoChungTu(soct);
        }


        // Thêm
        public static void insertChungTu(ChungTu_DTO ct)
        {
            ChungTu_DAO.Them1ChungTu(ct);
        }

        // Sửa
        public static void updateChungTu(string magoc, ChungTu_DTO ct)
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
        public static void insertChiTietChungTu(ChiTietChungTu_DTO ct)
        {
            ChiTietChungTu_DAO.themChiTietChungTu(ct);
        }

        // Sửa
        public static void updateChiTietChungTu(int magoc,ChiTietChungTu_DTO ct)
        {
            ChiTietChungTu_DAO.updateChiTietChungTu(magoc, ct);
        }

        // Xoa Chi tiet chung tu
        public static void deleteChiTietChungTu(int id)
        {
            ChiTietChungTu_DAO.deleteChiTietChungTu(id);
        }
    
    }

}
