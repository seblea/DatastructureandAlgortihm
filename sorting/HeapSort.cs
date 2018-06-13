using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sorting
{
    class HeapSort
    {

        public static void Sort(int[] arr)
        {
            int len = arr.Length - 1;
            int iter = len;
            int temp;

            //  > n/2 elements are leaf node

            while (len > 0)
            {
                iter = (len / 2) - 1; // Heapify start from n/2 -1 , all n/2 node are leaf node

                while (iter >= 0)
                {
                    Heapify(arr, iter, len);
                    iter--;
                }
                // exchange at len with 0 , because it is max heap 
                temp = arr[0];
                arr[0] = arr[len];
                arr[0] = temp;
                len--;
               
                
            }

        }

        public static void Heapify(int[] arr, int at, int len)
        {
            if (at >= len / 2) // it is leaf node  
                return;

            int left = (2 * at) + 1; //left node found at
            int right= (2 * at) + 2;// right node found at
            int max = at;
            int temp=arr[at];

            if(right  <= len) // the node has both left and right node
            {  if (arr[at] < arr[right] || arr[at] < arr[left])
                {
                    if (arr[right] > arr[left])
                    {
                        if (arr[at] < arr[right])
                        {
                            arr[at] = arr[right];
                            arr[right] = temp;
                            max = right;
                        }

                    }
                    else
                    {
                        if (arr[at] < arr[left])
                        {
                            arr[at] = arr[left];
                            arr[left] = temp;
                            max = left;
                        }


                    }
                }
            }

            else // if the node has only left node
            {
                if (arr[at] < arr[left])
                {
                    arr[at] = arr[left];
                    arr[left] = temp;
                    max = left;
                }

            }

            if (max != at) // Heapify should be done for alter node 
                Heapify(arr, max, len);
        }
    }

}
