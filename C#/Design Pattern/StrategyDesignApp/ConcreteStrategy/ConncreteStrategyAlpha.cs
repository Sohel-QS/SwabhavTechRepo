﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StrategyDesignApp.Strategy;

namespace StrategyDesignApp.ConcreteStrategy
{
    class ConncreteStrategyAlpha : IStrategy
    {
        public void AlgorithmInterface()
        {
            Console.WriteLine("Called ConncreteStrategyAlpha.AlgorithmInterface()");
        }
    }
}
