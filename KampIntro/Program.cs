using System;

namespace KampIntro
{
    class Program
    {
        private static bool kategoriEtiketi;

        static void Main(string[] args)
        {
            //type safety = tip güvenliği
            // çift tırnak kullancaksın
            //c++ gibi noktalı virgül unutma.
            //do not repeat your sefl - Kendini tekrarlama. 
            //kategoriEtiketi değer tutucu , lias takma ad demektir burda.
            //ondalıklı sayılar double da tutulur.
            //bool şart bloğu

            string kategoriEtiketi = "Kategoriler";
            //int OgrenciSayisi = 32000;
            //double FaizOrani = 1.45;
            bool sistemeGirisYapmisMi = false;
            double dolarDun = 7.35;
            double dolarBugun = 7.45;

            if (dolarDun>dolarBugun)
            {
                Console.WriteLine("Azalış Butonu");
            }
            else if (dolarDun<dolarBugun)

            {
                Console.WriteLine("Artış Butonu");

            }
            else 
            {
                Console.WriteLine("değişmedi Butonu");
            
            }


            if (sistemeGirisYapmisMi == true)
            {
                Console.WriteLine("Kullanıcı ayarları butonu");
            }
            else
            {
                Console.WriteLine("Giriş yap butonu");
            }
          



            Console.WriteLine(kategoriEtiketi);

           

        }
    }
}
