using Product_BLL_Interface;
using DAO;
using DAO_Interface;
using Entity_User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Product_BLL
{
    public class Product_BLL : Product_BLL_Interface
    {
        private Product_DAO_Interface _ProductDao = new Product_DAO();
        public Product_BLL()
        {
            this._ProductDao = new Product_DAO();
        }
        public void Add(Product value)
        {
            _ProductDao.Add(value);
        }
        public IEnumerable<Product> GetAll()
        {
            return _ProductDao.GetAll();
        }
        public void Remove(int id)
        {
            _ProductDao.Remove(id);
        }
        public User GetInfoUser(int id)
        {
            return _ProductDao.GetInfoUser(id);
        }
        public void Update(int id, string FirstName, string SecondName, string ThirdName, DateTime date)
        {
            _ProductDao.UpdateUser(id, FirstName, SecondName, ThirdName, date);
        }
    }
}
