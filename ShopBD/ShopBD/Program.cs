using System;
using System.Collections.Generic;
using System.IO;
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
            string inputFile = @"I:\git\CSharp\ShopBD\ShopBD\Input.txt";
            string outputFile = @"I:\git\CSharp\ShopBD\ShopBD\Output.txt";

            using (StreamReader streamReader = new StreamReader(inputFile, false))
            {
                string line;
                while ((line = streamReader.ReadLine()) != null)
                {
                    string[] templine = line.Split();
                    Shop shop;
                    if (templine.Length==5)
                    {
                        shop = new Shop(templine[0], Convert.ToInt32(templine[1]), Convert.ToInt32(templine[2]), Convert.ToDateTime(templine[3]), Convert.ToDateTime(templine[4]));
                    }
                    else 
                    {
                        shop = new Shop(templine[0], Convert.ToInt32(templine[1]), Convert.ToInt32(templine[2]),null,null);
                    }
                    listShop.AddLast(shop);
                }
            }
            using(StreamWriter stream = new StreamWriter(inputFile,false))
            {
                foreach (var item in listShop)
                {
                    stream.WriteLine(item.GetData());
                }
            }

            using(StreamWriter streamWriter = new StreamWriter(outputFile,false))
            {
                streamWriter.WriteLine("Полный список товаров:");
                foreach(var item in listShop)
                {
                    streamWriter.WriteLine(item.ToString());
                }

                streamWriter.WriteLine("Акционные товары:");
                foreach (var item in listShop)
                {
                    if (item.GetSale() > 0)
                    {
                        streamWriter.WriteLine(item.ToString());
                    }
                }

                listShop.ElementAt(0).SetPrice(250);
                streamWriter.WriteLine("Изменный полный список товаров:");
                foreach (var item in listShop)
                {
                    streamWriter.WriteLine(item.ToString());
                }

                streamWriter.WriteLine("Поиск по названию,введите название:");
                Console.WriteLine("Введите название товара");
                string findName = Console.ReadLine();
                foreach (var item in listShop)
                {
                    if (item.GetName() == findName)
                    {
                        streamWriter.WriteLine(item.ToString());
                    }
                }

                streamWriter.WriteLine("Поиск товаров с акцией,введите дату:");
                DateTime data = Convert.ToDateTime(Console.ReadLine());
                int count = 0;
                foreach (var item in listShop)
                {
                    if ((item.GetStartSale() <= data) && (item.GetEndSale() >= data))
                    {
                        streamWriter.WriteLine(item.ToString());
                        count++;
                    }
                }
                if(count==0)
                {
                    streamWriter.WriteLine("Таких товаров нет");
                }
                Console.WriteLine("Удаление всех акций:");
                foreach (var item in listShop)
                {
                    if (item.GetSale() != 0)
                    {
                        item.SetSale(0, null, null);
                    }
                }
                Console.WriteLine("Полный список товаров:");
                foreach (var item in listShop)
                {
                    Console.WriteLine(item.ToString());
                }

                Console.WriteLine("Введите id:");
                int idProduct = Convert.ToInt32(Console.ReadLine());
                foreach (var item in listShop)
                {
                    if (item.GetId() == idProduct)
                    {
                        int saleProduct = Convert.ToInt32(Console.ReadLine());
                        DateTime dtS = Convert.ToDateTime(Console.ReadLine());
                        DateTime dtE = Convert.ToDateTime(Console.ReadLine());
                        item.SetSale(saleProduct, dtS, dtE);
                    }
                }
                Console.WriteLine("Полный список товаров:");
                foreach (var item in listShop)
                {
                    Console.WriteLine(item.ToString());
                }
            }
        }
    }
}
