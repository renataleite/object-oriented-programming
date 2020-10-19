using System;

namespace RefAndOut
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            int result;
            Calculator.Triple(ref a);
            Calculator.Double(a, out result);
            Console.WriteLine(a);
            Console.WriteLine(result);
        }
    }
}
