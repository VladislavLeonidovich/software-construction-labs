class Program
{
    static void Main(string[] args)
    {
        ILogger fileLogger = new FileLoggerAdapter();
        fileLogger.Log("This is a log message.");
        fileLogger.Error("This is an error message.");
        fileLogger.Warn("This is a warning message.");
    }
}
class Program
{
    static void Main(string[] args)
    {
        Hero warrior = new Warrior();
        warrior = new Armor(warrior);
        warrior = new Weapon(warrior);
        
        Console.WriteLine($"{warrior.GetDescription()} has power {warrior.GetPower()}.");
    }
}
class Program
{
    static void Main(string[] args)
    {
        Shape square = new Square(new RasterRenderer());
        square.Draw();

        Shape circle = new Circle(new VectorRenderer());
        circle.Draw();
    }
}
