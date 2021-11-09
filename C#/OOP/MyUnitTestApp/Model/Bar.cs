using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyUnitTestApp.Model
{
    [MyUnitTestClass]
    class Bar
    {
        public Bar() { }
        [MyUnitTestMethod]
        public bool B1()
        {
            return true;
        }
        public bool B2()
        {
            return false;
        }
        [MyUnitTestMethod]
        public bool B3()
        {
            return true;
        }
        public override string ToString()
        {
            return "TestCase Methods For Class Bar :";
        }
    }
}
