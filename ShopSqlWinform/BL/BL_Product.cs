using BL_Interface;
using DAO;
using DAO_Interface;
using Entity_User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BL
{
    public class BL_Product : BL_Product_Interface
    {
        private Product_DAO_Interface _productDao = new Product_DAO();
        public BL_Product()
        {
            this._productDao = new Product_DAO();
        }
        public void Add(Product value)
        {
            _productDao.Add(value);
        }
        public IEnumerable<Product> GetAll()
        {
            return _productDao.GetAll();
        }
        public IEnumerable<Product> DeleteAll()
        {
            return _productDao.DeleteAll();
        }
        public void DeleteProduct(int id)
        {
            _productDao.DeleteProduct(id);
        }
        public void UpdateProduct(int id, string name, double price, int sale, DateTime saleStart,DateTime saleEnd)
        {
            _productDao.UpdateProduct(id, name,price,sale,saleStart,saleEnd);
        }
        public IEnumerable<Product> SearchByName(string name)
        {
            return _productDao.SearchByName(name);
        }
        public IEnumerable<Product> SearchByPrice(double price)
        {
            return _productDao.SearchByPrice(price);
        }
        public IEnumerable<Product> SearchBySale(int sale)
        {
            return _productDao.SearchBySale(sale);
        }
        public IEnumerable<Product> SearchByDateSale(DateTime dateTime)
        {
            return _productDao.SearchByDateSale(dateTime);
        }
    }
}
