using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StrategyDesignApp.Strategy;

namespace StrategyDesignApp.ConcreteStrategy
{
    class ConncreteStrategyBeta : IStrategy
    {
        public void AlgorithmInterface()
        {
            Console.WriteLine("Called ConncreteStrategyBeta.AlgorithmInterface()");
        }
    }
}
