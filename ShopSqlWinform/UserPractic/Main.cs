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
        private BL_User_Interface _userPL = new BL_User();
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
            DeleteUser f = new DeleteUser();
            f.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Update f = new Update();
            f.Show();
        }
    }
}
