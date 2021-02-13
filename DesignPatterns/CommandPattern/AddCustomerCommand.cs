using System;
using DesignPatterns.CommandPattern.fx;

namespace DesignPatterns.CommandPattern
{
    public class AddCustomerCommand :ICommand
    {
        private readonly CustomerService _customerService;
        public AddCustomerCommand(CustomerService customerService)
        {
            _customerService = customerService;
        }
        public void Execute()
        {
            _customerService.AddCustomer();
        }
    }
}