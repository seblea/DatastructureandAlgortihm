using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinkedList;

namespace Tree1
{   // Implement a function to check if a binary tree is a BST
    public class CheckBinarytreeisBST
    {
        public static bool IsBST(BinaryTreeNode root)
        {
            if (root == null)
                return true;

            bool left = true;
            bool right = true;

            if (root.CompareTo(root.left) > 0 && root.CompareTo(root.right) < 0) // Compareto implemetation :if it is greater than  return 1 , it is less than return -1 equal return 0
            {
                left = IsBST(root.left);
                right = IsBST(root.right);

                return (left && right);
            }
            else
                return false;


        }

    }


}
