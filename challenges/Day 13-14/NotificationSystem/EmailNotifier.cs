using cs_notes_and_code.challenges.NotificationSystem.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_notes_and_code.challenges.NotificationSystem
{
    internal class EmailNotifier : INotifier
    {

        public void Send(string recipient, string text, DateTime dateSent)
        {
            Console.WriteLine($"Recipient: {recipient}");
            Console.WriteLine($"Message: {text}");
            Console.WriteLine($"Date Sent: {dateSent}");

        }
    }
}
