using System;
using System.Collections.Generic;
using System.Security.Permissions;

namespace AddressBookSystemProject
{
    class AddressBookMain
    {
        static void Main(string[] args)
        {
            Dictionary<string, AddressBookBuilder> addressBookDict = new Dictionary<string, AddressBookBuilder>();
            int countOfPersonsInState=0, countOfPersonsInCity=0;
            string repeat = "yes";
            Console.WriteLine("How many address Book you want to add");
            int numAddressBook = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= numAddressBook; i++)
            {
                Console.WriteLine("Enter the name of address book " + i + ": ");
                string addressBookName = Console.ReadLine();
                AddressBookBuilder addressBook = new AddressBookBuilder();
                addressBookDict.Add(addressBookName, addressBook);
            }
            do
            {
                Console.WriteLine("1.Add Contact \n2.Edit Contact \n3.Delete Contact \n4.Search Contact \n5.Display Contacts \n6.Sort by First name \n7.Sort by Zip \n8.Sort by City \n9.Sort by State \n10.Write in txt \n11.Read in txt \n12.exit \nEnter your Choice:");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Enter Address Book name where you want to add contacts");
                        string addContactInAddressBook = Console.ReadLine();
                        Console.WriteLine("Enter how many contacts you want to add");
                        int numberOfContacts = Convert.ToInt32(Console.ReadLine());
                        for (int i = 1; i <= numberOfContacts; i++)
                        {
                            takeInputAndAddToContacts(addressBookDict[addContactInAddressBook]);
                        }
                        addressBookDict[addContactInAddressBook].DisplayContacts();
                        break;
                    case 2:
                        Console.WriteLine("Enter Address Book name where you want to edit contact");
                        string editContactInAddressBook = Console.ReadLine();
                        Console.WriteLine("Enter FirstName of Contact to be edited");
                        string firstNameOfContactToBeEdited = Console.ReadLine();
                        addressBookDict[editContactInAddressBook].EditContact(firstNameOfContactToBeEdited);
                        addressBookDict[editContactInAddressBook].DisplayContacts();
                        break;
                    case 3:
                        Console.WriteLine("Enter Address Book name where you want to delete contact");
                        string deleteContactInAddressBook = Console.ReadLine();
                        Console.WriteLine("Enter FirstName of Contact to be deleted");
                        string firstNameOfContactToBeDeleted = Console.ReadLine();
                        addressBookDict[deleteContactInAddressBook].DeleteContact(firstNameOfContactToBeDeleted);
                        addressBookDict[deleteContactInAddressBook].DisplayContacts();
                        break;
                    case 4:
                        Console.WriteLine("Press c for city or s for state");
                        string place = Console.ReadLine();
                        place = place.ToLower();
                        Console.WriteLine("Enter name of place");
                        String findPlace = Console.ReadLine();
                        Dictionary<string, List<string>> dictionaryCity = new Dictionary<string, List<string>>();
                        Dictionary<string, List<string>> dictionaryState = new Dictionary<string, List<string>>();
                        foreach (var element in addressBookDict)
                        {
                            List<String> listOfPersonsinPlace = new List<string>();
                            if (place.Equals("c"))
                            {
                                listOfPersonsinPlace = element.Value.findPersonsInCity(findPlace);
                                countOfPersonsInCity += element.Value.findNumberOfPersonsInCity(findPlace);
                                foreach (var name in listOfPersonsinPlace)
                                {
                                    if (!dictionaryCity.ContainsKey(findPlace))
                                    {
                                        List<string> list = new List<string>();
                                        list.Add(name);
                                        dictionaryCity.Add(findPlace, list);
                                    }
                                    else
                                        dictionaryCity[findPlace].Add(name);
                                }
                            }
                            else
                            {
                                listOfPersonsinPlace = element.Value.findPersonsInState(findPlace);
                                countOfPersonsInState += element.Value.findNumberOfPersonsInState(findPlace);
                                foreach (var name in listOfPersonsinPlace)
                                {
                                    if (!dictionaryState.ContainsKey(findPlace))
                                    {
                                        List<string> list = new List<string>();
                                        list.Add(name);
                                        dictionaryState.Add(findPlace, list);
                                    }
                                    else
                                        dictionaryState[findPlace].Add(name);
                                }
                            }
                        }
                        if (dictionaryCity.Count != 0)
                        {
                            Console.WriteLine("Persons in the city :-");
                            foreach (var mapElement in dictionaryCity)
                            {
                                foreach (var listElement in mapElement.Value)
                                {
                                    Console.WriteLine(listElement);
                                }
                            }
                        }
                        else
                        {
                            Console.WriteLine("Persons in the state :-");
                            foreach (var mapElement in dictionaryState)
                            {
                                foreach (var listElement in mapElement.Value)
                                {
                                    Console.WriteLine(listElement);
                                }
                            }
                        }
                        Console.WriteLine("No. of person in city: " + countOfPersonsInCity);
                        Console.WriteLine("No. of person in state: " + countOfPersonsInState);
                        break;
                    case 5:
                        Console.WriteLine("Enter Address Book name to display contacts");
                        string displayContactInAddressBook = Console.ReadLine();
                        addressBookDict[displayContactInAddressBook].DisplayContacts();
                        break;
                    case 6:
                        Console.WriteLine("Enter Address Book name to sort contacts");
                        string sortContactInAddressBook = Console.ReadLine();
                        addressBookDict[sortContactInAddressBook].sortByFirstName();
                        break;
                    case 7:
                        Console.WriteLine("Enter Address Book name to sort contacts");
                        string sortByZipInAddressBook = Console.ReadLine();
                        addressBookDict[sortByZipInAddressBook].sortByZip();
                        break;
                    case 8:
                        Console.WriteLine("Enter Address Book name to sort contacts");
                        string sortByCityInAddressBook = Console.ReadLine();
                        addressBookDict[sortByCityInAddressBook].sortByCity();
                        break;
                    case 9:
                        Console.WriteLine("Enter Address Book name to sort contacts");
                        string sortByStateInAddressBook = Console.ReadLine();
                        addressBookDict[sortByStateInAddressBook].SortByState();
                        break;
                    case 10:
                        Console.WriteLine("Enter Address Book name to store contacts");
                        string storeAddressBook = Console.ReadLine();
                        addressBookDict[storeAddressBook].storeInTxt();
                        break;
                    case 11:
                        Console.WriteLine("Enter Address Book name to display contacts");
                        string readAddressBook = Console.ReadLine();
                        addressBookDict[readAddressBook].readFromTxt();
                        break;
                    case 12:
                        repeat = "no";
                        break;
                    default:
                        Console.WriteLine("Please enter valid choice");
                        break;
                }
            } while (repeat.Equals("yes"));
        }
        public static void takeInputAndAddToContacts(AddressBookBuilder addressBook)
        {
            Console.WriteLine("Enter FirstName");
            string firstName = Console.ReadLine();
            Console.WriteLine("Enter LastName");
            string lastName = Console.ReadLine();
            Console.WriteLine("Enter Address");
            string address = Console.ReadLine();
            Console.WriteLine("Enter City");
            string city = Console.ReadLine();
            Console.WriteLine("Enter State");
            string state = Console.ReadLine();
            Console.WriteLine("Enter Zip");
            string zip = Console.ReadLine();
            Console.WriteLine("Enter PhoneNumber");
            string phoneNumber = Console.ReadLine();
            Console.WriteLine("Enter Email id");
            string email = Console.ReadLine();
            addressBook.AddContact(firstName, lastName, address, city, state, zip, phoneNumber, email);
        }
    }
}