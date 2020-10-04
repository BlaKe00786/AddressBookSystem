using System;
namespace AddressBookSystemProject
{
    class AddressBookMain
    {
        static void Main(string[] args)
        {
            int choice;
            AddressBookBuilder addressBookBuilder = new AddressBookBuilder();
            string FirstName, LastName, Address, City, State, Zip, PhoneNumber, Email,NameToSearch,NameToDelete;
            Console.WriteLine("Welcome to Address Book System \n Enter your choice:");
            while (true)
            {
                Console.WriteLine(" \n 1. Add Contact \n 2. Display Contacts \n 3. Edit Existing Contact \n 4. Delete a contact \n 5.Exit");
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
                        Console.WriteLine("Enter Contact First Name to edit details: ");
                        NameToSearch = Console.ReadLine();
                        addressBookBuilder.EditContact(NameToSearch);
                        break;
                    case 4:
                        Console.WriteLine("Enter Contact First Name to delete contact: ");
                        NameToDelete = Console.ReadLine();
                        addressBookBuilder.DeleteContact(NameToDelete);
                        break;
                    case 5:
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
