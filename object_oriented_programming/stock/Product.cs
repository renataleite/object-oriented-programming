using System;
using System.Collections.Generic;
using System.Text;

namespace stock
{
    class Product
    {
        private string _name;
        public double Price { get; private set; }
        public int Stock { get; private set; }

        public Product() { }

        public Product(string name, double price, int stoque)
        {
            _name = name;
            Price = price;
            Stock = stoque;
        }

        public Product(string name, double price)
        {
            _name = name;
            Price = price;
            Stock = 0;
        }

        public string Name
        {
            get { return _name; }
            set
            {
                if (value!=null&&value.Length > 1)
                {
                    _name = value;
                }
            }
        }

        
        public double TotalStock()
        {
            return Price * Stock; ;
        }

        public void AddProducts(int quantity)
        {
            Stock += quantity;
        }

        public void RemoveProducts(int quantity)
        {
            Stock = Stock - quantity;
        }

        public override string ToString()
        {
            return _name + ", $" + Price.ToString("F2") + ", " + Stock + " unidades, Total: §" + TotalStock().ToString("F2");
        }
    }
}
