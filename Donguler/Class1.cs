using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Donguler
{
    internal class Class1
    {
        static void Main(string[] args)
        {
            string kurs1 = "Yazılım Geliştirici Yetiştiirme Kampı";
            string kurs2 = "Programlamaya Başlangıç Kursu";
            string kurs3 = "Python Kursu";
            //array - dizi
            string[] kurslar = new string[] { "Yazılım Geliştirici Yetiştiirme Kampı", "Programlamaya Başlangıç Kursu", "Python Kursu","C#" };
         
            for (int i = 0; i < kurslar.Length; i++)
            {
             Console.WriteLine(kurslar[i]);   
            }

            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }

            Console.WriteLine("Sayfa Sonu");
        }
    }
}
 