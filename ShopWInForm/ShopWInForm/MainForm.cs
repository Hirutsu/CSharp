using MySqlX.XDevAPI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShopWInForm
{
    public partial class ShopByHirutsu : Form
    {
        public Product product = new Product();
        LinkedList<Product> listShop = new LinkedList<Product>();
        LinkedList<Product> tempProducts = new LinkedList<Product>();
        public string FindOpt;
        public string NameButton;

        public ShopByHirutsu()
        {
            InitializeComponent();
            ShopList.AllowUserToAddRows = false;
        }

        //Файл - меню
        private void OpenToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            listShop.Clear();
            ShopList.Rows.Clear();
            Product._incID = 0;
            string nameFile;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                nameFile = openFileDialog1.FileName;
                using (StreamReader streamReader = new StreamReader(nameFile, false))
                {
                    string line;
                    while ((line = streamReader.ReadLine()) != null)
                    {
                        string[] templine = line.Split();
                        Product shop;
                        if (templine.Length == 5)
                        {
                            shop = new Product(templine[0], Convert.ToInt32(templine[1]), Convert.ToInt32(templine[2]), Convert.ToDateTime(templine[3]), Convert.ToDateTime(templine[4]));
                        }
                        else
                        {
                            shop = new Product(templine[0], Convert.ToInt32(templine[1]), Convert.ToInt32(templine[2]), null, null);
                        }
                        listShop.AddLast(shop);
                    }
                    int index = 0;
                    foreach (var item in listShop)
                    {
                        ShopList.Rows.Add();
                        ShopList[0, index].Value = item.GetId();
                        ShopList[1, index].Value = item.GetName();
                        ShopList[2, index].Value = item.GetPrice();
                        ShopList[3, index].Value = item.GetSale();
                        if(item.GetSale()!=0)
                        {
                            ShopList[4, index].Value = item.GetPrice()-item.GetPrice() * (item.GetSale() / 100.0);
                        }
                        else
                        {
                            ShopList[4, index].Value = item.GetPrice();
                        }
                        ShopList[5, index].Value = item.GetStartSale();
                        ShopList[6, index].Value = item.GetEndSale();
                        index++;
                    }
                }
            }
            else
            {
                MessageBox.Show("Ошибка чтения из файла");
            }
        }
        
        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string nameFile = saveFileDialog1.FileName;
                using (StreamWriter streamWriter = new StreamWriter(nameFile, false))
                {
                    foreach (var item in listShop)
                    {
                        if (item.GetSale() != 0)
                        {
                            streamWriter.WriteLine(item.GetName() + " " + item.GetPrice() + " " + item.GetSale() + " " + ((DateTime)item.GetStartSale()).ToString("dd.MM.yyyy") + " " + ((DateTime)item.GetEndSale()).ToString("dd.MM.yyyy"));
                        }
                        else
                        {
                            streamWriter.WriteLine(item.GetName() + " " + item.GetPrice() + " " + item.GetSale());
                        }
                    }
                }
            }
        }

        private void AddProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddProduct addProduct = new AddProduct();
            addProduct.Owner = this;
            addProduct.ShowDialog();
        }
        public void AddProc(Product prod)
        {
            listShop.AddLast(prod);
            int index = ShopList.Rows.Count;
            ShopList.Rows.Add();
            ShopList[0, ShopList.Rows.Count-1].Value = prod.GetId();
            ShopList[1, ShopList.Rows.Count-1].Value = prod.GetName();
            ShopList[2, ShopList.Rows.Count-1].Value = prod.GetPrice();
            ShopList[3, ShopList.Rows.Count-1].Value = prod.GetSale();
            if(prod.GetSale()==0)
            {
                ShopList[4, ShopList.Rows.Count-1].Value = prod.GetPrice();
            }
            else
            {
                ShopList[4, ShopList.Rows.Count - 1].Value = prod.GetPrice() - prod.GetPrice() * (prod.GetSale() / 100.0);
            }
            if (prod.GetStartSale().ToString() != "")
            {
                ShopList[5, ShopList.Rows.Count-1].Value = prod.GetStartSale();
            }
            if(prod.GetEndSale().ToString()!="")
            {
                ShopList[6, ShopList.Rows.Count-1].Value = prod.GetEndSale();
            }
        }

        //обновить таблицу
        private void UpdateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShopList.Rows.Clear();
            int index = 0;
            foreach (var item in listShop)
            {
                ShopList.Rows.Add();
                ShopList[0, index].Value = item.GetId();
                ShopList[1, index].Value = item.GetName();
                ShopList[2, index].Value = item.GetPrice();
                ShopList[3, index].Value = item.GetSale();
                ShopList[4, index].Value = item.GetPrice() - item.GetPrice() * (item.GetSale() / 100.0);
                ShopList[5, index].Value = item.GetStartSale();
                ShopList[6, index].Value = item.GetEndSale();
                index++;
            }
        }
        
        //Сортировать по
        private void PriceUpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var result = listShop.OrderBy(u => u.GetPrice());
            ShopList.Rows.Clear();
            int index = 0;
            foreach (var item in result)
            {
                ShopList.Rows.Add();
                ShopList[0, index].Value = item.GetId();
                ShopList[1, index].Value = item.GetName();
                ShopList[2, index].Value = item.GetPrice();
                ShopList[3, index].Value = item.GetSale();
                if (item.GetSale() != 0)
                {
                    ShopList[4, index].Value = item.GetPrice() - item.GetPrice() * (item.GetSale() / 100.0);
                }
                else
                {
                    ShopList[4, index].Value = item.GetPrice();
                }
                ShopList[5, index].Value = item.GetStartSale();
                ShopList[6, index].Value = item.GetEndSale();
                index++;
            }
        }

        private void SaleUpToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var result = listShop.OrderBy(u => u.GetSale());
            ShopList.Rows.Clear();
            int index = 0;
            foreach (var item in result)
            {
                ShopList.Rows.Add();
                ShopList[0, index].Value = item.GetId();
                ShopList[1, index].Value = item.GetName();
                ShopList[2, index].Value = item.GetPrice();
                ShopList[3, index].Value = item.GetSale();
                if (item.GetSale() != 0)
                {
                    ShopList[4, index].Value = item.GetPrice() - item.GetPrice() * (item.GetSale() / 100.0);
                }
                else
                {
                    ShopList[4, index].Value = item.GetPrice();
                }
                ShopList[5, index].Value = item.GetStartSale();
                ShopList[6, index].Value = item.GetEndSale();
                index++;
            }
        }

        private void PriceDownToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var result = listShop.OrderByDescending(u => u.GetPrice());
            ShopList.Rows.Clear();
            int index = 0;
            foreach (var item in result)
            {
                ShopList.Rows.Add();
                ShopList[0, index].Value = item.GetId();
                ShopList[1, index].Value = item.GetName();
                ShopList[2, index].Value = item.GetPrice();
                ShopList[3, index].Value = item.GetSale();
                if (item.GetSale() != 0)
                {
                    ShopList[4, index].Value = item.GetPrice() - item.GetPrice() * (item.GetSale() / 100.0);
                }
                else
                {
                    ShopList[4, index].Value = item.GetPrice();
                }
                ShopList[5, index].Value = item.GetStartSale();
                ShopList[6, index].Value = item.GetEndSale();
                index++;
            }
        }

        private void SaleDownToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var result = listShop.OrderByDescending(u => u.GetSale());
            ShopList.Rows.Clear();
            int index = 0;
            foreach (var item in result)
            {
                ShopList.Rows.Add();
                ShopList[0, index].Value = item.GetId();
                ShopList[1, index].Value = item.GetName();
                ShopList[2, index].Value = item.GetPrice();
                ShopList[3, index].Value = item.GetSale();
                if (item.GetSale() != 0)
                {
                    ShopList[4, index].Value = item.GetPrice() - item.GetPrice() * (item.GetSale() / 100.0);
                }
                else
                {
                    ShopList[4, index].Value = item.GetPrice();
                }
                ShopList[5, index].Value = item.GetStartSale();
                ShopList[6, index].Value = item.GetEndSale();
                index++;
            }
        }

        //Поиск по цене,названию,скидке,проведению скидки
        private void FindToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NameButton = sender.ToString();
            FindForm FindProduct = new FindForm();
            FindProduct.Owner = this;
            FindProduct.ShowDialog();
            tempProducts.Clear();
        }

        public void FindProduct()
        {
            if(NameButton == "Названию")
            {
                foreach(var item in listShop)
                {
                    if (item.GetName() == FindOpt)
                    {
                        tempProducts.AddLast(item);
                    }
                }
                ShopList.Rows.Clear();
                int index = 0;
                foreach (var item in tempProducts)
                {
                    ShopList.Rows.Add();
                    ShopList[0, index].Value = item.GetId();
                    ShopList[1, index].Value = item.GetName();
                    ShopList[2, index].Value = item.GetPrice();
                    ShopList[3, index].Value = item.GetSale();
                    ShopList[4, index].Value = item.GetPrice() - item.GetPrice() * (item.GetSale() / 100.0);
                    ShopList[5, index].Value = item.GetStartSale();
                    ShopList[6, index].Value = item.GetEndSale();
                    index++;
                }
            }
            else if(NameButton == "Цене")
            {
                foreach (var item in listShop)
                {
                    if (item.GetPrice() == Convert.ToDouble(FindOpt))
                    {
                        tempProducts.AddLast(item);
                    }
                }
                ShopList.Rows.Clear();
                int index = 0;
                foreach (var item in tempProducts)
                {
                    ShopList.Rows.Add();
                    ShopList[0, index].Value = item.GetId();
                    ShopList[1, index].Value = item.GetName();
                    ShopList[2, index].Value = item.GetPrice();
                    ShopList[3, index].Value = item.GetSale();
                    ShopList[4, index].Value = item.GetPrice() - item.GetPrice() * (item.GetSale() / 100.0);
                    ShopList[5, index].Value = item.GetStartSale();
                    ShopList[6, index].Value = item.GetEndSale();
                    index++;
                }
            }
            else if (NameButton == "Скидке")
            {
                foreach (var item in listShop)
                {
                    if (item.GetSale() == Convert.ToInt32(FindOpt))
                    {
                        tempProducts.AddLast(item);
                    }
                }
                ShopList.Rows.Clear();
                int index = 0;
                foreach (var item in tempProducts)
                {
                    ShopList.Rows.Add();
                    ShopList[0, index].Value = item.GetId();
                    ShopList[1, index].Value = item.GetName();
                    ShopList[2, index].Value = item.GetPrice();
                    ShopList[3, index].Value = item.GetSale();
                    ShopList[4, index].Value = item.GetPrice() - item.GetPrice() * (item.GetSale() / 100.0);
                    ShopList[5, index].Value = item.GetStartSale();
                    ShopList[6, index].Value = item.GetEndSale();
                    index++;
                }
            }
            else
            {
                foreach (var item in listShop)
                {
                    if (item.GetStartSale() <= Convert.ToDateTime(FindOpt) && (item.GetEndSale() >= Convert.ToDateTime(FindOpt)))
                    {
                        tempProducts.AddLast(item);
                    }
                }
                ShopList.Rows.Clear();
                int index = 0;
                foreach (var item in tempProducts)
                {
                    ShopList.Rows.Add();
                    ShopList[0, index].Value = item.GetId();
                    ShopList[1, index].Value = item.GetName();
                    ShopList[2, index].Value = item.GetPrice();
                    ShopList[3, index].Value = item.GetSale();
                    ShopList[4, index].Value = item.GetPrice() - item.GetPrice() * (item.GetSale() / 100.0);
                    ShopList[5, index].Value = item.GetStartSale();
                    ShopList[6, index].Value = item.GetEndSale();
                    index++;
                }
            }
            if(tempProducts.Count ==0)
            {
                ShopList.Rows.Clear();
                MessageBox.Show("Таких товаров не найдено");
            }
        }

        //меню программы внизу
        private void ButtonDeleteProd_Click(object sender, EventArgs e)
        {
            int size = listShop.Count;
            if(TextBoxForDelete.Text =="")
            {
                MessageBox.Show("Введите id");
                return;
            }
            else
            {
                foreach (var item in listShop.ToArray())
                {
                    if(item.GetId() == Convert.ToInt32(TextBoxForDelete.Text))
                    {
                        listShop.Remove(item);
                    }
                }
                if(size == listShop.Count())
                {
                    MessageBox.Show("С таким товаром id не найдено");
                    return;
                }
                else
                {
                    ShopList.Rows.Clear();
                    int index = 0;
                    foreach (var item in listShop.ToArray())
                    {
                        ShopList.Rows.Add();
                        ShopList[0, index].Value = item.GetId();
                        ShopList[1, index].Value = item.GetName();
                        ShopList[2, index].Value = item.GetPrice();
                        ShopList[3, index].Value = item.GetSale();
                        ShopList[4, index].Value = item.GetPrice() - item.GetPrice() * (item.GetSale() / 100.0);
                        ShopList[5, index].Value = item.GetStartSale();
                        ShopList[6, index].Value = item.GetEndSale();
                        index++;
                    }
                }
            }
        }
    }
}
