using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_MobileStoreApp;

namespace DAO_MoblieStoreApp
{
    public class DAO_Controller
    {
        IMPROOKSTOREDataContext db = new IMPROOKSTOREDataContext();
        DAO_Connection dc = new DAO_Connection();

        //Chức năng quản lý nhân viên
        public DataTable LoadEmployee()
        {
            SqlDataAdapter da;
            DataTable dt = new DataTable();
            string query = "Select * From NhanVien";
            da = new SqlDataAdapter(query, dc.Connect());
            da.Fill(dt);
            return dt;
        }

        //public void InsertEmployee(Employee empl)
        //{
        //    NhanVien nhanVien = new NhanVien();
        //    nhanVien.IDNhanVien = empl.MaNV;
        //    nhanVien.HoNhanVien = empl.HoNV;
        //    nhanVien.TenNhanVien = empl.TenNV;
        //    nhanVien.NgaySinhNhanVien = empl.NgaySinhNV;
        //    nhanVien.DiaChiNhanVien = empl.DiaChiNV;
        //    nhanVien.DienThoaiNhanVien = empl.DienThoaiNV;
        //    nhanVien.TaiKhoanNhanVien = empl.TaiKhoanNV;
        //    nhanVien.MatKhauNhanVien = empl.MatKhauNV;
        //    nhanVien.LoaiNhanVien = empl.LoaiNhanVien;

        //    db = new IMPROOKSTOREDataContext();
        //    db.NhanViens.InsertOnSubmit(nhanVien);

        //    db.SubmitChanges();
        //}

        public bool InsertEmployee(Employee empl)
        {
            try
            {
                NhanVien nhanVien = new NhanVien();
                nhanVien.IDNhanVien = empl.MaNV;
                nhanVien.HoNhanVien = empl.HoNV;
                nhanVien.TenNhanVien = empl.TenNV;
                nhanVien.NgaySinhNhanVien = empl.NgaySinhNV;
                nhanVien.DiaChiNhanVien = empl.DiaChiNV;
                nhanVien.DienThoaiNhanVien = empl.DienThoaiNV;
                nhanVien.TaiKhoanNhanVien = empl.TaiKhoanNV;
                nhanVien.MatKhauNhanVien = empl.MatKhauNV;
                nhanVien.LoaiNhanVien = empl.LoaiNhanVien;

                db = new IMPROOKSTOREDataContext();
                db.NhanViens.InsertOnSubmit(nhanVien);

                db.SubmitChanges();
                return true;
            }
            catch (SqlException)
            {
                return false;
            }
        }

        //public void DeleteEmployee(Employee empl)
        //{
        //    NhanVien nhanVien = new NhanVien();
        //    nhanVien.IDNhanVien = empl.MaNV;
        //    nhanVien.HoNhanVien = empl.HoNV;
        //    nhanVien.TenNhanVien = empl.TenNV;
        //    nhanVien.NgaySinhNhanVien = empl.NgaySinhNV;
        //    nhanVien.DiaChiNhanVien = empl.DiaChiNV;
        //    nhanVien.DienThoaiNhanVien = empl.DienThoaiNV;
        //    nhanVien.TaiKhoanNhanVien = empl.TaiKhoanNV;
        //    nhanVien.MatKhauNhanVien = empl.MatKhauNV;
        //    nhanVien.LoaiNhanVien = empl.LoaiNhanVien;

        //    db = new IMPROOKSTOREDataContext();
        //    db.NhanViens.Attach(nhanVien);
        //    db.NhanViens.DeleteOnSubmit(nhanVien);
        //    db.SubmitChanges();
        //}

        public bool DeleteEmployee(int IDEmpl)
        {
            try
            {
                //NhanVien nhanVien = new NhanVien();
                //nhanVien.IDNhanVien = empl.MaNV;
                //nhanVien.HoNhanVien = empl.HoNV;
                //nhanVien.TenNhanVien = empl.TenNV;
                //nhanVien.NgaySinhNhanVien = empl.NgaySinhNV;
                //nhanVien.DiaChiNhanVien = empl.DiaChiNV;
                //nhanVien.DienThoaiNhanVien = empl.DienThoaiNV;
                //nhanVien.TaiKhoanNhanVien = empl.TaiKhoanNV;
                //nhanVien.MatKhauNhanVien = empl.MatKhauNV;
                //nhanVien.LoaiNhanVien = empl.LoaiNhanVien;

                //db = new IMPROOKSTOREDataContext();
                //db.NhanViens.Attach(nhanVien);
                //db.NhanViens.DeleteOnSubmit(nhanVien);
                //db.SubmitChanges();

                //return true;

                db = new IMPROOKSTOREDataContext();
                NhanVien nhanVien = db.NhanViens.FirstOrDefault(p => p.IDNhanVien == IDEmpl);

                db.NhanViens.DeleteOnSubmit(nhanVien);
                db.SubmitChanges();

                return true;
                
            }
            catch (SqlException)
            {
                return false;
            }
        }

