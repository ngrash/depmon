namespace DepMon.Core
{
    public interface IProvider
    {
        string Name { get; }
        IStationService StationService { get; }
        IDepartureService DepartureService { get; }
    }
}
