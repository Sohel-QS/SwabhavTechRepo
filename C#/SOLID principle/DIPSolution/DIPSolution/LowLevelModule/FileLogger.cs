using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DIPSolution.CommonModule;

namespace DIPSolution.LowLevelModule
{
    class FileLogger:ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine("FileLogger :\nMessage{0}", message);
        }
    }
}
