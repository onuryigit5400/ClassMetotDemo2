using System;

namespace ClassMetotDemo2
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Ad = "Onur";
            musteri1.Soyad = "Yiğit";

            Musteri musteri2 = new Musteri();
            musteri2.Ad = "Defne Bilge";
            musteri2.Soyad = "Yiğit";

            //Musteri[] musteriler = new Musteri[] { musteri1, musteri2 };

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);
            Console.WriteLine("-------------------------------");
            musteriManager.Listele(musteri1);
            musteriManager.Listele(musteri2);
            Console.WriteLine("-------------------------------");
            musteriManager.Sil(musteri1);
            musteriManager.Sil(musteri2);




            Console.ReadKey();
        }
    }
}
