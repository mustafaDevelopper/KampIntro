using System;

namespace Constructors // yapıcı demektir . Yapıcı blok anlamına gelir.
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer { Id = 1, FirstName = "Mustafa", LastName = "Bostancı", City = "Ankara" };

            Customer customer2 = new Customer(2, "Furkan", "Bostancı", "Ankara");

            Console.WriteLine(customer2.FirstName);

        }   
    }

    class Customer
    {
        public Customer()
        {
                
        }
        //default constructor
        public Customer(int id, string firstName, string LastName, string city)
        {
            FirstName = firstName;
            LastName = LastName;
            Id = id;
            City = city;
        }
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }
    }
}
