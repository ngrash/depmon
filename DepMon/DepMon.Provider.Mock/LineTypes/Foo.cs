using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DepMon.Core;

namespace DepMon.Provider.Mock.LineTypes
{
    class Foo : ILineType
    {
        public string Name
        {
            get { return "Foo"; }
        }
    }
}
