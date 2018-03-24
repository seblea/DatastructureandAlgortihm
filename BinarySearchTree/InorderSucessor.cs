using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinkedList;

namespace BinaryTree
{
    public class InorderSucessor // for binary search tree
    {
        public static BinaryTreeNode Sucessor(BinaryTreeNode root , BinaryTreeNode look) // BinaryTree node data is character  look is binarytree node
        {
             BinaryTreeNode No =SearchBinaryTree.BinarySearchHeight(root, look); // class that will find the node in Binary search tree

             BinaryTreeNode su = new BinaryTreeNode();


            //Inorder Sucessor of a node will be find in the right left most of the given node . in the right node if the node has no left node , the parent will be inorder suessor

            su = No.right;

            while (su.left != null)
            {
                su = su.left;
               
            }
            return su;
        }

      
    }
}
