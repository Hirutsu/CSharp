using BL;
using BL_Interface;
using Entity_User;
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
    public partial class DeleteProduct : Form
    {
        private BL_User_Interface _productPL = new BL_User();
        public DeleteProduct()
        {
            InitializeComponent();
            comboBox1.DataSource = _productPL.GetAll();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Product user = (Product)comboBox1.SelectedItem;
            _productPL.DeleteProduct(user.ID);
            Close();
        }
    }
}
