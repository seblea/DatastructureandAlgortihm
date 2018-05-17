using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class Firstnot
    {
        public static int FirstnotRepeating(string st, int at, int[] ch)
        {
            if (st.Length == at)
                return -1;

            int c = st[at];
            ch[c]++;
            int not = FirstnotRepeating(st, at + 1, ch);

            if (ch[c] == 1)
                not = c;

            return not;
        }





        public static void Main()
        {   //assumption character encode is unicode


            string s = "abacabad";
            int[] ch = new int[256];

            for (int i = 0; i < 256; i++)
                ch[i] = 0;

            int not = FirstnotRepeating(s, 0, ch);

            Console.WriteLine("the first non repeating charchter is {0}", (char)not);
            Console.ReadKey();

        }
    }
}

