using System;
using System.Collections.Generic;

namespace list2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Use the following code to create a list of random numbers. Each number will be between 0 and 5.
            Random random = new Random();
            List<int> numbers = new List<int>
            {
                random.Next(6),
                random.Next(6),
                random.Next(6),
                random.Next(6),
                random.Next(6),
                random.Next(6),
            };
            for (int i = 0; i < numbers.Count; i++)

            {
                // Determine if the current loop index is contained inside of the `numbers` list. Print a message to the console indicating whether the index is in the list.
                if (numbers[i] == i)
                {
                    Console.WriteLine($"The list contains : {i}");
                }
                else
                {
                    Console.WriteLine($"The list doesn't contain: {i}");
                }

            }
        }
    }
}