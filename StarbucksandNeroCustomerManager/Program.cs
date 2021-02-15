using System;
using StarbucksandNeroCustomerManager.Abstract;
using StarbucksandNeroCustomerManager.Concrete;

namespace StarbucksandNeroCustomerManager
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseCustomerManager customerManager = new NeroCustomerManager();
            customerManager.Save(new Entities.Customer {Id = 1, DateofBirth = new DateTime(2000, 09, 25),FirstName="Büşra", LastName = "Akbulut", NationalityId = "34147968664"});
            BaseCustomerManager customerManager2 = new StarbucksCustomerManager();
            customerManager.Save(new Entities.Customer { Id = 12, DateofBirth = new DateTime(1997, 03, 11), FirstName = "Fadime", LastName = "Akbulut", NationalityId = "12345678911" });
        }
    }
}

