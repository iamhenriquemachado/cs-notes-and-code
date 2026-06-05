using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_notes_and_code.challenges.NotificationSystem
{
    internal abstract class Message
    {
        public string Recipient { get; set; }
        public string Text { get; set; }

        public DateTime DateSent { get; set; }
        public Message(string recipient, string message, DateTime dateSent)
        {
            Recipient = recipient;
            Text = message;
            DateSent = dateSent;
        }
    }
}
