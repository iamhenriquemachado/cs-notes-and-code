using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_notes_and_code.challenges.Day_21_22.FuncEventHandler
{
    internal class ConsoleFleetLogger : IFleetLogger
    {
        public void LogInfo(string message)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($"[INFO - {DateTime.Now:HH:mm:ss}: {message}");
            Console.ResetColor();
        }

        public void LogWarning(string message)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"[WARNING - {DateTime.Now:HH:mm:ss}: {message}");
            Console.ResetColor();
        }
    }
}
