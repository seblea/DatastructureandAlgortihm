using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Divideandconcure
{
    static class  FindDuplicate
    { //Given an array that contains number from 1 to n-1 and exactly 1 duplicate , find the duplicate

        public static void Duplicate(int [] b)
        {
            int sum = 0;
            
            for (int i = 0; i < b.Length; i++)
            {
                sum = sum + b[i] - i;

            }

            Console.WriteLine("The duplicate element is {0}", sum);
        }
    }
}
