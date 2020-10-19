﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ListExercise
{
    class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }

        public Employee(int id, string name, double salary)
        {
            Id = id;
            Name = name;
            Salary = salary;
        }

        public void IncreaseSalary(double pertentage)
        {
            Salary = Salary * (1 + pertentage /100.0);
        }

        public override string ToString()
        {
            return Id
                + ", "
                + Name
                + ", "
                + Salary.ToString("F2");
        }
    }
}
