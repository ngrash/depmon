
namespace DepMon.Provider.Mock
{
    public class MockProvider : IProvider
    {
        public MockProvider()
        {
            StationService = new MockStationService();
            DepartureService = new MockDepartureService();
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
    }
}
