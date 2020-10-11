using System;

namespace stock
{
    class Program
    {
        static void Main(string[] args)
        {
            Product p = new Product("TV", 500.00, 10);

            p.Name = "T";

            Console.WriteLine(p.Name);
            Console.WriteLine(p.Price);

            /*Console.WriteLine("Entre os dados do produto: ");
            Console.Write("Nome: ");
            string name = Console.ReadLine();
            Console.Write("Preco: ");
            double price = double.Parse(Console.ReadLine());
            Console.Write("Quantidade no estoque: ");
            int stock = int.Parse(Console.ReadLine());

            Product p1 = new Product(name, price, stock);

            Product p2 = new Product(name, price);


            Console.WriteLine("Dados do produto: " + p1);
            Console.Write("Digite o número de produtos a ser adicionado ao estoque: ");
            int quantity = int.Parse(Console.ReadLine());
            p1.AddProducts(quantity);
            Console.WriteLine("Dados atualizados: " + p1);
            Console.Write("Digite o número de produtos a ser removido ao estoque: ");
            quantity = int.Parse(Console.ReadLine());
            p1.RemoveProducts(quantity);
            Console.WriteLine("Dados atualizados: " + p1);*/




        }
    }
}
