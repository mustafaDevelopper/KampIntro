using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product(); //101 bellekte ki yeri referans vererek gidiyor.
            product1.Id = 1;
            product1.CategoryId = 2;
            product1.ProductName = "Masa";
            product1.UnitPrice = 500;
            product1.UnitInStock = 3;

            Product product2 = new Product {Id=2, CategoryId=5, UnitInStock=5, ProductName="Kalem", UnitPrice=35};

            //pascalcase Kelimelerin ilk harfi büyüktür bu class demektir . camelCase
            //case sensitive küçük büyük harf duyarlılıgı demektir. 
            ProductManager productManager = new ProductManager(); 
            productManager.Add(product1);
            Console.WriteLine(product1.ProductName);

          

            //int,float,double,bool...  değer tip
            //diziler , class,abstract class ,interface ..  referans tip 
            // ref out keywordleri metotlarda çok önemlidir.
        }
    }
}
