using System;
using System.Collections.Generic;
using System.Text;

namespace BankAccount
{
    class Account
    {
        public double Balance { get; private set; }
        public int Number { get; private set; }
        public string Owner { get; set; }

        static double Rate = 5.00;

        public Account(int number, string owner)
        {
            Number = number;
            Owner = owner;
        }

        public Account(double depositInitial, int number, string owner) : this (number, owner)
        {
            Deposit(depositInitial);
        }



        public void Deposit(double deposit)
        {
            Balance += deposit;
        }

        public void Withdraw(double withdraw)
        {
            Balance -= withdraw + Rate;
        }

        public override string ToString()
        {
            return "Conta " + Number + ", Titular: " + Owner + ", Saldo: $ " + Balance.ToString("F2");
        }
    }
}
