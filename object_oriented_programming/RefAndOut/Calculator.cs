using System;
using System.Collections.Generic;
using System.Text;

namespace RefAndOut
{
    class Calculator
    {
        public static void Triple(ref int x)
        {
            x = x * 3;
        }
        public static void Double(int x, out int result)
        {
            result = x * 2;
        }
    }
}
