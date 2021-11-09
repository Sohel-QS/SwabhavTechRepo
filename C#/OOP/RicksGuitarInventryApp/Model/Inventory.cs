using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RicksGuitarInventryApp.Model
{
    class Inventory
    {
        private List<Guitar> guitars;
        public Inventory()
        {
            guitars = new List<Guitar>();
        }

        public void AddGuitar(string serialNumber, double price, GuitarBuilder builder, string model, GuitarType type, Wood backWood, Wood topWood)
        {
            Guitar guitar = new Guitar(
                serialNumber,
                price,
                builder,
                model,
                type,
                backWood,
                topWood);
            guitars.Add(guitar);
        }

        public Guitar GetGuitar(string serialNumber)
        {
            foreach(Guitar guitar in guitars)
            {
                if(guitar.SerialNumber == serialNumber)
                {
                    return guitar;
                }
            }
            return null;
        }

        public List<Guitar> Search(GuitarSpecs searchSpec)
        {
            List<Guitar> availableGuitars = new List<Guitar>();
            foreach(Guitar guitar in guitars)
            {
                GuitarSpecs specs = guitar.Specs;
                if (!specs.Builder.Equals(searchSpec.Builder))
                    continue;
                string model = specs.Model;
                if (model != null && !model.Equals("") && !model.Equals(searchSpec.Model.ToLower()))
                    continue;
                if (!specs.GType.Equals(searchSpec.GType))
                    continue;
                if (!specs.BackWood.Equals(searchSpec.BackWood))
                    continue;
                if (!specs.TopWood.Equals(searchSpec.TopWood))
                    continue;
                availableGuitars.Add(guitar);
            }
            return availableGuitars;
        }
    }
}
