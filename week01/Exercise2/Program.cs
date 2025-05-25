/*For the Stretch Challenge I added "+" and "-" as part of the grades I also
deleted the problems with about A+ over 93 and F- on less than 60
*/

using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string userInput = Console.ReadLine();
        int grade = int.Parse(userInput);
        string letter;
        if (grade >= 90)
        {
            letter = "A";
        }
        else if (grade >= 80 && grade <= 89)
        {
            letter = "B";
        }
        else if (grade >= 70 && grade <= 79)
        {
            letter = "C";
        }
        else if (grade >= 60 && grade <= 69)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        if (letter != "F")
        {
            int lastDigit = grade % 10;

            if (grade >= 93)
            {
                letter += "";
            }
            else if (lastDigit >= 7 && lastDigit <= 9)
            {
                letter += "+";
            }
            else if (lastDigit <= 2)
            {
                letter += "-";
            }
        }

        Console.WriteLine($"Your grade is: {letter}");

        if (grade >= 70)
        {
            Console.WriteLine("Congratulation. You passed!");
        }
        else
        {
            Console.WriteLine("Sorry, you did not pass.");
        }
    }
}