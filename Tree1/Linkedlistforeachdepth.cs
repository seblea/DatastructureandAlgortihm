
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

        public static void Creat(BinaryTreeNode root) 
        { //using breadth traversal


            if (root == null)
            {
                Console.WriteLine("Tree has no node");
                return;
            }

            Queue<BinaryTreeNode> que = new Queue<BinaryTreeNode>(); // to push the childern node of the current level

           
            //// Node data is object type 
          
            Node previous = null; // iterat through the queue 

            
           

            // stack contain head  of  linked  list of each level 

            Stack<Node> level = new Stack<Node>();

            int current = 0;// to track number of node in current  depth
            int count = 0;// to track number of node that should be DeEnqueue at each depth .
            int next = 0; // counter for possible number of next depth node 

            BinaryTreeNode tempnode = null;

            Node temp = new Node(root.data); // copy binary tree data to linked list node
            var data=root.data; // for diplaying
            level.Push(temp); // first push the root 

          
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

           // already we Eneque the root childern .

            while (que.Count > 0) //  till no node to DeEnque 
            {
                count = next;
                current = next;
                next = 0; 

                while (count > 0) // 
                {
                    tempnode = que.Dequeue();

                    if (count == current) // the new level start .head of the current depth  
                    {
                        Node headli = new Node(tempnode.data); // copy binary tree data to linked list node
                        previous = headli; //  linked list pointer 

                        level.Push(headli);
                        
                      
                    }
                    else
                    {
                        Node levelnode = new Node(tempnode.data); // copy binary tree data to the node
                        previous.Next = levelnode;
                        levelnode.prev = previous;
                        previous = levelnode; // linked list iterator 

                        level.Push(levelnode);

                    }

                    // truck next level number of childern and Eneque next level childern
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
           
            count = que.Count; // Level 
            while(level != null)
            {
                temp = level.Pop(); // head of the linked list
                Console.WriteLine(" Nodes of Level {0}", count);
                
                while(temp != null) // 
                {
                    data = temp.data;
                    Console.Write("{0}=>",data);
                    temp = temp.Next;

                }

                count++;
                
            }
            
          
            // return level ;
        }
    }
}
