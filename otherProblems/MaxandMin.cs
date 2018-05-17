using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace otherProblems
{
    class MaxandMin
    { // find Maximim and minimum 
          
       
        public static int[] MaxMin(int[] arr,int st,int end)
        {
            int[] mam = new int[2];

            if (end - st <= 1)
            {
                   
                    mam[0] = arr[st] <= arr[end]? arr[st]:arr[end];
                    mam[1] = arr[st] >= arr[end] ? arr[st] : arr[end];

                return mam;

            }
            int mid = (end - st) / 2;

           

          int[] mm1=   MaxMin(arr, st, mid);
          int[] mm2= MaxMin(arr, mid+1, end);

         mam[0] =  mm1[0] <= mm2[0] ? mm1[0]:mm2[0]  ;
         mam[1]= mm1[1] >= mm2[1] ? mm1[1] : mm2[1];

            return mam;
        }
    }
}
