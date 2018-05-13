using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Strings
{
    static class Stringhasunique
    {
      static  public void Unique(string st) // using extra memory,hastable
       {
            Hashtable ha = new Hashtable();
            bool found = false;
            int len = st.Length;
            

            foreach(char ch in st)
            {
                if (ha.Contains(ch))
                {
                    found = true;
                    break;
                }

                else
                    ha.Add(ch, 1);
            }

            if (found == true)
                Console.WriteLine("The string has duplication charaters");
            else
               Console.WriteLine("The string has no duplication charaters");

        }

        // using bitwise arthemetic opration
        public static class StringUnique
        {  // assumption all characters are in lower case
            public static void checkUnique(String str)
            {
                int check = 0;
                int ch2 = 0;
                ch2 |= (1 << 0);


                for (int i = 0; i < str.Length; i++)
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

        // bad algorithm 
        static public void UniqueNoBuffer(string st) // with out buffer
        {
           
            bool found = false;
            int len = st.Length;
              
            int count = 0;
            foreach(char chout in st)
            { 
                foreach(char chin in st.Substring(count + 1))
                {  if(chout == chin)
                    {
                        found = true;
                        break;
                    }

                }

                if (found == true)
                    break;
                else
                { if (count == st.Length - 2) // the charachter before the last 

                        break;
                    else
                        count++;

                }
                 
            }
            

            if (found == true)
                Console.WriteLine("The string has duplication charaters");
            else
                Console.WriteLine("The string has no duplication charaters");

        }

    }
}
