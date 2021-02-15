using System;
using System.Collections.Generic;
using System.Text;
using StarbucksandNeroCustomerManager.Abstract;

namespace StarbucksandNeroCustomerManager.Entities
{
    public class Customer:IEntity

    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateofBirth { get; set; }
        public string NationalityId { get; set; }
    }
}
