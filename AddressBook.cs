using System;
using System.Collections.Generic;


namespace address_book
{
  class AddressBook
  {
    private List<Contact> _contacts = new List<Contact>();

    public void AddContact(Contact newContact)
    {
      _contacts.Add(newContact);
    }

    public Contact GetByEmail(string emailToFind){
      return _contacts.Find(contact => contact.Email == emailToFind);
    }
  }
}