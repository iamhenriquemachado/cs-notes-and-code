using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_notes_and_code.challenges.EmployeeSystem
{
    internal class Intern : Employee
    {

        public Intern(string name, decimal baseSalary) : base(name, baseSalary)
        {
            // Implement the base class
        }

        public override decimal GetBonus()
        {
            return BaseSalary * 0.05m;
        }
    }
}
