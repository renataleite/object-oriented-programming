using System;
using System.Collections.Generic;
using System.Text;

namespace stock
{
    class Product
    {
        public string Name;
        public double Price;
        public int Stoque;

        public double TotalStock()
        {
            return Price * Stoque; ;
        }

        public void AddProducts(int quantity)
        {
            Stoque += quantity;
        }

        public void RemoveProducts(int quantity)
        {
            Stoque = Stoque - quantity;
        }

        public override string ToString()
        {
            return Name + ", $" + Price.ToString("F2") + ", " + Stoque + " unidades, Total: §" + TotalStock().ToString("F2");
        }
    }
}
