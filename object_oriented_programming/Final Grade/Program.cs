using System;

namespace Final_Grade
{
    class Program
    {
        static void Main(string[] args)
        {
            Student s;

            s = new Student();

            Console.Write("Nome do aluno: ");
            s.Name = Console.ReadLine();
            Console.WriteLine("Digite as três notas do aluno");
            s.Grade1 = double.Parse(Console.ReadLine());
            s.Grade2 = double.Parse(Console.ReadLine());
            s.Grade3 = double.Parse(Console.ReadLine());
            Console.WriteLine("NOTA FINAL = " + s.AddGrade().ToString("F2"));
            if (s.Approved())
            {
                Console.WriteLine("Aprovado");
            }
            else
            {
                Console.WriteLine("Reprovado");
                Console.WriteLine("Faltaram " + s.PointsToGo().ToString("F2") + " pontos");
            }
        }
    }
}
