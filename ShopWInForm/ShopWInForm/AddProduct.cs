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
    public partial class AddProduct : Form
    {
        public AddProduct()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Product prod;
            if (NameProductTB.Text == "")
            {
                MessageBox.Show("Введите название товара");
                return;
            }
            else if (PriceProductTB.Text == "")
            {
                MessageBox.Show("Введите цену товара");
            }
            else if(SaleProductTB.Text =="")
            {
                MessageBox.Show("Введите скидку товара");
            }
            else
            {
                ShopByHirutsu main = this.Owner as ShopByHirutsu;
                if (main != null)
                {
                    if (Convert.ToInt32(SaleProductTB.Text) != 0)
                    {
                        prod = new Product(NameProductTB.Text, Convert.ToDouble(PriceProductTB.Text), Convert.ToInt32(SaleProductTB.Text), Convert.ToDateTime(SaleStartTB.Text), Convert.ToDateTime(SaleEndTB.Text));
                    }
                    else
                    {
                        prod = new Product(NameProductTB.Text, Convert.ToDouble(PriceProductTB.Text), Convert.ToInt32(SaleProductTB.Text), null, null);
                    }
                    main.AddProc(prod);
                }
            }
            this.Close();
        }

    }
}
