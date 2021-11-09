using System;

namespace PropertiesSyntaxApp.Model
{
    class Foo
    {
        Random rad = new Random();
        private int _bar;
        private int _baz;
        public Foo()
        {
            _baz = rad.Next(0, 2);
        }

        public int Bar {
            get {
                return _bar;
            }
            set
            {
                if(value>0)
                {
                    _bar = value;
                }
            }
        }

        public int Baz
        {
            get {
                return _baz;
            }
        }
    }
}
