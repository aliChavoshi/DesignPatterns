using DesignPatterns.Builder._1;
using DesignPatterns.Builder._2;

//Factory Method Pattern
// new RoadLogistics().PlanDelivery("A");
// new SeaLogistics().PlanDelivery("B");
// new PlaneLogistics().PlanDelivery("C");

//Builder Pattern
// var gamingComputer = new GamingComputerBuilder()
//     .SetCpu("Core i9")
//     .SetGpu("NVIDIA GeForce RTX 3080")
//     .SetRam("32GB")
//     .SetStorage("1TB SSD")
//     .Build();
// gamingComputer.Display();
//
// var officeComputer = new OfficeComputerBuilder()
//     .SetCpu("Core i5")
//     .SetGpu("Integrated Graphics")
//     .SetRam("16GB")
//     .SetStorage("512GB SSD")
//     .Build();
// officeComputer.Display();

//Builder Pattern - Email Example
var email = new EmailBuilder()
    .SetTo("recipient@example.com")
    .SetSubject("Hello")
    .SetAttachments("file1.txt")
    .SetAttachments("file2.jpg")
    .Build();
email.Send();