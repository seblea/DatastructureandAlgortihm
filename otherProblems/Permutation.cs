using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace otherProblems
{  // Generate distinct permuation for the given string 
    public static class permituation
    {
        public static void Generate(string st)
        {

            Dictionary<string, int> permu = Permuation(st, 0, st.Length); // starting index 0 given lenght of the stirng

            foreach (string s in permu.Keys)

                Console.Write(s.ToString() + " ");
            Console.ReadLine();

        }

        private static Dictionary<string, int> Permuation(string pst, int sta, int len) // generate permuation starting from the given index upto the end of the string
        {
            Dictionary<string, int> stcoll = null; // to point to generated  substring permuation collection ,starting from sta +1 up to the end
            Dictionary<string, int> ans = new Dictionary<string, int>(); // after getting collection of  permuation for index Sta +1 upto end , generate permuation for 
            //sta upto end , placing character  st[sta] in differet position with generated permuation for sta +1 
            if (len == 1)
            {
                string s = pst.Substring(sta, 1);
                ans.Add(s, 1);
                return ans;

            }

            else

            {
                stcoll = Permuation(pst, sta + 1, len - 1); //permuation for sta + 1 ;

                string c = pst[sta].ToString();
                string sa;

                // generate permuation for sta up to the end 
                foreach (string ss in stcoll.Keys)
                {

                    for (int i = 0; i < len; i++) // starting from the postion 0 ,place character st[sta] into different postion 
                    {
                        sa = Put(c, ss, i);
                        if (!ans.ContainsKey(sa))
                            ans.Add(sa, len);
                    }


                }

                return ans;

            }



        }

        private static string Put(string a, string ps, int l)
        {
            if (l == 0)
            {
                return a + ps;
            }

            if (l == ps.Length)
                return (ps + a);
            else
                return ps.Substring(0, l - 0) + a.ToString() + ps.Substring(l, ps.Length - l);
        }

    }
}
