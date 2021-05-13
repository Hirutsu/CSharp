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
        private BL_Product_Interface _userPL = new BL_Product();
        public AddProduct()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            if(String.IsNullOrWhiteSpace(TB_Price.Text)|| String.IsNullOrWhiteSpace(TB_Name.Text)|| String.IsNullOrWhiteSpace(TB_Sale.Text)||string.IsNullOrWhiteSpace(DTP_StartSale.Value.ToString()) || string.IsNullOrWhiteSpace(DTP_StartSale.Value.ToString()))
            {
                errorProvider1.SetError(button1, "Введите все поля");
                return;
            }
            if(DTP_StartSale.Value>DTP_EndSale.Value)
            {
                errorProvider1.SetError(button1, "Дата проведения акции неверно выставлена");
                return;
            }
            if(int.Parse(TB_Sale.Text)>100 || int.Parse(TB_Sale.Text)<0)
            {
                errorProvider1.SetError(button1, "Скидка должна быть от 0 до 100%");
                return;
            }
            if (!float.TryParse(TB_Price.Text,out _))
            {
                errorProvider1.SetError(button1, "Цена введена неправильно");
                return;
            }
            if (!float.TryParse(TB_Sale.Text, out _))
            {
                errorProvider1.SetError(button1, "Скидка введена неправильно");
                return;
            }
            if (float.Parse(TB_Price.Text)<0)
            {
                errorProvider1.SetError(button1, "Цена должна быть неотрицательной");
                return;
            }
            else
            {
                Product user = new Product(TB_Name.Text, float.Parse(TB_Price.Text), int.Parse(TB_Sale.Text), DTP_StartSale.Value,DTP_EndSale.Value);
                _userPL.Add(user);
                Close();
            }
        }
    }
}
