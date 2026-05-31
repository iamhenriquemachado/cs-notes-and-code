using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_notes_and_code.challenges.ContactBook
{
    internal class ContactBook
    {

       
        public void ListContacts(List<Contact> myContacts)
        {
            foreach(var contact in myContacts)
            {
                Console.WriteLine($"List of contacts: {contact.Name},s {contact.Email}, {contact.Phone}");
            }
        }
    }
}
