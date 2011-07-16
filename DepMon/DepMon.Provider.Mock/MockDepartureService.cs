using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DepMon.Core;

namespace DepMon.Provider.Mock
{
    class MockDepartureService : IDepartureService
    {
        public IDeparture GetNextDeparture(ILine line, IStation station)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<IDeparture> GetNextDepartures(ILine line, IStation station, int count)
        {
            throw new NotImplementedException();
        }
    }
}
