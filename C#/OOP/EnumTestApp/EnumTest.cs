using System;

namespace EnumTestApp.Model
{
    class EnumTest
    {

        public static void Display(string[] arr)
        {
            foreach (string item in arr)
            {
                if (String.IsNullOrEmpty(item))
                    continue;
                Console.WriteLine(item);
            }
            Console.WriteLine("\n");
        }

        static void Main(string[] args)
        {
            DaysOfWeek dayOfWeek = new DaysOfWeek();
            string[] days = new string[10];

            days = dayOfWeek.GetWeekEndDays();
            Console.WriteLine("Week Days Are :\n");
            Display(days);

            days = dayOfWeek.GetWorkingDays();
            Console.WriteLine("Working Days Are :\n");
            Display(days);

            days = dayOfWeek.GetWeekDays();
            Console.WriteLine("Week Days Are :\n");
            Display(days);
        }
    }
}
