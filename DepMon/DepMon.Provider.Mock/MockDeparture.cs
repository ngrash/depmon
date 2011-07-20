using System;

namespace DepMon.Provider.Mock
{
    class MockDeparture : IDeparture
    {
        public DateTime DepartureTime
        {
            get;
            set;
        }

        public IStation Station
        {
            get;
            set;
        }

        public ILine Line
        {
            get;
            set;
        }
    }
}
