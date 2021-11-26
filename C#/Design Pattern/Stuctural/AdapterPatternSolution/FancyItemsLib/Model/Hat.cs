using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FancyItemsLib.Model
{
    class Hat
    {
        private string _shortName;
        private string _longName;
        private double _price;
        private double _gst = 0.08;

        public Hat(string shortName, string longName, double price)
        {
            _shortName = shortName;
            _longName = longName;
            _price = price;
        }

        public string ShortName 
        { 
            get => _shortName; 
            set => _shortName = value; 
        }
        public string LongName 
        { 
            get => _longName; 
            set => _longName = value; 
        }
        public double Price 
        { 
            get => _price*_gst; 
            set => _price = value; 
        }
    }
}
