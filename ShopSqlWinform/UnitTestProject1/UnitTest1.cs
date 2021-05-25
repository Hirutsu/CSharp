using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using BL;
using BL_Interface;
using Entity_User;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {

        //BL_Product_Interface _userPL = new BL_Product();
        
        [TestMethod]
        [ExpectedException(typeof (ArgumentException),"До###еб,введи нормальную цену")]
        public void ChechedPrise()
        {
            int id = 10;
            string Name = "пиво";
            double Price = -100;
            int Sale = 5;
            DateTime StartSale = new DateTime(2021,12,2);
            DateTime EndSale = new DateTime(2021,12,2);
            var product = new Product(Name, Price, Sale, StartSale, EndSale);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException), "До###еб,введи нормальную скидку")]
        public void ChechedSale()
        {
            int id = 10;
            string Name = "пиво";
            double Price = 150;
            int Sale = 21321;
            DateTime StartSale = new DateTime(2021, 12, 2);
            DateTime EndSale = new DateTime(2021, 12, 2);
            var product = new Product(Name, Price, Sale, StartSale, EndSale);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception), "До###еб,введи название товара")]
        public void ChechedName()
        {
            int id = 10;
            string Name = "";
            double Price = 150;
            int Sale = 5;
            DateTime StartSale = new DateTime(2021, 12, 2);
            DateTime EndSale = new DateTime(2021, 12, 2);
            var product = new Product(Name, Price, Sale, StartSale, EndSale);
        }
    }
}
