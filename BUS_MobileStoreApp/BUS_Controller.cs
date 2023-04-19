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

        public DataTable ShowEmployee()
        {
            return ctrl_D.LoadEmployee();
        }

        //public void AddEmployee(Employee epl)
        //{
        //    ctrl_D.InsertEmployee(epl);
        //}

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
        //public void RemoveEmployee(Employee epl)
        //{
        //    ctrl_D.DeleteEmployee(epl);
        //}

        public bool RemoveEmployee(int IDEmpl)
        {
            return ctrl_D.DeleteEmployee(IDEmpl);
        }

        //public void EditEmployee(Employee epl)
        //{
        //    ctrl_D.UpdateEmployee(epl);
        //}

        public bool EditEmployee(Employee epl)
        {
            return ctrl_D.UpdateEmployee(epl);
        }

        public bool EditedEmployee(NhanVien epl)
        {
            return ctrl_D.UpdatedEmployee(epl);
        }

        public DataTable ShowCategories()
        {
            return ctrl_D.LoadCategories();
        }

        //public void AddCategories(Categories cate)
        //{
        //    ctrl_D.InsertCategories(cate);
        //}

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
        //public void RemoveCategories(Categories cate)
        //{
        //    ctrl_D.DeleteCategories(cate);
        //}

        public bool RemoveCategories(Categories cate)
        {
            return ctrl_D.DeleteCategories(cate);
        }

        //public void EditCategories(Categories cate)
        //{
        //    ctrl_D.UpdateCategories(cate);
        //}

        public bool EditCategories(Categories cate)
        {
            return ctrl_D.UpdateCategories(cate);
        }

        public DataTable ShowCustomer()
        {
            return ctrl_D.LoadCustomer();
        }

        //public void AddCustomer(Customer cust)
        //{
        //    ctrl_D.InsertCustomer(cust);
        //}

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

        //public void RemoveCustomer(Customer cust)
        //{
        //    ctrl_D.DeleteCustomers(cust);
        //}

        public bool RemoveCustomer(Customer cust)
        {
           return ctrl_D.DeleteCustomers(cust);
        }

        //public void EditCustomer(Customer cust)
        //{
        //    ctrl_D.UpdateCustomer(cust);
        //}

        public bool EditCustomer(Customer cust)
        {
            return ctrl_D.UpdateCustomer(cust);
        }

        public DataTable ShowProduct()
        {
            return ctrl_D.LoadProduct();
        }

        public bool AddProduct(Product prod)
        {
            return ctrl_D.InsertProduct(prod);
        }

        public bool RemoveProduct(int prod)
        {
            return ctrl_D.DeleteProduct(prod);
        }

        public bool EditProduct(Product prod)
        {
            return ctrl_D.UpdateProduct(prod);
        }

        public bool EditedProduct(SanPham sanPham)
        {
            return ctrl_D.UpdatedProduct(sanPham);
        }

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
