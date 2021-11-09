using System;
using System.Linq;
using System.Reflection;

namespace CustomAttributeApp.Model
{
    class Program
    {
        public static void NeedToRefactorMethods(Type[] types)
        {
            Console.WriteLine("Method Need To Refactor :");
            foreach(var type in types)
            {
                var methods = type.GetMethods().Where(t => t.GetCustomAttributes<NeedToRefactor>().Count() > 0);
                foreach(var method in methods)
                {
                    Console.WriteLine(method); 
                }
            }
        }
        static void Main(string[] args)
        {
            var assembly = Assembly.GetExecutingAssembly();
            var types = assembly.GetTypes();
            NeedToRefactorMethods(types);
        }
    }
}
