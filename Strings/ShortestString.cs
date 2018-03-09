using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    public static class ShortestString
    { //given two string st1 and st2,find the shortest string that has both st1 and st2 as subsequence

        public static char[] ShortString(string st1, string st2)
        {
            // let first get the largest common subsequence

            char[] st = LongSubSequence.Long(st1, st2);


            int ln1, ln2, ln3, i;
            ln1 = 0;
            ln2 = 0;
            ln3 = 0;


            char[] sst = new char[st1.Length + st2.Length];
            i = 0;

            while (ln1 < st1.Length || ln2 < st2.Length || ln3 < st.Length)
            {
                if (ln1 < st1.Length && ln2 < st2.Length)
                {
                    if (st1[ln1] != st[ln3])
                    {
                        sst[i] = st[ln1];
                        ln1++;
                        i++;
                    }

                    else if (st1[ln2] != st[ln3])
                    {
                        sst[i] = st[ln2];
                        ln2++;
                        i++;
                    }

                    else
                    {
                        sst[i] = st[ln2];
                        ln2++;
                        ln3++;
                        i++;
                    }
                }
                else if (ln1 < st1.Length)
                {
                    sst[i] = st[ln1];
                    ln1++;
                    i++;
                }
                else
                {

                    sst[i] = st[ln2];
                    ln2++;
                    i++;
                }

            }

            return sst;
        }
    }
}
