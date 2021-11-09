using System;
using System.Collections.Generic;

namespace GenericDictionaryApp.Model
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

            var s1 = new Student(12, 10, "Vinay", "Mumbai");
            var s2 = new Student(10, 12, "Chinamy", "Mumbai");
            var s3 = new Student(12, 10, "VINAY", "MUMBAI");

            Console.WriteLine(s1.GetHashCode());
            Console.WriteLine(s2.GetHashCode());
            Console.WriteLine(s3.GetHashCode());

            var students = new Dictionary<Student, Student>();

            AddStudent(students,s1);
            AddStudent(students,s2);
            AddStudent(students,s3);

            Console.WriteLine("Size :{0}", students.Count);
        }

        private static object AddStudent(Dictionary<Student, Student> students, Student student)
        {
            if (!students.ContainsKey(student))
            {
                students.Add(student, student);
                return null;
            }
            return null;
        }

        private static void CaseStudy1()
        {
            var map = new Dictionary<int, string>();
            map.Add(1,"One");
            map.Add(2,"One");
            map.Add(3,"Two");

            Console.WriteLine("Size: {0}", map.Count);

            foreach(var item in map)
            {
                Console.WriteLine("{0} : {1}", item.Key,item.Value);
            }
        }
    }
}
