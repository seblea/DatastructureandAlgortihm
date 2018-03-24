
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinkedList;

namespace tree1
{
    class inkedlistforeachdepth
    {  //Given a BST ,creat a linked list of all nodes at each depth 

        public static void Creat(BinaryTreeNode root) // Data value of the linked list is a node.Each node in the linked list hold  head of each depth as data .linked list of linked list 
        { //using breadth traversal

            // Node data is object type 

            Queue<BinaryTreeNode> que = new Queue<BinaryTreeNode>(); // to track the node of the next depth

            // head of the outer linked list linked list

            Node parent =null; //  , outer linked list iterator 
            Node parent2 = null;// In each dpeth inner  linked list iterator 
            Node iterator = parent; // iterat through the queue 

            int current = 0;// to track number of node in current  depth

            int count = 0;// to track number of node that should be DeEnque at each depth .
            int next = 0; // counter for possible number of next depth node 

            BinaryTreeNode tempnode = null;

            Node temp = new Node(root.data); // copy binary tree data to linked list node
            Node head = new Node(temp); //  this node hold in the linked list as data ,head of outer linked list
            parent = head;// outer linked list iterator 

          
            if(root.left != null)
            {
                next++;
                que.Enqueue(root.left); // first enqueue the root children


            }

            if (root.right != null)
            {
                next++;
                que.Enqueue(root.left); // first enqueue the root childern


            }



            while (que.Count > 0) //  till no node to DeEnque 
            {
                count = next;
                current = next;
                next = 0; 

                while (count > 0) // deenque 
                {
                    tempnode = que.Dequeue();

                    if (count == current) // the new level start .head of the current depth should b , current will not update throught the current depth 
                    {
                        Node li2 = new Node(tempnode.data); // copy binary tree data to linked list node
                        parent2 = li2; // inner linked list

                        Node head2 = new Node(li2); //  this node hold in the linked list as data ,the head of the current depth 
                        parent.Next = head2; // the outer linked list
                        head2.prev = parent;
                        parent = head2; // track for the next node  
                    }
                    else
                    {
                        Node li2 = new Node(tempnode.data); // copy binary tree data to the node
                        parent2.Next = li2;
                        li2.prev = parent2;
                        parent2 = li2; // inner linked list iterator 


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

            // dispaly the result 
            parent = head;
            count = 0; // Level 
            while(parent != null)
            {
                Console.WriteLine(" Nodes of Level {0}", count);
                iterator = (Node)(parent.data); // inner iterator

                while(iterator != null)
                {
                    Console.Write("{0}=>");

                }

                count++;
                parent = parent.Next;
            }
            
          
            // return head ;
        }
    }
}
