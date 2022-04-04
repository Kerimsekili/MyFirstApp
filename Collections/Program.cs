 using System;
 using System.Collections.Generic;

 namespace Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string[] names = new string[] {"Ahmet","Kerim","Arslan","Mahmut" };
            //Console.WriteLine(names[1]);

            List<string> names2 = new List<string>(){ "Ahmet", "Kerim", "Arslan", "Mahmut" };
            Console.WriteLine(names2[0]);
            Console.WriteLine(names2[1]);
            Console.WriteLine(names2[2]);
            Console.WriteLine(names2[3]);
            names2.Add("Furkan");
            Console.WriteLine(names2[4]);
        }
    }
}
