﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class CreateSingleLink
    {
        public SingleLinkedList Create() // create Linked list 
        {

        SingleLinkedList li = new SingleLinkedList();
        char ch;
        int x;

        bool continu = true;

        while(continu==true)
            {
               Console.WriteLine("Would Like to Add a Node ? Type Y for Yes , or Type N for No ");
                ch = Convert.ToChar(Console.Read());

                if (char.ToUpper(ch) == 'Y')
                {
                    x = Console.Read();
                    ch = Convert.ToChar(x);
                    Node n = new Node();
                    n.data = ch;
                    li.Add(n);

                }
                else
                    continu = false;
            }

            return li;

        }
    }
}
