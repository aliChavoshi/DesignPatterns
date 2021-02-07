using System;
using System.Collections.Generic;
using DesignPatterns.Abstraction;
using DesignPatterns.Encapsulation;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            var mail = new MailService();
            mail.
        }

        static ITaxCalculator Calculator()
        {
            return new CalculateTax2019();
        }
    }
}
