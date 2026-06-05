using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_notes_and_code.challenges.EmployeeSystem
{
    internal abstract class Employee
    {
        public string Name { get; set; }
        public decimal BaseSalary { get; set; }

        // it obbligates child class to reference and implement it when calling the constructor
        public Employee(string name, decimal baseSalary) {Name = name; BaseSalary = baseSalary; }

        // abstract method that needs to be implemented by the child class with its own logic. 
        public abstract decimal GetBonus();
    }
}
