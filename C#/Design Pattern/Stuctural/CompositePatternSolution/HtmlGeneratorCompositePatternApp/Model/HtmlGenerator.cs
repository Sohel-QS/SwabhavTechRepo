using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HtmlGeneratorCompositePatternApp.Model
{
    class HtmlGenerator
    {
        public void Generate(string addLines)
        {
            List<string> lines = new List<string>();

            lines.Add("<!Doctype html>");
            lines.Add("<html>");
            lines.Add("<head>");
            lines.Add("<title>");
            lines.Add("Html Generator usin Composite Pattern");
            lines.Add("</title>");
            lines.Add("</head>");
            lines.Add("<body>");

            lines.Add(addLines);

            lines.Add("</body>");
            lines.Add("</html>");

            File.WriteAllLines("index.html", lines);
        }
    }
}
