using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Divideandconcure
{
   static class Rotateunknownnumber
    {
       public static void Rotatate(int[] b)
        {
            string st;
            int rot;


            Enterrotate:
            Console.WriteLine("How many times to rotate");
            st = Console.ReadLine();
            if (!int.TryParse(st, out rot))
            {
                Console.WriteLine("Enter integer number");
                goto Enterrotate;
            }

            int Tnext;
            int Tprev;

            while (rot != 0)
            {
                if (rot > 0)
                {
                    b[0] = b[b.Length - 1];
                    Tnext = b[0];
                    Tprev = b[0];
                    for (int i = 1; i <= b.Length - 1; i++)
                    {
                        Tnext = b[i];
                        b[i] = Tprev;
                        Tprev = Tnext;

                    }
                    rot--;

                }

                else
                {
                    b[b.Length - 1] = b[0];
                    Tnext = b[b.Length - 1];
                    Tprev = b[b.Length - 1];
                    for (int i = b.Length - 1; i >= 0; i--)
                    {
                        Tnext = b[i];
                        b[i] = Tprev;
                        Tprev = Tnext;

                    }
                    rot++;
                }

            }

          
        }



    }
}


