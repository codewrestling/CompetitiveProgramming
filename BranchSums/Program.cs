// Write a function that takes in a Binary Tree and returns a list of its branch
// sums ordered from leftmost branch sum to rightmost branch sum.

// A branch sum is the sum of all values in a Binary Tree branch. A Binary Tree
// branch is a path of nodes in a tree that starts at the root node and ends at
// any leaf node.

// Each BinaryTree node has an integer value, a left child node, and a right child node.
// Children nodes can either be BinaryTree nodes themselves or None / null.

// Sample Input
//       tree =    1
//              /     \
//             2       3
//           /   \    /  \
//          4     5  6    7
//        /   \  /
//       8    9 10
//
// Sample Output
// [15, 16, 18, 10, 11]

// 15 == 1 + 2 + 4 + 8
// 16 == 1 + 2 + 4 + 9
// 18 == 1 + 2 + 5 + 10
// 10 == 1 + 3 + 6
// 11 == 1 + 3 + 7


using System;
using System.Collections.Generic;

namespace BranchSums
{
    class Program
    {
        static void Main(string[] args)
        {
            BinaryTree bt = GetBinaryTree();
            List<int> branchSum = new List<int>();
            GetBranchSum(bt, 0, branchSum);
            PrintBranchSum(branchSum);
        }

        private static void PrintBranchSum(List<int> branchSum)
        {
            foreach (var item in branchSum)
            {
                Console.WriteLine(item);
            }
        }

        private static void GetBranchSum(BinaryTree tree, int runningSum, List<int> branchSum)
        {
            // Time Complexity - O(n)
            // Space Complexity - O(n)

            if (tree == null) return;
            
            int totalSum = runningSum + tree.value;
            if (tree.left == null && tree.right == null)
            {
                branchSum.Add(totalSum);
                return;
            }

            GetBranchSum(tree.left, totalSum, branchSum);
            GetBranchSum(tree.right, totalSum, branchSum);
        }

        private static BinaryTree GetBinaryTree()
        {
            return new BinaryTree(1)
            {
                left = new BinaryTree(2)
                {
                    left = new BinaryTree(4)
                    {
                        left = new BinaryTree(8),
                        right = new BinaryTree(9)
                    },
                    right = new BinaryTree(5)
                    {
                        left = new BinaryTree(10)
                    }
                },
                right = new BinaryTree(3)
                {
                    left = new BinaryTree(6),
                    right = new BinaryTree(7)
                }
            };
        }
    }
}
