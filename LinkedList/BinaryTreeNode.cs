using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
   public class BinaryTreeNode: IComparable<BinaryTreeNode>
    {
      public  BinaryTreeNode parent=null;
      public  BinaryTreeNode left=null;
      public  BinaryTreeNode right=null;
      public  object data;
      public int rh=-1;// right height
      public int lh=-1;//left height
      public int h=0;//height
      public int depth=0;//

        public  int CompareTo(BinaryTreeNode obj) // object should be binaryTree 
        {
            if (obj == null)
                return -1;

           
            Type ty = data.GetType();

            if (ty == typeof(int))
            {
                int ifirst = Convert.ToInt32(this.data); // this node is greater than 
                int isecond = Convert.ToInt32(obj.data); // this node is less than 

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
                    return -1;
                //else
                //throw new ArgumentException("Object is not a comparable");

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
                    return -1;
                // else
                //   throw new ArgumentException("Object is not a comparable");


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
                    return -1;

                //else
                //   throw new ArgumentException("Object is not a comparable");
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
                    return -1;
                // else
                //    throw new ArgumentException("Object is not a comparable");

            }

            else
                return -1;


        }


    }
}
