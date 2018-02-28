using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    class IsCircular
    {  //  check the double linked list is circular or not

        public static void Circular(DoubleLinkedList dl) //using two pointer fast and slow 
        {

            Node fast=dl.Head.Next.Next; // two node ahead 
            Node slow = dl.Head;
            bool cir = false;

            while (fast != null && cir==false)
            {
                if (fast == slow)
                {
                    cir = true; }
                else
                {
                    fast= fast.Next.Next;
                    slow = slow.Next;
                }
            }

            if (cir == true)
                Console.WriteLine("It is Circular");
            else
                Console.WriteLine("It is not Circular");
        }

    }
}
