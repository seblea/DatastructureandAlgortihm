using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    class GetKthtotheLast // 
    {
        static Node GetKthlast(SingleLinkedList li,int k)
        {
            Node Iter = li.Head;
            Node IterK = li.Head;
             int count = 0;
                       
            // set IterK  at kth node from the head 
            while(count < k && IterK != null)
            {
                IterK = IterK.Next;
                count++;
            }

             if( count < k)
            {
                Console.WriteLine(" Number of element in the List is lessthan  {0}", k);
                return null;
            }
             // 
            while(IterK != null ) // iterk is leading iter with k node ahead
            {
                IterK = IterK.Next;
                Iter = Iter.Next;

            }

            return Iter;
          

        }
    }
}
