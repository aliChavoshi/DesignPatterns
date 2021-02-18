using System;
using System.Collections.Generic;

namespace DesignPatterns.Composite
{
    public class Group:IComponent
    {
        private readonly List<IComponent> _components = new();

        public void Add(IComponent component)
        {
            _components.Add(component);
        }
        public void Render()
        {
            foreach (var item in _components)
                item.Render();
        }
        public void Move()
        {
            foreach (var component in _components)
                component.Move();
        }
    }
}