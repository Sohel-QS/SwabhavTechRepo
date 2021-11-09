using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace MyUnitTestApp.Model
{
    class Program
    {
        static void Main(string[] args)
        {
            var assembly = Assembly.GetExecutingAssembly();
            var types = assembly.GetTypes();
            GetClasses(types);
        }

        private static void GetClasses(Type[] types)
        {
            foreach(Type type in types)
            {
                var attribute = type.GetCustomAttribute<MyUnitTestClass>();
                if(attribute is MyUnitTestClass)
                {
                    GetMethodsOfClass(type);
                }
            }
        }

        private static void GetMethodsOfClass(Type type)
        {
            var methods = type.GetMethods().Where(t => t.GetCustomAttributes<MyUnitTestMethod>().Count() > 0);
            InvockMethod(methods, type);
        }

        private static void InvockMethod(IEnumerable<MethodInfo> methods, Type type)
        {
            ConstructorInfo constructor = type.GetConstructor(Type.EmptyTypes);
            object classObj = constructor.Invoke(new object[] { });
            Console.WriteLine("{0}", classObj);
            foreach (MethodInfo method in methods)
            {
                if ((bool)method.Invoke(classObj, new object[] { }))
                {
                    Console.WriteLine("{0} --> Passed", method);
                }
                else
                    Console.WriteLine("{0} --> Failed", method);
            }
        }

    }
}
