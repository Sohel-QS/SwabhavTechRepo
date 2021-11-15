using System;
using System.Collections.Generic;
using TemplateDesignPatternApp.Template;

namespace TemplateDesignPatternApp.VehicalData
{
    class VehicalType : Vehical
    {
        private List<string> vehicalTypes;
        public override void Connect()
        {
            vehicalTypes = new List<string>();
        }

        public override void Disconnect()
        {
            vehicalTypes.Clear();
        }

        public override void Process(int top)
        {
            Console.WriteLine("Vehical Type ------");
            for (int index = 0; index < top; index++)
            {
                Console.WriteLine(vehicalTypes[index]);
            }
        }

        public override void Select()
        {
            vehicalTypes.Add("Car");
            vehicalTypes.Add("Bike");
            vehicalTypes.Add("Boat");
            vehicalTypes.Add("Truck");
        }
    }
}
