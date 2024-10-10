class ObserverExample
{
    static void Main(string[] args)
    {
        HTMLElement element = new HTMLElement();
        EventListener listener = new EventListener();

        element.AddEventListener(listener);

        element.TriggerClick();
        element.TriggerMouseOver();
    }
}
