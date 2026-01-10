using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        int userNumber = -1;

        while (userNumber != 0)
        {
            Console.Write("Enter number: ");
            userNumber = int.Parse(Console.ReadLine());

            if (userNumber != 0)
            {
                numbers.Add(userNumber);
            }
        }

        // Compute the sum
        int sum = 0;
        foreach (int num in numbers)
        {
            sum += num;
        }

        // Compute the average
        double average = (double)sum / numbers.Count;

        // Find the largest number
        int max = numbers[0];
        foreach (int num in numbers)
        {
            if (num > max)
            {
                max = num;
            }
        }

        // Find the smallest positive number
        int? smallestPositive = null;
        foreach (int num in numbers)
        {
            if (num > 0)
            {
                if (smallestPositive == null || num < smallestPositive)
                {
                    smallestPositive = num;
                }
            }
        }

        // Sort the list
        numbers.Sort();

        // Display Results
        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {max}");

        if (smallestPositive != null)
        {
            Console.WriteLine($"The smallest positive number is: {smallestPositive}");
        }
        else
        {
            Console.WriteLine("There were no positive numbers.");
        }

        Console.Write("The sorted list is: ");
        foreach (int num in numbers)
        {
            Console.Write($"{num} ");
        }
        Console.WriteLine();
    }
}
