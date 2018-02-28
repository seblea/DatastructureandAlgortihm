using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    class ReverseLinkIteratevely
    {
        public static void Reverse(DoubleLinkedList dl)
        {
            Node current = dl.Head;
            Node prev = null;
            Node next = null;

            while(current != null)
            {
                next = current.Next;
                current.prev = next;
                current.Next = prev;
                prev = current;
                current = next;
            }

            dl.Head = prev;
            Console.WriteLine("The Linked List is sucessfully reverse");
        }
    }
}
