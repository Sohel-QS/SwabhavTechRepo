using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FactoryMethodLib.Product;

namespace FactoryMethodLib.Factory
{
    public interface IAutoFactory
    {
        IAutoFactory GetInstace();
        IAuto Make();
    }
}
