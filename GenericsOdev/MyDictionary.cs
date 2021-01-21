using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsOdev
{
    class MyDictionary<T>
    {
        T[] array;

        public MyDictionary()
        {
            array = new T[0];
        }


        public void Add(T item)
        {
            T[] temparray = array;
            array = new T[array.Length + 1];
            for (int i = 0; i < temparray.Length; i++)
            {
                array[i] = temparray[i];
            }

            array[array.Length - 1] = item;
        }

        public int Count
       {
            get {return array.Length; }
       }
        public T[] item
        {
            get { return array; }
        }



    }
}
