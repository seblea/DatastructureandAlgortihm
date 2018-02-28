using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackProblem
{
    static class MissingParenthesis
    {
        static  Stack<char> Parenthesis(string st) // if you get the open parenthisis push to the stack ,if you get closed parenthis  pop from the stack and compare
        {
            Stack<char> par = new Stack<char>();
            Stack<char> result= new Stack<char>();
            char temp;

            foreach (char t in st)
            {
                if (t == '(')
                    par.Push(t);
                else if (t == ')')
                {
                    temp = par.Pop();
                    if(temp != t)
                    {
                        result.Push(temp);
                    }


                }
            }
            return result;
        }
    }
}
