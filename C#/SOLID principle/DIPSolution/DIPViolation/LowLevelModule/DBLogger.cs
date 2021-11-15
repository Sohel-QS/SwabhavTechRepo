using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIPViolation.LowLevelModule
{
    class DBLogger
    {
        public void WriteLine(string message)
        {
            Console.WriteLine("DBLogger :\nMessage :{0}",message);
        }
    }
}
