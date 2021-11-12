using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SrpSolutionApp.Model
{
    class Program
    {
        static void Main(string[] args)
        {
            Invoice invoice = new Invoice(1, "invoice", 200000, 0.1f, 0.5f);

            var console = new InvoiceConsolePrinter();
            console.Print(invoice);

            var htmlGenerator = new InvoiceHtmlGenerator();
            htmlGenerator.Generate(invoice);
        }
    }
}
