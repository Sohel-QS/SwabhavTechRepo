using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarServiceDecoratorApp.Model;

namespace CarServiceDecoratorApp.Decorator
{
    abstract class CarServicing : ICarService
    {
        public abstract double GetCost();

        public abstract string GetDetails();
    }
}
