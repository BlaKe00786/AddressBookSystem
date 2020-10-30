using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AddressBookSystemProject
{
   public class AddressBookBuilder : IContacts
    {
        public List<Contacts> contactList;
        public AddressBookBuilder()
        {
            this.contactList = new List<Contacts>();
        }
        public void AddContact(string FirstName, string LastName, string Address, string City, string State, string Zip, string PhoneNumber, string Email)
        {
            bool duplicate = equals(FirstName);
            if (!duplicate)
            {
                Contacts contact = new Contacts(FirstName, LastName, Address, City, State, Zip, PhoneNumber, Email);
                contactList.Add(contact);
            }
            else
                Console.WriteLine("Cannot add duplicate Contact first name");
        }
        private bool equals(string firstName)
        {
            if (this.contactList.Any(e => e.FirstName == firstName))
                return true;
            else
                return false;
        }
        public void DisplayContacts()
        {
            foreach (Contacts contact in contactList)
            {
                Console.WriteLine("First Name : " + contact.FirstName);
                Console.WriteLine("Last Name : " + contact.LastName);
                Console.WriteLine("Address : " + contact.Address);
                Console.WriteLine("City : " + contact.City);
                Console.WriteLine("State : " + contact.State);
                Console.WriteLine("Zip : " + contact.Zip);
                Console.WriteLine("Phone Number : " + contact.PhoneNumber);
                Console.WriteLine("Email : " + contact.Email);
            }
        }
        public void EditContact(string FirstName)
        {
            int flag = 1;
            foreach (Contacts contact in contactList)
            {
                if(FirstName.Equals(contact.FirstName))
                {
                    flag = 0;
                    Console.WriteLine("Enter Last Name : ");
                    contact.LastName = Console.ReadLine();
                    Console.WriteLine("Enter Address: ");
                    contact.Address = Console.ReadLine();
                    Console.WriteLine("Enter City : ");
                    contact.City = Console.ReadLine();
                    Console.WriteLine("Enter State : ");
                    contact.State = Console.ReadLine();
                    Console.WriteLine("Enter Zip code : ");
                    contact.Zip = Console.ReadLine();
                    Console.WriteLine("Enter Phone Number : ");
                    contact.PhoneNumber = Console.ReadLine();
                    Console.WriteLine("Enter Email : ");
                    contact.Email = Console.ReadLine();
                }
            }
            if(flag==1)
            {
                Console.WriteLine("Contact not found!");
            }
        }
        public void DeleteContact(string FirstName)
        {
            int flag = 1;
            foreach (Contacts contact in contactList)
            {
                if (FirstName.Equals(contact.FirstName))
                {
                    flag = 0;
                    contactList.Remove(contact);
                    Console.WriteLine("Successfully Deleted!");
                    break;
                }
            }
            if(flag==1)
            {
                Console.WriteLine("Contact not found!");
            }
        }
        public List<String> findPersonsInCity(string place)
        {
            List<String> personsFounded = new List<string>();
            foreach (Contacts contact in contactList.FindAll(e => (e.City.Equals(place))).ToList())
            {
                string name = contact.FirstName + " " + contact.LastName;
                personsFounded.Add(name);
            }
            if (personsFounded.Count == 0)
            {
                foreach (Contacts contact in contactList.FindAll(e => (e.State.Equals(place))).ToList())
                {
                    string name = contact.FirstName + " " + contact.LastName;
                    personsFounded.Add(name);
                }
            }
            return personsFounded;
        }
        public List<String> findPersonsInState(string place)
        {
            List<String> personsFounded = new List<string>();
            foreach (Contacts contact in contactList.FindAll(e => (e.State.Equals(place))).ToList())
            {
                string name = contact.FirstName + " " + contact.LastName;
                personsFounded.Add(name);
            }
            return personsFounded;
        }
        public int findNumberOfPersonsInCity(string place)
        {
            int numberOfPersonsFound = contactList.FindAll(e => (e.City.Equals(place))).Count;
            return numberOfPersonsFound;
        }
        public int findNumberOfPersonsInState(string place)
        {
            int numberOfPersonsFound = contactList.FindAll(e => (e.State.Equals(place))).Count;
            return numberOfPersonsFound;
        }
        public void sortByFirstName()
        {
            List<string> sortList = new List<string>();
            foreach (Contacts contact in contactList)
            {
                string sort = contact.ToString();
                sortList.Add(sort);
            }
            sortList.Sort();
            foreach (string entry in sortList)
            {
                Console.WriteLine(entry);
            }
        }
        public void sortByZip()
        {
            contactList.Sort(new Comparison<Contacts>((x, y) => string.Compare(x.Zip, y.Zip)));
            foreach (Contacts contact in contactList)
            {
                Console.WriteLine(contact.FirstName + "\n" + contact.LastName + "\n" + contact.Address + "\n" + contact.City + "\n" + contact.State + "\n" + contact.Zip + "\n" + contact.PhoneNumber + "\n" + contact.Email);
            }

        }
        public void sortByCity()
        {
            contactList.Sort(new Comparison<Contacts>((x, y) => string.Compare(x.City, y.City)));
            foreach (Contacts contact in contactList)
            {
                Console.WriteLine(contact.FirstName + "\n" + contact.LastName + "\n" + contact.Address + "\n" + contact.City + "\n" + contact.State + "\n" + contact.Zip + "\n" + contact.PhoneNumber + "\n" + contact.Email);
            }

        }
        public void SortByState()
        {
            contactList.Sort(new Comparison<Contacts>((x, y) => string.Compare(x.State, y.State)));
            foreach (Contacts contact in contactList)
            {
                Console.WriteLine(contact.FirstName + "\n" + contact.LastName + "\n" + contact.Address + "\n" + contact.City + "\n" + contact.State + "\n" + contact.Zip + "\n" + contact.PhoneNumber + "\n" + contact.Email);
            }
        }
        public void storeInTxt()
        {
            FileIO.WriteFile(contactList);
        }
        public void readFromTxt()
        {
            FileIO.ReadFile();
        }
        public void storeInCsv()
        {
            FileIO.WriteCSV(contactList);
        }
        public void readFromCsv()
        {
            FileIO.ReadCSV();
        }
        public void storeInJson()
        {
            FileIO.WriteJson(contactList);
        }
        public void readFromJson()
        {
            FileIO.ReadJson();
        }
    }
}

