using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace module3_ExploringExamples.Models
{
    public class MyArray<T> //<T> is a type of my array
    {
        private static int capacity = 10;
        private int count = 0;
        private T[] array = new T[capacity];

        public void AddElement(T element)
        {
            if(count + 1 < 11)
            {
                array[count] = element;
            }
            count++;
        }

        public T this[int index]
        {
            get { return array[index]; }
            set { array[index] = value; }
        }
    }
}