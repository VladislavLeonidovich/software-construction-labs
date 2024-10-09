public class SmartTextReader
{
    public string[][] ReadFile(string path)
    {
        var lines = File.ReadAllLines(path);
        return lines.Select(line => line.ToCharArray().Select(c => c.ToString()).ToArray()).ToArray();
    }
}
public class SmartTextChecker : SmartTextReader
{
    public new string[][] ReadFile(string path)
    {
        Console.WriteLine("Opening file...");
        var content = base.ReadFile(path);
        Console.WriteLine($"File has {content.Length} lines.");
        Console.WriteLine("Closing file...");
        return content;
    }
}
