namespace DesignPatterns.BridgePattern
{
    public class RemoteControl
    {
        //Bridge
        protected readonly IDevice Device;

        public RemoteControl(IDevice device)
        {
            Device = device;
        }
        public void TurnOn()
        {
            Device.TurnOn();
        }

        public void TurnOff()
        {
            Device.TurnOff();
        }
    }
}