using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicProgramming
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter The string you want to generate all distinict permuation");

            string st = Console.ReadLine();

            permituation.Generate(st);
        }

    }
}
