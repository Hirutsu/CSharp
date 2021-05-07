using Entity_User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BL_Interface
{
    public interface BL_User_Interface
    {
        void Add(Product product);
        IEnumerable<Product> GetAll();
        Product GetInfoProduct(int id);
        void UpdateProduct(int id, string Name, double Price, int Sale, DateTime? StartSale, DateTime? EndSale);
        void Remove(int id);
    }
}
