using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarServiceDecoratorApp.Model;

namespace CarServiceDecoratorApp.Decorator
{
    class OilChange : CarServicing
    {
        private ICarService _service;
        private CarServicing _otherService;
        private double _cost = 1200;
        public OilChange(ICarService service)
        {
            this._service = service;
        }
        public OilChange(CarServicing otherService)
        {
            this._otherService = otherService;
        }

        public override double GetCost()
        {
            if (_service != null)
            {
                return this._cost + _service.GetCost();
            }

            return this._cost + _otherService.GetCost();
        }

        public override string GetDetails()
        {
            if (_service != null)
            {
                return _service.GetDetails() + "\n\tOil Change Charges :" + this._cost;
            }

            return _otherService.GetDetails() + "\n\tOil Change Charges :" + this._cost;
        }
    }
}
