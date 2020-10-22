using CompositionAndEnum.Entities;
using CompositionAndEnum.Entities.Enums;
using System;

namespace CompositionAndEnum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter cliente data:");
            Console.Write("Name: ");
            string clientName = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("Birth date (DD/MM/YYYY): ");
            DateTime birthDate = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Enter order data");
            Console.Write("Status: ");
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());

            Client client1 = new Client(clientName, email, birthDate);
            Order order = new Order(DateTime.Now, status, client1);

            Console.Write("How many items to this order? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i<=n; i++)
            {
                Console.WriteLine($"Enter #{i} item data");
                Console.Write("Product name: ");
                string productName = Console.ReadLine();
                Console.Write("Product price: ");
                double price = double.Parse(Console.ReadLine());

                Product product = new Product(productName, price);

                Console.Write("Quantity:");
                int quantity = int.Parse(Console.ReadLine());

                OrderItem orderItem = new OrderItem(quantity, price, product);

                order.AddItem(orderItem);
            }



            Console.WriteLine("Order Summary: ");
            Console.WriteLine(order);

        }
    }
}
