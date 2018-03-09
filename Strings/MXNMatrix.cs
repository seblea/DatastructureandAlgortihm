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
            int row, column;

            for (int i =0; i< m; i++)
            {
                for(int j=0; j< n; j++)
                {
                    if (mat[i, j] == 0)
                    {
                        row = i;
                        column = 0;

                        while(column < n) // set column
                        {
                            mat[i, column] = 0;
                            column++;
                        }

                        
                        row = 0;
                        column = j;
                        while (row < m) //set rows
                        {
                            mat[row, column] = 0;
                            row++;
                        }
                    }
                }
            }

            Console.WriteLine("Sucessfuly Finished");
        }
    }
}
