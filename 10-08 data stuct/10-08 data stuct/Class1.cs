using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_08_data_stuct
{
    public class DynamicArray
    {
        private int[] data;

        private int capacity; //to define size

        private int count;
        public DynamicArray()
        {
            count = 0;

            capacity = 5;

            data = new int[capacity];
        }
        public void Print()
        {
            if(count == 0)
            {
                Console.WriteLine("DynamicArray is empty");

                return;
            }
            for (int i= 0; i < count; i++)
            {
                Console.Write($"{data[i]} ");
            }
            Console.WriteLine();
        }
    }
}
