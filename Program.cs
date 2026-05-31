using cs_notes_and_code.challenges.ContactBook;

Console.WriteLine("Contact Book. Program started...");
Console.WriteLine("Listing contacts...");

List<Contact> contacts = new List<Contact>();

Contact newContact = new Contact { Name = "Henrique", Phone = "17991886146" };

contacts.Add(newContact);

foreach(var contact in contacts)
{
    Console.WriteLine($"Contact list is ready... {contact.Name}, {contact.Phone}");
}