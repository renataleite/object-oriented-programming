using System;

namespace people_data
{
    class Program
    {
        static void Main(string[] args)
        {
            Person a, b;

            a = new Person();
            b = new Person();

            Console.WriteLine("Dados da primeira pessoa: ");
            a.Name = Console.ReadLine();
            a.Age = int.Parse(Console.ReadLine());

            Console.WriteLine("Dados da primeira pessoa: ");
            a.Name = Console.ReadLine();
            a.Age = int.Parse(Console.ReadLine());
        }
    }
}
