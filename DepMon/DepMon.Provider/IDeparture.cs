using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DepMon.Provider
{
    public interface IDeparture
    {
        DateTime DepartureTime { get; }
        IStation Station { get; }
        ILine Line { get; }
    }
}
