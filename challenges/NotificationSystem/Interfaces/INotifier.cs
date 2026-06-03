using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_notes_and_code.challenges.NotificationSystem.Interfaces
{
    internal interface INotifier
    {
        void Send(string recipient, string text, DateTime sentDate);
    }
}
