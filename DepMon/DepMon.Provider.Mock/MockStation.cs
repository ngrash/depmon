﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DepMon.Core;

namespace DepMon.Provider.Mock
{
    class MockStation : IStation
    {
        public string Name
        {
            get;
            set;
        }
    }
}