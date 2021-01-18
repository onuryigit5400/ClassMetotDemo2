using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo2
{
    class MusteriManager
    {
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine(musteri.Ad + " adlı müşteri eklenmiştir");
        }

        public void Listele(Musteri musteri)
        {
            Console.WriteLine(musteri.Ad + " adlı müşteri listelenmiştir");
        }
        public void Sil(Musteri musteri)
        {
            Console.WriteLine(musteri.Ad + " adlı müşteri silinmiştir");
        }
    }
}
