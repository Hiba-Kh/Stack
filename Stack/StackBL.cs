using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    public class MyStack<T>
    {
        
        private int maxSize;
        public T[] objects;
        int top;
        public MyStack(int size)
        {
            top = -1;
            maxSize = size;
            objects = new T[maxSize];
        }
       
        public bool isEmpty()
        {
            return top == -1;
        }
        public bool isFull()
        {
            return top == maxSize - 1;

        }
        public void Push(T data)
        {
            if (isFull())
                Console.WriteLine("No Enough Space!");
            else
                objects[++top] = data;
        }
        public T Pop()
        {
            if (isEmpty())
                return default(T);
            else
                return (T)objects[top--];
        }
        public void Print()
        {
            for (int i = 0; i <= top; i++)
                Console.WriteLine(objects[i]);  
        }
        public void Peak()
        {
            Console.WriteLine(objects[top]);
        }
        public void Clear()
        {
            Array.Clear(objects, 0, maxSize);
            top = -1;
        }

    }
}
