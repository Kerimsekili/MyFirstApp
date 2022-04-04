using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMethodDemo
{
    internal class CustomerManager
    {
        public void AddCustomer(Customer customer)
        {
            Console.WriteLine(customer.Name+ " : "+"Customer Added ! ");
        }
        public void DeleteCustomer(Customer customer)
        {
            Console.WriteLine(customer.Name+ " : "+"Customer Deleted ! ");
        }
        public void ListCustomer(Customer[] customers)
        {
            foreach (Customer customer in customers)
            {
                Console.WriteLine("Customer Listed ! ");
                
            }
                
        }
    }


}
