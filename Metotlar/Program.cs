using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            Urun urun1 = new Urun(); // Urun classından bir örnek oluşturduk
            urun1.Adi = "Elma";
            urun1.Fiyati = 5;
            urun1.Aciklama = "Amasya Elması";
            urun1.StokAdedi = 2000;

            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Diyarbakır Karpuzu";
            urun2.StokAdedi = 500;

            Urun[] urunler = new Urun[]
            {
                urun1,urun2
            }; 

            //type-safe -->  tip güvenli
            foreach(Urun urun in urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("***********");
            }

            Console.WriteLine("-------- METOTLAR --------");

            // instance oluşturma
            SepetManager sepetManager = new SepetManager();
            //Encapsulation
            sepetManager.Ekle(urun2);
            sepetManager.Ekle2("Armut", "Armutun iyisi", 12,1000);


        }
    }
}
