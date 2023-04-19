using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_MobileStoreApp
{
    public class Customer
    {
        private int maKH;
        private string tenKH;
        private DateTime ngaySinhKH;
        private string diaChiKH;
        private string dienThoaiKH;
        private string emailKH;
        //private string taiKhoanKH;
        //private string matKhauKH;

        public int MaKH
        {
            get { return maKH; }
            set { maKH = value; }
        }

        public string TenKH
        {
            get { return tenKH; }
            set { tenKH = value; }
        }

        public DateTime NgaySinhKH
        {
            get { return ngaySinhKH; }
            set { ngaySinhKH = value; }
        }

        public string DiaChiKH
        {
            get { return diaChiKH; }
            set { diaChiKH = value; }
        }

        public string DienThoaiKH
        {
            get { return dienThoaiKH; }
            set { dienThoaiKH = value; }
        }

        public string EmailKH
        {
            get { return emailKH; }
            set { emailKH = value; }
        }

        //public string TaiKhoanKH
        //{
        //    get { return taiKhoanKH; }
        //    set { taiKhoanKH = value; }
        //}

        //public string MatKhauKH
        //{
        //    get { return matKhauKH; }
        //    set { matKhauKH = value; }
        //}

        public Customer()
        {
        }

        public Customer(int maKH, string tenKH, DateTime ngaySinhKH, string diaChiKH, string dienThoaiKH, string emailKH)
        {
            this.maKH = maKH;
            this.tenKH = tenKH;
            this.ngaySinhKH = ngaySinhKH;
            this.diaChiKH = diaChiKH;
            this.dienThoaiKH = dienThoaiKH;
            this.emailKH = emailKH;
            //this.taiKhoanKH = taiKhoanKH;
            //this.matKhauKH = matKhauKH;
        }
    }
}
