using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{  
    public class DoubleLinkedList
    {
       public Node Head=null;
       public  int count=0;
       
        Node iter=null;

        public void Remove(Node N)
        {
           
            if (count > 0)
            {
                iter = Head;

                while ((iter.data != N.data) || iter != null)
                {
                    iter = iter.Next;

                }
                if (iter != null)
                {
                    count--;
                    iter.Next = iter.Next.Next;
                    iter.Next.prev = iter;
                    Console.WriteLine("Sucessfully remove");
                }
            }

            else
            {
                Console.WriteLine("there is no such node to remove");

            }
        }

            public void Add(Node P) {
                if (count > 0)
                {
                    iter = Head;

                    while (iter.Next != null)
                    {
                      iter = iter.Next;
                       
                    }

                       iter.Next = P;
                       P.prev = iter;
                       count++;
                }
                else
                {
                    this.Head = P;


                }

            }

        }

   
}
