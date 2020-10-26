using System;
using System.Collections.Generic;
using System.Text;

namespace PriceTags.Entities
{
    class ImportedProduct : Product
    {
        public double CustmsFee { get; set; }

        public ImportedProduct()
        {

        }

        public ImportedProduct(string name, double price, double custmsFee) : base(name, price)
        {
            CustmsFee = custmsFee;
        }

        public double TotalPrice()
        {
            return Price + CustmsFee;
        }

        public override string PriceTag()
        {
            return Name + " $ " + TotalPrice().ToString("F2") + "(Customs fee: $" + CustmsFee.ToString("F2") + ")";
        }
    }
}
