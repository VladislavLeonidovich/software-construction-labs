public class Runway
{
    private bool available = true;

    public bool IsAvailable()
    {
        return available;
    }

    public void SetAvailability(bool available)
    {
        this.available = available;
    }
}
