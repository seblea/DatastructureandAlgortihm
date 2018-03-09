using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    public static class LongSubSequence
    { 
        public static char[] Long(string st1, string st2)
        {
            int m = st1.Length + 1;
            int n = st2.Length + 1;
            int[,] mat = new int[m, n];
            int max = 0;
            int count = 0;
            int i, j,s; // counter for the loop

            char[] st;
            

            // let construct  m X n matrics

            for(i =0; i < m; i++)
            {
                for( j=0; j< n; j++)
                {
                    if(i==0 || j == 0)
                    {
                        mat[i, j] = 0;
                    }

                    else
                    {  if (st1[i - 1] == st2[j - 1])  // if eqaul go back diagonal and add 1
                        {
                            mat[i, j] = mat[i - 1, j - 1] + 1;
                        }
                        else // not eqaul take maximum of left or up cell 

                            mat[i, j] = mat[i, j - 1] >= mat[i - 1, j] ? mat[i, j - 1] : mat[i - 1, j];

                    }

                }
            }

            max = mat[m - 1, n - 1]; // length of the subsequence

            st = new char[max]; // to hold the subsequence character
            // back track the sub sequence

            i = m - 1;
            j = n - 1;
            s = max - 1;

            while(count < max)
            {
                if (st1[i - 1] == st2[j - 1]) // if it is much pick the charachter and go back diagonal
                {
                    count++;
                    st[s] = st1[i - 1];
                    i = i - 1;
                    j = j - 1;
                }
                else // select from the top and left whic is maximum , default to left
                {
                    if(mat[i - 1,j] > mat[i,j-1] )
                      {
                        i = i - 1;

                      }
                    else
                     {
                        j = j - 1;
                     }
                }



            }

           
            return st;
        }
    }
}
