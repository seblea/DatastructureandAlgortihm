using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinkedList;

namespace BinarySearchTree
{    // creating max heap out of unsorted array
    class MaxBinaryTree
    {  
        public static void MaxHeap(int[] a)
        {
            //after n/2 data are leaf node
            //so we have to Heapfiye n/2 -1 ,bottom up approach

            int i = a.Length / 2 - 1;

            while(i >= 0)
            {
                Heapify(a, i);
                i--;
            }



        }

        public static void Heapify(int[]a ,int i)
        {
            // check if it is leaf node

            if (i >= ((a.Length / 2) ))
                return;

            int length = a.Length;
            int left = (2 * i) + 1;
            int right = (2 * i) + 2;
            int large = i;
            int temp = 0;

        
            if (a[large] < a[left])

                large = left;

            if (right < length)// it might not have right children 
            {
                if (a[large] < a[right])
                    large = right;
            }
            if (large != i)
            {
                temp = a[i];
                a[i] = a[large];
                a[large] = temp;

                Heapify(a, large);
            }

        }
        
    }
}
