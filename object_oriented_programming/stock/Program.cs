using System;

namespace stock
{
    class Program
    {
        static void Main(string[] args)
        {
            Product p1;

            p1 = new Product();

            Console.WriteLine("Entre os dados do produto: ");
            Console.Write("Nome: ");
            p1.Name = Console.ReadLine();
            Console.Write("Preco: ");
            p1.Price = double.Parse(Console.ReadLine());
            Console.Write("Quantidade no estoque: ");
            p1.Stoque = int.Parse(Console.ReadLine());

            Console.WriteLine("Dados do produto: " + p1);
            Console.Write("Digite o número de produtos a ser adicionado ao estoque: ");
            int quantity = int.Parse(Console.ReadLine());
            p1.AddProducts(quantity);
            Console.WriteLine("Dados atualizados: " + p1);
            Console.Write("Digite o número de produtos a ser removido ao estoque: ");
            quantity = int.Parse(Console.ReadLine());
            p1.RemoveProducts(quantity);
            Console.WriteLine("Dados atualizados: " + p1);




        }
    }
}
