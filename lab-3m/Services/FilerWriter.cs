public class FileWriter
{
    public void Write(string message) 
    {
        File.AppendAllText("log.txt", message);
    }

    public void WriteLine(string message) 
    {
        File.AppendAllText("log.txt", message + Environment.NewLine);
    }
}
