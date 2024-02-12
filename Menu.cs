using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsAssignment
{
    public class Menu<T> where T:struct
    {
        bool flag = true;
        private GenericStack<T> _stack;
        public Menu(GenericStack<T> stack) 
        {
            _stack = stack;

        }

        public void BeginMenu()
        {
            while (flag)
            {
                Console.WriteLine("Enter 1 to push");
                Console.WriteLine("Enter 2 to pop");
                Console.WriteLine("Enter 3 to peek");
                Console.WriteLine("Enter 4 to check if stack is empty.");
                Console.WriteLine("Enter 5 to display the elements.");
                Console.WriteLine("Enter 0 to exit!");

                var res = Console.ReadLine();

                switch (res)
                {
                    case "1":
                        Console.WriteLine("Enter element to push!");
                        var input = Console.ReadLine();
                        if (string.IsNullOrEmpty(input))
                        {
                            _stack.Push(default(T));
                        } else
                        {
                            T a = (T)Convert.ChangeType(input, typeof(T));
                            _stack.Push(a);
                        }
                        
                        break;
                    case "2":
                        _stack.Pop();
                        break;
                    case "3":
                        Console.WriteLine(_stack.Peek());
                        break;
                    case "4":
                        Console.WriteLine(_stack.IsEmpty());
                        break;
                    case "5":
                        _stack.Display();
                        break;
                    case "0":
                        flag = false;
                        break;
                }

            }

        }

    }
}
