using System;
using System.Linq.Expressions;

namespace OOP2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IndividualCustomer customer1 = new IndividualCustomer();
            //Samet Sepetto
            customer1.Id = 1;
            customer1.CustomerId = "12345";
            customer1.Name = "Samet";
            customer1.Surname = "Sepetto";
            customer1.TcNo = "15487566";

            //Kodlama.io
            CoorporateCustomer customer2 = new CoorporateCustomer();
            customer2.Id = 2;
            customer2.CustomerId = "85641";
            customer2.CompanyName = "Kodlama.IO";
            customer2.TaxNumber = "1975142506";


            Customer customer3 = new IndividualCustomer();
            Customer customer4 = new CoorporateCustomer();

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer1);
            customerManager.Add(customer2);


        }
    }
}
