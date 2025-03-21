using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        // Use the Do-while loop here
        int userNumber = -1;
        while (userNumber != 0)
        {
            Console.Write ("Enter a number list: ");

            string userResponse = Console.ReadLine();
            userNumber = int.Parse(userResponse);

            // Add number to the list if it is not 0
            if (userNumber !=0)
            {
                numbers.Add(userNumber);
            }
        } 

        // Compute the sum of numbers

        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }

        Console.WriteLine($"The sum is: {sum}");

        // Compute the average
        //First, we convert the variable sum to a float. This is necessary because if both sum and count are integers,
        //the division will result in an integer, discarding the decimal part. 
        //By ensuring that sum is a float, the calculation is performed correctly, preserving the decimal values.

        float avarage = ((float)sum) / numbers.Count;
        Console.WriteLine($"The avarage is: {avarage:F2}");

        // Find the largest number of the list
        int largest = numbers[0];

        foreach (int number in numbers)
        {
            if (number > largest)
            {
                largest = number;
            }
        }

        Console.WriteLine($"The largest number is :{largest}");
    }
}