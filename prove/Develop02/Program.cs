using System;
using System.IO;
class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();

        Console.WriteLine("Welcome to the Journal Program!");
        bool running = true;
        while (running)
        {
            Console.WriteLine(Environment.NewLine + "Please select from the following: ");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            string input = Console.ReadLine();

            if (input == "1")
            {
                Entry entry = new Entry();
                entry.produceEntry();
                journal._entries.Add(entry._entry);
            }
            else if (input == "2")
            {
                journal.displayEntries();
            }
            else if (input == "3")
            {
                Console.Write("Choose the file: ");
                string filename = Console.ReadLine();
                string[] lines = System.IO.File.ReadAllLines(filename);
                    foreach (string line in lines)
                    {
                        journal._entries.Add(line);
                    }
                journal.displayEntries();
                
            }
            else if (input == "4")
            {
                Console.Write("Name the file: ");
                string filename = Console.ReadLine();

                using (StreamWriter outputFile = new StreamWriter(filename))
                {
                    foreach (string entry in journal._entries)
                    {
                        outputFile.WriteLine(entry);
                    }
                }
            }
            else if (input == "5")
            {
                running = false;
            }
            else 
            {
                Console.WriteLine("Thats not an option, try again!");
            }      
        }
    }
}