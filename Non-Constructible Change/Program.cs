//  Given an array of positive integers representing the values of coins in your
//  possession, write a function that returns the minimum amount of change (the
//  minimum sum of money) that you cannot create. The given coins can have
//  any positive integer value and aren't necessarily unique (i.e., you can have
//  multiple coins of the same value).
//  For example, if you're given coins = [1, 2, 5], the minimum
//  amount of change that you can't create is 4. If you're given no
//  coins, the minimum amount of change that you can't create is 1.
//
// Sample Input
// coins = [5, 7, 1, 1, 2, 3, 22]

// Sample Output
// 20

using System;
using System.Collections.Generic;

namespace Non_Constructible_Change
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> coins = new List<int> { 1, 2, 5 };
            int val = NonConstructibleChange(coins);
            Console.WriteLine(val);
            Console.Read();
        }

        private static int NonConstructibleChange(List<int> coins)
        {
            coins.Sort();
            int changeAlreadyCreated = 0;
            foreach (var item in coins)
            {
                int changeToBeCreated = changeAlreadyCreated + 1;
                if (item > changeToBeCreated) return changeAlreadyCreated + 1;
                changeAlreadyCreated += item;
            }
            return changeAlreadyCreated + 1;

        }
    }
}
