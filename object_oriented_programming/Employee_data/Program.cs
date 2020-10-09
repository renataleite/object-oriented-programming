using System;

namespace Employee_data
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee e;

            e = new Employee();

            Console.Write("Nome: ");
            e.Name = Console.ReadLine();
            Console.Write("Salário bruto: ");
            e.Salary = double.Parse(Console.ReadLine());
            Console.Write("Imposto: ");
            e.Tax = double.Parse(Console.ReadLine());

            Console.WriteLine("Funcionário: " + e);
            Console.WriteLine("Digite a porcentagem para aumentar o salário: ");
            double percentagem = double.Parse(Console.ReadLine());
            e.IncreaseSalary(percentagem);
            Console.WriteLine("Dados atualizados: " + e);
        }
    }
}
