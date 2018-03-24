using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinkedList;

namespace BinaryTree
{
    public class AllPathSumtogivenvalue
    {
       public static void AllPathSumto(BinaryTreeNode ro, int val)
        {
            List<Stack<int>> ans=new List<Stack<int>>(); 
            List<Stack<int>> allpath;
            allpath = ValSum(ro, val, ref ans);

            if (ans != null)
            {
                foreach (Stack<int> st in ans)
                {
                    foreach (int t in st)
                    {
                        Console.WriteLine("{0}->", t);
                    }
                    Console.WriteLine();
                }
            }
            else
                Console.WriteLine("There is no any path");
        }

        public static List<Stack<int>> ValSum(BinaryTreeNode root, int val, ref List<Stack<int>> ans) // return to calling all possible path from the leaf  
        {
            List<Stack<int>> left = null;
            List<Stack<int>> right = null;
            List<Stack<int>> allnode = new List<Stack<int>>();  // to return to parent possible path from all leaf node to them 
            
            
            int sum = 0;
         
            int ro = (int)root.data; // data is object type

            if (root == null)
                return null;

            if (root.left != null)
                left = ValSum(root.left, val,ref ans);

            if (root.right != null)
                right = ValSum(root.left, val,ref ans);
            
            // for each path push the current value , to pass for the parent
            foreach (Stack<int> st in left)
            {

                st.Push(ro);
            }

            foreach (Stack<int> rst in right)
            {
                rst.Push(ro);
            }

            // chech all path the sum 
            foreach (Stack<int> stal in left)
            {
                sum = 0;
                foreach (int t in stal)
                {
                    sum = sum + t;
                }

                // if so add to ref list the stack
                if (sum == val)
                    ans.Add(stal);
            }

            // chech all path the sum 
            foreach (Stack<int> star in right)
            {
                sum = 0;
                foreach (int t in star)
                {
                    sum = sum + t;
                }

                if (sum == val)
                    ans.Add(star);
            }
            //merege left and right ,merege into right , all possible path from leaf to the parent 
            foreach (Stack<int> stal in left)
                right.Add(stal);


            return right;

        }
    }
}
