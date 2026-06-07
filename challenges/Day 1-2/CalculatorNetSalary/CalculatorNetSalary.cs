using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_notes_and_code.challenges.CalculatorNetSalary
{
    public class CalculatorNetSalary
    {
        public CalculatorNetSalary()
        {

        }

        public void CalculateNetSalary(string salaryValue)
        {
            Console.WriteLine("Hello! Please, insert your salary.");

            salaryValue = Console.ReadLine();

            float rateInss = 11.0F;
            float rateIrpf = 0;

            if (!int.TryParse(salaryValue, out int result))
            {
                Console.WriteLine("Not a valid number. Please, check and try again.");
                result = Convert.ToInt32(Console.ReadLine());
            }

            if (result >= 2112 && result <= 2826)
            {
                rateIrpf = 7.5F;
            }
            else if (result > 2826 && result <= 3751)
            {
                rateIrpf = 15.0F;
            }

            float descontos = result * ((rateInss + rateIrpf) / 100);
            double salarioLiquido = result - descontos;

            Console.WriteLine($"O salário líquido é: {salarioLiquido}");
        }

    }
}
