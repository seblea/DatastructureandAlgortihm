using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinkedList;

namespace BinarySearchTree
{
    class InOrderTraverseNoParent // with out parent pointer
    {
        public static Queue<BinaryTreeNode> Inorder(BinaryTreeNode root) // you can display the result directly  , but return in Queue 
        {
            Stack<BinaryTreeNode> stak = new Stack<BinaryTreeNode>();

            Queue<BinaryTreeNode>  que= new Queue<BinaryTreeNode>();

            BinaryTreeNode ro = root;

           

            while(stak !=null && ro != null)
            {
                if (ro != null)
                { stak.Push(ro);
                    ro = ro.left;
                }
                else
                {
                    ro = stak.Pop();
                    que.Enqueue(ro);

                    if (stak != null)
                    {
                        ro = stak.Pop();
                        que.Enqueue(ro);
                    }
                    ro = ro.right;
                }
            }

            return que;
    }
}
