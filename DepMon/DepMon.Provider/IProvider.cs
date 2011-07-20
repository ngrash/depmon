using System;

namespace DepMon.Provider
{
    public interface IProvider
    {
        Guid UniqueID { get; }
        Type DepartureQueryType { get; }
        string Name { get; }
        IStationService StationService { get; }
        IDepartureService DepartureService { get; }
    }
}
