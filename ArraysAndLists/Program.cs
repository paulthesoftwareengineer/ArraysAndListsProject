using System;

namespace ArraysAndLists
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create an array of integers and populate it with the numbers 1-10
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            // Create two lists of type int
            List<int> evens = new List<int>();
            List<int> odds = new List<int>();

            // Use a foreach loop to iterate through the array of numbers
            foreach (int number in numbers)
            {
                // Check if the number is even or odd
                if (number % 2 == 0)
                {
                    // If the number is even, add it to the evens list
                    evens.Add(number);
                }
                else
                {
                    // If the number is odd, add it to the odds list
                    odds.Add(number);
                }
            }

            // Display the even numbers using a foreach loop
            Console.WriteLine("Even numbers:");
            foreach (int even in evens)
            {
                Console.WriteLine(even);
            }

            // Display the odd numbers using a for loop
            Console.WriteLine("Odd numbers:");
            for (int i = 0; i < odds.Count; i++)
            {
                Console.WriteLine(odds[i]);
            }
        }
    }
}
