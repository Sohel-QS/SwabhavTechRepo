using System;
using System.Configuration;
using System.Reflection;
using FactoryMethodLib.Factory;

namespace FactoryMethodClientApp
{
    class Program
    {
        static void Main(string[] args)
        {
            IAutoFactory factory1 = GetFactoryFromAppConfig();
            var auto = factory1.Make();
            auto.Start();
            auto.Stop();

            Console.WriteLine("\nHash Code of factory1 :{0}",factory1.GetHashCode());

            IAutoFactory factory2 = GetFactoryFromAppConfig();

            Console.WriteLine("\nHash Code of factory2 :{0}", factory2.GetHashCode());
        }

        private static IAutoFactory GetFactoryFromAppConfig()
        {
            Assembly asm = typeof(IAutoFactory).Assembly;

            var asmName = asm.GetName();

            Type calledType = Type.GetType(ConfigurationManager.AppSettings["factory"] + "," + asmName);

            IAutoFactory factory = calledType.InvokeMember("GetInstace", 
                BindingFlags.InvokeMethod | 
                BindingFlags.Public | 
                BindingFlags.Static, 
                null, 
                null, 
                null) as IAutoFactory;
            
            return factory;
        }
    }
}
