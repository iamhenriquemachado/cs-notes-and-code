using cs_notes_and_code.challenges.NotificationSystem.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_notes_and_code.challenges.NotificationSystem
{
    internal class AlertService
    {

        private readonly INotifier _notifier;

        public AlertService(INotifier notifier)
        {
            _notifier = notifier;
        }

        public void SendAlert(string recipient, string text, DateTime sentDate)
        {
            _notifier.Send(recipient, text, sentDate);
            Console.WriteLine("Message sent to the recipient.");
        }
    }
}
