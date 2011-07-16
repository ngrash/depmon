using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DepMon.Core;

namespace DepMon.Provider.Mock
{
    class MockStationService : IStationService
    {
        Dictionary<MockStation, List<MockLine>> stationsLines = new Dictionary<MockStation,List<MockLine>>() {
            { new MockStation() { Name = "foo" }, new List<MockLine>() {
                new MockLine() { Name = "1", Type = new LineTypes.Foo(), Destination = new MockDestination() { } },
                new MockLine() { Name = "2", Type = new LineTypes.Foo(), Destination = new MockDestination() { } },
            } }
        };

        public IEnumerable<IStation> FindStationByName(string name)
        {
            return new IStation[] {
                
                new MockStation() { Name = "bar" },
                new MockStation() { Name = "baz" }
            };
        }

        public IEnumerable<ILine> GetLines(IStation station)
        {
            throw new NotImplementedException();
        }
    }
}
