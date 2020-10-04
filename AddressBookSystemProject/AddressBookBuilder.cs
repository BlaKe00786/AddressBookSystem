using System;
using System.Collections.Generic;
using System.Text;

namespace AddressBookSystemProject
{
    class AddressBookBuilder : IContacts
    {
        public Dictionary<string, Contacts> dictionary;
        public AddressBookBuilder()
        {
            this.dictionary = new Dictionary<string, Contacts>();
        }
        public void AddContact(string FirstName, string LastName, string Address, string City, string State, string Zip, string PhoneNumber, string Email)
        {
            Contacts contact = new Contacts(FirstName,LastName,Address,City,State,Zip,PhoneNumber,Email);
            dictionary.Add(FirstName,contact);
        }
        public void DisplayContacts()
        {
            foreach (KeyValuePair<string, Contacts> dict in dictionary)
            {
                Console.WriteLine("First Name : " + dict.Value.FirstName);
                Console.WriteLine("Last Name : " + dict.Value.LastName);
                Console.WriteLine("Address : " + dict.Value.Address);
                Console.WriteLine("City : " + dict.Value.City);
                Console.WriteLine("State : " + dict.Value.State);
                Console.WriteLine("Zip : " + dict.Value.Zip);
                Console.WriteLine("Phone Number : " + dict.Value.PhoneNumber);
                Console.WriteLine("Email : " + dict.Value.Email);
                //textBox3.Text += string.Format("Key = {0}, Value = {1}", kvp.Key, kvp.Value);
            }
        }
    }
}
