using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WithoutElsezKeyword
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Your Age :");
            int age = Convert.ToInt32(Console.ReadLine());

            string message = CheckAge(age);

            Console.WriteLine(message);
        }

        private static string CheckAge(int age)
        {
            if (age < 18)
                return "Under Age";
            if (age > 60)
                return "Retired";
            return "Perfect Age";
        }
    }
}
