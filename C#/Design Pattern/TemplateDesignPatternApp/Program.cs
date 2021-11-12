using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TemplateDesignPatternApp.Template;
using TemplateDesignPatternApp.VehicalData;

namespace TemplateDesignPatternApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehical vehicalColor = new Color();
            vehicalColor.Run(6);

            Console.Write("\n");

            Vehical vehicalType = new VehicalType();
            vehicalType.Run(4);
        }
    }
}
