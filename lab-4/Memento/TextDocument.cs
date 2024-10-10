public class TextDocument
{
    private string content;

    public void SetContent(string content)
    {
        this.content = content;
    }

    public string GetContent()
    {
        return content;
    }

    public Memento Save()
    {
        return new Memento(content);
    }

    public void Restore(Memento memento)
    {
        content = memento.GetContent();
    }
}
