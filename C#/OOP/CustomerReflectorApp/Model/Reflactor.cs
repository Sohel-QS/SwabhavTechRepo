using System;
using System.Reflection;

namespace CustomerReflectorApp.Model
{
    class Reflactor
    {
        private Type type;
        public Reflactor(Type type)
        {
            this.type = type;
        }

        public void GetConstructorDetails()
        {
            ConstructorInfo[] constructors = type.GetConstructors(BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public);
            Console.WriteLine("Total onstructors :{0}", constructors.Length);
            foreach (ConstructorInfo constructor in constructors)
                Console.WriteLine(constructor);
            Console.Write("\n");
        }

        public void GetFieldDetails()
        {
            FieldInfo[] fields = type.GetFields(BindingFlags.NonPublic|BindingFlags.Instance|BindingFlags.Static|BindingFlags.Public);
            Console.WriteLine("Total Fields :{0}", fields.Length);
            foreach (FieldInfo field in fields)
                Console.WriteLine(field);
            Console.WriteLine("\n");
        }
        public void GetMethodDetails()
        {
            MethodInfo[] methods = type.GetMethods(BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.DeclaredOnly);
            Console.WriteLine("Total Methods :{0}", methods.Length);
            foreach (MethodInfo method in methods)
                Console.WriteLine(method);
            Console.WriteLine("\n");
        }
        public void GetMemberDetails()
        {
            MemberInfo[] members = type.GetMembers(BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.DeclaredOnly);
            Console.WriteLine("Total Members :{0}", members.Length);
            foreach (MemberInfo member in members)
                Console.WriteLine(member);
            Console.WriteLine("\n");
        }
        public void GetPropertyDetails()
        {
            PropertyInfo[] properties = type.GetProperties(BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public);
            Console.WriteLine("Total Properties :{0}", properties.Length);
            foreach (PropertyInfo property in properties)
                Console.WriteLine(property);
            Console.WriteLine("\n");
        }
    }
}
