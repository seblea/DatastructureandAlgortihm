using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Divideandconcure
{
   static class Rotateunknownnumbers
    {
        static public  void Rotatate(int[] b)
        {
               string st;
               int rot;
               int siz = b.Length - 1;


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
                     if (rot > 0) // rototate to right
                           {
                                     Tprev = b[b.Length - 1];
                                     for (int i = 0; i <= siz; i++)
                                         {
                                             Tnext = b[i];
                                             b[i] = Tprev;
                                             Tprev = Tnext;
                                           }
                                     rot = rot - 1;

                             }

                       else // to the left
                               {
                                    Tprev = b[0];
                                    for (int j = siz; j >= 0; j--)
                                        {
                                           Tnext = b[j];
                                           b[j] = Tprev;
                                           Tprev = Tnext;
                                         }
                                       rot = rot + 1;
                               }

            }

            for (int i = 0; i <= b.Length - 1; i++)
            {
                Console.WriteLine(b[i]);
            }



        }



    }
}


