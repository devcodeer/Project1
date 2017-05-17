using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
    public class NguoiDung_DTO
    {
        private int _id;
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        private String _tenTk;
        public String TenTk
        {
            get { return _tenTk; }
            set { _tenTk = value; }
        }

        private string _matKhau;
        public string MatKhau
        {
            get { return _matKhau; }
            set { _matKhau = value; }
        }

        private int _quyen;
        public int Quyen
        {
            get { return _quyen; }
            set { _quyen = value; }
        }

        public NguoiDung_DTO(string tentk, string matkhau, int quyen)
        {
            TenTk = tentk;
            MatKhau = matkhau;
            Quyen = quyen;
        }

        public NguoiDung_DTO()
        { }
    }
    public class DoiTuong_DTO
    {
        private String _maNhom;     
        private String _maDt;
        private String _tenDt;
        private String _diaChi;
        private String _email;
        private String _dienThoai;
        private String _mst;
        private String _soTknh;
        private String _tenNh;
        private String _chiNhanh;


        public String MaNhom
        {
            get { return _maNhom; }
            set { _maNhom = value; }
        }

        public String MaDt
        {
            get { return _maDt; }
            set { _maDt = value; }
        }

        public String TenDt
        {
            get { return _tenDt; }
            set { _tenDt = value; }
        }

        public String DiaChi
        {
            get { return _diaChi; }
            set { _diaChi = value; }
        }

        public String Email
        {
            get { return _email; }
            set { _email = value; }
        }

        public String DienThoai
        {
            get { return _dienThoai; }
            set { _dienThoai = value; }
        }

        public String Mst
        {
            get { return _mst; }
            set { _mst = value; }
        }

        public String SoTknh
        {
            get { return _soTknh; }
            set { _soTknh = value; }
        }

        public String TenNh
        {
            get { return _tenNh; }
            set { _tenNh = value; }
        }

        public String ChiNhanh
        {
            get { return _chiNhanh; }
            set { _chiNhanh = value; }
        }

        public DoiTuong_DTO(string madt, string tendt, string diachi, string email, string dienthoai, string mst, string sotknh, string tennh, string chinhanh, string manhom)
        {
            MaDt = madt;
            TenDt = tendt;
            DiaChi = diachi;
            Email = email;
            DienThoai = dienthoai;
            Mst = mst;
            SoTknh = sotknh;
            TenNh = tennh;
            ChiNhanh = chinhanh;
            MaNhom = manhom;
        }

        public DoiTuong_DTO()
        { 
        }


    }
    public class NhomDt_DTO
    {
        private String _maNhom;

        public String MaNhom
        {
            get { return _maNhom; }
            set { _maNhom = value; }
        }

       
        private String _tenNhom;

        public String TenNhom
        {
            get { return _tenNhom; }
            set { _tenNhom = value; }
        }

        public NhomDt_DTO(string manhom, string tennhom)
        {
            MaNhom = manhom;
            TenNhom = tennhom;
        }

        public NhomDt_DTO()
        { }
    }
    public class NhanVien_DTO
    {
        private String _maNv;

        public String MaNv
        {
            get { return _maNv; }
            set { _maNv = value; }
        }
        private String _tenNv;

        public String TenNv
        {
            get { return _tenNv; }
            set { _tenNv = value; }
        }
        private String _diaChi;

        public String DiaChi
        {
            get { return _diaChi; }
            set { _diaChi = value; }
        }
        private String _dienThoai;

        public String DienThoai
        {
            get { return _dienThoai; }
            set { _dienThoai = value; }
        }
        private String _email;

        public String Email
        {
            get { return _email; }
            set { _email = value; }
        }
        private String _maPb;

        public String MaPb
        {
            get { return _maPb; }
            set { _maPb = value; }
        }
        private String _chucVu;

        public String ChucVu
        {
            get { return _chucVu; }
            set { _chucVu = value; }
        }

        public NhanVien_DTO(string manv, string tennv, string diachi, string dienthoai, string email, string mapb, string chucvu)
        {
            MaNv = manv;
            TenNv = tennv;
            DiaChi = diachi;
            DienThoai = dienthoai;
            Email = email;
            MaPb = mapb;
            ChucVu = chucvu;
        }

        public NhanVien_DTO()
        { }

    }
    public class NganHang_DTO
    {
        private String _maNh;

        public String MaNh
        {
            get { return _maNh; }
            set { _maNh = value; }
        }
        private String _tenNh;

        public String TenNh
        {
            get { return _tenNh; }
            set { _tenNh = value; }
        }

        public NganHang_DTO(string manh, string tennh)
        {
            MaNh = manh;
            TenNh = tennh;
        }

        public NganHang_DTO()
        { }
               
    }
    public class PhongBan_DTO
    {
        private String _maPb;

        public String MaPb
        {
            get { return _maPb; }
            set { _maPb = value; }
        }
        private String _tenPb;

        public String TenPb
        {
            get { return _tenPb; }
            set { _tenPb = value; }
        }
        private String _dienThoai;

        public String DienThoai
        {
            get { return _dienThoai; }
            set { _dienThoai = value; }
        }
        private String _fax;

        public String Fax
        {
            get { return _fax; }
            set { _fax = value; }
        }

        public PhongBan_DTO(string mapb, string tenpb, string dienthoai, string fax)
        {
            MaPb = mapb;
            TenPb = tenpb;
            DienThoai = dienthoai;
            Fax = fax;
        }

        public PhongBan_DTO()
        { }
    }
    public class TienTe_DTO
    {
        private String _maTien;

        public String MaTien
        {
            get { return _maTien; }
            set { _maTien = value; }
        }
        private String _tenTien;

        public String TenTien
        {
            get { return _tenTien; }
            set { _tenTien = value; }
        }
        public TienTe_DTO(string matien, string tentien)
        {
            MaTien = matien;
            TenTien = tentien;
        }
        public TienTe_DTO()
        { }
    }
    public class TaiKhoanNganHang_DTO
    {
        private String _soTknh;

        public String SoTknh
        {
            get { return _soTknh; }
            set { _soTknh = value; }
        }
        private String _tenTknh;

        public String TenTknh
        {
            get { return _tenTknh; }
            set { _tenTknh = value; }
        }
        private String _maNh;

        public String MaNh
        {
            get { return _maNh; }
            set { _maNh = value; }
        }

        private String _chiNhanh;

        public String ChiNhanh
        {
            get { return _chiNhanh; }
            set { _chiNhanh = value; }
        }

        public TaiKhoanNganHang_DTO(string sotknh, string tentknh, string manh, string chinhanh)
        {
            SoTknh = sotknh;
            TenTknh = tentknh;
            MaNh = manh;
            ChiNhanh = chinhanh;
        }

        public TaiKhoanNganHang_DTO()
        { }
    }
    public class TaiKhoan_DTO
    {
        private String _maTk;
        public String MaTk
        {
            get { return _maTk; }
            set { _maTk = value; }
        }

        private String _tenTk;
        public String TenTk
        {
            get { return _tenTk; }
            set { _tenTk = value; }
        }

        private Int32 _capTk;
        public Int32 CapTk
        {
            get { return _capTk; }
            set { _capTk = value; }
        }

        private String _loaiTk;
        public String LoaiTk
        {
            get { return _loaiTk; }
            set { _loaiTk = value; }
        }

        private String _tkCha;
        public String TkCha
        {
            get { return _tkCha; }
            set { _tkCha = value; }
        }

        private Decimal _duNoDk;
        public Decimal DuNoDk
        {
            get { return _duNoDk; }
            set { _duNoDk = value; }
        }

        private Decimal _duCoDk;
        public Decimal DuCoDk
        {
            get { return _duCoDk; }
            set { _duCoDk = value; }
        }

        private Decimal _duNoNt;
        public Decimal DuNoNt
        {
            get { return _duNoNt; }
            set { _duNoNt = value; }
        }

        private Decimal _duCoNt;
        public Decimal DuCoNt
        {
            get { return _duCoNt; }
            set { _duCoNt = value; }
        }

        private String _maNt;
        public String MaNt
        {
            get { return _maNt; }
            set { _maNt = value; }
        }

        public TaiKhoan_DTO(string matk, string tentk, string loaitk, int captk,string tkcha , string matien,decimal dunodk, decimal ducodk, decimal dunont, decimal ducont)
        {
            MaTk = matk;
            TenTk = tentk;
            LoaiTk = loaitk;
            CapTk = captk;
            TkCha = tkcha;
            MaNt = matien;
            DuNoDk = dunodk;
            DuNoDk = ducodk;
            DuNoNt = dunont;
            DuCoNt = ducont;
        }

        public TaiKhoan_DTO()
        { }
    }
    public class LuaChon_DTO
    {
        private String _luaChon;

        public String LuaChon
        {
            get { return _luaChon; }
            set { _luaChon = value; }
        }

        public LuaChon_DTO(string lt)
        {
            LuaChon = lt;
        }
        public LuaChon_DTO()
        { 
        }
    }
}
