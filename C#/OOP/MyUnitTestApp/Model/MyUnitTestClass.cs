using System;

namespace MyUnitTestApp.Model
{
    [AttributeUsage(AttributeTargets.Class)]
    class MyUnitTestClass  :Attribute
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
