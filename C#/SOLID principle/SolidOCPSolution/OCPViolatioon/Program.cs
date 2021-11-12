using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCPViolation.Model
{
    class Program
    {
        static void Main(string[] args)
        {
            var fd1 = new FixedDeposit("Sohel", 100000, 10, FestivalType.NewYear);
            Console.WriteLine("Simple Interest Is :{0}",fd1.SimpleInterest());


            var fd2 = new FixedDeposit("Sohel", 100000, 10, FestivalType.Diwali);
            Console.WriteLine("Simple Interest Is :{0}", fd2.SimpleInterest());
        }
    }
}
