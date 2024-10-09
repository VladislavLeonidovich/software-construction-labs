public class SmartTextReaderLocker : SmartTextReader
{
    private string _regexPattern;

    public SmartTextReaderLocker(string regexPattern)
    {
        _regexPattern = regexPattern;
    }

    public new string[][] ReadFile(string path)
    {
        if (Regex.IsMatch(path, _regexPattern))
        {
            Console.WriteLine("Access denied!");
            return null;
        }
        return base.ReadFile(path);
    }
}
