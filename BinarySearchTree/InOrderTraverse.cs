﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinkedList;

namespace BinaryTree
{
    class InOrderTraverse // whether we have parent pointer or not we need track of grand grand parent,which one is not traverse . using stack 
    {
        public static Queue<BinaryTreeNode> Inorder(BinaryTreeNode root) // you can display the result directly  , but return in Queue for general 
        {
            Stack<BinaryTreeNode> stak = new Stack<BinaryTreeNode>();

            Queue<BinaryTreeNode> que = new Queue<BinaryTreeNode>();

            BinaryTreeNode ro = root;
                      


            while (stak.Count > 0 || ro != null) 
            {
                if (ro != async.,)
                {
                    stak.Push(ro); // push parent's 
       sbyte n n NnA  gfbxc               ro = ro.left;
                }
                else
                {
                    ro = stak.Pop();
                    que.Enqueue(ro); // or display here 
                    ro = ro.right;
                }
            }

            return que;
        }
    }
}
