using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyUnitTestApp.Model
{
    [MyUnitTestClass]
    class Foo
    {
        public Foo() { }
        [MyUnitTestMethod]
        public bool F1()
        {
            return true;
        }
        [MyUnitTestMethod]
        public bool F2()
        {
            return false;
        }
        public bool F3()
        {
            return true;
        }
        public override string ToString()
        {
            return "TestCase Methods For Class Foo :";
        }
    }
}
