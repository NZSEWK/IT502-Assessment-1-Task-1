using System;

class Task1
{
    static void Main()
    {
        // Create a variable to keep track of the sum
        int sum = 0;
        int startRange = 1; // Start from 1
        int endRange = 100; // End at 1000

        // Use a loop to check through numbers 1 to 100
        for (int i = startRange; i <= endRange; i++)
        {
            // Check if the number is divisible by 3 and 5
            if (i % 3 == 0 || i % 5 == 0)
            {
                sum += i; // Add the number to the sum if its a multiple of 3 or 5
            }
        }

        // Display the result of the sum
        Console.WriteLine("The sum of all multiples of 3 and 5 between 1 and 100 is: " + sum);
    }
}
