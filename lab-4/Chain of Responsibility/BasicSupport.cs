public class BasicSupport : SupportHandler
{
    private SupportHandler nextHandler;

    public void SetNextHandler(SupportHandler nextHandler)
    {
        this.nextHandler = nextHandler;
    }

    public void HandleRequest(int issueLevel)
    {
        if (issueLevel == 1)
        {
            Console.WriteLine("Basic support: Проблему вирішено на рівні 1.");
        }
        else if (nextHandler != null)
        {
            nextHandler.HandleRequest(issueLevel);
        }
        else
        {
            Console.WriteLine("Жоден рівень не зміг вирішити проблему.");
        }
    }
}
