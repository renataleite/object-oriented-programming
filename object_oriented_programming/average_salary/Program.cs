using System;

namespace average_salary
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee e1, e2;

            e1 = new Employee();
            e2 = new Employee();

            Console.WriteLine("Dados do primeiro funcionário: ");
            Console.Write("Nome: ");
            e1.Name = Console.ReadLine();
            Console.Write("Salário: ");
            e1.Salary = double.Parse(Console.ReadLine());

            Console.WriteLine("Dados do segundo funcionário: ");
            Console.Write("Nome: ");
            e2.Name = Console.ReadLine();
            Console.Write("Salário: ");
            e2.Salary = double.Parse(Console.ReadLine());

            double average = (e1.Salary + e2.Salary) / 2;

            Console.WriteLine("Salário médio = " + average.ToString("F2"));
        }
    }
}
