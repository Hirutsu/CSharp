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
    public partial class UpdateProduct : Form
    {
        private BL_User_Interface _userPL = new BL_User();
        private int _id = 0;

        public UpdateProduct()
        {
            InitializeComponent();
            comboBox1.DataSource = _userPL.GetAll();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            if (String.IsNullOrWhiteSpace(TB_Price.Text) || String.IsNullOrWhiteSpace(TB_Name.Text) || String.IsNullOrWhiteSpace(TB_Sale.Text))
            {
                errorProvider1.SetError(button1, "Fill in all the fields");
            }
            else
            {
                var user = new Product(TB_Name.Text, double.Parse(TB_Price.Text), int.Parse(TB_Sale.Text), DTP_StartSale.Value, DTP_EndSale.Value);
                _userPL.UpdateProduct(_id, TB_Name.Text, double.Parse(TB_Price.Text), int.Parse(TB_Sale.Text), DTP_StartSale.Value,DTP_EndSale.Value);
                Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var product = (Product)comboBox1.SelectedItem;
            _id = product.ID;
            TB_Name.Text = product.Name;
            TB_Price.Text = product.Price.ToString();
            TB_Sale.Text = product.Sale.ToString();
            string date = product.StartSale.Day.ToString() + "-" + product.StartSale.Month.ToString() + "-" + product.StartSale.Year.ToString();
            DTP_StartSale.Value = DateTime.Parse(date);
            date = product.EndSale.Day.ToString() + "-" + product.EndSale.Month.ToString() + "-" + product.EndSale.Year.ToString();
            DTP_EndSale.Value = DateTime.Parse(date);
        }
    }
}
