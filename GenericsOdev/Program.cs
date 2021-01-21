using System;

namespace GenericsOdev
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int> myDictionary = new MyDictionary<int>();
            myDictionary.Add(3);
            myDictionary.Add(4);
            myDictionary.Add(5);
            myDictionary.Add(6);
            myDictionary.Add(7);
            Console.WriteLine(myDictionary.Count);
          
        }
    }
}
