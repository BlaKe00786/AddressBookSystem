using System;
using System.Collections.Generic;
using System.IO;
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
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("No file");
            }
        }
    }
}
