using System;

namespace DesignPatterns.CommandPattern
{
    public class CustomerService
    {
        public void AddCustomer()
        {
            Console.WriteLine("Add Customer");
        }
        public void DeleteCustomer()
        {
            Console.WriteLine("delete Customer");
        }
    }
}