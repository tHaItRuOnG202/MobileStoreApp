using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_MobileStoreApp
{
    public class Employee
    {
        private int maNV;
        private string hoNV;
        private string tenNV;
        private DateTime ngaySinhNV;
        private string diaChiNV;
        private string dienThoaiNV;
        private string taiKhoanNV;
        private string matKhauNV;
        private bool loaiNhanVien;

        public int MaNV
        {
            get { return maNV; }
            set { maNV = value; }
        }
        public string HoNV
        {
            get { return hoNV; }
            set { hoNV = value; }
        }

        public string TenNV
        {
            get { return tenNV; }
            set { tenNV = value; }
        }

        public DateTime NgaySinhNV
        {
            get { return ngaySinhNV; }
            set { ngaySinhNV = value; }
        }

        public string DiaChiNV
        {
            get { return diaChiNV; }
            set { diaChiNV = value; }
        }

        public string DienThoaiNV
        {
            get { return dienThoaiNV; }
            set { dienThoaiNV = value; }
        }

        public string TaiKhoanNV
        {
            get { return taiKhoanNV; }
            set { taiKhoanNV = value; }
        }

        public string MatKhauNV
        {
            get { return matKhauNV; }
            set { matKhauNV = value; }
        }

        public bool LoaiNhanVien
        {
            get { return loaiNhanVien; }
            set { loaiNhanVien = value; }
        }

        public Employee()
        {
        }

        public Employee(int maNV, string hoNV, string tenNV, DateTime ngaySinhNV, string diaChiNV, string dienThoaiNV, string taiKhoanNV, string matKhauNV, bool loaiNhanVien)
        {
            this.maNV = maNV;
            this.hoNV = hoNV;
            this.tenNV = tenNV;
            this.ngaySinhNV = ngaySinhNV;
            this.diaChiNV = diaChiNV;
            this.dienThoaiNV = dienThoaiNV;
            this.taiKhoanNV = taiKhoanNV;
            this.matKhauNV = matKhauNV;
            this.loaiNhanVien = loaiNhanVien;
        }
    }
}
