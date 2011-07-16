using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DepMon.Provider
{
    public interface IDepartureService
    {
        IDeparture GetNextDeparture(ILine line, IStation station);
        IEnumerable<IDeparture> GetNextDepartures(ILine line, IStation station, int count);
    }
}
