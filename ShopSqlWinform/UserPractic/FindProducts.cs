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
    public partial class FindProducts : Form
    {
        private BL_Product_Interface _userPL = new BL_Product();

        public FindProducts(string str)
        {
            InitializeComponent();
            label2.Text = str;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(label2.Text == "Название")
            {
                dataGridView1.DataSource = _userPL.SearchByName(textBox1.Text);
            }
            if (label2.Text == "Цену")
            {
                try
                {
                    dataGridView1.DataSource = _userPL.SearchByPrice(double.Parse(textBox1.Text));
                }
                catch
                {
                    errorProvider1.SetError(button1, "Введите нормальную цену");
                }
            }
            if (label2.Text == "Скидку")
            {
                try
                {
                    dataGridView1.DataSource = _userPL.SearchBySale(int.Parse(textBox1.Text));
                }
                catch
                {
                    errorProvider1.SetError(button1, "Введите нормальную скидку");
                }
            }
            if (label2.Text == "Дату проведения")
            {
                try
                {
                    dataGridView1.DataSource = _userPL.SearchByDateSale(DateTime.Parse(textBox1.Text));
                }
                catch
                {
                    errorProvider1.SetError(button1, "Введите нормальную дату");
                }
            }
        }
    }
}
