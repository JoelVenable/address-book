using System;
using System.Collections.Generic;


namespace address_book
{
  class AddressBook
  {
    private List<Contact> _contacts;

    public void AddContact(Contact newContact)
    {
      _contacts.Add(newContact);
    }
  }
}