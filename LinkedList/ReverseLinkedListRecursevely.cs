using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    class ReverseLinkedListRecursevely
     {

        public static Node Reverse(Node N, Node prev, Node next) // return the reversed head pointer
        {
            Node head = null;
            if (N.Next == null)
            {
               N.Next = prev;
                N.prev = next;
                head = N;
            }
            else
            {
              head=Reverse(N.Next, N, N.Next.Next);
                N.Next = prev;
                N.prev = next;

            }
            return head;

        }
    }
}
