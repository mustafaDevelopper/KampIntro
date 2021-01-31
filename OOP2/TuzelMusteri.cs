using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2
{
    //Coorporate-Tüzel müşteri
    //miras inheritance denir. Müşteride olan özellikler artık gerçek ve tüzelde de var demektir.
    class TuzelMusteri:Musteri // tüzel müşteri bir müşteridir demek ":" 
    {
       
        public string SirketAdi { get; set; }
        public string VergiNo { get; set; }
    }
}
