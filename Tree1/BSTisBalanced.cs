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

            int rootheight = Balanced(root, ref result);

            if (result == true)
                Console.WriteLine(" BST is Balanced");
            else
                Console.WriteLine("BST isnot Balanced");
        }





        public static int Balanced(BinaryTreeNode root ,ref  bool bala) // returns the height  . compare left and right height update bala ,
            //bala is common for all each recursion,since it is by reference . each recursion will update it if only if  the difference between left height and right height 
            //is greter than one 
        {
            if (root == null) // leaf node right or left height is -1
                return -1;

            int left=-1;
            int right=-1;
                    

            left = Balanced(root.left,  ref bala);
            right= Balanced(root.left, ref bala);

            root.lh = left ;
            root.rh = right ;

            if (Math.Abs(root.lh - root.rh) > 1) // if the right and left height difference is greater than 1 Using AVL it is not balanced
                bala = false;
            else
                bala = (bala && true);

               root.h = ((root.lh > root.rh) ? root.lh : root.rh) +1 ;// take the maximum 

            return root.h;

        }

    }
}
