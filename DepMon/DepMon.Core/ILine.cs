using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DepMon.Core
{
    public interface ILine
    {
        string Name { get; }
        ILineType Type { get; }
        IDestination Destination { get; }
    }
}
