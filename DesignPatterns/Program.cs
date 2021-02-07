using System;
using System.Collections.Generic;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            var cal = Calculator();
            Console.WriteLine(cal.CalculateTax());
        }

        static ITaxCalculator Calculator()
        {
            return new CalculateTax2019();
        }
    }
}
