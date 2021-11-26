using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimpleFactoryLib.Product;

namespace SimpleFactoryLib.Factory
{
    public class AutoMobileFactory
    {
        private static AutoMobileFactory _factory;
        private static object _locker = new object();
        public static AutoMobileFactory GetInstance()
        {
            if (_factory == null)
            {
                lock (_locker)
                {
                    if (_factory == null)
                    {
                        _factory = new AutoMobileFactory();
                    }
                }
            }
            return _factory;
        }

        public IAuto Make(AutoType type)
        {
            if (type == AutoType.AUDI)
                return new Audi();
            else if (type == AutoType.BMW)
                return new Bmw();
            return new Tesla();
        }
    }
}
