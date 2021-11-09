using System;

namespace ClassStructureTest
{
    public class Program
    {
        protected int count = 0;
        public int flag = 0;
        static void Main(string[] args)
        {
            Program prog = new Program();
            prog.count = 1;

        }
    }
    public class SubProgram : Program
    {
        flag = 1;
    }
}
