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
        public static void Sucessor(BinaryTreeNode root , char look) // BinaryTree node data is character 
        {
             Stack<BinaryTreeNode> Stak = new Stack<BinaryTreeNode>();

             BinaryTreeNode No =SearchBinaryTree.BinarySearchTree(root, look); // class that will find the node 

             BinaryTreeNode su = new BinaryTreeNode();

              
            //Inorder Sucessor of a node will be find in the right left most of the given node
            if (su.right == null)
            {
                su = su.parent;
            }

             else
            {
                su = No.right;
                while (su.left != null)
                {
                    su = su.left;

                }
            }
            if(su!=null)

                Console.WriteLine(" Inorder Sucessor is {0}", su.data);
            else

                Console.WriteLine("there is no  Inorder Sucessor for the given node" );
        }

      
    }
}
