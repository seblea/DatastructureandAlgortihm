using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    public class Node
    {
        public Node Next = null;
        public char data;


        public Node(char par)
        {
            data = par;

        }
    }
}
