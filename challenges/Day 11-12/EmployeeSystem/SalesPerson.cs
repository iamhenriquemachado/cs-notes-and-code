using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_notes_and_code.challenges.EmployeeSystem
{
    internal class SalesPerson : Employee
    {
        public decimal Comission { get; set; }
        public SalesPerson(string name, decimal baseSalary, decimal comissionValue) : base(name, baseSalary)
        {
            Comission = comissionValue;
        }

        public override decimal GetBonus()
        {
            return BaseSalary * 0.15m * Comission;
        }
    }
}
