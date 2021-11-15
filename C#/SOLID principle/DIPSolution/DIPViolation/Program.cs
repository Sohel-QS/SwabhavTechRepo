using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIPViolation.HighLevelModule
{
    class Program
    {
        static void Main(string[] args)
        {
            TaxCalculator tax = new TaxCalculator(LogPolicyType.DB);
            Console.WriteLine(tax.Calculate(10, 2));
            Console.WriteLine(tax.Calculate(10, 0));

        }
    }
}
