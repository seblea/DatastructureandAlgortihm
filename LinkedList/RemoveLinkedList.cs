using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
   public static class RemoveLinkedList
    {         
        public static void Remove(SingleLinkedList lt,Node N) 
        {
            Node iter = lt.Head;
                  
            Node prev = null;
            if (iter != null)
            {        

                while ((iter.data != N.data) || iter != null)
                {
                    prev = iter;
                    iter = iter.Next;

                }
                if (iter != null) // set previous node of next pointer with  found node next pointer
                {
                    if (iter == lt.Head) // if it is at head
                        lt.Head = lt.Head.Next;
                    else
                        prev.Next = iter.Next;
                    

                    Console.WriteLine("Sucessfully remove");
                }
            }

            else
            {
                Console.WriteLine("there is no such node to remove");

            }
        }

        

    }
}
