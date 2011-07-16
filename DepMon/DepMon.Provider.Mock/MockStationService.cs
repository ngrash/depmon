using System.Collections.Generic;
using System.Linq;

namespace DepMon.Provider.Mock
{
    class MockStationService : IStationService
    {
        private Dictionary<MockStation, List<MockLine>> _stationsLines = new Dictionary<MockStation,List<MockLine>>() {
            { new MockStation() { Name = "foo" }, new List<MockLine>() {
                new MockLine() { Name = "1", Type = new LineTypes.Foo(), Destination = new MockDestination() { Name = "Fizz" } },
                new MockLine() { Name = "2", Type = new LineTypes.Bar(), Destination = new MockDestination() { Name = "Buzz" } },
            } },
            { new MockStation() { Name = "bar" }, new List<MockLine>() {
                new MockLine() { Name = "1", Type = new LineTypes.Foo(), Destination = new MockDestination() { Name = "Fizz" } },
                new MockLine() { Name = "2", Type = new LineTypes.Bar(), Destination = new MockDestination() { Name = "Buzz" } },
                new MockLine() { Name = "3", Type = new LineTypes.Foo(), Destination = new MockDestination() { } },
            } },
            { new MockStation() { Name = "baz" }, new List<MockLine>() {
                new MockLine() { Name = "1", Type = new LineTypes.Foo(), Destination = new MockDestination() { Name = "Fizz" } },
                new MockLine() { Name = "3", Type = new LineTypes.Foo(), Destination = new MockDestination() { Name = "FizzBuzz" } },
            } }
        };

        public IEnumerable<IStation> FindStationByName(string name)
        {
            // stupid search
            return _stationsLines
                .Where(kv => kv.Key.Name.StartsWith(name))
                .Select(kv => kv.Key);
        }

        public IEnumerable<ILine> GetLines(IStation station)
        {
            return _stationsLines
                .Where(kv => kv.Key.Name == station.Name)
                .First()
                .Value;
        }
    }
}
