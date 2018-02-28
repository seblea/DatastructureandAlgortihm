using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    class CheckStringPermutations
    {
        public static void Permutations(string st1,string st2) // with out extra buffer
        {
            bool found = false;
            int count = 0;
            int upperbound = st1.Length - 1;


            if (st1.Length != st2.Length)
            {
                Console.WriteLine(" They are not Permutations");
                return;
            }

            while (found == false && count <= upperbound) // iterate  one string from the front the other from the tail
            {  
                if(st1.Substring(count).Equals(st2.Substring(upperbound - count)))
                {
                    count++;
                } 

                else
                {
                    found = true;
                    break;
                }

            }

            if (found == true)
                Console.WriteLine("No,One is not permutations of the others");
            else
                
                Console.WriteLine("Yes, One is permutations of the others");


        }
    }
}
