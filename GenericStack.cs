using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsAssignment
{
    public class GenericStack<T> where T:struct
    {

        List<T> st = new List<T>();
        public GenericStack() { }

        int Top = -1;

        public void Push(T a)
        {
              
                ++Top;
                st.Add(a);


                
               
            
        }

        public void Pop()
        {
            T elem = st[Top];
            Top--;

        }

        public T Peek()
        {
            return st[Top];
        }

        public bool IsEmpty()
        {
            if (Top==-1) 
            {
                return true;
            } else
            {
                return false;
            }


        }

        public void Display()
        {
            var newTop = Top;
            while (newTop != -1)
            {
                Console.WriteLine(st[newTop]);
                newTop--;

            }
        }
    }


}
