using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SetGenericApp.Model
{
    class Program
    {
        static void Main(string[] args)
        {
            //CaseStudy1();
            CaseStudy2();
        }

        private static void CaseStudy2()
        {
            Student s1 = new Student(101, "Chinmay", "Mumbai");
            Student s2 = new Student(101, "Chinmay", "Mumbai");
            Console.WriteLine(s1.RollNumber);
            Console.WriteLine(s2.RollNumber);

            HashSet<Student> students = new HashSet<Student>();
            students.Add(s1);
            students.Add(s2);

            Console.WriteLine("HashSet Size :{0}",students.Count);
        }


        private static void CaseStudy1()
        {
            HashSet<int> nos = new HashSet<int>();
            nos.Add(10);
            nos.Add(200);
            nos.Add(10);
            nos.Add(197);
            nos.Add(2);
            nos.Add(10);
            int len = nos.Count();
            Console.WriteLine("Lenght of HashSet :{0}", len);

            Console.WriteLine("HashSet Contains :");
            foreach(int no in nos)
            {
                Console.WriteLine(no);
            }
        }
    }
}
