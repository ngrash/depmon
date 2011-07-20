using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DepMon.Provider.Mock
{
    class ServiceRegister
    {
        private static ServiceRegister _instance = null;

        public static MockStationService StationService
        {
            get { return _instance._stationService; }
        }

        public static MockDepartureService DepartureService
        {
            get { return _instance._departureService; }
        }

        static ServiceRegister()
        {
            _instance = new ServiceRegister();
        }

        private MockStationService _stationService = null;
        private MockDepartureService _departureService = null;

        private ServiceRegister()
        {
            _stationService = new MockStationService();
            _departureService = new MockDepartureService();
        }
    }
}
