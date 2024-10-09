public class Logger
{
    public void Log(string message) 
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Log: " + message);
        Console.ResetColor();
    }

    public void Error(string message) 
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Error: " + message);
        Console.ResetColor();
    }

    public void Warn(string message) 
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("Warn: " + message);
        Console.ResetColor();
    }
}
public interface ILogger
{
    void Log(string message);
    void Error(string message);
    void Warn(string message);
}

public class FileLoggerAdapter : ILogger
{
    private FileWriter _fileWriter = new FileWriter();

    public void Log(string message) 
    {
        _fileWriter.WriteLine("Log: " + message);
    }

    public void Error(string message) 
    {
        _fileWriter.WriteLine("Error: " + message);
    }

    public void Warn(string message) 
    {
        _fileWriter.WriteLine("Warn: " + message);
    }
}
