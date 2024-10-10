public class HTMLElement
{
    private List<EventListener> listeners = new List<EventListener>();

    public void AddEventListener(EventListener listener)
    {
        listeners.Add(listener);
    }

    public void TriggerClick()
    {
        foreach (var listener in listeners)
        {
            listener.OnClick();
        }
    }

    public void TriggerMouseOver()
    {
        foreach (var listener in listeners)
        {
            listener.OnMouseOver();
        }
    }
}
