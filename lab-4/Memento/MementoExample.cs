class MementoExample
{
    static void Main(string[] args)
    {
        TextDocument document = new TextDocument();
        TextEditor editor = new TextEditor(document);

        editor.Write("Перша версія тексту.");
        editor.PrintContent();

        editor.Write("Друга версія тексту.");
        editor.PrintContent();

        editor.Undo();
        editor.PrintContent();
    }
}
