using _03AbstractFactory;

Console.WriteLine("Abstract Factory");

OperatingSystemFactory factory = new WindowsFactory();
IOperatingSystem operatingSystem= factory.CreateOperatingSystem();

Console.WriteLine($"Operating System: {operatingSystem.Name}");

factory = new MacOSFactory();
operatingSystem = factory.CreateOperatingSystem();
Console.WriteLine($"operatingSystem: {operatingSystem.Name}");