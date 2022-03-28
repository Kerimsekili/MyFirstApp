using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KampIntro
{
    class Program
    {
        static void Main(String[] args)
        {
            //type safety
            string kategoriEtiketi = "Kategori";
            int ogrenciSayisi = 12344;
            double faizOrani = 1.55;
            bool sistemeGirisYapmisMi = true;
            double dolarDun = 14.65;
            double dolarBugun = 15.20;

            if (dolarDun > dolarBugun)
            {
                Console.WriteLine("Azalış Oku");
            }
            else if (dolarDun< dolarBugun)
            {
                Console.WriteLine("Artış Oku");
            }
            else
            {
                Console.WriteLine("Değişmedi");

            }
            

                if (sistemeGirisYapmisMi == true)
            {
                Console.WriteLine("User Settings Button");
            }
            else 
            {
                Console.WriteLine(kategoriEtiketi);
            }
            
        }

    }


}
