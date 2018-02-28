using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    class DoublePalindrome

    {  public void Palindrome(DoubleLinkedList dl) // the previous is linear  , not arbitrary pointer
        {
            Node front = dl.Head;
            Node back = front;
            bool found = false;

            // set back pointer  to the end , compare the end with the front till the middle

            while(back.Next != null)
            {
                back = back.Next;
            }

            while(front != back && found==false) // if front==back , Lenght of string is Odd
            {   if(front.data != back.data) 
                {
                    found = true;
                    break;

                }
                front = front.Next;
                if (front == back) // the string has even lenght ,aleadry in the middle
                    break;
                else
                    back = back.prev;

            }

        }
    }
}
