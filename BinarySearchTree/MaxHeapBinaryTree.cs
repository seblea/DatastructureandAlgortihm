using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinkedList;

namespace BinarySearchTree
{
    class MaxBinaryTree
    {
        //given array build MaxHeap binary tree

        public BinaryTreeNode MaxHeap(object[] a)
        {
            BinaryTreeNode root = new BinaryTreeNode();
            BinaryTreeNode tem = new BinaryTreeNode(); // temporary node for swaping
            BinaryTreeNode swa = new BinaryTreeNode(); // to track in which the new child  will be link after swap


            BinaryTreeNode tempnode = null; // temprary node , the node as parent for the coming childern 

            Queue<BinaryTreeNode> temp = new Queue<BinaryTreeNode>();

            root.data = a[0];

            int size = 1;
            int i = 1;
            int count = 0;
            int icount = 0; //to count left and right is picked and deque from the queue

            int swap = 0; // if it is swapped and it is in the left ,we have to keep the first swap node as parent for the next insertion
            
            while(i < a.Length && temp !=null) // i  position at ,next element to be convert 
            {
                size = size * 2; //number of elements shoud be in the level 
                count = 0;
                icount = 0;
                  while( count <= size) // size will be growing by * 2 , 
                {
                    BinaryTreeNode newchild = new BinaryTreeNode();
                    newchild.data = a[i];

                    i++; // counter for array index
                    count++; // counter for elemnnts for that level
                    icount++; // counter for left and right child 
                    swap = 0; // there is no swap 
                    if (icount ==1) //  node will be link as left of the parent  
                    {
                        tempnode = temp.Dequeue();  // node which gonna have childern, parent 
                        tempnode.left = newchild;
                        newchild.parent = tempnode;

                        swa = tempnode ; // if there is no swap the next child will be link to this node as right 

                        while (tempnode.parent != null &&  newchild.CompareTo(tempnode) == 1) // if the inserted node value is greater than it's parent iteratively swap 
                         {
                            tem.parent = newchild.parent;
                            newchild.parent = tempnode.parent;

                            tem.left = newchild.left;
                            newchild.left = tempnode.left;

                            tem.right = newchild.parent;
                            newchild.right = tempnode.right;

                            newchild.left.parent = newchild;
                            newchild.right.parent = newchild;

                            tempnode.parent = tem.parent;
                            tempnode.left = tem.left;
                            tempnode.right = tem.right;
                            swap++;
                            if (swap == 1)
                            {
                                swa = tempnode;

                                
                            }

                            tempnode = newchild; 

                         }
                        

                    }
                    else
                    {
                        swa.right = t;
                        t.parent = tempnode;
                        icount = 0;
                    }

                    
            

                }

                i = i + size;

            }

            
            

            

        }
    }
}
