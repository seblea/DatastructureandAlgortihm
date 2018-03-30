using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinkedList;

namespace BinaryTree
{
    class BuildHeap
    {
        public static void  Heap(int[] arr)
         {
            int n= arr.Length;
            int ind;

            int temp;

             
                for (int i = ((n -1)/ 2); i <= 0; i--) // n/2 + 1 .... n  are all leaf nead
                {
                    ind =( i * 2) +1;
                    if (arr[i] > arr[ind])
                    {
                        temp = arr[i];
                        arr[i] = arr[ind];
                        arr[ind] = temp;
                    }

                    if (ind + 1 < n)
                    {
                        temp = arr[i];
                        arr[i] = arr[ind + 1];
                        arr[ind + 1] = temp;
                    }


                }

               

          

        }
    }
}
