using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SrpViolationApp.Model
{
    class Program
    {
        static void Main(string[] args)
        {
            Invoice invoice = new Invoice(1, "invoice", 200000, 0.1f, 0.5f);
            invoice.Print();
        }
    }
}
