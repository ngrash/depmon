using System;

namespace DepMon.Provider.Mock
{
    public class MockProvider : IProvider
    {
        public Guid UniqueID {
            get { return new Guid("48196e1b-6474-4306-abb8-a01f5ff25634"); }
        }

        public Type DepartureQueryType
        {
            get { return typeof(MockDepartureQuery); }
        }

        public string Name
        {
            get { return "Mock Provider"; }
        }

        public IStationService StationService
        {
            get;
            private set;
        }

        public IDepartureService DepartureService
        {
            get;
            private set;
        }

        public MockProvider()
        {
            StationService = new MockStationService();
            DepartureService = new MockDepartureService();
        }
    }
}
