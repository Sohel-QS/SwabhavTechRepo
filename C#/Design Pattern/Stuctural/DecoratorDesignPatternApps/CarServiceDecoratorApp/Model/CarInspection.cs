using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarServiceDecoratorApp.Decorator;

namespace CarServiceDecoratorApp.Model
{
    class CarInspection : ICarService
    {
        private double _cost = 250.00;
        private CarServicing _servicing;

        public CarInspection(CarServicing servicing = null)
        {
            this._servicing = servicing;
        }

        public double GetCost()
        {
            if(_servicing!=null)
            {
                return this._cost + _servicing.GetCost();
            }
            return _cost;
        }

        public string GetDetails()
        {
            if (_servicing != null)
            {
                return _servicing.GetDetails() + "\n\tCar Inspection Charges :" + this._cost;
            }
            return "\tCar Inspection Charges :" + this._cost;
        }
    }
}
