using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Divideandconcure
{
    class MagicIndex // values are distinct
    {
        public static void Magindex(int[] b)
        {

            bool found = false;
            int ans = -1;
            int bottom = 0;
            int top = b.Length - 1;
            int mid = 0;

            do  // if mid > b[mid] ,never all n < mid be majic  index 
            {
                mid = (bottom + top) / 2;

                if (b[mid] == mid)

                {
                    ans = mid;
                    found = true;

                }

                else if (b[mid] < mid)
                {
                    bottom = mid + 1;
                    
                }
                else
                {
                    top = mid - 1;
                    
                }

               

            } while (found == false && bottom < top);


            if (ans != -1)
                Console.WriteLine("Magic Index is {0}", b[ans]);
            else
                Console.WriteLine("There is no Magix index in the array");

        }


    }
}


