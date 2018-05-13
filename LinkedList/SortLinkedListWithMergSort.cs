using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
   static class SortLinkedListWithMergSort
    {
       public  static  Node MergeSort(Node H)
        {
            if (H.Next == null || H == null)

                return H;

            Node middle = GetMiddle(H);
            Node middlenext = middle.Next;
            middle.Next = null;

            Node left = MergeSort(H);
            Node right = MergeSort(middlenext);

            Node Head = Sort(left, right);

            return Head;

        }

        public static Node Sort(Node left,Node right)
            {
            Node head = null;
            Node rpt = null;
            Node lpt=null;
            Node itr = null;

          // set for the iteration 


            if(left.CompareTo(right) <= 0)
            {
                head = left;
                rpt = right;
                lpt = left.Next;
             }

            else
            {
                head = right;
                rpt = right.Next;
                lpt = left;
            }

            itr = head;

            while(rpt !=null || lpt != null)
            {
                if( rpt.CompareTo(lpt) <=0)
                {
                    itr.Next = rpt;
                    rpt = rpt.Next;

                }
                else
                {
                    itr.Next = lpt;
                    lpt = lpt.Next;

                }
            }

            if (rpt == null)
                itr.Next = left;
            else
                itr.Next = right;


            return head;
        }



            public static Node GetMiddle(Node h)
              {
            if (h == null || h.Next == null)
                return h;

            Node slow = h;
            Node fast = h;
             
            while(fast != null)
            {
                fast = fast.Next;

                if (fast != null)
                {
                    slow = slow.Next;
                    fast = fast.Next;

                }
                 
            }

            return slow;
        }
    }
}
