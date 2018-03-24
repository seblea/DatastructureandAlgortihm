using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinkedList;

namespace BinarySearchTree
{
    class BuildHeap
    {
        public static Node  Heap(object[] arr)
         {
            Node root= new Node();

            Node n;
            root = null;

            Queue<object> temp = new Queue<object> ;

            for(int i=0; i< arr.Length; i++)
            {
                if (root == null)
                    root.data = arr[i];
                else
                  { n = new Node();
                
                  

            }

        }
    }
}
