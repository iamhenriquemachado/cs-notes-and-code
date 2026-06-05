using cs_notes_and_code.challenges.NotificationSystem.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_notes_and_code.challenges.NotificationSystem
{
    internal class SmsNotifier : INotifier
    {

        public void Send(string recipient, string text, DateTime dateSent)
        {
            Console.WriteLine($"Sending Sms To {recipient}... Please, wait!");
            Console.WriteLine($"Sms Message: {text}");
            Console.WriteLine($"Date Sent: {dateSent}");
        }
    }
}
