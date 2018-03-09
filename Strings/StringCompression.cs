using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    class StringCompression
    {
        public static string Compression(string st)
        {
            char[] co = new char[st.Length];

            int count = 1; // number of character appears sequentially


            int len = 1; // length of new compression string
            int i = 1; // counter for the string index
            int j = 0;// index for compressed array 

            char ch = st[0];
            co[j] = ch;

            while (len < st.Length && i < st.Length) // while compressing the length shouldn't be greater than the given string lemght
            {
                if (st[i] == co[j])
                {
                    count++;
                    i++;
                }

                else
                {
                    j++;
                    co[j] = (char)count;

                    j++;
                    co[j] = st[i];

                    len = len + 2;
                    count = 1;

                    i++;

                }


            }

            if (len < st.Length) // if the length of the compressed less than the given string
            {
                string str = co.ToString();

                return str.Substring(0, len);


            }
            else

                return st;


        }
    }
}
