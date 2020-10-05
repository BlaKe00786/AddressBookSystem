using System;
using System.Collections.Generic;
using System.Text;

namespace AddressBookSystemProject
{
    public interface IContacts
    {
        public void AddContact(string FirstName, string LastName, string Address, string City, string State, string Zip, string PhoneNumber, string Email);
        public void DisplayContacts();
        public void EditContact(string FirstName);
        public void DeleteContact(string FirstName);
    }
}
