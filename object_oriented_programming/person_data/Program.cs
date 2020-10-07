using System;

namespace person_data
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1, p2;

            p1 = new Person();
            p2 = new Person();

            Console.WriteLine("Dados da primeira pessoa:");
            p1.Name = Console.ReadLine();
            p1.Age = int.Parse(Console.ReadLine());

            Console.WriteLine("Dados da segunda pessoa:");
            p2.Name = Console.ReadLine();
            p2.Age = int.Parse(Console.ReadLine());

            string velha = "";
            if (p1.Age> p2.Age)
            {
                velha = p1.Name;
            }
            else
            {
                velha = p2.Name;
            }

            Console.WriteLine("Pessoa mais velha: " + velha);
        }
    }
}
