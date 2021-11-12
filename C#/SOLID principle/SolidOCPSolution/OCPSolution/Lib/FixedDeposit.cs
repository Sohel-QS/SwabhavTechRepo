using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCPSolution.Lib
{
    class FixedDeposit
    {
        private string _name;
        private double _amount;
        private int _duration;
        private IFestivalPolicy _festival;

        public FixedDeposit(string name, double amount, int noOfYears, IFestivalPolicy festival)
        {
            _name = name;
            _amount = amount;
            _duration = noOfYears;
            _festival = festival;
        }

        public string Name { get => _name; }
        public double Amount { get => _amount; }
        public int Duration { get => _duration; }

        public double SimpleInterest()
        {
            var result = _amount * _duration * _festival.CalculateRate();
            return Math.Round(result,2);
        }
    }
}
