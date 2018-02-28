using System;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Divideandconcure
{  // search an element in array where differnce between adjacent elements is 1
   public static class Adjacentelement
    {
       public static void Adjacent(int[] b)
        {
            int bottom = 0;
            bool Found = false;
            int ind = -1;
            int dis = 0;
            int val;


            Enter:
            string st = Console.ReadLine();

            if (!int.TryParse(st, out val))
            {
                Console.WriteLine("Enter Integer Number to be search");
                goto Enter;
            }


            do
            {
                dis = Math.Abs(b[bottom] - val);
                
                if (dis == 0)
                {
                    Found = true;
                    ind = bottom;
                }

                else
                {
                    bottom = bottom + dis;

                }


            }
            while (Found == false && (bottom <= b.Length && bottom >= 0));


            if (ind != -1)
                Console.WriteLine(" It is Found at index {0}", ind);
            else
                Console.WriteLine(" It isn't found ");
        }
    }
}

