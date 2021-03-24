using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopWInForm
{
    public class Product
    {
        public static int _incID = 0;
        private int _id;
        private string _nameProduct;
        private double _priceProduct;
        private int _sale;
        private DateTime? _dateTimeSaleStart;
        private DateTime? _dateTimeSaleEnd;

        public Product(string nameProduct, double priceProduct, int sale, DateTime? dtStart, DateTime? dtEnd)
        {
            _id = _incID;
            _nameProduct = nameProduct;
            _priceProduct = priceProduct;
            _sale = sale;
            _dateTimeSaleStart = dtStart;
            _dateTimeSaleEnd = dtEnd;
            _incID++;
        }

        public Product()
        {
        }

        public override string ToString()
        {
            return "[id=" + _id +
                   "; name=" + _nameProduct +
                   "; price=" + _priceProduct +
                   "; sale=" + _sale +
                   "; discount price=" + (_priceProduct - _priceProduct * (_sale / 100.0)) +
                   "; dtStart=" + _dateTimeSaleStart + "; dtEnd=" + _dateTimeSaleEnd + "]";
        }
        public void SetNameProduct(string nameProduct)
        {
            this._nameProduct = nameProduct;
        }
        public void SetPrice(double priceProduct)
        {
            this._priceProduct = priceProduct;
        }
        public void SetSale(int sale, DateTime? dtStart, DateTime? dtEnd)
        {
            this._sale = sale;
            this._dateTimeSaleStart = dtStart;
            this._dateTimeSaleEnd = dtEnd;
        }
        public void SetAll(string nameProduct, double priceProduct, int sale)
        {
            this._nameProduct = nameProduct;
            this._priceProduct = priceProduct;
            this._sale = sale;
        }
        public int GetId()
        {
            return _id;
        }
        public string GetData()
        {
            return _nameProduct + " " + _priceProduct + " " + _sale + " " + _dateTimeSaleStart + _dateTimeSaleEnd;
        }
        public int GetSale()
        {
            return this._sale;
        }
        public string GetName()
        {
            return this._nameProduct;
        }
        public double GetPrice()
        {
            return this._priceProduct;
        }
        public DateTime? GetStartSale()
        {
            return this._dateTimeSaleStart;
        }

        public DateTime? GetEndSale()
        {
            return this._dateTimeSaleEnd;
        }
    }
}
