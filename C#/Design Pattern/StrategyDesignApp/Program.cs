using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StrategyDesignApp.ConcreteStrategy;
using StrategyDesignApp.Model;

namespace StrategyDesignApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Context context;

            context = new Context(new ConncreteStrategyAlpha());
            context.ContextInterface();
            Console.WriteLine("\n");

            context = new Context(new ConncreteStrategyBeta());
            context.ContextInterface();
            Console.WriteLine("\n");

            context = new Context(new ConncreteStrategyGamma());
            context.ContextInterface();
            Console.WriteLine("\n");
        }
    }
}
