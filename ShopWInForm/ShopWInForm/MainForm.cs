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

        public LinkedList<Product> listShop = new LinkedList<Product>();

        public ShopByHirutsu()
        {
            InitializeComponent();
            ShopList.AllowUserToAddRows = false;
        }

        private void OpenToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            listShop.Clear();
            ShopList.Rows.Clear();
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

        private void UpdateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(listShop.Count.ToString());
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

        private void AddProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddProduct addProduct = new AddProduct();
            addProduct.Show();
        }
        public void AddProc(Product prod)
        {
            MessageBox.Show(prod.ToString());
            MessageBox.Show(listShop.Count.ToString());
            listShop.AddLast(prod);
            MessageBox.Show(listShop.Count.ToString());
            ShopList.Rows.Clear();
            int index = ShopList.Rows.Count;
            ShopList.Rows.Add();
            ShopList[0, index].Value = prod.GetId();
            ShopList[1, index].Value = prod.GetName();
            ShopList[2, index].Value = prod.GetPrice();
            ShopList[3, index].Value = prod.GetSale();
            ShopList[4, index].Value = prod.GetPrice() * (prod.GetSale() / 100.0);
            ShopList[5, index].Value = prod.GetStartSale();
            ShopList[6, index].Value = prod.GetEndSale();
        }
    }
}
