using System;
using System.Collections.Generic;

namespace GenericsIntro
{
    class Program
    {
        static void Main(string[] args)
        {   
           
            MyList<string> isimler = new MyList<string>();
            isimler.Add("Mustafa");

            List<string> liste = new List<string>();
            Console.WriteLine(liste.Count); // count eleman sayısı demek.


            Console.WriteLine("Hello World!");
        }
    }
}
