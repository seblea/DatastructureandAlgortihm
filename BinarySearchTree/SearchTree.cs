using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinkedList;

namespace BinaryTree
{
    public class SearchTree // search node in the binary tree
    {
        public static BinaryTreeNode BinaryNode(BinaryTreeNode root, BinaryTreeNode node) 
        {
           
            BinaryTreeNode ro = root;
            BinaryTreeNode left=null;
            BinaryTreeNode right=null;
            int height;

            if (root == null)
                return null;

            if (root.CompareTo(node) == 0) // compare if it is equal return 0 
                return ro;

             height = ro.h + 1; // the next immeditate childern height

             if(root.left != null)
              {
                root.left.h = height;
                left = BinaryNode(root.left, node);
              }

            if (root.right != null)
            {
                root.right.h = height;
                right = BinaryNode(root.right, node);
            }

                    

            if (left != null) // if it is found in the left 
                return left;
            else
                return right;
            
               

          
           
        }


    }
}
