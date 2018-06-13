using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
/**Animal Shelter: An animal shelter, which holds only dogs and cats, operates on a strictly "first in, first
out" basis. People must adopt either the "oldest" (based on arrival time) of all animals at the shelter,
or they can select whether they would prefer a dog or a cat (and will receive the oldest animal of
that type). They cannot select which specific animal they would like. Create the data structures to
maintain this system and implement operations such as enqueue, dequeueAny, dequeueDog,
and dequeueCat. You may use the built-in LinkedList data structure.
    **/

namespace QueueProblems
{
   public enum AType
    {dog,cat}


    class AnimalShelter
    { private   Queue<animal> dog = new Queue<animal>();
      private   Queue<animal> cat = new Queue<animal>();

        public void Enqueue(animal an)
        {
            an.order = DateTime.Now;
            if (an.type == AType.cat)
            {            
                
                cat.Enqueue(an);

            }
            else
            {
                
              
                dog.Enqueue(an);
            }
        }

        public animal DeQueue(AType tt)
        {
            if (tt == AType.cat)
                if (cat.Count > 0)
                    return dog.Dequeue();
                else
                    return null;
            else
                if (dog.Count > 0)
                return cat.Dequeue();
            else
                return null;
        }

        public  animal DequeOlder()
        {
           animal  ca = cat.Peek();
           animal  dg = dog.Peek();

            if (ca.order < dg.order)
                return cat.Dequeue();
            else
                return dog.Dequeue();

        }

    }

    public  class animal
    {
        public DateTime  order { get; set; }

        public string name { get; set; }
        public float age { get; set; }
        public  AType type { get; set; }

        public animal(AType tt)
        {
            this.type = tt;
        }
        
    }
}
