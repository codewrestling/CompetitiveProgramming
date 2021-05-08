
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
using System.Collections.Generic;

namespace CompetitiveProgramming
{
    class TwoNumberSum
    {
        static void Main(string[] args)
        {
            int[] arrayValues = new[] { 3, 5, -4, 8, 11, 1, -6, -1 };
            int targetSum = 10;

            // Solution 1
            var arraySumSolution1 = GetArrayWithSumSolution1(arrayValues, targetSum);
            Print(arraySumSolution1, "Solution 1: ");
            // Solution 2
            var arraySumSolution2 = GetArrayWithSumSolution2(arrayValues, targetSum);
            Print(arraySumSolution2, "Solution 2: ");
            // Solution 3
            var arraySumSolution3 = GetArrayWithSumSolution3(arrayValues, targetSum);
            Print(arraySumSolution3, "Solution 3: ");
            
            Console.ReadLine();
        }

        private static void Print(int[] array, string text)
        {
            Console.WriteLine(text);
            foreach (var item in array)
            {
                Console.WriteLine(item);
            }
        }

        private static int[] GetArrayWithSumSolution1(int[] arrayValues, int targetSum)
        {
            // Time Complexity O(n^2)
            // Space Complexity O(1)
            for (int i = 0; i < arrayValues.Length - 1; i++)
            {
                for (int j = i + 1; j < arrayValues.Length; j++)
                {
                    if (arrayValues[i] + arrayValues[j] == targetSum)
                    {
                        return new[] { arrayValues[i], arrayValues[j] };
                    }
                }
            }
            return new int[] { };
        }

        private static int[] GetArrayWithSumSolution2(int[] arrayValues, int targetSum)
        {
            // Time Complexity = O(n)
            // Space Complexity = O(n)
            
            List<int> visitedValues = new List<int>();
            foreach (int number in arrayValues)
            {
                int requiredNumber = targetSum - number;
                if (visitedValues.Contains(requiredNumber))
                {
                    return new[] { number, requiredNumber };
                }
                else
                {
                    visitedValues.Add(number);
                }
            }
            return new int[] { };
        }

            private static int[] GetArrayWithSumSolution3(int[] arrayValues, int targetSum)
            {
                // Time complexity O(nlogn)
                // Space complexity O(1)
            
                Array.Sort(arrayValues);  // QuickSort time complexity is O(nlogn) 
                int left = 0;
                int right = arrayValues.Length - 1;

                // while loop complexity O(n)
                // together O(n + nlogn) => O(nlogn)
                while(left < right)
                {
                    int sum = arrayValues[left] + arrayValues[right];
                    if(sum < targetSum)
                    {
                        left++;
                    }
                    else if (sum > targetSum)
                    {
                        right--;
                    }
                    else
                    {
                        return new[] { arrayValues[left], arrayValues[right] };
                    }
                }
                return new int[] { };
            }
    }
}
