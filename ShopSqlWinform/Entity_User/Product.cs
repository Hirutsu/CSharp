using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Entity_User
{
   public class Product
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public int Sale { get; set; }
        public DateTime StartSale { get; set; }
        public DateTime EndSale { get; set; }

        public Product()
        {

        }
        public Product (string Name, double Price, int Sale, DateTime StartSale, DateTime EndSale)
        {
            this.Name= Name;
            this.Price = Price;
            this.Sale = Sale;
            this.StartSale = StartSale;
            this.EndSale = EndSale;
        }
        public override string ToString()
        {
            return $"{ID}) Name:{Name} Price: {Price} Sale: {Sale} Start Sale: {StartSale } End Sale: {EndSale}";
        }
    }
}
