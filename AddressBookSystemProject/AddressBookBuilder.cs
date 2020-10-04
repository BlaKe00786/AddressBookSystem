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
            }
        }
        public void EditContact(string FirstName)
        {
            int flag = 1;
            foreach (KeyValuePair<string, Contacts> dict in dictionary)
            {
                if(FirstName.Equals(dict.Key))
                {
                    flag = 0;
                    Console.WriteLine("Enter Last Name : ");
                    dict.Value.LastName = Console.ReadLine();
                    Console.WriteLine("Enter Address: ");
                    dict.Value.Address = Console.ReadLine();
                    Console.WriteLine("Enter City : ");
                    dict.Value.City = Console.ReadLine();
                    Console.WriteLine("Enter State : ");
                    dict.Value.State = Console.ReadLine();
                    Console.WriteLine("Enter Zip code : ");
                    dict.Value.Zip = Console.ReadLine();
                    Console.WriteLine("Enter Phone Number : ");
                    dict.Value.PhoneNumber = Console.ReadLine();
                    Console.WriteLine("Enter Email : ");
                    dict.Value.Email = Console.ReadLine();

                }
            }
            if(flag==1)
            {
                Console.WriteLine("Contact not found!");
            }
        }
    }
}
