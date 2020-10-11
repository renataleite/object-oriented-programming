using System;

namespace BankAccount
{
    class Program
    {
        static void Main(string[] args)
        {
            Account account;

            Console.Write("Entre o número da conta: ");
            int number = int.Parse(Console.ReadLine());

            Console.Write("Entre o titular da conta: ");
            string name = Console.ReadLine();

            Console.Write("Haverá depósito inicial (s/n)?");
            char answer = char.Parse(Console.ReadLine());


            if (answer == 's')
            {
                Console.Write("Entre um valor para depósito: ");
                double initialDeposit = double.Parse(Console.ReadLine());
                account = new Account(initialDeposit, number, name);
            }
            else
            {
                account = new Account(number, name);
            }
            Console.WriteLine("Dados da conta:");
            Console.WriteLine(account);
            Console.Write("Entre um valor para depósito: ");
            double deposit = double.Parse(Console.ReadLine());
            account.Deposit(deposit);
            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(account);
            Console.Write("Entre um valor para saque: ");
            double withdraw = double.Parse(Console.ReadLine());
            account.Withdraw(withdraw);
            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(account);
        }
    }
}
