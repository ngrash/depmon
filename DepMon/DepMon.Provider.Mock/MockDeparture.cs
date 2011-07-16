using System;

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
