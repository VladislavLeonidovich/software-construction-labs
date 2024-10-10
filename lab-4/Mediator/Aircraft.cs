public class Aircraft
{
    private string name;

    public Aircraft(string name)
    {
        this.name = name;
    }

    public string GetName()
    {
        return name;
    }

    public void RequestLanding(CommandCentre centre)
    {
        centre.RequestLanding(this);
    }
}
