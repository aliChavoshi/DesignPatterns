using System;
using System.Collections.Generic;
using DesignPatterns.CommandPattern.fx;
using DesignPatterns.Strategy;

namespace DesignPatterns.CommandPattern.CompositeCommand
{
    public class CompositeCommand : ICommand
    {
        private readonly List<ICommand> _commands = new List<ICommand>();
        public void Add(ICommand command)
        {
            _commands.Add(command);
        }
        public void Execute()
        {
            foreach (var command in _commands)
                command.Execute();
        }
    }
}