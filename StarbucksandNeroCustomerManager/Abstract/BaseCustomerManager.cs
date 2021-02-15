using System;
using System.Collections.Generic;
using System.Text;
using StarbucksandNeroCustomerManager.Entities;

namespace StarbucksandNeroCustomerManager.Abstract
{
    public abstract class BaseCustomerManager : ICustomerService
    {
        public virtual void Save(Customer customer)
        {
            Console.WriteLine("Saved To DataBase : "+ customer.FirstName);
        }
    }
}
