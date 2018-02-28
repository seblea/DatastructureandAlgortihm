using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Divideandconcure;

namespace Divideandconcure
{
    class Arrayproblem
    {
        public static void Main(string[] args)
        {
            string ans;
            string con;

            menu:
            Console.WriteLine("Type 1 ,Find element in a sorrted array appear once");
            Console.WriteLine("Type 2 ,Find Majic index in array");
            Console.WriteLine("Type 3 ,Find element in  sorted Array that rotated n times");
            Console.WriteLine("Type 4 ,Array Contains number from 1 to n-1 and exactly 1 duplicate");
            Console.WriteLine("Type 5 ,Search an element in Array where the difference beteen Adjacent is 1");
            Console.WriteLine("Type 6 ,Split the array into two where one array contains sum of n-1 numbers");
          
            try
            {
                 ans = Console.ReadLine();
            }
            catch(Exception e)
            {
                Console.WriteLine("{0} Exception caught.", e);
                goto menu;
            }


            switch (ans)
            {
                case "1":
                    int[] b = GetArray.GetNArray();
                    AppearOnce.Distinct(b);
                    
                    break;
                case "2":
                    int[] c = GetArray.GetNArray();
                    MagicIndex.Magindex(c);
                    break;
                case "3":
                    int[] d = GetSorrtedArray.GetArray();
                    Rotateunknownnumbers.Rotatate(d);
                    FindInSortedRotattedArray.Findval(d);
                    break;
                case "4":
                    int[] e = GetArray.GetNArray();
                    FindDuplicate.Duplicate(e);
                    break;
                case "5":
                    int[] f = GetArray.GetNArray();
                    Adjacentelement.Adjacent(f);
                    break;
                case "6":
                    int[] g = GetArray.GetNArray();
                    Splitthearrayintotwo.Split(g);
                    break;

                default :
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
