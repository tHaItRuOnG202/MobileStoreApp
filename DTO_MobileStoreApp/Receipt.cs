using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_MobileStoreApp
{
    public class Receipt
    {
        private int maHoaDon;
        private DateTime ngayXuat;
        private string tongTien;
        private string maNhanVien;
        private string maKhachHang;

        public int MaHoaDon
        {
            get { return maHoaDon; }
            set { maHoaDon = value; }
        }

        public DateTime NgayXuat
        {
            get { return ngayXuat; }
            set { ngayXuat = value; }
        }

        public string TongTien
        {
            get { return tongTien; }
            set { tongTien = value; }
        }

        public string MaNhanVien
        {
            get { return maNhanVien; }
            set { maNhanVien = value; }
        }

        public string MaKhachHang
        {
            get { return maKhachHang; }
            set { maKhachHang = value; }
        }

        public Receipt()
        {
        }

        public Receipt(int maHoaDon, DateTime ngayXuat, string tongTien, string maNhanVien, string maKhachHang)
        {
            this.maHoaDon = maHoaDon;
            this.ngayXuat = ngayXuat;
            this.tongTien = tongTien;
            this.maNhanVien = maNhanVien;
            this.maKhachHang = maKhachHang;
        }
    }
}
