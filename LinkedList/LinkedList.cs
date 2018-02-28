using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    class LinkedList
    {
        public static void Main()
        {
            string ans;
            string con;

            menu:

            Console.WriteLine("Type 1 ,Check Linked Singly List is Palindrome ");
            Console.WriteLine("Type 2 ,Check Linked Double List is Palindrome ");
            Console.WriteLine("Type 3 ,Linked List is Circular");
            Console.WriteLine("Type 4 ,Clone Linked list wth random number");
            Console.WriteLine("Type 5 ,Remove duplicates from the unsorted Linked list with temporary buffer allowed");
            Console.WriteLine("Type 6 ,Remove duplicates from the unsorted Linked list with temporary buffer is not allowed");
            Console.WriteLine("Type 7 ,Find Kth element from the last in Sigly Linked list");
            Console.WriteLine("Type 8 ,delete the node from  in Sigly Linked list,given only access on that node");
            Console.WriteLine("Type 9 ,Partion a linked list around the value x,such that all nodes less than X come before  all Nodes greater than or equal to X ");
            Console.WriteLine("Type 10 ,Riverse Linked List , Recursively");
            Console.WriteLine("Type 11 ,Riverse Linked List , Iterteively");
            Console.WriteLine("Type 12 ,Given a singly linked list in ascending ,construct a balanced BST");

            try
            {
                ans = Console.ReadLine();
            }
            catch (Exception e)
            {
                Console.WriteLine("{0} Exception caught.", e);
                goto menu;
            }


            switch (ans)
            {
                case "1":
                  

                    break;
                case "2":
                  
                    break;
                case "3":
                   
                    break;
                case "4":
                    
                    break;
                case "5":
                    
                    break;
                case "6":
                   
                    break;
                case "7":

                    break;
                case "8":

                    break;
                case "9":

                    break;
                case "10":

                    break;

                default:
                    {
                        Console.WriteLine("Invalid type");
                        break;
                    }


            }
            Console.WriteLine("Continue  Y or N  ?");
            con = Console.ReadLine().ToUpper();
            if (con == "Y")
                goto menu;
            else
                Console.ReadKey();
        }
    }
}
