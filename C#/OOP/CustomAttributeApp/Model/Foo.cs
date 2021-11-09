using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomAttributeApp.Model
{
    class Foo
    {
        [NeedToRefactor]
        public void M1()
        { }
        public void M2()
        { }
        public void M3()
        { }
        [NeedToRefactor]
        public void M4()
        { }
        [NeedToRefactor]
        public void M5()
        { }
        public void M6()
        { }
    }
}
