using System;

class Program
{
    static void Main(string[] args)
    {
        bool running = true;
        while (running)
        {
            Console.WriteLine("Menu: ");
            Console.WriteLine("    1. Breathing Activity");
            Console.WriteLine("    2. Reflecting Activity");
            Console.WriteLine("    3. Listing Activity");
            Console.WriteLine("    4. Quit");
            Console.Write("Enter your choice: ");
            string choice = Console.ReadLine();

            if (choice == "1")
            {
                Breathing breathing = new Breathing("Breathing", "walking you through breathing ing and out slowly. Clear your mind and focus on your breathing.");
                breathing.Breathe();
            }
            else if (choice == "2")
            {
                Reflecting reflecting = new Reflecting("Reflecting", "helping you think back on times in your life where you excelled or failed and what you learned from those experiences.");
                reflecting.Reflect();
            }
            else if (choice == "3")
            {
                Listing listing = new Listing("Listing", "Having you list out as many things as you can think of in a certain category.");
                listing.List();
            }
            else if (choice == "4")
            {
                Console.WriteLine("Goodbye!");
                running = false;
            }
            else
            {
                Console.WriteLine("Invalid choice!");
            }
        }

    }
}