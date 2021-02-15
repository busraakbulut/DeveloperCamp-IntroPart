using System;
using System.Collections.Generic;
using System.Text;
using StarbucksandNeroCustomerManager.Abstract;
using StarbucksandNeroCustomerManager.Entities;

namespace StarbucksandNeroCustomerManager.Concrete
{
    public class CustomerCheckManager : ICustomerCheckService
    {
        public bool CheckIfRealPerson(Customer customer)
        {
            return true;
        }
    }
}
