using System;
using System.Collections.Generic;
using System.Text;
using StarbucksandNeroCustomerManager.Entities;

namespace StarbucksandNeroCustomerManager.Abstract
{
    public interface ICustomerCheckService
    {
        bool CheckIfRealPerson(Customer customer);
    }
}
