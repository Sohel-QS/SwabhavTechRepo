using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionGenerationApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNo = int.Parse(args[0]);
            int secondNo = int.Parse(args[1]);
            int result = firstNo / secondNo;
            Console.WriteLine("{0} / {1} = {2}", firstNo, secondNo, result);
            Console.WriteLine("End Of Main");
            Main(args);
        }
    }
}
