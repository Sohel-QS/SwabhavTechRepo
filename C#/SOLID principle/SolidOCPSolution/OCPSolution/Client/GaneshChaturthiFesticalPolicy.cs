using System;
using OCPSolution.Lib;

namespace OCPSolution.Client
{
    class GaneshChaturthiFesticalPolicy : IFestivalPolicy
    {
        private double _rate = 0.08;
        public double CalculateRate()
        {
            return _rate;
        }
    }
}
