using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace otherProblems
{  // write a solution that only iterates over the string once and uses o(1) additional memory , assumption is all ints are in small case

    public struct CharP
       { public int index { get;  }
         public char ch { get; }
         public int rep { get; set; }

         public CharP(int ind,char c)
        {
            index = ind;
            ch = c;
            rep = 1;

        }
    }

static class  FirstNotRepeatingCharacter
    {
     
        public static void First()
        {
            string s = "abacabad";
            CharP te;
            int ind = -1;

            Dictionary<char,CharP> count = new Dictionary<char, CharP>();
           
            foreach(char c in s)
            {
                ind++;
                if (count.ContainsKey(c))
                {
                    te = count[c];
                    te.rep++;
                }
                else
                {
                    CharP temp=new CharP(ind,c);
                    count.Add(c, temp);

                }

            }

            foreach(CharP ch in count.Values)
            {
                  if(ch.rep ==1)
                  {
                    Console.WriteLine(ch.ch);
                    break;
                }
            }
            
        }
    }
}
