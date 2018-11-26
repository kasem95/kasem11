using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VectorEX
{
    class Program
    {
        static void Main(string[] args)
        {
            IntegersVector blad = new IntegersVector();
            blad.Add(5);
            blad.Add(10);
            blad.Add(1);
            for(int i = 0;i<3;i++)
            {
                Console.WriteLine(blad.Get(i));
            }
        }
    }
    class IntegersVector
    {
        int[] integers;
        int position;

        public IntegersVector()
        {
            position = -1;
            integers = new int[1];
        }

        public void Add(int newInteger)
        {
            if (integers.Length == position + 1)
            {
                integers[position] = newInteger;
            }
            
        }

        public int Get(int index)
        {
            return integers[index];
        }

        public bool IsEmpty()
        {
            return position == -1;
        }

        public int Size()
        {
            return position;
        }

        private void EnlargeVector()
        {
            int[] temp = new int[(position+1)*2];
            integers.CopyTo(temp, 0);
            integers = temp;
        }
    }
}
