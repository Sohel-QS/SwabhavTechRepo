using System;
using AurionProMathCalculator;

namespace ConsoleAurionProMathCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            AurionProMath math = new AurionProMath();
            PrimeNumberMethod(math);
            GenaratePrimeNumbers(math);
            GenerateEvenNumbers(math);
        }

        private static void GenerateEvenNumbers(AurionProMath math)
        {
            int range = 25;
            int[] evenNumbers = math.GenerateEvenNosTill(range);
            Console.WriteLine("Even Numbers Till {0} :",range);

            foreach (int number in evenNumbers)
            {
                Console.WriteLine("{0} ", number);
            }
        }

        private static void GenaratePrimeNumbers(AurionProMath math)
        {
            int range = 25;
            int[] primeNumbers = math.GeneratePrimeNosTill(range);
            Console.WriteLine("Prime Numbers Till {0} :", range);

            foreach (int number in primeNumbers)
            {
                Console.WriteLine("{0} ", number);
            }
        }

        private static void PrimeNumberMethod(AurionProMath math)
        {
            Console.Write("Enter Number to Check Prime Number :");
            int number = Convert.ToInt32(Console.ReadLine());
            if (math.CheckPrimeNo(number))
                Console.WriteLine("Prime Number");
            else
                Console.WriteLine("Not Prime Number");
        }
    }
}
