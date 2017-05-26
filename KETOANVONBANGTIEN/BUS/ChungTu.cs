using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using DTO;
using DAO;

namespace BUS
{
    public class XuLyChenhLech_BUS
    {
        public static void xoaXuLyChenhLech(int maXL)
        {
            XuLyChenhLech_DAO.xoaXuLyChenhLech(maXL);
        }
        public static void updateXyLyChenhLech(XuLyChenhLech_DTO xyLy, string soct, int sotiennt)
        {
            XuLyChenhLech_DAO.updateXyLyChenhLech(xyLy, soct, sotiennt);
        }

        public static void xuLyChenhLech(String soct, String tkno, String tkco, String noidung, int sotiennt, int sotien, string tigiaso, string tigiathuc)
        {
            XuLyChenhLech_DAO.xuLyChenhLech(soct, tkno, tkco, noidung, sotiennt, sotien, tigiaso, tigiathuc);
        }
        public static DataTable getDSXyLyChenhLech()
        {
            return XuLyChenhLech_DAO.getDSXyLyChenhLech();
        }
    }
    public class ChungTu_BUS
    {
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

        public static DataTable SELECT_PC(string ngayBatDau,string ngayketThuc)
        {
            return ChungTu_DAO.SELECT_PC(ngayBatDau,ngayketThuc);
        }
        public static DataTable SELECT_PT(string ngayBatDau, string ngayketThuc)
        {
            return ChungTu_DAO.SELECT_PT(ngayBatDau, ngayketThuc);
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
