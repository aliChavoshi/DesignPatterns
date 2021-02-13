using System;
using DesignPatterns.CommandPattern.fx;

namespace DesignPatterns.CommandPattern.CompositeCommand
{
    public class ResizeCommand : ICommand
    {
        public void Execute()
        {
            Console.WriteLine("Resize ... ");
        }
    }
}