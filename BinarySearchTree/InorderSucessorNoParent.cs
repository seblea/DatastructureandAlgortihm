using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinkedList;

namespace BinarySearchTree
{
    public class InorderSucessorwithnoParent // if the node has no parent pointer 
    {
        public static void Sucessor(BinaryTreeNode root , BinaryTreeNode look)
        {
            Stack<BinaryTreeNode> Stak = new Stack<BinaryTreeNode>();

             BinaryTreeNode No = Search(root, look);
        }

        public static BinaryTreeNode Search(BinaryTreeNode root, BinaryTreeNode look)
        {
            bool found = false;
            BinaryTreeNode ro=root;
            
            while (found == false && ro !=null)
            {
                if (ro.data == look.data)
                   found=true;
                else
                {
                    if(ro.data > look.data)
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
    }
}
