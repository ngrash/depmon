using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DepMon.Provider.Mock
{
    public class MockDepartureQuery : IDepartureQuery
    {
        public string Station { get; set; }
        public string Line { get; set; }
    }
}
