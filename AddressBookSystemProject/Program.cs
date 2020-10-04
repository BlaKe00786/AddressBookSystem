using System;
namespace AddressBookSystemProject
{
    class AddressBookMain
    {
        static void Main(string[] args)
        {
            int choice;
            AddressBookBuilder addressBookBuilder = new AddressBookBuilder();
            string FirstName, LastName, Address, City, State, Zip, PhoneNumber, Email;
            Console.WriteLine("Welcome to Address Book System \n Enter your choice:");
            while (true)
            {
                Console.WriteLine(" \n 1. Add Contact \n 2. Display Contacts \n 3.Exit");
                choice= Convert.ToInt32(Console.ReadLine());
                switch(choice)
                {
                    case 1: 
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
                        break;
                    case 2: 
                        addressBookBuilder.DisplayContacts();
                        break;
                    case 3:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Enter Valid Choice:");
                        break;
                }
            }
            
        }
    }
}
