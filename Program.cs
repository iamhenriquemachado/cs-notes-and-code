using cs_notes_and_code.challenges.ContactBook;


Contact contact = new Contact() { Name = "John Smith", Phone = "+15551234567", Email = "john.smith@email.com" };

ContactBook cOperations = new ContactBook();

cOperations.AddContact(111, contact.Name, contact.Phone, contact.Email);