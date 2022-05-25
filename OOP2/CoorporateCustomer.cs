using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2
{
    internal class CoorporateCustomer : Customer
    {
        public int Id { get; set; }
        public string CustomerId { get; set; }
        public string CompanyName { get; set; }
        public string TaxNumber { get; set; }

    }
}
