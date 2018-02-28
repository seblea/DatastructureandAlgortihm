using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{  
    public class SingleLinkedList
    {
        Node Head=null;
        int count=0;
        Node iter=null;

        public Node Remove(Node N)
        {
            Node prev = null;
            if (count > 0)
            {
                iter = Head;

                while ((iter.data != N.data) || iter != null)
                {
                    prev = iter;
                    iter = iter.Next;

                }
                if (iter != null)
                {
                    prev.Next = iter.Next;
                    Console.WriteLine("Sucessfully remove");
                }
            }

            else
            { Console.WriteLine("there is no such node to remove");

            }

            public void Add(Node P) {
                if (count > 0)
                {
                    iter = Head;

                    while (iter.Next == null)
                    {
                        iter.Next = P;
                        count++;
                    }


                }
                else
                {
                    this.Head = N;


                }

            }

        }

   
}
