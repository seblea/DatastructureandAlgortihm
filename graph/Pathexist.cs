using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace graph
{
   public  class Pathexist
    {  //Determine if a path exists from a source node to a destination node
        // Graph is defined as class graph .It has a  dictionary collections Graph<int,GraphNode> . Vertices  are define as key of dictionary 
        // Graphode is defined as class with vertices value as int and connected edge with  dictionary<int,int> as neighbour
        public static bool Exist(int  source,int dest,Graph gr)
        {
            Queue<int> node = new Queue<int>();
            bool found = false;
            int parent;
            bool exist = false;

            //check first source and destination are exist

            if (gr.GraphRep.ContainsKey(source) && gr.GraphRep.ContainsKey(dest))
            {
                  gr.GraphRep[source].Visted = true;
                  node.Enqueue(source);

                  while(node != null && found==false)
                  {
                    parent = node.Dequeue();
                    gr.GraphRep[parent].Visted = true; 

                    foreach(int nn in gr.GraphRep[parent].negihbours.Keys)
                    {    if (gr.GraphRep[nn].Visted == false)
                        {
                            gr.GraphRep[nn].parent = parent;
                            if (nn == dest)
                            {
                                found = true;
                                break;
                            }
                            else
                                node.Enqueue(nn);
                        }
                    }
                      

                  }
             }
            
                return exist;
        }
    }
}
