using System;
using System.Collections.Generic;
using TemplateDesignPatternApp.Template;

namespace TemplateDesignPatternApp.VehicalData
{
    class Color : Vehical
    {
        private List<string> colors;
        public override void Connect()
        {
            colors = new List<string>();
        }

        public override void Disconnect()
        {
            colors.Clear();
        }

        public override void Process(int top)
        {
            Console.WriteLine("Colors ------");
            for(int index=0;index<top;index++)
            {
                Console.WriteLine(colors[index]);
            }
        }

        public override void Select()
        {
            colors.Add("Red");
            colors.Add("Green");
            colors.Add("Blue");
            colors.Add("Yellow");
            colors.Add("White");
            colors.Add("Black");
        }
    }
}
