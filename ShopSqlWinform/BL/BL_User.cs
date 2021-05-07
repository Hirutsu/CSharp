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
    public class BL_User : BL_User_Interface
    {
        private User_DAO_Interface _productDao = new User_DAO();
        public BL_User()
        {
            this._productDao = new User_DAO();
        }
        public void Add(Product value)
        {
            _productDao.Add(value);
        }
        public IEnumerable<Product> GetAll()
        {
            return _productDao.GetAll();
        }
        public void Remove(int id)
        {
            _productDao.Remove(id);
        }
        public Product GetInfoProduct(int id)
        {
            return _productDao.GetInfoProduct(id);
        }
        public void UpdateProduct(int id, string name, double price, int sale, DateTime? saleStart,DateTime? saleEnd)
        {
            _productDao.UpdateProduct(id, name,price,sale,saleStart,saleEnd);
        }
    }
}
