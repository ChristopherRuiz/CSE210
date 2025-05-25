//For the stretch I made the program to choose the magic number

using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 101);
        int guess = -1;

        //Asking for the number
        Console.WriteLine("I have a magic number in mind. Can you guess it?");
        while (guess != number)
        {
            Console.Write("What is your guess? ");
            string userInput = Console.ReadLine();
            if (int.TryParse(userInput, out guess))
            {
                if (number > guess)
                    {
                        Console.WriteLine("Higher");
                    }
                    else if (number < guess)
                    {
                        Console.WriteLine("Lower");
                    }
                    else
                    {
                        Console.WriteLine("You guessed it!");
                    }
            }
        }

    }
}