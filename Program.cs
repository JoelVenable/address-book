using System;
using System.Collections.Generic;

namespace address_book
{
  class Program
  {
    static void Main(string[] args)
    {
      Contact bob = new Contact()
      {
        FirstName = "Bob",
        LastName = "Smith",
        Email = "bob.smith@email.com",
        Address = "100 Some Ln, Testville, TN 11111"
      };
      Contact sue = new Contact()
      {
        FirstName = "Sue",
        LastName = "Jones",
        Email = "sue.jones@email.com",
        Address = "322 Hard Way, Testville, TN 11111"
      };
      Contact juan = new Contact()
      {
        FirstName = "Juan",
        LastName = "Lopez",
        Email = "juan.lopez@email.com",
        Address = "888 Easy St, Testville, TN 11111"
      };


      AddressBook addressBook = new AddressBook();

      addressBook.AddContact(bob);
      addressBook.AddContact(sue);
      addressBook.AddContact(juan);

      // Let's see what happens...
      addressBook.AddContact(sue);



      List<string> emails = new List<string>() {
          "sue.jones@email.com",
          "juan.lopez@email.com",
          "bob.smith@email.com"
      };

      // Insert an email that does NOT match a contact...
      emails.Insert(1, "not-in-addressbook@email.com");

      emails.ForEach(email =>
      {
          try
          {
        Contact contact = addressBook.GetByEmail(email);
        Console.WriteLine("-----------------------");
        Console.WriteLine($"Name: {contact.FirstName} {contact.LastName}");
        Console.WriteLine($"Email: {contact.Email}");
        Console.WriteLine($"Address: {contact.Address}");
          }
          catch (NullReferenceException ex)
          {
              Console.WriteLine($"No contact found with email address: {email}");
          }
      });



    }
  }
}
