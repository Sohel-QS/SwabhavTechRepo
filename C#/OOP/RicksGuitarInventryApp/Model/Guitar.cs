using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RicksGuitarInventryApp.Model
{
    class Guitar
    {
        private string _serialNumber;
        private double _price;
        GuitarSpecs _specs;

        public Guitar():this("",0.00,GuitarBuilder.ANY,"",GuitarType.ACOUSTIC,Wood.INDIAN_ROSEWOOD,Wood.INDIAN_ROSEWOOD)
        {
        }
        public Guitar(string serialNumber, double price, GuitarBuilder builder, string model, GuitarType type, Wood backWood, Wood topWood)
        {
            _serialNumber = serialNumber;
            _price = price;
            _specs = new GuitarSpecs(builder, model, type, backWood, topWood);
        }

        public string SerialNumber
        {
            get => _serialNumber;
        }
        public double Price
        {
            get => _price;
            set => _price = value;
        }
        public GuitarSpecs Specs
        {
            get => _specs;
        }

    }
}
