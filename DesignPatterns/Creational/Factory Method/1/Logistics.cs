namespace DesignPatterns.Creational.Factory_Method._1;

public abstract class Logistics
{
    protected abstract ITransport CreateTransport();

    public void PlanDelivery(string package)
    {
        var transport = CreateTransport();
        transport.Deliver(package);
    }
}

public class RoadLogistics : Logistics
{
    protected override ITransport CreateTransport() => new Truck();
}

public class SeaLogistics : Logistics
{
    protected override ITransport CreateTransport() => new Ship();
}

public class PlaneLogistics : Logistics
{
    protected override ITransport CreateTransport() => new Plane();
}