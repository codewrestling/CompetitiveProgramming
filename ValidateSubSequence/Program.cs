// VALIDATE SUB SEQUENCE

// Given two non-empty arrays of integers, write a function that determines
// whether the second array is a subsequence of the first one.
// A subsequence of an array is a set of numbers that aren't necessarily adjacent
// in the array but that are in the same order as they appear in the array. For
// instance, the numbers "[1, 3, 4]" form a subsequence of the array
// "[1, 2, 3, 4]", and so do the numbers "[2, 4]". Note
// that a single number in an array and the array itself are both valid
// subsequences of the array.

// Sample Input
// "array" = [5, 1, 22, 25, 6, -1, 8, 10]
// "sequence" = [1, 6, -1, 10]

// Sample Output
// true



using System;
using System.Collections.Generic;

namespace ValidateSubSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> array = new List<int>() { 5, 1, 22, 25, 6, -1, 8, 10 };
            List<int> sequence = new List<int>() { 1, 6, -1, 10 };

            Console.WriteLine("Solution 1: " + IsValidSubsequenceSol1(array, sequence));
            Console.WriteLine("Solution 2: " + IsValidSubsequenceSol2(array, sequence));
            Console.WriteLine("Solution 3: " + IsValidSubsequenceSol3(array, sequence));

            Console.ReadLine();
        }

        private static bool IsValidSubsequenceSol3(List<int> array, List<int> sequence)
        {
            int seqId = 0;
            foreach (int currentElement in array)
            {
                if (seqId == sequence.Count)
                    return true;
                if (currentElement == sequence[seqId])
                {
                    seqId++;
                }
            }
            return seqId == sequence.Count;
        }

        private static bool IsValidSubsequenceSol2(List<int> array, List<int> sequence)
        {
            int arrayIndex = 0;
            int sequenceIndex = 0;
            while (arrayIndex < array.Count && sequenceIndex < sequence.Count)
            {
                if (array[arrayIndex] == sequence[sequenceIndex])
                {
                    sequenceIndex++;
                }
                arrayIndex++;
            }
            return sequenceIndex == sequence.Count;
        }

        private static bool IsValidSubsequenceSol1(List<int> array, List<int> sequence)
        {
            int lastIndexFound = -1;
            bool elementFound = false;
            foreach (int currentElement in sequence)
            {
                elementFound = false;
                // For matching sequence look forward
                for (int j = lastIndexFound + 1; j < array.Count; j++)
                {
                    if (array[j] == currentElement)
                    {
                        elementFound = true;
                        lastIndexFound = j;
                        break;
                    }
                }

                if (!elementFound)
                {
                    return false;
                }
            }

            if (elementFound)
            {
                return true;
            }
            return false;
        }
    }
}