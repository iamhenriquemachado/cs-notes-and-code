using cs_notes_and_code.challenges.ContactBook;


// Instantiate the class 
ContactBook cBook = new ContactBook();
List<Contact> c = new List<Contact>();


Contact listOfContacts = new Contact { 
    Id = 1,
    Name = "Henrique de Castro Machado",
    Phone = "+5517991886146",
    Email = "heyhenriquecastro@gmail.com"
};

//string name = "Henrique de Castro Machado";
//string phone = "+5517991886146";
//string? email = "heyhenriquecastro@gmail.com";


cBook.AddContact(c, listOfContacts.Id, listOfContacts.Name, listOfContacts.Phone, listOfContacts.Email);

cBook.RemoveContact(c, 1);


cBook.ListContacts(c);