        //public void UpdateEmployee(Employee empl)
        //{
        //    db = new IMPROOKSTOREDataContext();
        //    var update = db.NhanViens.SingleOrDefault(id => id.IDNhanVien == empl.MaNV);
        //    update.IDNhanVien = empl.MaNV;
        //    update.HoNhanVien = empl.HoNV;
        //    update.TenNhanVien = empl.TenNV;
        //    update.NgaySinhNhanVien = empl.NgaySinhNV;
        //    update.DiaChiNhanVien = empl.DiaChiNV;
        //    update.DienThoaiNhanVien = empl.DienThoaiNV;
        //    update.TaiKhoanNhanVien = empl.TaiKhoanNV;
        //    update.MatKhauNhanVien = empl.MatKhauNV;
        //    update.LoaiNhanVien = empl.LoaiNhanVien;

        //    db.SubmitChanges();
        //}

        public bool UpdateEmployee(Employee empl)
        {
            try
            {
                db = new IMPROOKSTOREDataContext();
                var update = db.NhanViens.SingleOrDefault(id => id.IDNhanVien == empl.MaNV);
                update.IDNhanVien = empl.MaNV;
                update.HoNhanVien = empl.HoNV;
                update.TenNhanVien = empl.TenNV;
                update.NgaySinhNhanVien = empl.NgaySinhNV;
                update.DiaChiNhanVien = empl.DiaChiNV;
                update.DienThoaiNhanVien = empl.DienThoaiNV;
                update.TaiKhoanNhanVien = empl.TaiKhoanNV;
                update.MatKhauNhanVien = empl.MatKhauNV;
                update.LoaiNhanVien = empl.LoaiNhanVien;

                db.SubmitChanges();
                return true;
            }
            catch (SqlException)
            {
                return false;
            }
        }

        public bool UpdatedEmployee(NhanVien empl)
        {
            try
            {
                db = new IMPROOKSTOREDataContext();
                var update = db.NhanViens.SingleOrDefault(id => id.IDNhanVien == empl.IDNhanVien);
                update.IDNhanVien = empl.IDNhanVien;
                update.HoNhanVien = empl.HoNhanVien;
                update.TenNhanVien = empl.TenNhanVien;
                update.NgaySinhNhanVien = empl.NgaySinhNhanVien;
                update.DiaChiNhanVien = empl.DiaChiNhanVien;
                update.DienThoaiNhanVien = empl.DienThoaiNhanVien;
                update.TaiKhoanNhanVien = empl.TaiKhoanNhanVien;
                update.MatKhauNhanVien = empl.MatKhauNhanVien;
                update.LoaiNhanVien = empl.LoaiNhanVien;

                db.SubmitChanges();
                return true;
            }
            catch (SqlException)
            {
                return false;
            }
        }

        public DataTable SearchEmployee(string kw)
        {
            SqlDataAdapter da;
            DataTable dt = new DataTable();
            string query = "Select * From NhanVien Where TenNhanVien like N'" + kw + "%' ";
            da = new SqlDataAdapter(query, dc.Connect());
            da.Fill(dt);
            return dt;
        }

        public DataTable SearchedEmployee(string kw)
        {
            SqlDataAdapter da;
            DataTable dt = new DataTable();
            string query = "Select * From NhanVien Where TenNhanVien like N'%" + kw + "%' ";
            da = new SqlDataAdapter(query, dc.Connect());
            da.Fill(dt);
            return dt;
        }

        //Chức năng quản lý danh mục sản phẩm
        public DataTable LoadCategories()
        {
            SqlDataAdapter da;
            DataTable dt = new DataTable();
            string query = "Select * From LoaiSanPham";
            da = new SqlDataAdapter(query, dc.Connect());
            da.Fill(dt);
            return dt;
        }

        //public void InsertCategories(Categories cate)
        //{
        //    LoaiSanPham loaiSP = new LoaiSanPham();
        //    loaiSP.IDLoaiSanPham = cate.MaLoaiSP;
        //    loaiSP.TenLoaiSanPham = cate.TenLoaiSP;

        //    db = new IMPROOKSTOREDataContext();
        //    db.LoaiSanPhams.InsertOnSubmit(loaiSP);

        //    db.SubmitChanges();
        //}

        public bool InsertCategories(Categories cate)
        {
            try
            {
                LoaiSanPham loaiSP = new LoaiSanPham();
                loaiSP.IDLoaiSanPham = cate.MaLoaiSP;
                loaiSP.TenLoaiSanPham = cate.TenLoaiSP;

                db = new IMPROOKSTOREDataContext();
                db.LoaiSanPhams.InsertOnSubmit(loaiSP);

                db.SubmitChanges();

                return true;
            }
            catch (SqlException)
            {
                return false;
            }
        }

        //public void DeleteCategories(Categories cate)
        //{
        //    LoaiSanPham loaiSP = new LoaiSanPham();
        //    loaiSP.IDLoaiSanPham = cate.MaLoaiSP;
        //    loaiSP.TenLoaiSanPham = cate.TenLoaiSP;

