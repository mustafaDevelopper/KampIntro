using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "Yazılım Geliştirici Yetiştirme Kampı";
            string kurs2 = "Programlamaya başlangıç için temel kurs";
            string kurs3 = "Java Kursu";
            string kurs4 = "Python";
            string kurs5 = "C++";


            

            //array = diziler listelemeler için kullanılır.

            string[] kurslar = new string[] { "Yazılım Geliştirici Yetiştirme Kampı", "Programlamaya başlangıç için temel kurs", "Java Kursu","Python","C#" };




            for (int i = 0; i <kurslar.Length; i++)  // i<kurslar.Lengt yapma sebebimiz dinamik şekilde kurslar güncellendikce buda güncellensin diye lenght eleman demek.
            {
                Console.WriteLine (kurslar[i]);
            }

            Console.WriteLine("For bitti");

            foreach (string kurs in kurslar)  // foreach dizi temelli yapıları tek tek dönmeye yarar.Dizilere uygulanır.in kurslar kursları tek tek dolaş demek 
            {
                Console.WriteLine(kurs);
            }

            Console.WriteLine("sayfa Sonu-footer");

        }
    }
}
