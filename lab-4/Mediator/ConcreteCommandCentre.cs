public class ConcreteCommandCentre : CommandCentre
{
    private Runway runway;
    private Aircraft aircraft;

    public void RegisterRunway(Runway runway)
    {
        this.runway = runway;
    }

    public void RegisterAircraft(Aircraft aircraft)
    {
        this.aircraft = aircraft;
    }

    public bool RequestLanding(Aircraft aircraft)
    {
        if (runway.IsAvailable())
        {
            Console.WriteLine("Дозвіл на посадку для " + aircraft.GetName());
            return true;
        }
        else
        {
            Console.WriteLine("Смуга зайнята.");
            return false;
        }
    }
}
