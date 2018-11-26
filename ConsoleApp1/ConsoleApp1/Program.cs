using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack s = new Stack(3);
            s.Push(1);
            s.Push(2);
            s.Push(3);
            s.Push(4);
            s.Push(4);
            Console.WriteLine(s.Pop());
            Console.WriteLine(s.Pop());
            Console.WriteLine(s.Pop());
            Console.WriteLine(s.Pop());
            Console.WriteLine(s.Pop());

            Console.WriteLine("____________________________");
            s.Push(1);
            s.Push(2);
            s.Push(3);
            s.Push(4);
            s.Push(4);

            while(s.Peek() != -1)
            {
                Console.WriteLine(s.Pop());
            }
        }
    }

    class Stack
    {
        int[] values;
        int pointer;

        public Stack() : this(10)
        {
            //values = new int[10];
        }

        public Stack(int size)
        {
            values = new int[size];
            pointer = -1;
        }

        public void Push(int newValue)
        {
            if (pointer == values.Length - 1)
            {
                Console.WriteLine("Stack is full!!");
            }
            else
            {
                values[++pointer] = newValue;
            }
        }

        public int Pop()
        {
            
            if (pointer >= 0)
            {
                int ret = values[pointer];
                values[pointer--] = 0;
                return ret;
            }
            else
            {
                Console.WriteLine("pop() - Stack is empty!!");
                return pointer;
            }
        }

        public int Peek()
        {
            if(pointer<0)
            {
                Console.WriteLine("peek() - Stack is empty!");
                return pointer;
            }
            return values[pointer];
        }

        public bool IsEmpty()
        {
            return pointer == -1;
        }
    }
}