        //    db = new IMPROOKSTOREDataContext();
        //    db.LoaiSanPhams.Attach(loaiSP);
        //    db.LoaiSanPhams.DeleteOnSubmit(loaiSP);
        //    db.SubmitChanges();
        //}

        //public bool DeleteCategories(Categories cate)
        //{
        //    try
        //    {
        //        LoaiSanPham loaiSP = new LoaiSanPham();
        //        loaiSP.IDLoaiSanPham = cate.MaLoaiSP;
        //        loaiSP.TenLoaiSanPham = cate.TenLoaiSP;

        //        db = new IMPROOKSTOREDataContext();
        //        db.LoaiSanPhams.Attach(loaiSP);
        //        db.LoaiSanPhams.DeleteOnSubmit(loaiSP);
        //        db.SubmitChanges();

        //        return true;
        //    }
        //    catch (SqlException)
        //    {
        //        return false;
        //    }
        //}

        public bool DeleteCategories(int IDCate)
        {
            try
            {
                db = new IMPROOKSTOREDataContext();
                LoaiSanPham loaiSanPham = db.LoaiSanPhams.FirstOrDefault(p => p.IDLoaiSanPham == IDCate);

                db.LoaiSanPhams.DeleteOnSubmit(loaiSanPham);
                db.SubmitChanges();

                return true;
            }
            catch (SqlException)
            {
                return false;
            }
        }

        //public void UpdateCategories(Categories cate)
        //{
        //    db = new IMPROOKSTOREDataContext();
        //    var update = db.LoaiSanPhams.SingleOrDefault(id => id.IDLoaiSanPham == cate.MaLoaiSP);
        //    update.IDLoaiSanPham = cate.MaLoaiSP;
        //    update.TenLoaiSanPham = cate.TenLoaiSP;

        //    db.SubmitChanges();
        //}

        public bool UpdateCategories(Categories cate)
        {
            try
            {
                db = new IMPROOKSTOREDataContext();
                var update = db.LoaiSanPhams.SingleOrDefault(id => id.IDLoaiSanPham == cate.MaLoaiSP);
                update.IDLoaiSanPham = cate.MaLoaiSP;
                update.TenLoaiSanPham = cate.TenLoaiSP;

                db.SubmitChanges();

                return true;
            }
            catch (SqlException)
            {
                return false;
            }
        }

        public DataTable SearchCategories(string kw)
        {
            SqlDataAdapter da;
            DataTable dt = new DataTable();
            string query = "Select * From LoaiSanPham Where TenLoaiSanPham like N'" + kw + "%' ";
            da = new SqlDataAdapter(query, dc.Connect());
            da.Fill(dt);
            return dt;
        }

        public DataTable SearchedCategories(string kw)
        {
            SqlDataAdapter da;
            DataTable dt = new DataTable();
            string query = "Select * From LoaiSanPham Where TenLoaiSanPham like N'%" + kw + "%' ";
            da = new SqlDataAdapter(query, dc.Connect());
            da.Fill(dt);
            return dt;
        }

        //Chức năng quản lý khách hàng
        public DataTable LoadCustomer()
        {
            SqlDataAdapter da;
            DataTable dt = new DataTable();
            string query = "Select * From KhachHang";
            da = new SqlDataAdapter(query, dc.Connect());
            da.Fill(dt);
            return dt;
        }

        //public void InsertCustomer(Customer cust)
        //{
        //    KhachHang khachHang = new KhachHang();
        //    khachHang.IDKhachHang = cust.MaKH;
        //    khachHang.TenKhachHang = cust.TenKH;
        //    khachHang.NgaySinhKhachHang = cust.NgaySinhKH;
        //    khachHang.DiaChiKhachHang = cust.DiaChiKH;
        //    khachHang.DienThoaiKhachHang = cust.DienThoaiKH;
        //    khachHang.EmailKhachHang = cust.EmailKH;
        //    khachHang.TaiKhoanKhachHang = cust.TaiKhoanKH;
        //    khachHang.MatKhauKhachHang = cust.MatKhauKH;

        //    db = new IMPROOKSTOREDataContext();
        //    db.KhachHangs.InsertOnSubmit(khachHang);

        //    db.SubmitChanges();
        //}

        public bool InsertCustomer(Customer cust)
        {
            try
            {
                KhachHang khachHang = new KhachHang();
                khachHang.IDKhachHang = cust.MaKH;
                khachHang.TenKhachHang = cust.TenKH;
                khachHang.NgaySinhKhachHang = cust.NgaySinhKH;
                khachHang.DiaChiKhachHang = cust.DiaChiKH;
                khachHang.DienThoaiKhachHang = cust.DienThoaiKH;
                khachHang.EmailKhachHang = cust.EmailKH;
                //khachHang.TaiKhoanKhachHang = cust.TaiKhoanKH;
                //khachHang.MatKhauKhachHang = cust.MatKhauKH;

                db = new IMPROOKSTOREDataContext();
                db.KhachHangs.InsertOnSubmit(khachHang);

                db.SubmitChanges();

                return true;
            }
            catch (SqlException)
            {
                return false;
            }
        }

