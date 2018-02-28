using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Divideandconcure
{
    class splitArraysum
    {  
        public static void split(int [] a)
        {
            int temp;
            // the first iteration of the bubble sort push the maximum value to the end
           
            for(int i=0;i< a.Length -1; i++)
            {
                if (a[i] > a[i + 1])
                {
                    temp = a[i];
                    a[i] = a[i + 1];
                    a[i + 1] = temp;
                }
        }
            temp = a[a.Length - 1];
            for(int j=0;j < a.Length - 1; i++)
            {
                temp = temp - a[i];
            }
            if (temp != 0)
                Console.WriteLine("Invalid Array, it can't be split ");
            else
                Console.WriteLine("split complete");
        }
}
