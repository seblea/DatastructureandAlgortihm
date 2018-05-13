using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    delegate void DelegateS(int[] arr,int st,int en);


    class SorrtArray
    {
        public static void Sort(int[] arr, DelegateS de)
        {
            de(arr,0,arr.Length-1);
        }

     }

    class ftest {
        public static void Main(int[] arr)
        {
            DelegateS ds = new DelegateS(SortRecursion);

            SorrtArray.Sort(arr, ds);

        }

        public static void SortRecursion(int[] a, int st, int en)
        {
            int middle = (a.Length / 2);
            object mid = a[middle];

            if (st < en)
            {
                SortRecursion(a, st, middle - 1);
                SortRecursion(a, middle + 1, en);
                Merge(a, st, middle, en);
            }
            else
                return;
        }


        public static void Merge(int[] a, int st, int m, int en)
        {
            int n1 = m - st + 1;
            int n2 = en - m;
            int i, j, k;

            int[] a1 = new int[n1];
            int[] a2 = new int[n2];

            //copy the sub array

            for (i = 0; i < n1; i++)
            {
                a1[i] = a[st + i];
            }

            for (i = 0; i < n2; i++)
            {
                a2[i] = a[m + 1 + i];
            }

            i = 0;
            j = 0;
            k = st;
            while (i < n1 && j < n2)
            {
                if (a1[i] <= a2[j])
                {
                    a[k] = a1[i];
                    i++;
                }
                else
                {
                    a[k] = a2[j];
                    j++;
                }
                k++;
            }

            while (i < n1) // copying the left if there is left 
            {
                a[k] = a1[i];
                i++;
                k++;
            }

            while (j < n2) // copying the left if there is left 
            {
                a[k] = a1[j];
                j++;
                k++;
            }

        }



    }
}
