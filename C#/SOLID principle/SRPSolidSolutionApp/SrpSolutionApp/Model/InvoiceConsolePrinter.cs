using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SrpSolutionApp.Model
{
    class InvoiceConsolePrinter
    {
        public void Print(Invoice invoice)
        {
            Console.WriteLine("ID :{0}\nDiscription :{1}\nAmount :{2}\nTax :{3}%\nDiscount :{4}%" +
                "\nDiscount Amount:{5}\nTax Amount :{6}\nFinal Amount :{7}",
                invoice.Id,
                invoice.Discription,
                invoice.Amount,
                invoice.Tax * 100,
                invoice.Discount * 100,
                invoice.CalculateDiscount(),
                invoice.CalculateTax(),
                invoice.CalculateFinalAmount());
        }
    }
}
