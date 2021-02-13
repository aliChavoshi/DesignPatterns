using System;
using DesignPatterns.CommandPattern.fx;

namespace DesignPatterns.CommandPattern.CompositeCommand
{
    public class BlackAndWhiteCommand:ICommand
    {
        public void Execute()
        {
            Console.WriteLine("Black & White ... ");
        }
    }
}