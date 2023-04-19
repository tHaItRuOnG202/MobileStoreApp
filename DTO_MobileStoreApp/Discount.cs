using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_MobileStoreApp
{
    public class Discount
    {
        private int maGiamGia;
        private string giaTri;
        private DateTime ngayBatDau;
        private DateTime ngayKetThuc;

        public int MaGiamGia
        {
            get { return maGiamGia; }
            set { maGiamGia = value; }
        }

        public string GiaTri
        {
            get { return giaTri; }
            set { giaTri = value; }
        }

        public DateTime NgayBatDau
        {
            get { return ngayBatDau; }
            set { ngayBatDau = value; }
        }

        public DateTime NgayKetThuc
        {
            get { return ngayKetThuc; }
            set { ngayKetThuc = value; }
        }

        public Discount()
        {
        }

        public Discount(int maGiamGia, string giaTri, DateTime ngayBatDau, DateTime ngayKetThuc)
        {
            this.maGiamGia = maGiamGia;
            this.giaTri = giaTri;
            this.ngayBatDau = ngayBatDau;
            this.ngayKetThuc = ngayKetThuc;
        }
    }
}