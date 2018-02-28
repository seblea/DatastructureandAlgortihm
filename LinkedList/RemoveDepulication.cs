using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
   public class RemoveDepulication
    {
          
       public static void RemoveDublicate(SingleLinkedList li) //using hash table, extra memory
        {
            Hashtable Ha = new Hashtable();

            Node temp = li.Head;
            Node prev;

            // using hash table

            Ha.Add(temp.data, temp.Next);
            prev = temp;

            temp = temp.Next; // start iteration at the second element
            while (temp != null)
            {
                if (Ha.Contains(temp.data)) //it is in the hash

                {
                    prev.Next = temp.Next;
                  
                }
                else
                {
                    prev = temp;
                    Ha.Add(temp.data, temp.Next);
                }
                temp = temp.Next;
            }

        }

        //  if temporary buffer is not allowed
     public static void RemoveDepulicateNoBuffer(SingleLinkedList li) // Itertare for each node  
        {
            Node Iter  = li.Head;
            Node temp;
            bool found = false;
            Node prev = null;
            int Length = li.count;

            for (int i=1;i < Length;i++)
            {
                temp = Iter.Next;
                
                while (temp !=null && found==false)
                {
                    if (Iter.data == temp.data)
                    {
                        found = true;
                        if (Iter != li.Head)
                        {
                            prev.Next = temp.Next;
                            li.count--;
                                                    
                        }
                       else
                        {
                            li.Head = li.Head.Next;
                            Iter = li.Head;
                            prev = null;
                            li.count--;
                        }

                      }
                    else
                    {
                        prev = temp;
                        temp = temp.Next;

                    }
                }
            }
        }

    }
}
