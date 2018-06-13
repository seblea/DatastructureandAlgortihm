using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace graph
{
   public  class Graph
    {
       public  Dictionary<int, GraphNode> GraphRep;

        public Graph()
        {
            GraphRep = new Dictionary<int, GraphNode>();
        }
    }
}
