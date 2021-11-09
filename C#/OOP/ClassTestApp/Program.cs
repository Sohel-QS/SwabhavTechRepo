using System;

namespace ClassTestApp.Model
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();

            student.SetName("Sohel");
            student.SetLocation("Titwala");
            student.SetScore(75);

            Student std = new Student();
            std.SetName("Samnit");
            std.SetLocation("Ulhasnagar");
            std.SetScore(90);
        }
    }
}
