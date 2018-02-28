using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Divideandconcure
{
    class FindInSortedRotattedArray
    {   public static void Findval(int[] a)
        {
            bool found = false;
            int top = a.Length -1;
            int bottom=0;
            int mid;
            int ind = -1;
            int val;

            Enter:
            string st = Console.ReadLine();

            if (!int.TryParse(st, out val))
            {
                Console.WriteLine("Enter Integer Number to be search");
                goto Enter;
            }

            /*  get the middle , Always either  right or the left is in Ascending order 
             *  
             *  **/
            do
            {
              mid = (top + bottom) / 2;
                if (a[mid] == val)
                    {
                    found = true;
                    ind= mid;

                     }
                else if (a[mid] < a[top] ) // the right is in ascending order 
                {
                       if (a[top] >= val && a[mid] < val)
                        bottom = mid + 1;
                    else

                        top = mid - 1;

                }
                
                else //left  is in Ascending order 
                {
                    if (a[bottom] <= val && a[mid] > val )
                        top = mid - 1;

                    else

                       bottom = mid + 1;
                    
                }

               
            } while (found == false  && bottom <= top);

            if (ind >= 0)
                Console.WriteLine("It is found at Index: {0}", ind);
            else
                Console.WriteLine("It couldn't  found ");
        }

    }
}
