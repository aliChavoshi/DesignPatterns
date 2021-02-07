using System;
using System.Collections.Generic;
using DesignPatterns.Encapsulation;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            var account = new Account();
        }

        static ITaxCalculator Calculator()
        {
            return new CalculateTax2019();
        }
    }
}
