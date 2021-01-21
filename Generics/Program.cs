using System;
using System.Collections.Generic;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> sehirler1 = new List<string>();
            sehirler1.Add("Ordu");
            
           
            MyList<string> sehirler2 = new MyList<string>();
            sehirler2.Add("İstanbul");
            sehirler2.Add("İstanbul");
            sehirler2.Add("İstanbul");
            sehirler2.Add("İstanbul");
            Console.WriteLine(sehirler2.Count);






        }
    }

    class MyList<T>//Generic class
    {
        T[] array;
        T[] temparray;
        public MyList()
        {
            array = new T[0];
        }
        public void Add(T item)
        {
             temparray = array;// geçici dizi
            array = new T[array.Length+1];
            for (int i = 0; i < temparray.Length; i++)
            {
                array[i] = temparray[i];
            }
            array[array.Length - 1] = item;
        }

     

        public int Count
        {
            get { return array.Length; }

        }


    }



}
