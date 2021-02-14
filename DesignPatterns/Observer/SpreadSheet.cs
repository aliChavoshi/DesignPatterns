using System;

namespace DesignPatterns.Observer
{
    public class SpreadSheet : IObserver
    {
        private readonly DataSource _dataSource;

        public SpreadSheet(DataSource dataSource)
        {
            _dataSource = dataSource;
        }
        public void Update()
        {
            Console.WriteLine($"Update SpreadSheet {_dataSource.GetValue()}");
        }
    }
}