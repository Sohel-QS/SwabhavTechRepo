using System;

namespace CustomAttributeApp.Model
{
    [AttributeUsage(System.AttributeTargets.Class|System.AttributeTargets.Method|System.AttributeTargets.Struct)]
    class NeedToRefactor : Attribute
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
