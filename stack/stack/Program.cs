using System;
using System.IO;

namespace stackSpace
{
    class Stack<T>
    {
        private List<T> list;

        public Stack()
        {
           list = new List<T>();
        }
        public void Push(T value)
        {
            list.Add(value);
        }
        public T? Pop()
        {
            if(list.Count > 0)
            {
                T returnedVal = list[list.Count - 1];
                list.RemoveAt(list.Count - 1);
                return returnedVal;
            }
            return default(T);
        }
        public void Print()
        {
            foreach(T value in list)
            {
                Console.Write(value + " ");
            }
            Console.WriteLine();
        }
        public T Peak() { 
            if(list.Count > 0 )
            {
                return list[list.Count - 1];
            }
            return default(T);
        }
        public void Clear()
        {
            list.Clear();
        }
    }

    class Test
    {
        public static void Main(string[] args) { 
            Stack<int> stack = new Stack<int>();
            Console.Write("Empty stack: ");
            stack.Print();
            Console.Write("Stack after pushing (42, 43, 44): ");
            stack.Push(42);
            stack.Push(43);
            stack.Push(44);
            stack.Print();
            Console.Write("Pop then push the top: ");
            stack.Pop();
            stack.Push(stack.Peak());
            stack.Print();
            Console.Write("Clear stack: ");
            stack.Clear();
            stack.Print();
        }
    }
}