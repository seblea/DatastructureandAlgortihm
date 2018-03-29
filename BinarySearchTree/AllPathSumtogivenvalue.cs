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
            Stack<int> res = new Stack<int>();


            int sum = 0;

            int ro = (int)root.data; // data is object type

            if (root == null)
                return null;

            if (root.left != null)
                left = ValSum(root.left, val,ref ans);

            if (root.right != null)
                right = ValSum(root.left, val,ref ans);



            // for each path , from leaf nodes to current node, push the current value  

            foreach (Stack<int> st in left) // left childerns 
            {

                st.Push(ro);
            }

            foreach (Stack<int> rst in right) //right childrens
            {
                rst.Push(ro);
            }

            // chech all path for the sum 
            foreach (Stack<int> stal in left) // left childrens and the current node 
            {
                sum = 0;
                foreach (int t in stal)
                {
                    sum = sum + t;
                    res.Push(t);
                    if (sum == val)
                        break;
                }

                // if so add the stack to the list. Possible path for the sum 
                if (sum == val)
                    ans.Add(res);
            }

            res.Clear();
            // chech all path the sum 
            foreach (Stack<int> star in right) // childrens and the current node
            {
                sum = 0;
                foreach (int t in star)
                {
                    sum = sum + t;
                    res.Push(t);
                    if (sum == val)
                        break;
                }

                if (sum == val) // 
                    ans.Add(res);
            }
            //merege left and right , default merege into right , all possible path from leaf to the parent 
            foreach (Stack<int> stal in left)
                right.Add(stal);


            return right;

        }
    }
}
