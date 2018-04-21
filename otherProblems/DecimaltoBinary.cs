using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace otherProblems
{
    class DecimaltoBinary
    { 
          public static void ToBinary(int num)
          {
            Stack<int> res = new Stack<int>();

            int num2 = num;
            int rem;

            while(num2 !=0)
            {
                rem = num2 % 2;
                num2 = num2 / 2;
                res.Push(rem);

            }

            Console.WriteLine("Converting {0} into binary ", num);

            while( res.Count > 0)
            {
                Console.Write(res.Pop());
            }
          }
    }
}
