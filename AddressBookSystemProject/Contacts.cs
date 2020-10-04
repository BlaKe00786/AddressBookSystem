using System;
using System.Collections.Generic;
using System.Text;

namespace AddressBookSystemProject
{
    class Contacts
    {
        public string FirstName;
        public string LastName;
        public string Address;
        public string City;
        public string State;
        public string Zip;
        public string PhoneNumber;
        public string Email;
        public Contacts(string FirstName, string LastName, string Address, string City, string State, string Zip, string PhoneNumber, string Email)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Address = Address;
            this.City = City;
            this.State = State;
            this.Zip = Zip;
            this.PhoneNumber = PhoneNumber;
            this.Email = Email;
        }
    }
    public interface IContacts
    {
        public void AddContact(string FirstName, string LastName, string Address, string City, string State, string Zip, string PhoneNumber, string Email);
        public void DisplayContacts();
        public void EditContact(string FirstName);
    }
}
