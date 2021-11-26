using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


delegate int NumberChanger(int n1, int n2);
namespace DelegateApp
{
    class Program
    {
        public static int AddNum(int num1, int num2)
        {
            return num1 + num2;
        }

        public static int MultNum(int num1, int num2)
        {
            return num1 * num2;
        }
        public static int SubNum(int num1, int num2)
        {
            return num1 - num2;
        }
        static void Main(string[] args)
        {
            NumberChanger nC1 = new NumberChanger(AddNum);
            NumberChanger nC2 = new NumberChanger(MultNum);
            NumberChanger nC3 = new NumberChanger(SubNum);

            Console.WriteLine("Addition :"+nC1(25, 10));
            Console.WriteLine("Multiplication :" + nC2(25, 10));
            Console.WriteLine("Subtraction :" + nC3(25, 10));

        }
    }
}
