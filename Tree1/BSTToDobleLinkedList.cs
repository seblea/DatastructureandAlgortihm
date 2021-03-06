﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinkedList;

namespace Tree1
{    // Convert a BST into a doubly linkedlist.
    class BSTIntoDoubleLinkedList
        {  
            public static Node Doublelink(BinaryTreeNode root) // return head of the double linked list
            {   // using inorder traverse 

                Node head = null;
                Node tail = null; // to track tail of the linked list for the insertion
                Node tempnode = null;

                BinaryTreeNode temp = null; // temporarly to store  pop node from the queue.
                Stack<BinaryTreeNode> tempstack = new Stack<BinaryTreeNode>(); // store the parents

            if (root != null)
                temp = root;
            else
                return null;


                while (tempstack.Count > 0 || temp != null)
                {

                    if (temp != null)
                    {
                        tempstack.Push(temp);
                        temp = temp.left;

                    }
                    else
                    {
                        temp = tempstack.Pop();
                        tempnode = new Node(temp.data);

                        if (head == null)
                        {
                            head = tempnode;
                        }
                        else
                        {
                            tail.Next = tempnode;
                            tempnode.prev = tail;

                        }

                        tail = tempnode;

                        temp = temp.right;

                    }
                }


                return head;


            }
        }
    }


