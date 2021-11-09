using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceApp
{
    class Program
    {
        public class Student
        {
            public string studentName;
            public void GetStudentName()
            {
                Console.WriteLine("Student Name :{0}", studentName);
            }
        }
        public class Location : Student
        {
            public string studentLocation;
            public void GetStudentLocation()
            {
                Console.WriteLine("Student Name :{0}{1}", studentLocation,studentName);
            }
        }
        public class District : Location
        {
            public string studentDistrict;
            public void GetStudentDistrict()
            {
                Console.WriteLine("Student Name :{0}", studentDistrict);
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Single Level Inheritance");
            //single Level inheritance
            Location loc = new Location();
            loc.studentName = "Sohel";
            loc.studentLocation = "Titwala";
            loc.GetStudentName();
            loc.GetStudentLocation();

            Console.WriteLine("Multi Level Inheritance");
            //multi-level inheritance
            District dist = new District();
            dist.studentName = "Sohel";
            dist.studentLocation = "Titwala";
            dist.studentDistrict = "Thane";
            dist.GetStudentName();
            dist.GetStudentLocation();
            dist.GetStudentDistrict();
        }
    }
}
