using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinkedList;

namespace BinarySearchTree
{
    class LinkedListofNode
    {  //Given a BST ,creat a linked list of all nodes at each depth 

        public static Node Creat(BinaryTreeNode root) //Each node in the linked list hold head of each depth as data , so each linked list of each depth 
        { //using breadth traversal

            Queue<BinaryTreeNode> que = new Queue<BinaryTreeNode>(); // to track the node of the next depth

            Node  head= new Node(root); // head of the linked list
            Node parent = head; // to track who is the head of each depth 
            Node iterator = parent; // iterat throgh the queue 

            int current = 0;// number of node in current  depth
             
            int count = 1;// to track number of node that should be deEnque at each depth
            int next = 1; // possible number of next depth node

            BinaryTreeNode tempnode = new BinaryTreeNode();
            tempnode = root;
            que.Enqueue(root);      
           

            while(que.Count > 0 ) //  
            {
                count = next;
                current = next;
                next = 0;
                
                while (count > 0)
                {
                    tempnode = que.Dequeue();

                    if(count==current) // head of the depth
                     {
                        Node li2 = new Node(tempnode.data); // copy binary tree data to linked list node
                        Node head2 = new Node(li2); //  this node hold in the linked list as data ,the head of the current depth 
                        parent.Next = head2;
                        head2.prev = parent;
                        parent = li2; // track for the next node  
                     }
                    else
                      {
                        Node li2 = new Node(tempnode.data); // copy binary tree data to the node
                        parent.Next = li2;
                        li2.prev = parent;
                        parent = li2;


                    }

                    // truck next level number of childern and Enque next level childern
                    if (tempnode.left != null)
                    {
                        que.Enqueue(tempnode.left);
                        next++;
                    }
                    if (tempnode.right != null)
                    {
                        que.Enqueue(tempnode.right);
                        next++;

                    }

                    count--;
                }



            }

            return head;

        }
    }
}
