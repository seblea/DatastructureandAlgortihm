using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    class PartitionLinkedList
    {
        public static void Partition(DoubleLinkedList lt,object x) // revious pointer is linear 
        {
            Node iter = lt.Head;

            Node prev = null; 
            Node next = null;
            Node IPrev = null;
            Node INext = null;
            Node look = null;
            char dir = 'L';  // it is in the left
            /*get first the value x  ,keep previous and next pointer of the node
             *  consider cases
             *    if it is at Head 
             *    if it is in the middle or at end
             *    create and expand partion arround the give node.if the node requires moving ,move to next to the given node .if the node is in the right side leave ,don't move .
             *    
             * **/
            if (lt.Head != null) // check there is an element in the list
            {

                while ((iter.data != x) || iter != null) // get first the given node and let 'look' pointer to point at
                {
                    prev = iter;
                    iter = iter.Next;

                }
                if (iter.data == x)
                {
                    next = iter.Next;
                    look = iter;

                }
            }

            else
                Console.WriteLine("There is no any element in the given list");




            if (look == null) // end excuetion the given node is not found
            {
                Console.WriteLine(" The give node isnot found");
                return;

            }

                // set direction of iteration ,direction from the node ,if the node is found at head  then dir is right ,if it is at end or in the middle set with Left

                if (look == lt.Head)
                   dir = 'R'; // right
                else
                  dir = 'L'; //left 

            iter = lt.Head;
            IPrev = null;
            INext = lt.Head.Next; // next iterator
            prev = look; // pointer around the partion node , left ptr where moved node being inserted
            next = look; // pointer around the partion node , right ptr where moved node being inserted

            while (iter != null)
            {  if(iter.CompareTo(look.data) >= 0 && dir =='L') // move the node right to
                {
                    //deletion 
                    INext.prev = IPrev; // set prvious ptr of the next node 
                    IPrev.Next = INext; // set next pointer of the previous node to the next node to be iterat

                    if (lt.Head == iter)
                        lt.Head = iter.Next; // if the node is head , adjust head to next node

                    iter.Next = next.Next; //  insertion
                    iter.prev = next;
                    next.Next.prev = iter;
                    next.Next = iter;


                    next = iter ; //set right boundary

                    // set the iteration  pointer where it should resume

                    iter = INext;
                    INext = iter.Next;

                          if (iter == prev) // while moving to the right and get to left boundary ,jump the iteration to the right
                               {
                                  iter = next.Next; //
                                  IPrev = next;
                                  INext = iter.Next;
                                  dir = 'R'; // iteration is in the right side of the pation node

                              }

             else if (iter.data < look.data && dir == 'R') //Move to the left
                    {

                        INext.prev = IPrev; //deletion
                        IPrev.Next = INext;

                        iter.Next = prev; // insertion to the left
                        iter.prev = prev.prev;
                        prev.prev.Next = iter;
                        prev.prev = iter;

                        prev = iter; //set left boundary

                        // resum the ieration

                        iter = INext;
                        INext = iter.Next;



                    }

                  else // don't move ,keep iteration to right

                    {
                        IPrev = iter;
                        iter = iter.Next;
                        INext = iter.Next;

                        if (iter == prev) // while moving to the right and get to left boundary ,jump the iteration
                        {
                            iter = next.Next;
                            IPrev = next;
                            INext = iter.Next;
                            dir = 'R';

                        }

                    }


                }

            }

            Console.WriteLine("The list is sucessfully partion");
         

        }
    }
}
