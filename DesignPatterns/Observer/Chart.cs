using System;

namespace DesignPatterns.Observer
{
    public class Chart : IObserver
    {
        private readonly DataSource _dataSource;
        public Chart(DataSource dataSource)
        {
            _dataSource = dataSource;
        }
        public void Update()
        {
            Console.WriteLine($"Update Chart {_dataSource.GetValue()}");
        }
    }
}