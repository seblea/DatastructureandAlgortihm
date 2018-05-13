using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{ // write an algorithm such that if an element in a M xN matrix is 0 set entire rows and columns to zero
    class MXNMatrix
    {
        public static void SetZero(int[,] mat, int m,int n)
        {
            int[] column=new int[n];
            int[] rows = new int[m];
            int col = 0;
            int ro = 0;
            int col2 = 0;
            bool br = false;

            for(int k=0;k < n;k++)
            {
                column[k] = 1;
            }

            for (int t = 0; t < n; t++)
            {
                rows[t] = 1;
            }



            for (int row =0; row< m; row++)
            {
                col = 0;
              while(col <= n)
                {
                    if(mat[row,col] == 0)
                    {
                      
                        br = true;
                       
                        // check if that columns value before
                        if (column[col] != 0)
                        {
                            ro = 0;
                            while (ro <= row) // already visted columns
                            {
                                mat[ro, col] = 0;
                                ro++;
                            }
                        }
                        else
                              column[col] = 0;



                        if (rows[row] != 0)
                        {
                            col2 = 0;
                            while (col2 <= col)
                            {
                                mat[row, col2] = 0;
                                col2++;
                            }

                            rows[row] = 0;
                        }
                    }
                    else
                    {
                        if (rows[row] == 0 || column[col]==0)
                        {
                            mat[row, col] = 0;
                        }

                    }

                    col++;

                }
                 
            }

            Console.WriteLine("Sucessfuly Finished");
        }
    }
}
