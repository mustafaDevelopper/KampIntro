using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    //snippet
    class Product      //entity(varlık) gibi isimler veririz.
    {
        //Bir nesneyi diğerinden ayırmak için kullanılan özel isimlerdir. Primery key oldugu için başta yer alır.
        public int Id { get; set; }

        //foreign key oldugu için kod okunması açısından buraya yazmak daha iyidirr.
        public int CategoryId { get; set; }

        //ürün adı
        public string ProductName { get; set; }

        //ürün fiyatı
        public double UnitPrice { get; set; }

        //Ürün stogu
        public int UnitInStock { get; set; }

        //crud create read update delete operasyonları denir.



    }
}