        //public void DeleteCustomers(Customer cust)
        //{
        //    KhachHang khachHang = new KhachHang();
        //    khachHang.IDKhachHang = cust.MaKH;
        //    khachHang.TenKhachHang = cust.TenKH;
        //    khachHang.NgaySinhKhachHang = cust.NgaySinhKH;
        //    khachHang.DiaChiKhachHang = cust.DiaChiKH;
        //    khachHang.DienThoaiKhachHang = cust.DienThoaiKH;
        //    khachHang.EmailKhachHang = cust.EmailKH;
        //    khachHang.TaiKhoanKhachHang = cust.TaiKhoanKH;
        //    khachHang.MatKhauKhachHang = cust.MatKhauKH;

        //    db = new IMPROOKSTOREDataContext();
        //    db.KhachHangs.Attach(khachHang);
        //    db.KhachHangs.DeleteOnSubmit(khachHang);
        //    db.SubmitChanges();
        //}

        //public bool DeleteCustomer(Customer cust)
        //{
        //    try
        //    {
        //        KhachHang khachHang = new KhachHang();
        //        khachHang.IDKhachHang = cust.MaKH;
        //        khachHang.TenKhachHang = cust.TenKH;
        //        khachHang.NgaySinhKhachHang = cust.NgaySinhKH;
        //        khachHang.DiaChiKhachHang = cust.DiaChiKH;
        //        khachHang.DienThoaiKhachHang = cust.DienThoaiKH;
        //        khachHang.EmailKhachHang = cust.EmailKH;
        //        //khachHang.TaiKhoanKhachHang = cust.TaiKhoanKH;
        //        //khachHang.MatKhauKhachHang = cust.MatKhauKH;

        //        db = new IMPROOKSTOREDataContext();
        //        db.KhachHangs.Attach(khachHang);
        //        db.KhachHangs.DeleteOnSubmit(khachHang);
        //        db.SubmitChanges();

        //        return true;
        //    }
        //    catch (SqlException)
        //    {
        //        return false;
        //    }
        //}

        public bool DeleteCustomer(int IDCust)
        {
            try
            {
                db = new IMPROOKSTOREDataContext();
                KhachHang khachHang = db.KhachHangs.FirstOrDefault(p => p.IDKhachHang == IDCust);

                db.KhachHangs.DeleteOnSubmit(khachHang);
                db.SubmitChanges();

                return true;
            }
            catch (SqlException)
            {
                return false;
            }
        }

        //public void UpdateCustomer(Customer cust)
        //{
        //    db = new IMPROOKSTOREDataContext();
        //    var update = db.KhachHangs.SingleOrDefault(id => id.IDKhachHang == cust.MaKH);
        //    update.IDKhachHang = cust.MaKH;
        //    update.TenKhachHang = cust.TenKH;
        //    update.NgaySinhKhachHang = cust.NgaySinhKH;
        //    update.DiaChiKhachHang = cust.DiaChiKH;
        //    update.DienThoaiKhachHang = cust.DienThoaiKH;
        //    update.EmailKhachHang = cust.EmailKH;
        //    update.TaiKhoanKhachHang = cust.TaiKhoanKH;
        //    update.MatKhauKhachHang = cust.MatKhauKH;

        //    db.SubmitChanges();
        //}

        public bool UpdateCustomer(Customer cust)
        {
            try
            {
                db = new IMPROOKSTOREDataContext();
                var update = db.KhachHangs.SingleOrDefault(id => id.IDKhachHang == cust.MaKH);
                update.IDKhachHang = cust.MaKH;
                update.TenKhachHang = cust.TenKH;
                update.NgaySinhKhachHang = cust.NgaySinhKH;
                update.DiaChiKhachHang = cust.DiaChiKH;
                update.DienThoaiKhachHang = cust.DienThoaiKH;
                update.EmailKhachHang = cust.EmailKH;
                //update.TaiKhoanKhachHang = cust.TaiKhoanKH;
                //update.MatKhauKhachHang = cust.MatKhauKH;

                db.SubmitChanges();

                return true;
            }
            catch (SqlException)
            {
                return false;
            }
        }

        public DataTable SearchCustomer(string kw)
        {
            SqlDataAdapter da;
            DataTable dt = new DataTable();
            string query = "Select * From KhachHang Where TenKhachHang like N'" + kw + "%' ";
            da = new SqlDataAdapter(query, dc.Connect());
            da.Fill(dt);
            return dt;
        }

        public DataTable SearchedCustomer(string kw)
        {
            SqlDataAdapter da;
            DataTable dt = new DataTable();
            string query = "Select * From KhachHang Where TenKhachHang like N'%" + kw + "%' ";
            da = new SqlDataAdapter(query, dc.Connect());
            da.Fill(dt);
            return dt;
        }

