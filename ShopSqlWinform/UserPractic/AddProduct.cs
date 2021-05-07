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
    public partial class AddProduct : Form
    {
        private BL_User_Interface _userPL = new BL_User();
        public AddProduct()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            if(String.IsNullOrWhiteSpace(TB_Price.Text)|| String.IsNullOrWhiteSpace(TB_Name.Text)|| String.IsNullOrWhiteSpace(TB_Sale.Text))
            {
                errorProvider1.SetError(button1, "Fill in all the fields");
            }
            else
            {
                var user = new Product(TB_Name.Text, float.Parse(TB_Price.Text), int.Parse(TB_Sale.Text), DTP_StartSale.Value,DTP_EndSale.Value);
                _userPL.Add(user);
                Close();
            }
        }
    }
}
