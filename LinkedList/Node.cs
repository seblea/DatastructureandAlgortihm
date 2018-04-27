using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class Node :IComparable<Node>
    {
        public Node Next = null;
        public Node prev = null;
        
        public object data;

        public  Node(object da)
        {
            this.data = da;
        }

        public int CompareTo(Node obj)
        {
            if (obj == null) return 1;

            
                             
            Type ty = data.GetType();

            if (ty == typeof(int))
            {
                int ifirst = Convert.ToInt32(this.data);
                int isecond = Convert.ToInt32(obj.data);

                if (obj != null)

                {
                    if (ifirst > isecond)
                        return 1;
                    else if (ifirst < isecond)
                        return -1;
                    else
                        return 0;
                }

                else
                    // throw new ArgumentException("Object is not a comparable");
                    return -2;
            }

            else if (ty == typeof(string))
            {
               string sfirst = Convert.ToString(this.data);
               string isecond = Convert.ToString(obj.data);

                if (obj != null)
                {
                   return sfirst.CompareTo(isecond);
                }

                else
                    // throw new ArgumentException("Object is not a comparable");
                    return -2;

            }

            else if (ty == typeof(double))
            {
                double dofirst = Convert.ToDouble(this.data);
                double dosecond = Convert.ToDouble(obj.data);

                if (obj != null)

                {
                    if (dofirst > dosecond)
                        return 1;
                    else if (dofirst < dosecond)
                        return -1;
                    else
                        return 0;
                }

                else
                    // throw new ArgumentException("Object is not a comparable");
                    return -2;
            }

            else if (ty == typeof(decimal))
            {
                Decimal dfirst = Convert.ToDecimal(this.data);
                Decimal dsecond = Convert.ToDecimal(obj.data);

                if (obj != null)

                {
                    if (dfirst > dsecond)
                        return 1;
                    else if (dfirst < dsecond)
                        return -1;
                    else
                        return 0;
                }

                else
                    //throw new ArgumentException("Object is not a comparable");
                  
                    return -2;
            }


        }


           
        }
    }

