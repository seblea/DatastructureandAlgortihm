using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Divideandconcure
{
    class GetSorrtedArray
    {
        public static int[] GetArray()
        {
            int si; //Array size
            Enter:
            Console.WriteLine("Enter array size");
            string st = Console.ReadLine();

            if (!int.TryParse(st, out si))
            {
                Console.WriteLine("Enter Integer Number");
                goto Enter;
            }

            if (si <= 0)
            {
                Console.WriteLine("Enter positive  Integer Number greater than zero");
                goto Enter;
            }
            int[] a = new int[si];

            Console.WriteLine("Enter sorted array Values");
            for (int i = 0; i < si; i++)
            {
                again:
                Console.WriteLine("Enter array index {0}", i);
                st = Console.ReadLine();

                int.TryParse(st, out a[i]);
                if (i > 0)
                {
                    if (a[i] < a[i - 1])
                    {
                        Console.WriteLine("Invalid order");
                        goto again;
                    }
                }
            }

            return a;
        }
    }
}
