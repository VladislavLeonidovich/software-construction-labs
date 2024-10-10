public interface SupportHandler
{
    void SetNextHandler(SupportHandler nextHandler);
    void HandleRequest(int issueLevel);
}
