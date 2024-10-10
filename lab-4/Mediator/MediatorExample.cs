class MediatorExample
{
    static void Main(string[] args)
    {
        CommandCentre centre = new ConcreteCommandCentre();
        Runway runway = new Runway();
        Aircraft aircraft = new Aircraft("Boeing 737");

        centre.RegisterRunway(runway);
        centre.RegisterAircraft(aircraft);

        aircraft.RequestLanding(centre);
    }
}
