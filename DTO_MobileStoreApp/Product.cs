using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_MobileStoreApp
{
    public class Product
    {
        private int maSP;
        private string tenSP;
        private string donVi;
        private string donGia;
        private string hinhSanPham;
        private int maLoaiSP;
        private int maGiamGia;

        public int MaSP
        {
            get { return maSP; }
            set { maSP = value; }
        }

        public string TenSP
        {
            get { return tenSP; }
            set { tenSP = value; }
        }

        public string DonVi
        {
            get { return donVi; }
            set { donVi = value; }
        }

        public string DonGia
        {
            get { return donGia; }
            set { donGia = value; }
        }

        public string HinhSanPham
        {
            get { return hinhSanPham; }
            set { hinhSanPham = value; }
        }

        public int MaLoaiSP
        {
            get { return maLoaiSP; }
            set { maLoaiSP = value; }
        }

        public int MaGiamGia
        {
            get { return maGiamGia; }
            set { maGiamGia = value; }
        }

        public Product()
        {
        }

        public Product(int maSP, string tenSP, string donVi, string donGia, string hinhSanPham, int maLoaiSP, int maGiamGia)
        {
            this.maSP = maSP;
            this.tenSP = tenSP;
            this.donVi = donVi;
            this.donGia = donGia;
            this.hinhSanPham = hinhSanPham;
            this.maLoaiSP = maLoaiSP;
            this.maGiamGia = maGiamGia;
        }
    }
}
