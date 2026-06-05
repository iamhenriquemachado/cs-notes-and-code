using System;
using System.Collections.Generic;

namespace cs_notes_and_code.challenges.ContactBook
{
    internal class ContactBook
    {
        private HashSet<string> _registeredEmail = new HashSet<string>();
        private Dictionary<int, Contact> _contactList = new Dictionary<int, Contact>();

        public void AddContact(int uniqueId, string name, string phone, string? email)
        {
            if (email != null)
            {
                string normalizedEmail = email.ToLower().Trim();

                if (_registeredEmail.Contains(normalizedEmail))
                {
                    Console.WriteLine($"Email already registered in the application {normalizedEmail}");
                    return;
                }

                Contact newContact = new Contact
                {
                    Name = name,
                    Phone = phone,
                    Email = email ?? "No Email Provided"
                };
                _contactList.Add(uniqueId, newContact);

                _registeredEmail.Add(normalizedEmail);
            }

            Console.WriteLine($"Contact {name} added with ID {uniqueId}!");
        }

        public void RemoveContactById(int id)
        {
            bool found = false;

            if (_contactList.TryGetValue(id, out var contact))
            {
                var email = contact.Email;

                if (email != "No Email Provided")
                {
                    _registeredEmail.Remove(email);
                }

                _contactList.Remove(id);
                found = true;

                Console.WriteLine("Contact removed");
            }

            if (!found)
            {
                Console.WriteLine("Contact ID not found in the list.");
            }
        }

        public void ListContact()
        {
            foreach (var contact in _contactList.Values)
            {
                Console.WriteLine($"Refreshing... Contact List: {contact.Name} - {contact.Email} - {contact.Phone}");
            }
        }
    }
}