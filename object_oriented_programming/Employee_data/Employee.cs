using System;
using System.Collections.Generic;
using System.Text;

namespace Employee_data
{
    class Employee
    {
        public string Name;
        public double Salary;
        public double Tax;


        public double NetSalary()
        {
            return Salary - Tax;
        }

        public void IncreaseSalary(double percentage)
        {
            Salary = (percentage/100 + 1) * Salary;

        }

        public override string ToString()
        {
            return Name + ", $ " + NetSalary().ToString("F2");
        }

    }
}
