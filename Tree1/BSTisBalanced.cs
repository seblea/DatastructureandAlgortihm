using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinkedList;

namespace Tree1
{
    // Determine if a binary tree is balanced
  public static  class BSTisBalanced
    {   public static void  Check(BinaryTreeNode root)
        {
            bool result = true;

            int Treeheight = Balanced(root, ref result);

            if (result == true)
                Console.WriteLine(" BST is Balanced");
            else
                Console.WriteLine("BST isnot Balanced");
        }





        public static int Balanced(BinaryTreeNode root ,ref  bool bala) // default valu of balla is true.The function  returns the its height to the parent then  compare left and right height update bala ,
            //bala is common for all each recursion,since it is by reference . each recursion will update it if only if  the difference between left height and right height 
            //is greter than one ,when it is unblanced .
        {
            if (root == null) // leaf node right or left height is -1
                return 0;

            int left=-1;
            int right=-1;
                    

            left = Balanced(root.left,  ref bala);
            right= Balanced(root.left, ref bala);

            root.lh = left ;
            root.rh = right ;

            if (Math.Abs(root.lh - root.rh) > 1) // if the right and left height difference is greater than 1 Using AVL it is not balanced
                bala = false;
            else
                bala = (bala && true); // we have to keep the lower depth result 


            root.h = ((root.lh > root.rh) ? root.lh : root.rh) +1 ;// take the maximum from left and right height

            return root.h;

        }

    }
}
