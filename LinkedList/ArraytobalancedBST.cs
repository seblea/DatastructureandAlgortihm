using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    class ArraytobalancedBSTrecursion
    { //Given a singly linked list which has data sorted in ascending order ,construct a balanced BSt
        
      public  static BinaryTreeNode BST(SingleLinkedList  li) // only accept the head pointer
        {

            Node start = li.Head;
            Node end = null;
            Node iter = li.Head;
            BinaryTreeNode root=new BinaryTreeNode();

            while (iter != null)
            {
                if (iter.Next == null)
                    end = iter;
                   
                    iter = iter.Next;
                     
            }

            root = BSTRecursion(li.Head, end);

            return root;
        }


        // using recursion

        static BinaryTreeNode  BSTRecursion(Node start , Node end) // given the start and end of the linked list return the middle as root , left and right root as left and right 
        {
            
            Node iter = start;
            BinaryTreeNode root = new BinaryTreeNode();
            BinaryTreeNode left = new BinaryTreeNode();
            BinaryTreeNode right = new BinaryTreeNode();

            Node en=null;//left partion end node 
          
            int mid =0;

            int count = 0; // 

            while (iter !=null )
            {
                if (iter == end)
                    break;
                else
                {
                    iter = iter.Next;
                    count++;
                }
            }


            if (count > 1) // if there is more than one node

            {
                mid = (count / 2) + 1; // advance to the left to make balanced BST

                // find the middle

                iter = start;
                count = 0;

                while (count < mid -1) 
                {
                    en = iter; // to track  previous node of the middle
                    count++;

                    iter = iter.Next;
                }

                root.data = iter.data;

                left = BSTRecursion(start, en);
                right = BSTRecursion(iter.Next, end);
                root.left = left;
                left.parent = root;
                root.right = right;
                right.parent = root;

                return root;
            }

            else if (count == 1)
            {
                root.data = iter.data;
                return root;

            }
            else
                return null;

        }


    }
}
