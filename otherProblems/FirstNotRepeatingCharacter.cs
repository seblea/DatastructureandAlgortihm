using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace otherProblems
{    // any type of character 

static class  FirstNotRepeatingCharacter
    {

        public static int FirstnotRepeating(string st, int at, int[] ch)
        {
            if (st.Length == at)
                return -1;

          int c = st[at];
          ch[c]++;
          int not= FirstnotRepeating(st, at + 1, ch);

            if (ch[c] == 1)
                not = c;
            
               return not;
        }





        public static void First()
        {   //assumption character encode is unicode 


            string s = "abacabad";
            int[] ch = new int[256];
            int not= FirstnotRepeating(s, 0, ch);

            Console.WriteLine("the first non repeating charchter is {0}", s[not]);
            Console.ReadKey();

        }
    }
}
