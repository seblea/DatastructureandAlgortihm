using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace otherProblems
{  //Greatest common divisor of two number
    // a' is remainder when a is divided by b  .From mathimathics gcd(a,b)=gcd(b,a') so reursively or iteritevely
    class GreatestDivisor
    {
        public static int GCD(int a,int b)
        {
            int gcd;
            if (a > b)
            {  //gcd = CalulateRecu(a, b);
               gcd=CalulateIter(a,b) ;
            }
            else
            { //gcd = CalulateRecu(b, a);
                gcd = CalulateIter(b, a);
            }

            return gcd;
        }

        public static int CalulateIter(int a, int b)
        {

            if (b == 0)
                return a; 

            int rem;
            int num;
            int temp;
            
                rem = a % b;
                num = b;
           

            while(rem != 0)
            {
                temp= rem;
                rem = num % rem;
                num = temp;
            }

            return num;
        }

        // too slow algortihm , recurseviley 
        public static int CalulateRecu(int a,int b)
        {
            if (b == 0)
                return a;

            int gcd;
            int c = a % b;
            gcd = CalulateRecu(b, c);
            return gcd;
        }
    }
}