        //Chức năng quản lý sản phẩm
        public DataTable LoadProduct()
        {
            SqlDataAdapter da;
            DataTable dt = new DataTable();
            string query = "Select sp.IDSanPham, sp.TenSanPham, sp.DonVi, sp.DonGia, ls.TenLoaiSanPham, gg.GiaTri, sp.HinhAnh From SanPham sp, LoaiSanPham ls, GiamGia gg Where sp.IDLoaiSanPham = ls.IDLoaiSanPham And gg.IDGiamGia = sp.IDGiamGia";
            da = new SqlDataAdapter(query, dc.Connect());
            da.Fill(dt);
            return dt;
        }

        public DataTable LoadProductV2()
        {
            SqlDataAdapter da;
            DataTable dt = new DataTable();
            string query = "Select * From SanPham";
            da = new SqlDataAdapter(query, dc.Connect());
            da.Fill(dt);
            return dt;
        }

        //public int[] LoadCBIDProduct()
        //{
        //    db = new IMPROOKSTOREDataContext();
        //    return db.SanPhams.;
        //}

        public bool InsertProduct(Product prod)
        {
            try
            {
                SanPham sanPham = new SanPham();
                sanPham.IDSanPham = prod.MaSP;
                sanPham.TenSanPham = prod.TenSP;
                sanPham.DonVi = prod.DonVi;
                sanPham.DonGia = prod.DonGia;
                sanPham.HinhAnh = prod.HinhSanPham;
                sanPham.IDLoaiSanPham = prod.MaLoaiSP;
                sanPham.IDGiamGia = prod.MaGiamGia;

                db = new IMPROOKSTOREDataContext();
                db.SanPhams.InsertOnSubmit(sanPham);

                db.SubmitChanges();

                return true;
            }
            catch (SqlException)
            {
                return false;
            }
        }

        //public bool DeleteProduct(Product prod)
        //{

        //    try
        //    {
        //        SanPham sanPham = new SanPham();
        //        sanPham.IDSanPham = prod.MaSP;
        //        sanPham.TenSanPham = prod.TenSP;
        //        sanPham.DonVi = prod.DonVi;
        //        sanPham.DonGia = prod.DonGia;
        //        sanPham.HinhAnh = prod.HinhSanPham;
        //        sanPham.IDLoaiSanPham = prod.MaLoaiSP;
        //        sanPham.IDGiamGia = prod.MaGiamGia;

        //        db = new IMPROOKSTOREDataContext();
        //        db.SanPhams.Attach(sanPham);
        //        db.SanPhams.DeleteOnSubmit(sanPham);

        //        db.SubmitChanges();

        //        return true;

        //        //db = new IMPROOKSTOREDataContext();

        //        // Tải lại sản phẩm từ cơ sở dữ liệu
        //        //SanPham sanPham = db.SanPhams.FirstOrDefault(p => p.IDSanPham == prod.MaSP);

        //        // Nếu sản phẩm tồn tại, thực hiện xóa
        //        //if (sanPham != null)
        //        //{
        //            //db.SanPhams.DeleteOnSubmit(sanPham);
        //            //db.SubmitChanges();

        //            //return true;
        //        //}
        //    }
        //    catch (SqlException)
        //    {
        //        return false;
        //    }
        //}

        public bool DeleteProduct(int IDProd)
        {

            try
            {
                db = new IMPROOKSTOREDataContext();
                SanPham sanPham = db.SanPhams.FirstOrDefault(p => p.IDSanPham == IDProd);

                db.SanPhams.DeleteOnSubmit(sanPham);
                db.SubmitChanges();

                return true;
            }
            catch (SqlException)
            {
                return false;
            }
        }

        public bool UpdateProduct(Product prod)
        {
            try
            {
                db = new IMPROOKSTOREDataContext();
                var update = db.SanPhams.SingleOrDefault(id => id.IDSanPham == prod.MaSP);
                update.IDSanPham = prod.MaSP;
                update.TenSanPham = prod.TenSP;
                update.DonVi = prod.DonVi;
                update.DonGia = prod.DonGia;
                update.HinhAnh = prod.HinhSanPham;
                update.IDLoaiSanPham = prod.MaLoaiSP;
                update.IDGiamGia = prod.MaGiamGia;

                db.SubmitChanges();

                return true;
            }
            catch (SqlException)
            {
                return false;
            }
        }

        public bool UpdatedProduct(SanPham sanpham)
        {
            try
            {
                db = new IMPROOKSTOREDataContext();
                var update = db.SanPhams.SingleOrDefault(id => id.IDSanPham == sanpham.IDSanPham);
                update.IDSanPham = sanpham.IDSanPham;
                update.TenSanPham = sanpham.TenSanPham;
                update.DonVi = sanpham.DonVi;
                update.DonGia = sanpham.DonGia;
                update.HinhAnh = sanpham.HinhAnh;
                update.IDLoaiSanPham = sanpham.IDLoaiSanPham;
                update.IDGiamGia = sanpham.IDGiamGia;

                db.SubmitChanges();

                return true;
            }
            catch (SqlException)
            {
                return false;
            }
        }

        public DataTable SearchProduct(string kw)
        {
            SqlDataAdapter da;
            DataTable dt = new DataTable();
            string query = "Select * From SanPham Where TenSanPham like N'" + kw + "%' ";
            da = new SqlDataAdapter(query, dc.Connect());
            da.Fill(dt);
            return dt;
        }

