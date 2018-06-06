using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinkedList;

namespace BinaryTree
{    /***
    Design an algorithm and write code to find the first common ancestor of two nodes in a binary tree. 
    Avoid storing additional nodes in a data structure. NOTE: This is not necessarily a BST
    
    **///
    class Ancestor
    {
         // recursively find them 
        public static BinaryTreeNode CAncestor(BinaryTreeNode root,ref BinaryTreeNode lcs,params BinaryTreeNode [] node1)
        {
            if (root == null)
                return null;

            if (node1.Length == 1) // only to search one node 
            {   if (root == node1[0])
                    return root;
                else
                { BinaryTreeNode left = CAncestor(root.left,ref lcs, node1);
                  BinaryTreeNode right = CAncestor(root.right,ref lcs, node1);

                  return right != null ? right : left;
                }
            }

            else
            {
                if (root == node1[0] || root == node1[0])
                {
                    if (root == node1[0])
                    {
                        BinaryTreeNode left = CAncestor(root.left, ref lcs, node1[1]);// only search one node
                        BinaryTreeNode right = CAncestor(root.right, ref lcs, node1[1]);

                        if (left != null || right != null)
                            lcs = root;// 

                         return root; 

                    }

                    else
                    {
                        BinaryTreeNode left = CAncestor(root.left, ref lcs, node1[0]);
                        BinaryTreeNode right = CAncestor(root.right, ref lcs, node1[0]);

                        if (left != null || right != null)
                            lcs = root;

                        return root;

                    }

                }
                else
                {
                    BinaryTreeNode left = CAncestor(root.left, ref lcs, node1);
                    BinaryTreeNode right = CAncestor(root.right, ref lcs, node1);

                    if (left != null && right != null)
                        lcs = root;

                     return left != null ? left : right;
                }

            }

        }

        
        //option two , first find the two node with their height and adjust both to be in the same height and iteratively trace back their parent
        public static BinaryTreeNode CommonAnecstor(BinaryTreeNode root ,BinaryTreeNode node1, BinaryTreeNode node2) // tree with given root find ancestor of node1 and node 2
        {
            BinaryTreeNode ro = root;
            BinaryTreeNode no1 = SearchBinaryTree.BinarySearchHeight(root,node1); // get node1 pointer and height
            BinaryTreeNode no2 = SearchBinaryTree.BinarySearchHeight(root, node2); // get node2 pointer and height

            if (no1 == null || no2 == null) // node couldn't find
                return null;

            int h1 = no1.h;
            int h2 = no2.h;
            int h = h1; // default value

            if (h1 != h2)
            { // pick the minimum height
                 h = (h1 < h2) ? h1 : h2;

                if (h1 > h) // which one is in lower depth 
                    no1 = GotoUp(no1, h); // to make both in the the same level
                else
                    no2 = GotoUp(no2, h);
            }

             //  trace back to the parents and find the common
            while(no1 != no2)
            {
                no1 = no1.parent;
                no2 = no2.parent;
                h--;
            }

            no1.h = h;

            return no1;

        }

          public static BinaryTreeNode  GotoUp(BinaryTreeNode b,int he) // go up to the given height ,return parent node at that height
          {
            BinaryTreeNode temp = new BinaryTreeNode();
            if (b.h < he) // if it is equal or in lower height 
                return null;

            if (b.h == he) // if it is equal or in lower height 
                return b;

            int t = he;

            while(t != he)
            {
                temp = temp.parent;
                t--;
            }

            temp.h = t;

            return temp;



          }
    }
}
