using CsvHelper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;

namespace AddressBookSystemProject
{
   public class FileIO
    {
        public static void ReadFile()
        {
            string inpuPath = @"C:\Users\samee\source\repos\AddressBookSystem\AddressBookSystemProject\Utilities\Contacts.txt";
            if (File.Exists(inpuPath))
            {
                using (StreamReader sr = File.OpenText(inpuPath))
                {
                    String fileData = "";
                    while ((fileData = sr.ReadLine()) != null)
                        Console.WriteLine((fileData));
                }
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("No file");
            }
        }
        public static void WriteFile(List<Contacts> contacts)
        {
            string outputPath = @"C:\Users\samee\source\repos\AddressBookSystem\AddressBookSystemProject\Utilities\Contacts.txt";
            if (File.Exists(outputPath))
            {
                using (StreamWriter streamWriter = File.AppendText(outputPath))
                {
                    foreach (Contacts contact in contacts)
                    {
                        streamWriter.WriteLine(contact);
                    }
                    streamWriter.Close();
                }
            }
            else
            {
                Console.WriteLine("No file");
            }
        }
        public static void ReadCSV()
        {
            string filePath = @"C:\Users\samee\source\repos\AddressBookSystem\AddressBookSystemProject\Utilities\Contacts.csv";
            string[] data = File.ReadAllLines(filePath);
            foreach (string str in data)
            {
                string[] column = str.Split(",");
                foreach(string str2 in column)
                {
                    Console.WriteLine(str2);
                }
            }
        }
        public static void WriteCSV(List<Contacts> data)
        {
            string path = @"C:\Users\samee\source\repos\AddressBookSystem\AddressBookSystemProject\Utilities\Contacts.csv";
            if (File.Exists(path))
            {
                using (StreamWriter streamWriter = File.AppendText(path))
                {
                    foreach (Contacts contact in data)
                    {
                        streamWriter.WriteLine(contact.FirstName + "," + contact.LastName + "," + contact.Address + "," + contact.City + "," + contact.State + "," + contact.Zip + "," + contact.PhoneNumber + "," + contact.Email);
                    }
                    streamWriter.Close();
                }
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("No file");
            }
        }
    
    }
}
