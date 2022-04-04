using System;

namespace ClassMethodDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Customer customer = new Customer
            {
                Name = "Kerim",
                Surname = "SEKİLİ",
                Id = 1,
                TcNo = 105587956,


            };
            CustomerManager customerManager = new CustomerManager();

            customerManager.AddCustomer(customer);

        }
    }
}
