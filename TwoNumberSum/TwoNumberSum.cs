
// TWO NUMBER SUM

// Write a function that takes in a non-empty array of distinct integers and an
// integer representing a target sum. If any two numbers in the input array sum
// up to the target sum, the function should return them in an array, in any
// order. If no two numbers sum up to the target sum, the function should return
// an empty array.

// Note that the target sum has to be obtained by summing two different integers
// in the array; you can't add a single integer to itself in order to obtain the
// target sum.

// Sample Test
// array = [3, 5, -4, 8, 11, 1, -1, 6]
// targetSum = 10

// Sample Output
// [-1,11]


using System;

namespace CompetitiveProgramming
{
    class TwoNumberSum
    {
        static void Main(string[] args)
        {
            int[] values = new[] { 3, 5, -4, 8, 11, 1, -6, -1 };
            int targetSum = 10;

            for (int i = 0; i < values.Length - 1 ; i++)
            {
                for (int j = i + 1; j < values.Length; j++)
                {
                    if (values[i] + values[j] == targetSum)
                    {
                        Console.WriteLine($"{values[i]}, {values[j]}");
                    }
                }
            }

            Console.ReadLine();
        }
    }
}