        public DataTable SearchedProduct(string kw)
        {
            SqlDataAdapter da;
            DataTable dt = new DataTable();
            string query = "Select * From SanPham Where TenSanPham like N'%" + kw + "%' ";
            da = new SqlDataAdapter(query, dc.Connect());
            da.Fill(dt);
            return dt;
        }


        //Chức năng quản lý giảm giá
        public DataTable LoadDiscount()
        {
            SqlDataAdapter da;
            DataTable dt = new DataTable();
            string query = "Select * From GiamGia";
            da = new SqlDataAdapter(query, dc.Connect());
            da.Fill(dt);
            return dt;
        }

        public bool InsertDiscount(Discount disc)
        {
            try
            {
                GiamGia giamGia = new GiamGia();
                giamGia.IDGiamGia = disc.MaGiamGia;
                giamGia.GiaTri = disc.GiaTri;
                giamGia.ThoiGianBatDau = disc.NgayBatDau;
                giamGia.ThoiGianKetThuc = disc.NgayKetThuc;
                //khachHang.TaiKhoanKhachHang = cust.TaiKhoanKH;
                //khachHang.MatKhauKhachHang = cust.MatKhauKH;

                db = new IMPROOKSTOREDataContext();
                db.GiamGias.InsertOnSubmit(giamGia);

                db.SubmitChanges();

                return true;
            }
            catch (SqlException)
            {
                return false;
            }
        }

        public bool DeleteDiscount(int IDDisc)
        {

            try
            {
                db = new IMPROOKSTOREDataContext();
                GiamGia giamGia = db.GiamGias.FirstOrDefault(p => p.IDGiamGia == IDDisc);

                db.GiamGias.DeleteOnSubmit(giamGia);
                db.SubmitChanges();

                return true;
            }
            catch (SqlException)
            {
                return false;
            }
        }

        public bool UpdateDiscount(Discount disc)
        {
            try
            {
                db = new IMPROOKSTOREDataContext();
                var update = db.GiamGias.SingleOrDefault(id => id.IDGiamGia == disc.MaGiamGia);
                update.IDGiamGia = disc.MaGiamGia;
                update.GiaTri = disc.GiaTri;
                update.ThoiGianBatDau = disc.NgayBatDau;
                update.ThoiGianKetThuc = disc.NgayKetThuc;
                //update.TaiKhoanKhachHang = cust.TaiKhoanKH;
                //update.MatKhauKhachHang = cust.MatKhauKH;

                db.SubmitChanges();

                return true;
            }
            catch (SqlException)
            {
                return false;
            }
        }

        public bool UpdatedDiscount(GiamGia disc)
        {
            try
            {
                db = new IMPROOKSTOREDataContext();
                var update = db.GiamGias.SingleOrDefault(id => id.IDGiamGia == disc.IDGiamGia);
                update.IDGiamGia = disc.IDGiamGia;
                update.GiaTri = disc.GiaTri;
                update.ThoiGianBatDau = disc.ThoiGianBatDau;
                update.ThoiGianKetThuc = disc.ThoiGianKetThuc;
   
                db.SubmitChanges();
                return true;
            }
            catch (SqlException)
            {
                return false;
            }
        }

        public DataTable SearchDiscount(string kw)
        {
            SqlDataAdapter da;
            DataTable dt = new DataTable();
            string query = "Select * From GiamGia Where GiaTri like N'" + kw + "%' ";
            da = new SqlDataAdapter(query, dc.Connect());
            da.Fill(dt);
            return dt;
        }

        public DataTable SearchedDiscount(string kw)
        {
            SqlDataAdapter da;
            DataTable dt = new DataTable();
            string query = "Select * From GiamGia Where GiaTri like N'%" + kw + "%' ";
            da = new SqlDataAdapter(query, dc.Connect());
            da.Fill(dt);
            return dt;
        }

