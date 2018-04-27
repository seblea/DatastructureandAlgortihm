using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace otherProblems
{  // write a solution that only iterates over the string once and uses o(1) additional memory , assumption is all ints are in small case
    static class  FirstNotRepeatingCharacter
    {
        public static void First()
        {
            string s = "abacabad";

            int[] count = new int[26];
            char tem = '_';

            int t = 0;

            for(int j = 0;j < 25; j++)
            {
                count[j] = 0;
            }

            foreach(char c in s)
            {
                t = c - 'a';
                count[t]++;

            }

            foreach(char c in s)
            {
                t = c - 'a';

                if (count[t] == 1)
                {
                    tem = (char)(96 + t);
                    break;
                }
            }

            Console.WriteLine(tem);
        }
    }
}
