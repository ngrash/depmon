using System;
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
            throw new NotImplementedException();
        }
    }
}
