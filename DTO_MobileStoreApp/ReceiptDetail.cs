using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_MobileStoreApp
{
    public class ReceiptDetail
    {
        private int maHD;
        private int maSP;
        private int soLuong;
        private string donGia;

        public int MaHD
        {
            get { return maHD; }
            set { maHD = value; }
        }

        public int MaSP
        {
            get { return maSP; }
            set { maSP = value; }
        }

        public int SoLuong
        {
            get { return soLuong; }
            set { soLuong = value; }
        }

        public string DonGia
        {
            get { return donGia; }
            set { donGia = value; }
        }

        public ReceiptDetail()
        {
        }

        public ReceiptDetail(int maHD, int maSP, int soLuong, string donGia)
        {
            this.maHD = maHD;
            this.maSP = maSP;
            this.soLuong = soLuong;
            this.donGia = donGia;
        }
    }
}
