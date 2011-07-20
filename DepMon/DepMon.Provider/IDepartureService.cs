using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DepMon.Provider
{
    public interface IDepartureService
    {
        IDepartureQuery CreateQuery(ILine line, IStation station);
        IDeparture QueryNextDeparture(IDepartureQuery query);
    }
}
