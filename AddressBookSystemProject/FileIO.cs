using CsvHelper;
using Newtonsoft.Json;
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
            }
            else
            {
                Console.WriteLine("No file");
            }
        }
        public static void ReadJson()
        {
            string filePath = @"C:\Users\samee\source\repos\AddressBookSystem\AddressBookSystemProject\Utilities\Contacts.json";
            if (File.Exists(filePath))
            {
                IList<Contacts> contactsRead = JsonConvert.DeserializeObject<IList<Contacts>>(File.ReadAllText(filePath));
                foreach (Contacts contact in contactsRead)
                {
                    Console.Write(contact.FirstName);
                    Console.Write("\t" + contact.LastName);
                    Console.Write("\t" + contact.Address);
                    Console.Write("\t" + contact.City);
                    Console.Write("\t" + contact.State);
                    Console.Write("\t" + contact.Zip);
                    Console.Write("\t" + contact.PhoneNumber);
                    Console.Write("\t" + contact.Email);
                    Console.Write("\n");
                }
            }
            else
            {
                Console.WriteLine("File doesn't exists");
            }
        }
        public static void WriteJson(List<Contacts> data)
        {
            string filePath = @"C:\Users\samee\source\repos\AddressBookSystem\AddressBookSystemProject\Utilities\Contacts.json";
            if (File.Exists(filePath))
            {
                JsonSerializer jsonSerializer = new JsonSerializer();
                using (StreamWriter streamWriter = new StreamWriter(filePath))
                using (JsonWriter writer = new JsonTextWriter(streamWriter))
                {
                    jsonSerializer.Serialize(writer, data);
                }
            }
            else
            {
                Console.WriteLine("File doesn't exists");
            }
        }
    }
}
