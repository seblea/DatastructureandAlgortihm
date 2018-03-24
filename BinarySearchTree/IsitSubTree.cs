using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinkedList;

namespace BinaryTree
    {
    class IsitSubTree
    {  /*You have 2 very large binary trees: T1 with millions of nodes, and T2 with hundreds of nodes. 
        Create an algorithm to decide if T2 is a subtree of T1. A tree T2 is a subtree of T1 if there exists a node n in T1 such that the subtree 
        of n is identical to T2. That is, if you cut off the tree at node n, the two trees would be identical.
        **///

        public static Boolean SubTree(BinaryTreeNode root1,BinaryTreeNode root2) // binarytree  root2 is subtree of binarytree root1
        {
            int ans;

            BinaryTreeNode tr = SearchTree.BinaryNode(root1, root2); // search tree class will find root2 in root1 and return the node in root1

            if (tr == null)
                return false;

            ans = Sub(tr, root2); // pass root of trees for comparism 

            if (ans != 0)

                return false;
            else
                return true;
                    

            

        }

        public static int Sub(BinaryTreeNode tr1, BinaryTreeNode tr2) // 0 means they are identical.it will check all left and right data and the root
        {
            int ro;
            int left;
            int right;

            if (tr1 == null && tr2 == null) // exit case 
                return 0;

            if ((tr1 == null && tr2 != null ) || (tr1 != null && tr2 == null)) //exit case , one of them is null 
                return -1;

            ro = tr1.CompareTo(tr2); // return  0 if they are equal other wise -1 or 1 

            left = Sub(tr1.left, tr2.left);
            right = Sub(tr1.right, tr2.right);

            if (ro != 0 || left != 0 || right != 0) // one of them is return non equal 

                return -1;
            else
                return 0;




        }

        
    }
}
