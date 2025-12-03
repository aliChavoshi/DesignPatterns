using DesignPatterns.Adapter._1;
using DesignPatterns.Adapter._2;
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
//     .SetStorage("512GB SSD")2
//     .Build();
// officeComputer.Display();

//Builder Pattern - Email Example
// var email = new EmailBuilder()
//     .SetTo("recipient@example.com")
//     .SetSubject("Hello")
//     .SetAttachments("file1.txt")
//     .SetAttachments("file2.jpg")
//     .Build();
// email.Send();

//Adapter Pattern
// var analytics = new XmlToJsonAdapter();
// analytics.Analyze(new XmlData());

//Adapter Pattern - Payment Example
// سیستم پرداخت داخلی
IPaymentProcessor internalPayment = new InternalPaymentProcessor();
internalPayment.ProcessPayment(1_000_000, "IRR");
internalPayment.ValidatePayment();

IPaymentProcessor payPalAdapter = new PayPalAdapter();
payPalAdapter.ProcessPayment(1_000_000, "IRR");
payPalAdapter.ValidatePayment();