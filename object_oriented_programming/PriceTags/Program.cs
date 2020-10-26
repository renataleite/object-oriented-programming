using PriceTags.Entities;
using System;
using System.Collections.Generic;

namespace PriceTags
{
    class Program
    {
        static void Main(string[] args)
        {
            List <Product> list= new List<Product>();

            Console.WriteLine("Enter the number of products: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Product #{i} data:");
                Console.WriteLine("Common, used or imported (c/u/i)?");
                char type = char.Parse(Console.ReadLine());
                Console.WriteLine("Name:");
                string name = Console.ReadLine();
                Console.WriteLine("Price:");
                double price = double.Parse(Console.ReadLine());

                if (type == 'i')
                {
                    Console.WriteLine("Customs fee:");
                    double customs = double.Parse(Console.ReadLine());
                    list.Add(new ImportedProduct(name, price, customs));
                }
                else if (type == 'u')
                {
                    Console.WriteLine("Manufacture date (DD/MM/YYYY):");
                    DateTime manufactureDate = DateTime.Parse(Console.ReadLine());
                    list.Add(new UsedProduct(name, price, manufactureDate));
                }
                else
                {
                    list.Add(new Product(name, price));
                }
            }

            Console.WriteLine("PRICE TAGS: ");

            foreach (Product prod in list)
            {
                Console.WriteLine(prod.PriceTag());
            }

        }
    }
}
