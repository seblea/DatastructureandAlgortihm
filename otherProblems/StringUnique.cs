using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace otherProblems
{
   public static class StringUnique
    {  // assumption all characters are in lower case
        public static void checkUnique(String str)
        {
            int check = 0;
            int ch2 = 0;
            ch2 |= (1 << 0);
          

            for(int i = 0; i < str.Length; i++)
            {
                int val = str[i] - 'a';
                if ((check & (1 << val)) > 0)
                {
                   Console.WriteLine("The characters are not unique");
                    return;
                }
                check |= (1 << val);
               
            }
            Console.WriteLine("The characters are not unique");
            Console.ReadLine();
        }

    }
}
