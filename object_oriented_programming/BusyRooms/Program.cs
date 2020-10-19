using System;
using System.Numerics;

namespace BusyRooms
{
    class Program
    {
        static void Main(string[] args)
        {
            Guest[] vect = new Guest[10];

            Console.WriteLine("How many rooms will be rented?");
            int n = int.Parse(Console.ReadLine());

            for(int i = 1; i<=n; i++)
            {
                Console.WriteLine($"Rent #{i}:");
                Console.Write("Name:");
                string name = Console.ReadLine();
                Console.Write("Email:");
                string email = Console.ReadLine();
                Console.Write("Room:");
                int room = int.Parse(Console.ReadLine());
                vect[room] = new Guest(name, email);
            }

            Console.WriteLine("Busy rooms: ");
            for(int i = 0; i<10; i++)
            {
                if (vect[i] != null)
                {
                    Console.WriteLine(i + ": " + vect[i]);
                }
            }
        }
    }
}
