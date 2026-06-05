using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace cs_notes_and_code.challenges.EmployeeSystem
{
    internal class Manager : Employee
    {

        public Manager(string name, decimal baseSalary) : base(name, baseSalary)
        {

        }

        public override decimal GetBonus()
        {
            return BaseSalary * 0.30m + 500; ;
        }
    }
}


