using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DepMon.Core;

namespace DepMon.Provider.Mock
{
    class MockDeparture : IDeparture
    {
        public DateTime DepartureTime
        {
            get { throw new NotImplementedException(); }
        }

        public ILine Line
        {
            get { throw new NotImplementedException(); }
        }
    }
}
