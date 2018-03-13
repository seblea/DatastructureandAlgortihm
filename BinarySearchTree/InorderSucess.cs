using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinkedList;

namespace BinarySearchTree
{
    public class InorderSucessor // 
    {
        public static void Sucessor(BinaryTreeNode root , BinaryTreeNode look)
        {
            Stack<BinaryTreeNode> Stak = new Stack<BinaryTreeNode>();

             BinaryTreeNode No = Search(root, look);

             BinaryTreeNode su = new BinaryTreeNode();

              su = No.right;

            //Inorder Sucessor of a node will find in the right left most of the gien node


            while(su.left != null)
            {
                su = su.left;

            }

            Console.WriteLine(" Inorder Sucessor is {0}", su.data);
            
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
