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
    public partial class Update : Form
    {
        private BL_User_Interface _userPL = new BL_User();
        private int _id = 0;

        public Update()
        {
            InitializeComponent();
            comboBox1.DataSource = _userPL.GetAll();
        }

        private void button2_Click(object sender, EventArgs e)
        {
/*            errorProvider1.Clear();
            if (String.IsNullOrWhiteSpace(textBox1.Text) || String.IsNullOrWhiteSpace(textBox2.Text) || String.IsNullOrWhiteSpace(textBox3.Text))
            {
                errorProvider1.SetError(button1, "Fill in all the fields");
            }
            else
            {
                //var user = new User(textBox1.Text, textBox2.Text, textBox3.Text, dateTimePicker1.Value);
                _userPL.UpdateProduct(_id, textBox1.Text, textBox2.Text, textBox3.Text, dateTimePicker1.Value);
                Close();
            }*/
        }

        private void button1_Click(object sender, EventArgs e)
        {
/*            var product = (Product)comboBox1.SelectedItem;
            _id = product._ID;
            textBox1.Text = product.FirstN;
            textBox2.Text = product.SecondName;
            textBox3.Text = product.ThirdName;
            string date = product.DateOfBirth.Day.ToString() + "-" + product.DateOfBirth.Month.ToString() + "-" + product.DateOfBirth.Year.ToString();
            dateTimePicker1.Value = DateTime.Parse(date);*/
        }
    }
}
