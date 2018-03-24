using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinkedList;

namespace BinaryTree
{
   public  class SearchBinaryTree // seaarc in binary search tree
    {
      public static BinaryTreeNode BinarySearchHeight(BinaryTreeNode root, BinaryTreeNode data) // return the node with updating the of the level of depth of the node 
        {
            bool found = false;
            BinaryTreeNode ro = root;
            int height = 0;

            
            while (found == false && ro != null)
            {
                if (ro.CompareTo(data)==0)
                    found = true;
                else
                {
                    if (ro.CompareTo(data) < 0)
                    {
                        ro = ro.left;
                        
                    }
                    else
                    {
                        ro = ro.right;
                    }

                    height++; // track the depth
                }
            }

            ro.h = height;
            return ro;
        }
      

    }
}
