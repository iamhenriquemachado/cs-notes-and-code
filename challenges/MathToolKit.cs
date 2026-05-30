using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_notes_and_code.challenges
{
    internal class MathToolKit
    {
        public static double CalculateHypotenuse(double sideA, double sideB)
        {
            double triangleArea = sideA + sideB;
            return Math.Sqrt(triangleArea);
        }

        public static double CalculatePercentage(double amount, double total = 100.0)
        {
            if (total == 0)
            {
                Console.WriteLine("The total should be greater than 0");
            }
            return (amount / total) * 100;

        }

        public static double Average(int a, int b)
        {
            return (a + b) / 2;
        }

        public static double Average(int a, int b, int c)
        {
            return (a + b + c) / 3;
        }

        public static double Average(double[] numbers)
        {
            double sumArray = numbers.Sum();
            return sumArray / numbers.Length;
        }

        public static int Sum(int a, int b)
        {
            return a + b;
        }

        public static int Subtract(int a, int b)
        {
            return a - b;
        }

        public static int Multiply(int a , int b)
        {
            return a * b;
        }

        public static int Divide(int a , int b)
        {
            if (b == 0)
            {
                throw new DivideByZeroException("Cannot divide by 0");
            }

            else
            {
                return a / b;
            }
        }

        public static double Potentiation(int a, int b)
        {
            return Math.Pow(a, b);
        }
    }


}
