using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class ProductManager
    {
        public void Add(Product product) // 101 // void ne işe yarar = void metodu git yap anlamında emir kipi olarak kullanılır. 
        {
            Console.WriteLine(product.ProductName + " Eklendi.");
        }

        public void Update(Product product)
        {
            Console.WriteLine(product.ProductName + " Güncellendi.");
        }

    }
}
