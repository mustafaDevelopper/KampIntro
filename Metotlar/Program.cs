using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            string urunAdi = "Elma";
            double fiyati = 15;
            string aciklama = "Amasya Elması";

           

            string[] meyveler = new string[] {"Elma","Karpuz" };


            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya elması";

            Urun urun2= new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Diyarbakır Karpuzu";

            Urun[] urunler = new Urun[] {urun1,urun2 };

            //type safe--tip güvenli

            foreach (var urun in urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("-----------------");
            }

            Console.WriteLine("--------Metotlar----------");

            //instance - Örnek demek class örneği oluşturuyoruz.
            //encapsulation - kapsülleme demektir. ayrı ayrı yazacagımız ve düzensiz olacak bir yapıyı bir düzenin içine sokmamız demektir.

            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);

            sepetManager.Ekle2("Armut", "Yeşil armut", 12,10);
            sepetManager.Ekle2("Elma", "Yeşil elma", 15,9);
            sepetManager.Ekle2("Karpuz", "Diyarbakır Karpuzu", 75,8);
















        }
    }
}



// Tekrar tekrar kullanımı sağlarlar. Dont repeat your self!-DRY - Clean Code  - Best Practice (Doğru uygulama taktikleri)

// array bir veri tipinde istedigin kadar  ne akdar data ekleren o datayı tutan yapıdır.