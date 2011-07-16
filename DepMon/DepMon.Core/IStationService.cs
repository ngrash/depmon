using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DepMon.Core
{
    public interface IStationService
    {
        IEnumerable<IStation> FindStationByName(string name);
        IEnumerable<ILine> GetLines(IStation station);
    }
}
