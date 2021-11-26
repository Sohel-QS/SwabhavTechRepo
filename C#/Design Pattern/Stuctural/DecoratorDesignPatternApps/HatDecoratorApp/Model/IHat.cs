using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HatDecoratorApp.Model
{
    interface IHat
    {
        string GetName();
        double GetPrice();
        string GetDesciption();
    }
}
