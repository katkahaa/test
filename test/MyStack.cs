using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class MyStack<T>
    {
        T[] stack;
        int index;
        public MyStack(int max = 100)
        {
            stack = new T[max];
            index = -1;
        }

        public void Push(T t)
        {

            stack[++index] = t;
        }

        public T Pop()
        {
            try
            {
                return stack[index--];
            }
            catch (Exception r)
            {
                Console.WriteLine(r.Message);
                Console.ReadLine();
                return default;
            }
        }

        public T Peek()
        {
            try
            {
                return stack[index];
            }
            catch (Exception r)
            {
                Console.WriteLine(r.Message);
                return default;
            }
        }

        public bool IsEmpty()
        {
            if (stack.Length == 0)
                return true;
            return false;
        }

        public void PrintStack()
        {
            foreach (var item in stack)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }
}
