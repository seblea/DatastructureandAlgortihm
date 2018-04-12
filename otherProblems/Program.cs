using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace otherProblems
{
    class Program
    {
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
    }
}