        //Thanh toán hóa đơn
        public void InsertReceipt(int idRec, DateTime dateSale, string totalPrice, int idEmpl, int idCust)
        {
            string query = string.Format("INSERT INTO HoaDon(IDHoaDon, NgayXuatHoaDon, TongTien, IDNhanVien, IDKhachHang) VALUES({0}, N'{1}', N'{2}', {3}, {4})", idRec, dateSale, totalPrice, idEmpl, idCust);

            using (SqlConnection connection = dc.Connect())
            {
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
        }

        public void InsertReceiptDetail(int idRec, string idPro, int quantity, string uPrice)
        {
            string query = string.Format("INSERT INTO ChiTietHoaDon(IDHoaDon, IDSanPham, SoLuong, DonGia) VALUES({0}, {1}, N'{2}', N'{3}')", idRec, idPro, quantity, uPrice);

            using (SqlConnection connection = dc.Connect())
            {
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
        }

        public SanPham GetProductByID(int maSanPham)
        {
            db = new IMPROOKSTOREDataContext();
            return db.SanPhams.FirstOrDefault(sp => sp.IDSanPham == maSanPham);
        }

        //public DataTable GetDiscountByProduct(int maKhuyenMai)
        //{
        //    //// Lấy mã sản phẩm từ ComboBox
        //    //int txtMa;
        //    //string txtKQ;
        //    //// Tìm sản phẩm trong danh sách sản phẩm
        //    //SanPham selectedProduct = db.SanPhams.FirstOrDefault(p => p.IDSanPham == cmbMaSP);

        //    //// Nếu tìm thấy sản phẩm, hiển thị tên sản phẩm trên Textbox txtTenSP
        //    //if (selectedProduct != null)
        //    //{
        //    //    txtMa = selectedProduct.IDGiamGia;
        //    //    GiamGia selectedProduct2 = db.GiamGias.FirstOrDefault(p => p.IDGiamGia == txtMa);
        //    //    if (selectedProduct2 != null)
        //    //    {
        //    //        txtKQ = selectedProduct2.GiaTri;
        //    //        return txtKQ;
        //    //    }
        //    //}
        //    //return "Không có giảm giá!";

        //    //SqlDataAdapter da;
        //    //DataTable dt = new DataTable();
        //    //string query = String.Format("Select * From GiamGia Where IDGiamGiam = {0}", maKhuyenMai);
        //    //da = new SqlDataAdapter(query, dc.Connect());
        //    //da.Fill(dt);
        //    //return dt;


        //}

        public Discount getDiscount(int maKhuyenMai)
        {
            dc.Connect();
            
            string sqlQuery = String.Format("SELECT * FROM GiamGia Where IDGiamGia = {0}", maKhuyenMai);
            
            Discount disc = new Discount();
            using (SqlConnection connection = dc.Connect())
            {
                SqlCommand command = new SqlCommand(sqlQuery, connection);
                
                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {

                        disc.MaGiamGia = reader.GetInt32(0);
                        disc.GiaTri = reader.GetString(1);
                        disc.NgayBatDau = reader.GetDateTime(2);
                        disc.NgayKetThuc = reader.GetDateTime(3);
                    }
                }
                connection.Close();
            }
            return disc;
        }

        public KhachHang GetCustomerByID(int maKH)
        {
            db = new IMPROOKSTOREDataContext();
            return db.KhachHangs.FirstOrDefault(kh => kh.IDKhachHang == maKH);
        }

        //Chức năng quản lý hóa đơn
        public DataTable LoadReceipt()
        {
            SqlDataAdapter da;
            DataTable dt = new DataTable();
            string query = String.Format("Select * From HoaDon");

            da = new SqlDataAdapter(query, dc.Connect());
            da.Fill(dt);
            return dt;
        }

        public DataTable LoadReceiptV2()
        {
            SqlDataAdapter da;
            DataTable dt = new DataTable();
            string query = String.Format("Select hd.IDHoaDon, hd.NgayXuatHoaDon, hd.TongTien, CONCAT(nv.HoNhanVien, ' ', nv.TenNhanVien) as TenNhanVien, kh.TenKhachHang From HoaDon hd, NhanVien nv, KhachHang kh Where hd.IDNhanVien = nv.IDNhanVien And hd.IDKhachHang = kh.IDKhachHang");
            da = new SqlDataAdapter(query, dc.Connect());
            da.Fill(dt);
            return dt;
        }

        public DataTable LoadReceiptDetail(int recp)
        {
            SqlDataAdapter da;
            DataTable dt = new DataTable();
            string query = String.Format("Select sp.IDSanPham, sp.TenSanPham, cthd.SoLuong, sp.DonVi, sp.DonGia, km.GiaTri From SanPham sp, ChiTietHoaDon cthd, GiamGia km Where sp.IDSanPham = cthd.IDSanPham AND sp.IDGiamGia = km.IDGiamGia AND cthd.IDHoaDon = {0}", recp);
            da = new SqlDataAdapter(query, dc.Connect());
            da.Fill(dt);
            return dt;
        }

        public DataTable SearchReceiptCustomers(string kw)
        {
            SqlDataAdapter da;
            DataTable dt = new DataTable();
            string query = "Select hd.IDHoaDon, hd.NgayXuatHoaDon, hd.TongTien, CONCAT(nv.HoNhanVien, ' ', nv.TenNhanVien) as TenNhanVien, kh.TenKhachHang From HoaDon hd, NhanVien nv, KhachHang kh Where hd.IDNhanVien = nv.IDNhanVien And hd.IDKhachHang = kh.IDKhachHang AND TenKhachHang like N'%" + kw + "%' ";

            da = new SqlDataAdapter(query, dc.Connect());
            da.Fill(dt);
            return dt;
        }

        public DataTable LoadReceiptByIDEmployee(int IDEmpl)
        {
            SqlDataAdapter da;
            DataTable dt = new DataTable();
            string query = String.Format("Select * From HoaDon Where IDNhanVien = {0}", IDEmpl);

            da = new SqlDataAdapter(query, dc.Connect());
            da.Fill(dt);
            return dt;
        }

        public DataTable LoadProductByIDDiscount(int IDDis)
        {
            SqlDataAdapter da;
            DataTable dt = new DataTable();
            string query = String.Format("Select * From SanPham Where IDGiamGia = {0}", IDDis);

            da = new SqlDataAdapter(query, dc.Connect());
            da.Fill(dt);
            return dt;
        }

        //Chức năng thống kê
        public DataTable LoadRevenueCustomer(int month, int year)
        {
            SqlDataAdapter da;
            DataTable dt = new DataTable();
            //string query = String.Format("SELECT KhachHang.IDKhachHang, KhachHang.TenKhachHang, SUM(CAST(hd.TongTien AS FLOAT)) As TongTien " +
            //    "FROM    KhachHang, HoaDon hd" +
            //    "WHERE   KhachHang.IDKhachHang = hd.IDKhachHang AND MONTH(hd.NgayXuatHoaDon) = {0} AND YEAR(hd.NgayXuatHoaDon) = {1}" +
            //    "GROUP BY KhachHang.IDKhachHang, KhachHang.TenKhachHang" +
            //    "ORDER BY TongTien Desc",  month, year);

            string query = String.Format("SELECT kh.IDKhachHang, kh.TenKhachHang, SUM(TRY_CONVERT(FLOAT, hd.TongTien)) As TongTien" +
                " FROM	KhachHang kh, HoaDon hd" +
                " WHERE	kh.IDKhachHang = hd.IDKhachHang " +
                " AND MONTH(hd.NgayXuatHoaDon) = {0} " +
                " AND YEAR(hd.NgayXuatHoaDon) = {1} " +
                " GROUP BY kh.IDKhachHang, kh.TenKhachHang " +
                " ORDER BY SUM(CAST(hd.TongTien AS FLOAT)) DESC", month, year);

            da = new SqlDataAdapter(query, dc.Connect());
            da.Fill(dt);
            return dt;
        }

        public DataTable LoadRevenueProduct(int month, int year)
        {
            SqlDataAdapter da;
            DataTable dt = new DataTable();

            string query = String.Format("SELECT cthd.IDSanPham, sp.TenSanPham, SUM(TRY_CONVERT(FLOAT, (cthd.SoLuong))) As SoLuong, SUM(TRY_CONVERT(FLOAT, (cthd.SoLuong * sp.DonGia))) As DoanhThu " +
                " FROM SanPham sp, HoaDon hd, ChiTietHoaDon cthd " +
                " WHERE sp.IDSanPham = cthd.IDSanPham AND cthd.IDHoaDon = hd.IDHoaDon " +
                " AND MONTH(hd.NgayXuatHoaDon) = {0} " +
                " AND YEAR(hd.NgayXuatHoaDon) = {1} " +
                " GROUP BY cthd.IDSanPham, sp.TenSanPham " +
                " ORDER BY SUM(TRY_CONVERT(FLOAT, (cthd.SoLuong * sp.DonGia))) Desc", month, year);

            da = new SqlDataAdapter(query, dc.Connect());
            da.Fill(dt);
            return dt;
        }

        //Chức năng trang chủ sản phẩm
        public List<Product> sortProduct(int sortChoice)
        {
            dc.Connect();

            string sqlQuery = "Select * From SanPham Order By TRY_CONVERT(FLOAT, (DonGia))";
            if (sortChoice == 1)
            {
                sqlQuery += " Asc";
            }
            else
            {
                sqlQuery += " Desc";
            }

            List<Product> listProd = new List<Product>();
            using (SqlConnection connection = dc.Connect())
            {
                SqlCommand command = new SqlCommand(sqlQuery, connection);

                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Product prod = new Product();
                        prod.MaSP = reader.GetInt32(0);
                        prod.TenSP = reader.GetString(1);
                        prod.DonVi = reader.GetString(2);
                        prod.DonGia = reader.GetString(3);
                        prod.HinhSanPham = reader.GetString(4);
                        prod.MaLoaiSP = reader.GetInt32(5);
                        prod.MaGiamGia = reader.GetInt32(6);
                        listProd.Add(prod);
                    }
                }
                connection.Close();
            }
            return listProd;

            //string query = "Select * From SanPham Order By TRY_CONVERT(FLOAT, (DonGia))";
            //if (sortChoice == true)
            //{
            //    query += " Asc";
            //}
            //else
            //{
            //    query += " Desc";
            //}
        }

        public DataTable sortProd(int sortChoice)
        {
            SqlDataAdapter da;
            DataTable dt = new DataTable();
            string query = "Select * From SanPham Order By TRY_CONVERT(FLOAT, (DonGia))";
            if (sortChoice == 1)
            {
                query += " Asc";
            }
            else
            {
                query += " Desc";
            }

            da = new SqlDataAdapter(query, dc.Connect());
            da.Fill(dt);
            return dt;

            //string query = "Select * From SanPham Order By TRY_CONVERT(FLOAT, (DonGia))";
            //if (sortChoice == 1)
            //{
            //    query += " Asc";
            //}
            //else
            //{
            //    query += " Desc";
            //}
        }
    }
}
