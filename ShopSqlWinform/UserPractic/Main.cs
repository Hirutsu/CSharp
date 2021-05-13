using BL;
using BL_Interface;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserPractic
{
    public partial class Main : Form
    {
        private BL_Product_Interface _userPL = new BL_Product();
        public Main()
        {
            InitializeComponent();
            dataGridView1.DataSource = _userPL.GetAll();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddProduct addProduct = new AddProduct();
            addProduct.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = _userPL.GetAll();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DeleteProduct f = new DeleteProduct();
            f.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            UpdateProduct f = new UpdateProduct();
            f.Show();
        }

        private void FindProducts(object sender, EventArgs e)
        {
            string str = sender.ToString();
            FindProducts f = new FindProducts(str);
            f.Show();
        }
        private void DeleteAll(object sender, EventArgs e)
        {
            dataGridView1.DataSource = _userPL.DeleteAll();
        }
    }
}
