using System;
using System.Collections.Generic;
using System.Text;

namespace Dollar_Price
{
    class CurrencyConverter
    {
        public static double IOF = 0.06;

        public static double Converter(double dollarP, double quantity)
        {
            return dollarP * quantity * (1 + IOF);
        }
    }
}
