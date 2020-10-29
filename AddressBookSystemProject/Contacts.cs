using System;
using System.Collections.Generic;
using System.Text;

namespace AddressBookSystemProject
{
   public class Contacts
    {
        public string FirstName { get; set; }
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
        public override string ToString()
        {
            return FirstName + "\n" + LastName + "\n" + Address + "\n" + City + "\n" + State + "\n" + Zip + "\n" + PhoneNumber + "\n" + Email;
        }
    }
}
