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
        public static BinaryTreeNode Sucessor(BinaryTreeNode root , BinaryTreeNode look) // 
        {
             BinaryTreeNode No =SearchBinaryTree.BinarySearchHeight(root, look); // class that will find the node in Binary search tree

             BinaryTreeNode su = new BinaryTreeNode();


            //Inorder Sucessor of a node will be find in the right left most of the given node . in the right node if the node has no left node , the parent will be inorder suessor
            
            su = No.right;// No is pointing to the the given node , once to the right goes

            if (su == null)
                return null;

            while (su.left != null) // if isu.left null .su is still the parent so return su
            {
                su = su.left;
               
            }
            return su;
        }

      
    }
}
