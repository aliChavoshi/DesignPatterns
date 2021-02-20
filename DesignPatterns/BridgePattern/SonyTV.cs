using System;

namespace DesignPatterns.BridgePattern
{
    public class SonyTV : IDevice
    {
        public void TurnOn()
        {
            Console.WriteLine("Sony TurnOn");
        }

        public void TurnOff()
        {
            Console.WriteLine("Sony TurnOff");
        }

        public void SetChannel(int number)
        {
            Console.WriteLine($"Sony Set Channel {number}");
        }
    }
}