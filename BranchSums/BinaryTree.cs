using System;
using System.Collections.Generic;
using System.Text;

namespace BranchSums
{
    public class BinaryTree
    {
        public BinaryTree(int value)
        {
            this.value = value;
            this.left = null;
            this.right = null;
        }

        public int value;
        public BinaryTree left;
        public BinaryTree right;
    }
}
