using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "Yazılım Geliştirici Kamp Kursu";
            kurs1.Egitmen = "Engin Demiroğ";
            kurs1.IzlenmeOrani = 15;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "Programlamaya Giriş";
            kurs2.Egitmen = "Erdinç Akdemir";
            kurs2.IzlenmeOrani = 100;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "Veri Bilimi";
            kurs3.Egitmen = "Vahit Keskin";
            kurs3.IzlenmeOrani = 10;

            Kurs[] kurslar = new Kurs[]
            {
                  kurs1,kurs2,kurs3
            };

            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi+":"+kurs.Egitmen);
            }

        
        }
    }

    class Kurs
    {
        public string KursAdi { get; set; }
        public string Egitmen { get; set; }
        public int IzlenmeOrani { get; set; }

    }
}
