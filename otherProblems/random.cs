using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace otherProblems
{
    class Player
    {

       public int[] cards;
      public  string name;
      public  int score;

        Player(string na,int car)
        {
            this.name = na;
            cards = new int[car];

            for(int i=0;i< car; i++)
            {
                cards[i] = 0;
            }

        }

    }

   


    class random
    {
          public static void Play(Player[] pl )
        {

        }

          public static void Shuffle(Player[] pl, int st ,int end, int nocar)
        {
            Random ra = new Random();

           
            for(int i=0;i< nocar;i++)
            {
                 for(int j=0;j< pl.Length; j++)
                {
                    pl[j].cards[i] = ra.Next(st, end);
                }
            }
        }
    }
}
