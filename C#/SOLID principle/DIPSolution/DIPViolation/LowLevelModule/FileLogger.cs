using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIPViolation.LowLevelModule
{
    class FileLogger
    {
        public void WriteLine(string message)
        {
            Console.WriteLine("FileLogger :\nMessage{0}", message);
        }
    }
}
