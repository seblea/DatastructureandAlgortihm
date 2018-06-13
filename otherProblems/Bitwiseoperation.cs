

namespace otherProblems
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class InsertNintoM
        {
            //You are given two 32-bit numbers and N and m and two bits position,i abd j.write a method to inser M into N 
            //such that M starts at bit j and ends at bit i.
            // assumtion  the integers are positive number 
            // 1.make sure that m is less than or equal to  2 ^ (j-1+1) and N >= m ;
            // get minimum b such  2^ b <= m , 
            // z= right shift m with  j-b ;
            // y=get another number with all set 1 from most signinficant digit upto j  and from i upto 0
            // F=then Or Z with Y  ;
            // F2=set all bits from j to i with 0 for number N 
            // then Or F and F2 ;

            public static void Insert(int n, int m, int j, int i)
            {
                if (n < m)
                    Console.WriteLine("It is not possible ");
                int b = 0;
                int ms = 0;
                int mi2 = 0;
                int mi = 0;
                int f2 = 0;
                int ans = 0;
                for (b = 0; b <= 32; b++)
                {
                    if ((1 << i) >= m)
                        break;
                }

                if (1 << (j - i + 1) < b)
                    Console.WriteLine("It is not possible  adjust bit postion");

                ms = (m << (j - b)); // put the given number m in between j and i position 


                for (int sh = j; sh <= i; sh--)
                    mi |= (1 << sh); // to get all bits form j through i set 1 ;

                mi2 = ~mi; // get all bits from most siginificant digit upto j+1 and i-1 through 0  set 1
                f2 = mi2 & n; // set all bits of N from j to i with 0 ;
                ans = ms | f2;

                Console.WriteLine(ans);



            }


        }
    }


