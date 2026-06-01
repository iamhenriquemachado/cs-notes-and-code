using System;
using System.Collections.Generic;

namespace cs_notes_and_code.challenges.ContactBook
{
    internal class ContactBook
    {
        public void AddContact(List<Contact> myContacts, int id, string name, string phone, string? email)
        {
            Contact newContact = new Contact
            {   Id = id, 
                Name = name,
                Phone = phone,
                Email = email ?? "No Email Provided"
            };

            myContacts.Add(newContact);
            Console.WriteLine($"Contact added to the list...");
            Console.WriteLine($"Contact Data -  Name {name}, Phone {phone}, Email {email}");
        }

        public void RemoveContact(List<Contact> myContacts, int id)
        {
            
            for (int i = 0; i < myContacts.Count; i--)
            {
                if (myContacts[i].Id == id)
                {
                    myContacts.RemoveAt(i);
                    Console.WriteLine("Contact removed");
                } else
                {
                    Console.WriteLine("Contact not found");
                }
            }   
        }

        public void ListContacts(List<Contact> myContacts)
        {
            foreach (var contact in myContacts)
            {
                Console.WriteLine("Loading list of contacts...");
                Console.WriteLine($"Name: {contact.Name}, Email: {contact.Email}, Phone: {contact.Phone}");
            }
        }
    }
}