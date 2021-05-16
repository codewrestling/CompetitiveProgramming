// Write a function that takes in a non-empty array of integers that are sorted
// in ascending order and returns a new array of the same length with the squares
// of the original integers also sorted in ascending order.

// Sample Input
// array = [1, 2, 3, 5, 6, 8, 9]

// Sample Output
// [1, 4, 9, 25, 36, 64, 81]

using System;

namespace SortedSquaredArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { -5, -3, -2, 0, 1, 2, 3 };
            int[] arrSquaresSol1 = GetSquaredSortedArray(arr);
            int[] arrSquaresSol2 = GetSquaredSortedArraySolution2(arr);
            PrintArray(arrSquaresSol1);
            PrintArray(arrSquaresSol2);

            Console.Read();
        }

        private static void PrintArray(int[] arrSquaresSol2)
        {
            foreach (int t in arrSquaresSol2)
            {
                Console.WriteLine(t);
            }
        }

        private static int[] GetSquaredSortedArraySolution2(int[] arr)
        {
            // Time Complexity - O(n)
            // Space Complexity - O(n)

            int[] sortedSquares = new int[arr.Length];
            int smallerValueIndex = 0;
            int largerValueIndex = arr.Length - 1;

            for (int i = arr.Length - 1; i >= 0; i--)
            {
                // i is used for storing the value in sortedSquares array
                int smallerValue = arr[smallerValueIndex];
                int largerValue = arr[largerValueIndex];
                if (Math.Abs(smallerValue) > Math.Abs(largerValue))
                {
                    sortedSquares[i] = smallerValue * smallerValue;
                    smallerValueIndex++;
                }
                else
                {
                    sortedSquares[i] = largerValue * largerValue;
                    largerValueIndex--;
                }
            }
            return sortedSquares;
        }

        private static int[] GetSquaredSortedArray(int[] arr)
        {
            int[] arrSquares = new int[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                arrSquares[i] = arr[i] * arr[i];
            }

            Array.Sort(arrSquares);
            return arrSquares;
        }


    }
}
