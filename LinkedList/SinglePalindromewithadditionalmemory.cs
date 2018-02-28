using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    class SinglePalindromewithadditionalmemory
    {  
        public void palindrome(SingleLinkedList li) // using extra memory , using stack
        {
            Stack<Node> StNode = new Stack<Node>();

            Node ItList = li.Head;
            Node ItLink = null;
            bool found = false;

            // fill the stack

            while(ItList != null)
            {
                StNode.Push(ItList);
                if (ItList.Next != null)

                    ItList = ItList.Next;
                else
                    break;

            }

             ItLink = li.Head;
            //pop from the stack and compare with the linked list

            while (found == false && StNode != null)
            {  if (StNode.Pop().data != ItLink.data)
                {
                    found = true;
                }
                else
                {
                    ItLink = ItLink.Next;
                }

            }

            if(found==false)
            Console.WriteLine("The LinkedList is Palindrome");
            else
            Console.WriteLine("The LinkedList is not Palindrome");
        }

    }
}
