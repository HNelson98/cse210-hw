using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to Scripture Mastery");
        Scripture scripture = new Scripture();
        scripture.InputBook();
        scripture.FindReferences();
        scripture.DisplayReferences();
        Console.WriteLine($"\nWhich reference do you want to learn? ");
        string reference = Console.ReadLine();
        scripture.AssignScripture(reference);

        Mastery mastery = new Mastery(scripture.script);
        mastery.StringToList();
        bool continuelearning = true;
        while (continuelearning)
        {
            Console.Clear();
            Console.WriteLine(reference);
            mastery.DisplayScripture();
            Console.WriteLine();
            if (mastery.FindNumberOfWords() == 0){
                Console.WriteLine("\nYou have mastered this scripture!");
                continuelearning = false;
            } 
            else
            {
                Console.WriteLine("\nDo you want to continue learning? (n to quit, any other key to continue learning and remove words))");
                string answer = Console.ReadLine();
                if (answer == "n"){
                    continuelearning = false;
                }
                else
                {
                    mastery.RemoveScripture();
                }
            }
            
        }

        
    }
}