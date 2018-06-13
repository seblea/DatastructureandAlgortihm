using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace graph
{   //
    public class GraphNode
    {
        public int Vertices { get; set; }

        public Dictionary<int,int> negihbours=new Dictionary<int, int>();// int vertices 
        public int parent;
        public  bool Visted {get;set;}

        public Dictionary<int,int> GetNegihbours()
        {
            return negihbours;
        }

        public void AddNegihbours(int nd)
        {
            if(!negihbours.ContainsKey(nd))
               negihbours.Add(nd,nd);
        }
        public void RemoveNeghibhours(int nd) // undirected graph
        {
            if (negihbours.ContainsKey(nd))
                negihbours.Remove(nd);

        }

    }
}
