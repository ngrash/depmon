using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DepMon.Core
{
    public interface IDeparture
    {
        DateTime DepartureTime { get; }
        ILine Line { get; }
    }
}
