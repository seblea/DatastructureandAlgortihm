using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Divideandconcure

{
    static class Splitthearrayintotwo
    {
      public  static void Split(int[] b)
        {
            int sum = 0;
            int res;
            bool Found=false;
            int len = b.Length;
            int[] b1 = new int[len - 1];
            int[] b2 = new int[1];
            int i = 0; //counter
            List<int[]> sparray = new List<int[]>();

            // summup first
                 for ( i = 0; i < len; i++)
                  {
                     sum = sum + b[i];
                  }

            // check the result is  divisible by two
            res = (sum % 2);
            if (res > 0)
            {
                Console.WriteLine("The array can't split");
                
            }
            else
            {
                Found = false;
                i = 0;
                do
                {
                    if (b[i] == sum/2)
                        Found = true;
                    else
                       i++;
                }
                while (Found == false && i < len);
             }

                       
                if (Found == true)
                {// split the araay
                    b2[0] = b[i]; // sum of n-1
                int j = 0;
                int v = 0;
               
                
                do
                {   if (j == i)
                    {
                          v++;
                    }
                    b1[j] = b[v];
                    
                    j++;
                    v++;
                }while (j < b1.Length);
                              
                     sparray.Add(b1);
                     sparray.Add(b2);
                            

                          
                // disply the split
                Console.WriteLine("Split Arrays are");

                     foreach(int [] sp in sparray)
                        {
                             for(i = 0; i < sp.Length; i++)
                             {
                                 Console.Write(sp[i]);
                                  Console.Write(" ");
                              }
                             Console.WriteLine();
                        }
                     }

                else
                {
                    Console.WriteLine("The array can't split");
                    
                }
              
            }
        }
    }


