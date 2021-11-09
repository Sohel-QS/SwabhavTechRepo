using System;

namespace CustomExceptionApp.Model
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Your Age :");
            int age = Convert.ToInt32(Console.ReadLine());
            if (age < 18)
                throw new InvalidAgeException("Age must be grater than 18");
        }
    }
}
