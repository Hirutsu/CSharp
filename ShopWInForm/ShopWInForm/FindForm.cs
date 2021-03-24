using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShopWInForm
{
    public partial class FindForm : Form
    {
        public FindForm()
        {
            InitializeComponent();
        }

        private void Поиск_Click(object sender, EventArgs e)
        {
            if(TextBoxFind.Text != "")
            {
                ShopByHirutsu main = this.Owner as ShopByHirutsu;
                if (main != null)
                {
                    main.FindOpt = TextBoxFind.Text;
                    main.FindProduct();
                }
            }
            else 
            {
                MessageBox.Show("Введите данные");
            }
            this.Close();
        }
    }
}
