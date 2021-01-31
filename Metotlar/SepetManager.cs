using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    class SepetManager
    {

        // naming convention
        public void Ekle(Urun urun)
        {
            Console.WriteLine(urun.Adi+" sepete eklendi");
        }
        public void Ekle2(string urunAdi,string aciklama,double fiyati,int stokAdedi) // bunu kullanmak doğru değildir
        {
            Console.WriteLine("Tebrikler sepete eklendi:"+urunAdi);
        }
    }
}
