using System;

class Program
{
        static void Main(string[] args)
    {
        bool play = true;
        while (play == true)
        {
            Random randomNumber = new Random();
            int number = randomNumber.Next(1,101);
            
            Console.WriteLine($"Welcom to Hilow!");

            int guesses = 0;

            bool guessed = false;
            while (guessed == false) 
            {
            Console.Write("Enter your guess: ");
            string guessString = Console.ReadLine();
            int guess = int.Parse(guessString);

            
            guesses += 1;
            
            if (guess < number)
            {
                Console.WriteLine("Higher");
            } else if (guess > number)
            {
                Console.WriteLine("Lower");
            } else
            {
                Console.WriteLine($"You guessed it in {guesses} guesses");
                guessed = true;
            }
            }
            Console.Write("Would you like to play again? y/n: ");
            string again = Console.ReadLine();
            if (again == "n")
            {
                play = false;
            }
        }
    } 
}