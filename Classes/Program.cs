using System;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add();
            customerManager.Update();

            ProductManager productManager = new ProductManager();
            productManager.Add();
            productManager.Update();

            Customer customer = new Customer();
            customer.City = "Ankara";
            customer.FirstName = "Mustafa";  // class içinde = diyip yazmaya başlayınca :set kısmı çalışır.
            customer.LastName = "Bostancı";
            customer.Id = 1;

            Customer customer2 = new Customer  // class ı yukarda oldugu gibi tek tek de gösterebiliriz . aşağıda ki gibi süslü parantez icinde ctrl+spc yaparak da yazabiliriz.
            {
                Id = 2, City="İstanbul" , FirstName="Furkan" , LastName="Bostancı"
            };

            Console.WriteLine(customer2.FirstName); // customer2 nin firstnameni ver diyoruz buradada get bloğu çalışır.

            Console.ReadLine();
        }   
    }
}
