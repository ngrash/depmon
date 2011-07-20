using System;
using System.Linq;
using System.Collections.Generic;

namespace DepMon.Provider.Mock
{
    class MockDepartureService : IDepartureService
    {
        public IDepartureQuery CreateQuery(ILine line, IStation station)
        {
            return new MockDepartureQuery()
            {
                Line = line.Name,
                Station = station.Name
            };
        }

        public IDeparture QueryNextDeparture(IDepartureQuery query)
        {
            MockDepartureQuery departureQuery = (MockDepartureQuery)query;

            // rebuild the station
            IStation station = ServiceRegister.StationService.FindStationByName(departureQuery.Station).First();
            // rebuild the location
            ILine line = ServiceRegister.StationService.GetLines(station).Single(l => l.Name == departureQuery.Line);

            // calculate departure time - normally one would query a web service here
            DateTime nextDepartureTime = DateTime.Now;
            for(int min = nextDepartureTime.Minute; min % 10 != 0; min++) {
                nextDepartureTime = nextDepartureTime.AddMinutes(1);
            }

            return new MockDeparture()
            {
                Station = station,
                Line = line,
                DepartureTime = nextDepartureTime
            };
        }
    }
}
