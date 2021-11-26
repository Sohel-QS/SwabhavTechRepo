using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FactoryMethodLib.Product;

namespace FactoryMethodLib.Factory
{
    public class TeslaFactory : IAutoFactory
    {
        private static IAutoFactory _factory;
        private static object _locker = new object();
        private TeslaFactory()
        {

        }
        public static IAutoFactory GetInstace()
        {
            if (_factory == null)
            {
                lock (_locker)
                {
                    if (_factory == null)
                    {
                        _factory = new TeslaFactory();
                    }
                }
            }
            return _factory;
        }
        IAutoFactory IAutoFactory.GetInstace()
        {
            return GetInstace();
        }

        public IAuto Make()
        {
            return new Tesla();
        }

    }
}
