using System;
namespace AddressBookSystemProject
{
    class AddressBookMain
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Address Book System");
            AddressBookBuilder addressBookBuilder = new AddressBookBuilder();
            string FirstName, LastName, Address, City, State, Zip, PhoneNumber, Email;
            Console.WriteLine("Enter First Name : ");
            FirstName = Console.ReadLine();
            Console.WriteLine("Enter Last Name : ");
            LastName = Console.ReadLine();
            Console.WriteLine("Enter Address: ");
            Address = Console.ReadLine();
            Console.WriteLine("Enter City : ");
            City = Console.ReadLine();
            Console.WriteLine("Enter State : ");
            State = Console.ReadLine();
            Console.WriteLine("Enter Zip code : ");
            Zip = Console.ReadLine();
            Console.WriteLine("Enter Phone Number : ");
            PhoneNumber = Console.ReadLine();
            Console.WriteLine("Enter Email : ");
            Email = Console.ReadLine();
            addressBookBuilder.AddContact(FirstName, LastName, Address, City, State, Zip, PhoneNumber, Email);
            addressBookBuilder.DisplayContacts();
        }
    }
}
