
namespace DepMon.Provider.Mock
{
    class MockLine : ILine
    {
        public string Name
        {
            get;
            set;
        }

        public ILineType Type
        {
            get;
            set;
        }

        public IDestination Destination
        {
            get;
            set;
        }
    }
}
