using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace otherProblems
{
    class DutchFlagProblem
    {
        public static void DutchFlag(int [] arr) // with out extra buffer
        {
            int low, middle, high;
            int temp;

            low = 0;
            middle = 1;
            high = arr.Length - 1;

            // first set where is the first 1 



            while( middle != high)
            {
              low:
                if (arr[low] == 0)
                    low++;
                else
                {   if (arr[middle] == 0)
                    { //swap 
                        temp = arr[low];
                        arr[low] = arr[middle]; ;
                        arr[middle] = temp;
                        low++;
                       
                   }
                   else
                    {
                        if (arr[low] == 2)
                        { //swap 
                            temp = arr[low];
                            arr[low] = arr[high]; ;
                            arr[high] = temp;
                            low++;
                           
                        }

                        else
                        {
                            temp = arr[middle];
                            arr[low] = arr[middle]; ;
                            arr[middle] = temp;
                            low++;


                        }

                    }
                }
                 
              middle:
                    if (arr[middle] == 1)
                      middle++;
                   else
                   {  

                   }
              high:
                 if (arr[high] == 2)
                    high--;

                 else
                {


                }
            }

        }
    }

}
