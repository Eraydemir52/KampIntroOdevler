using System;

namespace GenericsOdev
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string> myDictionary = new MyDictionary<string>();
            myDictionary.Add("Eray");
            myDictionary.Add("Sefa");
            myDictionary.Add("Murat");
            myDictionary.Add("Mehmet");
            myDictionary.Add("Mustafa");
            Console.WriteLine(myDictionary.Count);

            foreach (var isim in myDictionary.item)
            {
                Console.WriteLine(isim);
            }


        }
    }
}
