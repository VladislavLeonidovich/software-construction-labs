public interface CommandCentre
{
    void RegisterRunway(Runway runway);
    void RegisterAircraft(Aircraft aircraft);
    bool RequestLanding(Aircraft aircraft);
}
