using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {

            // type-safety -> Tip güvenliği
            // Do not repeat yourself 
            // Değer tutucu
            string kategoriEtiketi = "Kategoriler";
            int ogrenciSayisi = 34;
            double faizOrani = 1.54;
            bool giris = false;

            double dolarDun = 7.30;
            double dolarBugun = 7.40;

            if (dolarBugun > dolarDun)
            {
                Console.WriteLine("Artış");
            }
            else if (dolarBugun == dolarDun)
            {
                Console.WriteLine("Sabit");
            }
            else
            {
                Console.WriteLine("Düşüş");
            }


           /* if (giris)
            {
                Console.WriteLine("Hoşgeldiniz");
            }
            else
            {
                Console.WriteLine("Bilgiler hatalı");
            }*/

            

        }
    }
}
