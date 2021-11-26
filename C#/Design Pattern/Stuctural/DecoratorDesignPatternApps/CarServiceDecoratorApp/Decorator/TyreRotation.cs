using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarServiceDecoratorApp.Model;

namespace CarServiceDecoratorApp.Decorator
{
    class TyreRotation : CarServicing
    {
        private ICarService _service;
        private CarServicing _otherService;
        private double _cost = 350;
        public TyreRotation(ICarService service)
        {
            this._service = service;
        }
        public TyreRotation(CarServicing otherService)
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
                return _service.GetDetails() + "\n\tTyre Rotation Charges :" + this._cost;
            }

            return _otherService.GetDetails() + "\n\tTyre Rotation Charges :" + this._cost;
        }
    }
}
