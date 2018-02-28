using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Divideandconcure
{
    class AppearOnce
    {
        public static void Distinct(int[] b)
        {

            bool found = false;
            int ans = -1;
            //int slength = b.Length;
            int bottom = 0;
            int top = b.Length - 1;
            int mid = 0;

            do
            {
                mid = (bottom + top) / 2;

                if ((mid % 2) != 0) //  odd is the second occurence of the number
                {

                    if (b[mid - 1] != b[mid]) //
                    {
                        top = mid - 1;

                    }
                    else
                    {
                        bottom = top + 1;
                    }


                }
                else
                {
                    if (b[mid + 1] != b[mid]) //
                    {
                        found = true;
                        ans = mid;
                    }
                    else
                    {
                        bottom = mid + 2;

                    }

                }

                if (top == bottom)
                {
                    found = true;
                    ans = top;

                }
               


            } while (found == false && top > bottom);

            if (ans >= 0)

                Console.WriteLine("Array value appears once is {0}", b[ans]);
            else

                Console.WriteLine("There is no array element appears once");

        }
    }
}
