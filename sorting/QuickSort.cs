using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sorting
{
    class QuickSort
    {
        public static void Sort(int[] arr, int st, int end)
        {
            if(st < end)
            {
                int p = Partition(arr, st, end);
                Sort(arr, st, p-1);
                Sort(arr, p+1,end);

            }
        }

        public static int Partition(int[] arr,int st,int end)
        {
            int iter = 0;
            int left = 0;
            int right = end;
            int temp = arr[end];

            while(left < right)
            {
                if(arr[iter] > temp )
                {  if (iter != right)
                    { arr[right] = arr[iter];
                        right++;
                        iter = right;

                    }
                   
                }
                else
                {
                    {
                        arr[right] = arr[iter];
                        right++;
                        iter = right;

                    }
                }
            }

            arr[left] = temp;
            return left;
        }
    }
}
