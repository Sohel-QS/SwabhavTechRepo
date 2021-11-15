using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StrategyDesignApp.Strategy;

namespace StrategyDesignApp.Model
{
    class Context
    {
        IStrategy _strategy;

        public Context(IStrategy strategy)
        {
            this._strategy = strategy;
        }

        public void ContextInterface()
        {
            _strategy.AlgorithmInterface();
        }
    }
}
