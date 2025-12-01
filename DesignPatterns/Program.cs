using DesignPatterns.Builder._1;
using DesignPatterns.Factory_Method._1;

//Factory Method Pattern
// new RoadLogistics().PlanDelivery("A");
// new SeaLogistics().PlanDelivery("B");
// new PlaneLogistics().PlanDelivery("C");

//Builder Pattern
var gamingComputer = new GamingComputerBuilder()
    .SetCpu("Core i9")
    .SetGpu("NVIDIA GeForce RTX 3080")
    .SetRam("32GB")
    .SetStorage("1TB SSD")
    .Build();
gamingComputer.Display();