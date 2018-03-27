using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace otherProblems
{
    class InfixtoPostfix
    { 
        public static void InfixToPost(String st) 
        {
            Stack<char> op = new Stack<char>();
            char temp;

            int count = 0;

            while(count < st.Length)
            {
                switch (st[count])
                {
                    case '(':
                        op.Push('(');
                        break;
                    case ')':
                        Console.Write(")");

                          while()
                        break;
                    case '+':
                        op.Push('+');
                        break;
                    case '-':
                        op.Push('-');
                        break;
                    case '':
                        op.Push('(');
                        break;
                }

                if (st[count]=='+' || st[count]== '+')

            }
        }
    }
}
