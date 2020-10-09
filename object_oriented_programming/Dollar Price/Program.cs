using System;

namespace Dollar_Price
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Qual é a cotação do dóldar?");
            double priceDollar = double.Parse(Console.ReadLine());
            Console.WriteLine("Quantos dólares você vai comprar?");
            double qtd = double.Parse(Console.ReadLine());
            Console.WriteLine("Valor a ser pago em reais = " + CurrencyConverter.Converter(priceDollar, qtd));
        }
    }
}
