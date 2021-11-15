using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DIPSolution.CommonModule;

namespace DIPSolution.LowLevelModule
{
    class DBLogger:ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine("DBLogger :\nMessage :{0}", message);
        }

    }
}
