using AddressBook.Core.Models;
using System;
 
namespace AddressBook.Application.Services
{
    public class AddressBookService
    {
        private readonly List<Contact> _contacts = new List<Contact>();

        public void AddContact(Contact contact)
        {
            _contacts.Add(contact);
        }

        public IEnumerable<Contact> GetAllContacts()
        {
            return _contacts;
        }
    }
}
