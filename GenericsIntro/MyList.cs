using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro
{
    class MyList<T> // T type demektir. Generic 1 tane değer alıyorsa genelde T olarak yazılır. Burada ki default anlamındadır ben sana T olarak ne verirsem istediğim elemanın türüde odur.
    {
        T[] items;
        //constructor metottur. ctor tabtab yaptıgında gelir . classı newlediğinde otomatik çalışır.
        public MyList()
        {
            items = new T[0];
        }
        public void Add(T item)
        {
            T[] tempArray = items; //tempArray geçici dizi demektir.
            items = new T[items.Length+1]; // .Length dizinin eleman sayısını verir. 
            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];
            }

            items[items.Length - 1] = item;
        }
    }
}
