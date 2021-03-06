﻿using System;

namespace Lab2.Models
{
    public class Employee: ICloneable
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double Salary { get; set; }
        public bool IsFree { get; set; }

        public Employee()
        {
            IsFree = true;
        }

        public Employee(string firstName, string lastName, double salary) : this()
        {
            FirstName = firstName;
            LastName = lastName;
            Salary = salary;
        }

        public object Clone()
        {
            return new Employee(FirstName, LastName, Salary);
        }
    }
}