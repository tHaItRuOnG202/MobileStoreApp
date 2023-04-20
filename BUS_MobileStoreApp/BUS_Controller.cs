using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO_MoblieStoreApp;
using DTO_MobileStoreApp;

namespace BUS_MobileStoreApp
{
    public class BUS_Controller
    {
        DAO_Controller ctrl_D = new DAO_Controller();

        // BUS nhân viên
        public DataTable ShowEmployee()
        {
            return ctrl_D.LoadEmployee();
        }

        public bool AddEmployee(Employee epl)
        {
            return ctrl_D.InsertEmployee(epl);
        }

        public DataTable FindEmployee(string keyword)
        {
            return ctrl_D.SearchEmployee(keyword);
        }

        public DataTable FoundEmployee(string keyword)
        {
            return ctrl_D.SearchedEmployee(keyword);
        }

        public bool RemoveEmployee(int IDEmpl)
        {
            return ctrl_D.DeleteEmployee(IDEmpl);
        }

        public bool EditEmployee(Employee epl)
        {
            return ctrl_D.UpdateEmployee(epl);
        }

        public bool EditedEmployee(NhanVien epl)
        {
            return ctrl_D.UpdatedEmployee(epl);
        }

        //BUS loại sản phẩm
        public DataTable ShowCategories()
        {
            return ctrl_D.LoadCategories();
        }

        public bool AddCategories(Categories cate)
        {
            return ctrl_D.InsertCategories(cate);
        }

        public DataTable FindCategories(string keyword)
        {
            return ctrl_D.SearchCategories(keyword);
        }

        public DataTable FoundCategories(string keyword)
        {
            return ctrl_D.SearchedCategories(keyword);
        }

        public bool RemoveCategories(int IDCate)
        {
            return ctrl_D.DeleteCategories(IDCate);
        }

        public bool EditCategories(Categories cate)
        {
            return ctrl_D.UpdateCategories(cate);
        }

        //BUS khách hàng
        public DataTable ShowCustomer()
        {
            return ctrl_D.LoadCustomer();
        }


        public bool AddCustomer(Customer cust)
        {
            return ctrl_D.InsertCustomer(cust);
        }

        public DataTable FindCustomer(string keyword)
        {
            return ctrl_D.SearchCustomer(keyword);
        }

        public DataTable FoundCustomer(string keyword)
        {
            return ctrl_D.SearchedCustomer(keyword);
        }

        public bool RemoveCustomer(int IDCust)
        {
           return ctrl_D.DeleteCustomer(IDCust);
        }

        public bool EditCustomer(Customer cust)
        {
            return ctrl_D.UpdateCustomer(cust);
        }

        //BUS sản phẩm
        public DataTable ShowProduct()
        {
            return ctrl_D.LoadProduct();
        }

        //public DataTable ShowCBIDProduct()
        //{
        //    return ctrl_D.LoadCBIDProduct();
        //}

        public bool AddProduct(Product prod)
        {
            return ctrl_D.InsertProduct(prod);
        }

        public bool RemoveProduct(int prod)
        {
            return ctrl_D.DeleteProduct(prod);
        }

        public DataTable FindProduct(string keyword)
        {
            return ctrl_D.SearchProduct(keyword);
        }

        public DataTable FoundProduct(string keyword)
        {
            return ctrl_D.SearchedProduct(keyword);
        }

        public bool EditProduct(Product prod)
        {
            return ctrl_D.UpdateProduct(prod);
        }

        public bool EditedProduct(SanPham sanPham)
        {
            return ctrl_D.UpdatedProduct(sanPham);
        }

        //BUS giảm giá
        public DataTable ShowDiscount()
        {
            return ctrl_D.LoadDiscount();
        }

        public bool AddDiscount(Discount disc)
        {
            return ctrl_D.InsertDiscount(disc);
        }

        public DataTable FindDiscount(string keyword)
        {
            return ctrl_D.SearchDiscount(keyword);
        }

        public DataTable FoundDiscount(string keyword)
        {
            return ctrl_D.SearchedDiscount(keyword);
        }

        public bool RemoveDiscount(int disc)
        {
            return ctrl_D.DeleteDiscount(disc);
        }

        public bool EditDiscount(Discount disc)
        {
            return ctrl_D.UpdateDiscount(disc);
        }

        public bool EditedDiscount(GiamGia disc)
        {
            return ctrl_D.UpdatedDiscount(disc);
        }

        //BUS thanh toán hóa đơn
        public void AddReceipt(string idRec, DateTime dateSale, string totalPrice, string idEmpl, string idCust)
        {
            ctrl_D.InsertReceipt(idRec, dateSale, totalPrice, idEmpl, idCust);
        }

        public void AddReceiptDetail(string idRec, string idPro, string quantity, string uPrice)
        {
            ctrl_D.InsertReceiptDetail(idRec, idPro, quantity, uPrice);
        }

        public string GetDistByProd(int mgg)
        {
            return ctrl_D.GetDiscountByProduct(mgg);
        }

        public SanPham GetPrById(int rd)
        {
            return ctrl_D.GetProductByID(rd);
        }

        public KhachHang GetCustByID(int maKH)
        {
            return ctrl_D.GetCustomerByID(maKH);
        }

        //BUS quản lý hóa đơn
        public DataTable ShowReceiptByIDEmployee(int IDEmpl)
        {
            return ctrl_D.LoadReceiptByIDEmployee(IDEmpl);
        }

        public DataTable ShowProductByIDDiscount(int IDDis)
        {
            return ctrl_D.LoadProductByIDDiscount(IDDis);
        }
    }
}
