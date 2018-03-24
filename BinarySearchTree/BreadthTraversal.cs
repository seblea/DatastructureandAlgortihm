using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinkedList;

namespace BinarySearchTree
{
    class BreadthTraversal
    {
        public static Queue<char> Traversal(BinaryTreeNode<T> root)
        {
            BinaryTreeNode<T> ro = root;
            BinaryTreeNode<T> tnode = root;
            Queue<BinaryTreeNode<T> > etemp = new Queue<BinaryTreeNode<T>>();
            Queue<char> result = new Queue<char>();

            etemp.Enqueue(ro);
            
            while(etemp!=null || ro != null)
            {
                tnode = etemp.Dequeue();

                result.Enqueue(tnode.data);

            }

        }
    }
}
