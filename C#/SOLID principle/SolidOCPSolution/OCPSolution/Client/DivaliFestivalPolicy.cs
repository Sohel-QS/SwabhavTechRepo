using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OCPSolution.Lib;

namespace OCPSolution.Client
{
    class DivaliFestivalPolicy : IFestivalPolicy
    {
        private double _rate = 0.09f;
        public double CalculateRate()
        {
            return _rate;
        }
    }
}
