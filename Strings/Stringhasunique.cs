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
