using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopBD
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList<Shop> listShop = new LinkedList<Shop>();
            Console.WriteLine("Write size");
            int size = Convert.ToInt32(Console.ReadLine());
            for (int index = 0; index < size; index++)
            {
                Console.WriteLine("Write name");
                string name = Console.ReadLine();

                Console.WriteLine("Write price");
                double price = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Write Sale");
                int sale = Convert.ToInt32(Console.ReadLine());

                Nullable<DateTime> dateTimeStart;
                Nullable<DateTime> dateTimeEnd;
                if (sale==0)
                {
                    dateTimeStart = null;
                    dateTimeEnd = null;
                }
                else
                {
                    Console.WriteLine("Write DateTime Sale Start");
                    dateTimeStart = Convert.ToDateTime(Console.ReadLine());

                    Console.WriteLine("Write DateTime Sale End");
                    dateTimeEnd = Convert.ToDateTime(Console.ReadLine());
                }

                Shop shop = new Shop(name, price, sale, dateTimeStart, dateTimeEnd);
                listShop.AddLast(shop);
            }

            Console.WriteLine("Полный список товаров");
            foreach (var item in listShop)
            {
                Console.WriteLine(item.ToString());
            }

            Console.WriteLine("Акционные товары");
            foreach (var item in listShop)
            {
                if (item.GetSale() > 0)
                {
                    Console.WriteLine(item.ToString());
                }
            }

            listShop.ElementAt(0).SetPrice(250);
            Console.WriteLine("Изменный полный список товаров");
            foreach (var item in listShop)
            {
                Console.WriteLine(item.ToString());
            }

            Console.WriteLine("Поиск по названию,введите название");
            string findName = Console.ReadLine();
            foreach(var item in listShop)
            {
                if(item.GetName() == findName)
                {
                    Console.WriteLine(item.ToString());
                }
            }

            Console.WriteLine("Поиск товаров с акцией,введите дату");
            DateTime data = Convert.ToDateTime(Console.ReadLine());
            foreach(var item in listShop)
            {
                if( (item.GetStartSale()<=data) &&(item.GetEndSale()>=data))
                {
                    Console.WriteLine(item.ToString());
                }
            }
        }
    }
}
