using System;
using DIPSolution.LowLevelModule;

namespace DIPSolution.HighLevelModule
{
    class Program
    {
        static void Main(string[] args)
        {
            TaxCalculator tax = new TaxCalculator(new DBLogger());
            Console.WriteLine(tax.Calculate(10, 5));
            Console.WriteLine(tax.Calculate(10, 0));
        }
    }
}
