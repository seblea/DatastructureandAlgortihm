using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace StackProblem
{
    static class ReverseStack
    { public static void Reverse(Stack<string> st)
        {
            string temp;
            int count, count2;
            Stack<string> stemp = new Stack<string>();

            count = 0;
            count2 = 0;
            //reversly push to another stack
            while (count < st.Count)
            {
                temp = st.Pop(); // temporarly the

                while (count2 > 0) // pop from temp stack and back to the first stack to get space for the pop element
                {
                    st.Push(stemp.Pop());
                    count2--;
                }

                count2 = count;

                stemp.Push(temp);

                while (count2 > 0) // pop from the first stack and back to the second stack 
                {
                    stemp.Push(st.Pop());
                    count2--;
                }

                count2 = count;

                count++;
                count2 = count;

            }

            // push reversed to the first one
            count = 0;
            while (count < stemp.Count)
            {
                st.Push(stemp.Pop());
                count++;
            }

            Console.WriteLine("Sucessfully the stack is reversed");


        }
    }
}
