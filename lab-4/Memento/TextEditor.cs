public class TextEditor
{
    private TextDocument document;
    private Stack<Memento> history = new Stack<Memento>();

    public TextEditor(TextDocument document)
    {
        this.document = document;
    }

    public void Write(string content)
    {
        history.Push(document.Save());
        document.SetContent(content);
    }

    public void Undo()
    {
        if (history.Count > 0)
        {
            document.Restore(history.Pop());
        }
    }

    public void PrintContent()
    {
        Console.WriteLine("Поточний текст: " + document.GetContent());
    }
}
