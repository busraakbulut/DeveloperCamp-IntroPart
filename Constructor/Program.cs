using System;

namespace Constructor
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer {Id= 1, FirstName= "Büşra", LastName = "AKBULUT", City= "ANTALYA" };

            Customer customer2 = new Customer(2,"Engin","Demiroğ","Diyarbakır");
        }
    }
    class Customer
    {
        // kendi oluşturduğumuz constructor ve bir method gibi düşünebiliriz.
        // bunu oluşturduğumuzda bizim classımızdaki ürünleri set etmemiz gerekiyor yoksa atama gerçekleştiriliyor ama atadığımız değeri döndüremiyoruz.
        public Customer(int id, string firstName, string lastName, string city)//
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            City = city;
        }
        // default constructordır yazmamıza gerek yoktur 
        public Customer()  // bu bir default constructor (ctor tab*2)
        {

        }
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }

    }
}
