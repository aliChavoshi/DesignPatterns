using System;

namespace DesignPatterns.DependencyInjection
{
    public class CalculateTax2018 : ITaxCalculator
    {
        public int CalculateTax()
        {
            return 1;
        }

        public void SayHello()
        {
            Console.WriteLine("Hello");
        }
    }
}