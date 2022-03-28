using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassIntro
{
    class Sınıflar
    {
        static void Main(String[] args)
        {
            string adi = "Engin";
            int age = 36;

            Kurs kurs1 = new Kurs();
            kurs1.Egitmen = "Engin Demirog";
            kurs1.Fiyati = 199.99;
            kurs1.IzenmeOrani = 99;

            Kurs kurs2 = new Kurs();
            kurs2.Egitmen = "Emre Ulusan";
            kurs2.Fiyati = 30.65;
            kurs2.IzenmeOrani = 40;

            Kurs kurs3 = new Kurs();
            kurs3.Egitmen = "Ahmet Emre";
            kurs3.Fiyati = 199.99;
            kurs3.IzenmeOrani = 99;

            Kurs kurs4 = new Kurs();
            kurs4.Egitmen = "Sadıg Turan";
            kurs4.Fiyati = 199.99;
            kurs4.IzenmeOrani = 99;

            //Console.WriteLine(kurs1.Egitmen + " " + kurs1.Fiyati);

            Kurs[] kurslar = new Kurs[] {kurs1,kurs2,kurs3,kurs4 };

            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.Egitmen+ " " +kurs.Fiyati);
            }
        }



        class Kurs
        {
            public string KursAdi { get; set; }
            public string Egitmen { get; set; }
            public int IzenmeOrani { get; set; }
            public double Fiyati { get; set; }
        }
    }
}
