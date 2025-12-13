using DesignPatterns.Behavioral.Observer;
using DesignPatterns.Behavioral.Strategy;
using DesignPatterns.Creational.Singleton;
using DesignPatterns.Structural.Adapter._2;
using DesignPatterns.Structural.Decorator;
using DesignPatterns.Structural.Facade._1;
using DesignPatterns.Structural.Facade._2;

//Singleton Pattern
// var single = ConfigurationManager.GetInstance;

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
// IPaymentProcessor internalPayment = new InternalPaymentProcessor();
// internalPayment.ProcessPayment(1_000_000, "IRR");
// internalPayment.ValidatePayment();
//
// IPaymentProcessor payPalAdapter = new PayPalAdapter();
// payPalAdapter.ProcessPayment(1_000_000, "IRR");
// payPalAdapter.ValidatePayment();

//Facade Pattern
// HomeTheaterFacade homeTheater = new HomeTheaterFacade();
//
// // تماشای فیلم
// homeTheater.WatchMovie("Game of Thrones");
//
// Console.WriteLine("\n Press Enter to stop the movie...");
// Console.ReadLine();
//
// // پایان فیلم
// homeTheater.EndMovie();

// Facade Pattern - Order Example
// OrderFacade orderSystem = new OrderFacade();
// orderSystem.PlaceOrder("P123", 150_000,
//     "Kashan", "user@example.com");

//Strategy Pattern
// var shoppingCart = new ShoppingCart();
// shoppingCart.AddItem("Item1", 100);
// shoppingCart.AddItem("Item2", 200);
// shoppingCart.AddItem("Item3", 300);
// shoppingCart.SetPaymentStrategy(new CreditCardStrategy("6219-1234-5678-9010"));
// shoppingCart.Checkout();
// shoppingCart.SetPaymentStrategy(new CryptoStrategy("your-crypto-wallet-address"));
// shoppingCart.Checkout();
// shoppingCart.SetPaymentStrategy(new PayPalStrategy("your-paypal-email@example.com"));
// shoppingCart.Checkout();

//Observer Pattern
// var weatherStation = new WeatherStation();
// weatherStation.Attach(new PhoneDisplay());
// weatherStation.Attach(new TvDisplay());
// weatherStation.SetTemperature(20);
// weatherStation.SetTemperature(30);

//Decorator Pattern
// 1. Simple Coffee
var coffee = new SimpleCoffee();
Console.WriteLine("simple coffee");
Console.WriteLine("description: " + coffee.Description());
Console.WriteLine("cost: " + coffee.Cost());
//2. Simple Coffee with Milk
ICoffee coffee2 = new SimpleCoffee();
coffee2 = new MilkDecorator(coffee2);
Console.WriteLine("\n simple coffee with milk");
Console.WriteLine("description: " + coffee2.Description());
Console.WriteLine("cost: " + coffee2.Cost());
//3.Milk with sugar
ICoffee coffee3 = new SimpleCoffee();
coffee3 = new MilkDecorator(coffee3);
coffee3 = new SugarDecorator(coffee3);
Console.WriteLine("\n simple coffee with milk and sugar");
Console.WriteLine("description: " + coffee3.Description());
Console.WriteLine("cost: " + coffee3.Cost());