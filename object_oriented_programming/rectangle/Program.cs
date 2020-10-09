using Rectangle;
using System;

namespace rectangle
{
    class Program
    {
        static void Main(string[] args)
        {
            RectangleC r;

            r = new RectangleC();
            
            Console.WriteLine("Entre a largura e altura do retângulo: ");
            r.Width = double.Parse(Console.ReadLine());
            r.Height = double.Parse(Console.ReadLine());

            Console.WriteLine("AREA = " + r.Area().ToString("F2"));
            Console.WriteLine("PERÍMETRO = " + r.Perimeter().ToString("F2"));
            Console.WriteLine("DIAGONAL = " + r.Diagonal().ToString("F2"));
        }
    }
}
