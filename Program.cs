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

    }
  }
}
