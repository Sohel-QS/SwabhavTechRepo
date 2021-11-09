using System;

namespace MyUnitTestApp.Model
{
    [AttributeUsage(AttributeTargets.Method)]
    class MyUnitTestMethod : Attribute
    {
        private string _name;
        public string Name 
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }
    }
}
