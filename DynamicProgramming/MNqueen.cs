using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicProgramming
{
     // putting queens on any given row X column chess board so that none of them share the same row ,coloumn or diagonal .
    class  MNqueen //M by N chess board
    {
        public static void Queen(int row, int coloumn)
        {
            int[] pos = new int[row]; // to track for each row where in which coloumn the queen can sit.

            // set first for each row the queen are not sit in any column with value -1
            for (int i = 0; i < row; i++)
            {
                pos[i] = -1;
            }

            Position(0, row, coloumn, pos); // 

           
            if (pos[0] == -1)//if all value of the pos is -1 .it is not possible to put the queen on the board
                Console.WriteLine("It is not possible to sit the queen in the given chess board ");
            else
                for (int j = 0; j < row; j++)
                {
                    for (int c = 0; c < coloumn; c++)
                    {
                        if (pos[j] == c)
                            Console.Write(" 1");
                        else
                            Console.Write(" 0");
                    }
                    Console.WriteLine();
                }
             }

         static void Position(int at,int row,int coloumn,int[] pos)
        {
         
            bool sit = false;

            if (at == row)

                return;

            if (at == 0) // the first row
            {
                if (pos[at] + 1 >= coloumn) // it is inpossible to sit the queen in the given chess board
                {
                    pos[at] = -1;
                    sit = false;
                    return;
                }
                else
                {
                    pos[0] = pos[0] + 1;
                    sit = true;
                }
            }

            else
            {
                sit = IsSit(at, coloumn, pos);
            }


            if (sit == false)
            {
                Position(at - 1, row, coloumn, pos);
            }
            else

                Position(at + 1, row, coloumn, pos);
            
        }



       static bool IsSit(int at,int coloumn, int[] pos)
        {
            int st ;
            bool eva;
            bool sit = false;
            int i;
            for (st = pos[at] + 1; st < coloumn; st++)
            {
                for ( i = 0; i < at; i++)
                {
                    eva = ( Math.Abs(at - i) == Math.Abs(st - pos[i]) || (st == pos[i]));
                    //Math.Abs(at - i) == Math.Abs(st - pos[i]) for diagonal 
                    //,st ==pos[i]  is on  the same column 
                    if (eva )
                    {
                        break;

                    }
                }

                if (i >= at)
                {
                    pos[at] = st;
                    sit = true;
                   
                }
                if (sit == true)
                    break;

            }

            if (sit == false)
                pos[at] = -1;// It is not possible to sit the queen in the given row ,at. hence resetting the postion to the beginning

            return sit;
        }


        /***
         static void Main(string[] args)
    {
        int row, col;
        row:
        Console.WriteLine("Enter valid integer value for the row ");
        string st = Console.ReadLine();


        if (!(Int32.TryParse(st, out row)))
            goto row;

        coloumn:
        Console.WriteLine("Enter valid integer value for the column ");
        string st1 = Console.ReadLine();


        if (!(Int32.TryParse(st1, out col)))
            goto coloumn;

        MNqueen.Queen(row, col);

    }
**/
         
    }
}
