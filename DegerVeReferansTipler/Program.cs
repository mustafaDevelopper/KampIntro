using System;

namespace DegerVeReferansTipler
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

            int sayi1 = 10;
            int sayi2 = 30;
            sayi1 = sayi2;
            sayi2 = 100;
            //sayi1??  cevap :30

            int[] sayilar1 = new int[] { 10, 20, 30 };
            int[] sayilar2 = new int[] { 100, 200, 300 };
            sayilar1 = sayilar2;
            sayilar2[0] = 999;
            //sayilar1[0]; ?? cevap:999
            //sayısal veri tipleri(değer tipler) : int , decimal, float , double ,bool (0 ve 1 tutar) = hepsi değer tiplerdir.
            //referans tipler : array , class , interface 
            //bellekte stack ve hip diye iki alan bulunur.
            //değer tip olanlar stack içinde gerçekleşir. 
            //new heap içinde yeni bir adres, bir yer oluştur demek.
            Console.WriteLine(sayi1);
            Console.WriteLine(sayilar1[0]);



        }
    }
}
