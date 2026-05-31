using System;
using System.Collections.Generic;

namespace cs_notes_and_code.challenges.ContactBook
{
    internal class ContactBook
    {
        public void AddContact(List<Contact> myContacts, string name, string phone, string? email)
        {
            Contact newContact = new Contact
            {
                Name = name,
                Phone = phone,
                Email = email ?? "No Email Provided"
            };

            myContacts.Add(newContact);
        }

        public void ListContacts(List<Contact> myContacts)
        {
            foreach (var contact in myContacts)
            {
                Console.WriteLine($"Name: {contact.Name}, Email: {contact.Email}, Phone: {contact.Phone}");
            }
        }
    }
}