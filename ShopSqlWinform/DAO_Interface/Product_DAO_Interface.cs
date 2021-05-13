using System;
using Entity_User;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAO_Interface
{
   public interface Product_DAO_Interface
    {
        void Add(Product product);
        IEnumerable<Product> GetAll();
        IEnumerable<Product> DeleteAll();
        void UpdateProduct(int id, string Name, double Price, int Sale, DateTime? StartSale,DateTime? EndSale);
        void DeleteProduct(int id);
        IEnumerable<Product> SearchByName(string name);
        IEnumerable<Product> SearchByPrice(double price);
        IEnumerable<Product> SearchBySale(int sale);
        IEnumerable<Product> SearchByDateSale(DateTime DateSale);
    }
}
