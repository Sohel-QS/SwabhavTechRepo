using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCPViolation.Model
{
    class FixedDeposit
    {
        private string _name;
        private double _amount;
        private int _duration;
        private FestivalType _festival;

        public FixedDeposit(string name,double amount,int noOfYears,FestivalType festival)
        {
            _name = name;
            _amount = amount;
            _duration = noOfYears;
            _festival = festival;
        }

        public string Name { get => _name;}
        public double Amount { get => _amount;}
        public int Duration { get => _duration;}
        public FestivalType Festival { get => _festival;}

        public double SimpleInterest()
        {
            return _amount * _duration * CalculateRate();
        }

        private double CalculateRate()
        {
            float rate = 0.0f;
            switch (_festival)
            {
                case FestivalType.NewYear:
                    rate = 9.0f;
                    break;
                case FestivalType.Diwali:
                    rate = 8.0f;
                    break;
                case FestivalType.Eid:
                    rate = 8.5f;
                    break;
                case FestivalType.Normal:
                    rate = 7.0f;
                    break;
            }
            return rate/100;
        }
    }
}
