using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    class CloneLinke // // with out extra buffer
    { public DoubleLinkedList CloneLinkList(DoubleLinkedList dl) // with out extra buffer
        {
            Node current = dl.Head; 
            Node next ;
            bool cont = true; // loop controler

            if(current ==null)
            {
                Console.WriteLine("Empty List ");
                return null;

            }

            DoubleLinkedList CloneHead = new DoubleLinkedList(); // POINTER to the head of the clone
            Node ClonePointer = new Node(); // poiner for the clone
            CloneHead.Head = ClonePointer;

            while (cont==true) //set Node that cloned point  to clone node ,clone node point to the next node of the cloned node 
            {
                ClonePointer.data = current.data; // clone the data
                ClonePointer.Next = current.Next;
                current.Next= ClonePointer; // point cloned to clone one
                current = ClonePointer.Next;

                if(current != null)
                
                   ClonePointer = new Node(); // follower for the clone
                else
                    break;
                
               
            }

            current = dl.Head;
            ClonePointer = CloneHead.Head; // set the iterator pointer back to head 

            while (cont == true) //set the  clone node arbitrary pointer
            {
                next = ClonePointer.Next; 
                ClonePointer.prev = current.prev.Next; // set arbitrary pointer of clone node
               
                current = next;

                if (current == null)
                    break;

            }

            //set back the cloned and clone node next pointer
            current = dl.Head;
            ClonePointer = CloneHead.Head;

            while (current != null)
            {
               next= ClonePointer.Next;
               current.Next = next;
               ClonePointer.Next = ClonePointer.Next.Next;

                current = next;
            }

               return CloneHead;
        }

    }
}
