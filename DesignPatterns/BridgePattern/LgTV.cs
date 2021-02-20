using System;

namespace DesignPatterns.BridgePattern
{
    public class LgTV : IDevice
    {
        public void TurnOn()
        {
            Console.WriteLine("LG TurnOn");
        }

        public void TurnOff()
        {
            Console.WriteLine("LG TurnOff");
        }

        public void SetChannel(int number)
        {
            Console.WriteLine($"LG Set Channel {number}");
        }
    }
}