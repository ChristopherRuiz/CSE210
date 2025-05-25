using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int userNumber = -1;
        
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        
        while (userNumber != 0)
        {
            Console.Write("Enter number: ");
            string userAdding = Console.ReadLine();
            userNumber = int.Parse(userAdding);

            // adding numbers
            if (userNumber != 0)
            {
                numbers.Add(userNumber);
            }
        }

        // Part 1: Computing the sum, or total, of the numbers in the list.
        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }
        Console.WriteLine($"The sum is: {sum}");

        // Part 2: Compute the average
        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average is: {average}");

        // Part 3: Find the maximum number
        int largest = numbers[0];

        foreach (int number in numbers)
        {
            if (number > largest)
            {
                largest = number;
            }
        }
        Console.WriteLine($"The largest number is: {largest}");
    }
}