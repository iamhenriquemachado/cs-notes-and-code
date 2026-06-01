using System;
using System.Collections.Generic;

namespace cs_notes_and_code.challenges.ContactBook
{
    internal class ContactBook
    {

        HashSet<string> _registeredEmail = new HashSet<string>();
        Dictionary<string, Contact> contactList = new Dictionary<string, Contact>();
        public void AddContact(Dictionary<string, Contact> c, int id, string name, string phone, string? email)
        {
            Contact newContact = new Contact
            {   Id = id, 
                Name = name,
                Phone = phone,
                Email = email ?? "No Email Provided"
            };

            string normalizedEmail = email.ToLower();

            if (_registeredEmail.Contains(normalizedEmail))
            {
                Console.WriteLine($"Email already registered in the application {normalizedEmail}");
                return;
            }

            myContacts.Add(newContact);
            Console.WriteLine($"Contact added to the list...");
            Console.WriteLine($"Contact Data -  Name {name}, Phone {phone}, Email {email}");
        }

        public void RemoveContact(List<Contact> myContacts, int id)
        {

            bool found = false;

            for (int i = myContacts.Count - 1; i >= 0; i--)
            {
                if (myContacts[i].Id == id)
                {

                    if (myContacts[i].Email != "No Email Provider")
                    {
                        _registeredEmail.Remove(myContacts[i].Email.ToLower());
                        Console.WriteLine("Email already exists in the list");
                    }
                    myContacts.RemoveAt(i);

                    found = true;
                    Console.WriteLine("Contact removed");
                }
            }

            if (!found)
            {
                Console.WriteLine("Contact ID not found in the list.");
            }
        }

        public void ListContact(Dictionary<string, Contact> contacts, string name)
        {
            foreach (string code in contacts.Keys)
            {
                if (code ==  name)
                {
                    Console.WriteLine($"Contact found");
                }
            }
             //for (int i = contacts.Count - 1; i>= 0; i--)
            //{
            //    if (contacts[i].Name == name)
            //    {
            //        Console.WriteLine($"Contact found: {contacts[i].Name}");
            //    }
            //}
        }
    }
}