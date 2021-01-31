using System;

namespace OOP2
{
    //ders konusu soyutlama . Soyutlamayı iyi öğrenirsen sektörde iş bulursun.
    class Program
    {
        static void Main(string[] args)
        {
            //musteri1 benim 
            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.Id = 1;
            musteri1.MusteriNo = "12345";
            musteri1.Adi = "Mustafa";
            musteri1.Soyadi = "Bostancı";
            musteri1.TcNo = "12345678912";


            //Kodlama.io

            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 2;
            musteri2.MusteriNo = "54321";
            musteri2.SirketAdi = "Kodlama.io";
            musteri2.VergiNo = "1234657890";


            // ben sirket değil şahısım dolasıyla sirket adı bizle alakalı değil.
            //Gerçek - Tüzel iki nesne var ikiside müşteri . Sırf birbirlerine benziyorlar diye birbirleri yerine kullanılamazlar.Farklı müşteri tipleridir.
            //SOLID - L harfi burda bize bunu söyler . Benziyorlar diye ınheridıns yapma diyor.


            Musteri musteri3 = new GercekMusteri();
            Musteri musteri4 = new TuzelMusteri();

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);


        }
    }
}
