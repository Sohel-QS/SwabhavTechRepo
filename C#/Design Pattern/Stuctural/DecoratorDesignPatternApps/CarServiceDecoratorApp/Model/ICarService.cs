using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarServiceDecoratorApp.Model
{
    interface ICarService
    {
        double GetCost();
        string GetDetails();
    }
}
