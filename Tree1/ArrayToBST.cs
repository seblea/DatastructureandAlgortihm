﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinkedList;

namespace Tree1
{
  
    class ArraytoMinimumalHeight
    { //Given a sorted array, create a binary search tree with minimal height

        public static BinaryTreeNode BST(object[] ar) // 
        {

            int len = ar.Length;
            int start = 0;
            int end = len - 1;
            

            BinaryTreeNode root = new BinaryTreeNode();

           
            root = BSTRecursion(ar,start, end);

            return root;
        }


        // using recursion divided and conqure 

        static BinaryTreeNode BSTRecursion(object [] ar,int  start, int end) // given the start and end of the array index set the middle  as root .
        {
        
            BinaryTreeNode root = new BinaryTreeNode();

           
            if(start  > end) // exit 
            {
                return null;
            }

          

            BinaryTreeNode left = new BinaryTreeNode();
            BinaryTreeNode right = new BinaryTreeNode();




            int mid = 0;
                  
             mid = ((start + end)/ 2) ; 

            // find the middle


                root.data = ar[mid];

                left = BSTRecursion(ar,start, mid-1);
                right = BSTRecursion(ar,mid+1, end);

                root.left = left;
                left.parent = root;

                root.right = right;
                right.parent = root;

                return root;
            }

           
        }


    }

