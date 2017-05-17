using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
    public class ChungTu_DTO
    {
       
        private String _soCt;

        public String SoCt
        {
            get { return _soCt; }
            set { _soCt = value; }
        }
        private Int32 _maLoaiCt;

        public Int32 MaLoaiCt
        {
            get { return _maLoaiCt; }
            set { _maLoaiCt = value; }
        }

     
        private DateTime _ngayCt;

        public DateTime NgayCt
        {
            get { return _ngayCt; }
            set { _ngayCt = value; }
        }
        private DateTime _ngayGhiSo;

        public DateTime NgayGhiSo
        {
            get { return _ngayGhiSo; }
            set { _ngayGhiSo = value; }
        }
        private String _maDt;

        public String MaDt
        {
            get { return _maDt; }
            set { _maDt = value; }
        }
        private String _nguoiGd;

        public String NguoiGd
        {
            get { return _nguoiGd; }
            set { _nguoiGd = value; }
        }
        private String _diaChi;

        public String DiaChi
        {
            get { return _diaChi; }
            set { _diaChi = value; }
        }
        private String _lyDo;

        public String LyDo
        {
            get { return _lyDo; }
            set { _lyDo = value; }
        }

        private String _kemTheo;

        public String KemTheo
        {
            get { return _kemTheo; }
            set { _kemTheo = value; }
        }
        private String _maTien;

        public String MaTien
        {
            get { return _maTien; }
            set { _maTien = value; }
        }
        private float _tyGia;

        public float TyGia
        {
            get { return _tyGia; }
            set { _tyGia = value; }
        }
        private String _tknhDi;

        public String TknhDi
        {
            get { return _tknhDi; }
            set { _tknhDi = value; }
        }
        private String _tknhDen;

        public String TknhDen
        {
            get { return _tknhDen; }
            set { _tknhDen = value; }
        }
        private Boolean _trangThai;

        public Boolean TrangThai
        {
            get { return _trangThai; }
            set { _trangThai = value; }
        }


        public ChungTu_DTO()
        { }

        public ChungTu_DTO(string soct, int loaict, DateTime ngayct, DateTime ngayghiso, string madt, string nguoigd, string diachi, string lydo, string kemtheo, string matien, float tygia, string tknhdi, string tknhden, bool trangthai)
        {
            SoCt = soct;
            MaLoaiCt = loaict;
            NgayCt = ngayct;
            NgayGhiSo = ngayghiso;
            MaDt = madt;
            NguoiGd = nguoigd;
            DiaChi = diachi;
            LyDo = lydo;
            KemTheo = kemtheo;
            MaTien = matien;
            TyGia = tygia;
            TknhDi = tknhdi;
            TknhDen = tknhden;
            TrangThai = trangthai;
        
        }


    }

    public class ChiTietCT_DTO
    {
        private Int32 _id;
        public Int32 Id
        {
            get { return _id; }
            set { _id = value; }
        }

        private String _soCt;
        public String SoCt
        {
            get { return _soCt; }
            set { _soCt = value; }
        }

        private String _tkNo;
        public String TkNo
        {
            get { return _tkNo; }
            set { _tkNo = value; }
        }

        private String _tkCo;
        public String TkCo
        {
            get { return _tkCo; }
            set { _tkCo = value; }
        }

        private String _noiDung;
        public String NoiDung
        {
            get { return _noiDung; }
            set { _noiDung = value; }
        }

        private Decimal _soTien;
        public Decimal SoTien
        {
            get { return _soTien; }
            set { _soTien = value; }
        }

        private Decimal _soTienNT;

        public Decimal SoTienNT
        {
            get { return _soTienNT; }
            set { _soTienNT = value; }
        }

        public ChiTietCT_DTO()
        { }

        public ChiTietCT_DTO(string soct, string tkno, string tkco, string noidung, Decimal sotiennt, decimal sotien)
        {
            SoCt = soct;
            TkNo = tkno;
            TkCo = tkco;
            NoiDung = noidung;
            SoTienNT = sotiennt;
            SoTien = sotien;
        }

             
    }
}
