using System;

namespace ClosestValueInBST
{
    class Program
    {
        static void Main(string[] args)
        {
            BST tree = GetBinaryTree();
            int closestValue = GetClosestValue(tree, 15, tree.value);
            int closestValueIterative = GetClosestValueIterative(tree, 15, tree.value);
            Console.WriteLine(closestValue);
            Console.WriteLine(closestValueIterative);
        }

        private static int GetClosestValue(BST tree, int target, int closest)
        {
            // Time Complexity
            //           - Average Case: O(log n)
            //           - Worst Case: O(n)

            // Space Complexity
            //           - Average Case: O(log n)
            //           - Worst Case: O(n)

            if (Math.Abs(target - tree.value) < Math.Abs(target - closest))
            {
                closest = tree.value;
            }

            if (tree.value > target && tree.left != null)
            {
                return GetClosestValue(tree.left, target, closest);
            }
            else if (tree.value < target && tree.right != null)
            {
                return GetClosestValue(tree.right, target, closest);
            }
            else
            {
                return closest;
            }
        }

        private static int GetClosestValueIterative(BST tree, int target, int closest)
        {
            // Time Complexity
            //           - Average Case: O(log n)
            //           - Worst Case: O(n)

            // Space Complexity
            //           - Average Case: O(1)
            //           - Worst Case: O(1)

            while (true)
            {
                if (Math.Abs(target - tree.value) < Math.Abs(target - closest))
                {
                    closest = tree.value;
                }

                if (tree.value > target && tree.left != null)
                {
                    tree = tree.left;
                }
                else if (tree.value < target && tree.right != null)
                {
                    tree = tree.right;
                }
                else
                {
                    return closest;
                }
            }
            
        }

        private static BST GetBinaryTree()
        {
            return new BST(10)
            {
                left = new BST(5)
                {
                    left = new BST(2)
                    {
                        left = new BST(1)
                    },
                    right = new BST(5)
                },
                right = new BST(15)
                {
                    left = new BST(13)
                    {
                        right = new BST(14)
                    },
                    right = new BST(22)
                }
            };
        }
    }
}
