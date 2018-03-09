using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    class ReplaceSpaceinString // if  there is more than two space next to each other replace as one 
    {  
        public static string Replace(string st , string st2) // replace with any string st2 
        {
            //first how many space is there 
            int count = 0; // count adjsut spaces as one 
            int total = 0;// total number of single space
            int len2 = st2.Length; // replace string lenght
            int newlent;
            char[] newchar;
            int j = 0;// counter for the new charchter array 
           

            for(int i=0; i< st.Length; i++) // count number of space total and  adjust spaces 
            {
                if(st[i]==' ')
                {
                    if (i > 0) // not at the begining of the string  , check the previous char is 
                    {
                        if (st[i - 1] == ' ') // adjusent  space is found 
                        {
                            total++; // 
                        }

                        else
                        {
                            count++; 
                            total++;

                        }
                    }

                    else // space at the beginning
                    {
                      count++;
                      total++;
                    }

                }
            }

            newlent = (st.Length - total) + (len2 * count); // number of char required
            newchar = new char[newlent];

            j = 0; // cunter for the new array 

            for (int i = 0; i < st.Length; i++)  
            {
                if (st[i] == ' ')
                {
                    if (i > 0) // not begining of the string
                    {
                        if (st[i - 1] != ' ')
                        {
                            // replace 
                            foreach (char ch in st2)
                            {
                                newchar[j] = ch;
                                j++;
                            }
                        }
                    }

                    else
                    {
                        foreach (char ch in st2)
                        {
                            newchar[j] = ch;
                            j++;
                        }
                    }
                }


                else // charachter is not space 
                {
                    newchar[j] = st[i];
                    j++;
                }

            }


            return newchar.ToString();

        }
    }
}
