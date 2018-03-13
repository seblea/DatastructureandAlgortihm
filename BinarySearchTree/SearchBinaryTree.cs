using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinkedList;

namespace BinaryTree
{
    class SearchBinaryTree
    {
        public static BinaryTreeNode BinarySearchTree(BinaryTreeNode root, char data)
        {
            bool found = false;
            BinaryTreeNode ro = root;

            while (found == false && ro != null)
            {
                if (ro.data == data)
                    found = true;
                else
                {
                    if (ro.data > data)
                    {
                        ro = ro.left;
                    }
                    else
                    {
                        ro = ro.right;
                    }
                }
            }

            return ro;
        }


        public static BinaryTreeNode SearchNode(BinaryTreeNode root, char data, out int height)
        {

            

        }
        

        public static BinaryTreeNode BinarySearchHeight(BinaryTreeNode root, char data, out int height) // return the node with the height 
        {
            bool found = false;
            BinaryTreeNode ro = root;
            height = 0;
            while (found == false && ro != null)
            {
                if (ro.data == data)
                    found = true;
                else
                {
                    if (ro.data > data)
                    {
                        ro = ro.left;
                       
                    }
                    else
                    {
                        ro = ro.right;
                    }

                    height++;
                }
            }

            return ro;
        }


    }
}
