using System;
using System.Collections.Generic;

namespace MyDictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int , string> myDictionary = new Dictionary<int , string>();
            myDictionary.Add(1, "Kerim");
            myDictionary.Add(2,"Ahmet");

            foreach (var item in myDictionary.Keys)
            {
                Console.WriteLine(item);
            }

            foreach (var item in myDictionary.Values)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine(myDictionary.Count);
            Console.ReadLine(); 
        }
    }
}
