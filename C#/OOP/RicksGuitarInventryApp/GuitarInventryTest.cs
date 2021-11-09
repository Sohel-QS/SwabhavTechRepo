using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RicksGuitarInventryApp.Model
{
    class GuitarInventryTest
    {
        static void Main(string[] args)
        {
            Inventory inventry = new Inventory();
            InitializeInventry(inventry);

            GuitarSpecs customerDescription = new GuitarSpecs(
                GuitarBuilder.FENDER, 
                "Stratocastor",
                GuitarType.ELECTRIC, 
                Wood.ALDER, 
                Wood.ALDER);

            List<Guitar> availableGuitars = inventry.Search(customerDescription);

            Console.WriteLine("Found Guitars As Per Customer's Description");
            PrintDetails(availableGuitars);
        }

        private static void PrintDetails(List<Guitar> availableGuitars)
        {
            foreach(Guitar guitar in availableGuitars)
            {
                GuitarSpecs specs = guitar.Specs;
                Console.WriteLine("\tWe have a {0} {1} {2} guitar:\n\t\t{3} back and sides," +
                    "\n\t\t{4} top.\n\tYou can it for only RS.{5}" +
                    "\n\t------",
                    specs.Builder,
                    specs.Model,
                    specs.GType,
                    specs.BackWood,
                    specs.TopWood,
                    guitar.Price
                    );
            }
        }

        private static void InitializeInventry(Inventory inventry)
        {
            inventry.AddGuitar("RGS1234", 3000.00, GuitarBuilder.FENDER, "Stratocastor", GuitarType.ELECTRIC, Wood.ALDER, Wood.ALDER);
            inventry.AddGuitar("RGS1235", 2000.00, GuitarBuilder.FENDER, "Stratocastor", GuitarType.ELECTRIC, Wood.ALDER, Wood.ALDER);
            inventry.AddGuitar("RGS1236", 1500.00, GuitarBuilder.FENDER, "Stratocastor", GuitarType.ELECTRIC, Wood.ALDER, Wood.ALDER);
        }
    }
}
