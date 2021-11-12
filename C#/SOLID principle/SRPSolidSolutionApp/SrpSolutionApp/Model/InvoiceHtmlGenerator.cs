using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SrpSolutionApp.Model
{
    class InvoiceHtmlGenerator
    {
        public void Generate(Invoice invoice)
        {
            List<string> lines = new List<string>();

            lines.Add("<html>");
            lines.Add("<body>");

            lines.Add("<h3> ID :" + invoice.Id + "<h3>");
            lines.Add("<h3> Discription :" + invoice.Discription + "<h3>");
            lines.Add("<h3> Amount :" + invoice.Amount + "<h3>");
            lines.Add("<h3> Tax :" + invoice.Tax * 100 + "%<h3>");
            lines.Add("<h3> Discount :" + invoice.Discount * 100 + "%<h3>");
            lines.Add("<h3> Discount Amount :" + invoice.CalculateTax() + "<h3>");
            lines.Add("<h3> Tax Tax :" + invoice.CalculateDiscount() + "%<h3>");
            lines.Add("<h3> Final Discount :" + invoice.CalculateFinalAmount() + "%<h3>");

            lines.Add("</html>");
            lines.Add("</body>");

            File.WriteAllLines("Invoice.html",lines);
        }
    }
}
