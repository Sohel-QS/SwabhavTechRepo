using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashSetCrudApp
{
    class Program
    {
        static HashSet<string> studentNames = new HashSet<string>();
        static void Main(string[] args)
        {
            Create();
            Read();
            Update();
            Read();
            Delete();
            Read();
        }

        private static void Delete()
        {
            studentNames.Clear();

            Console.WriteLine(">>>Hash Set Deleted");
        }

        private static void Update()
        {
            Console.WriteLine("Which name you want to update");
            string str = Console.ReadLine();
            Console.WriteLine("Enter updated Name :");
            str = Console.ReadLine();
            AddName(str);

            Console.WriteLine(">>>Hash Set Updated");
        }

        private static bool AddName(string str)
        {
            if(studentNames.Contains(str))
            {
                Console.WriteLine(">>>\tName Exist in Hash Set");
                return false;
            }
            studentNames.Add(str);
            return true;
        }

        private static void Create()
        {
            string[] names = new string[] { "Sohel", "Samnit", "Vipul", "Chinmay", "Sanket"};
            foreach(string name in names)
            {
                AddName(name);
            }
            Console.WriteLine(">>>Hash Set Created");
        }

        private static object Read()
        {
            Console.WriteLine(">>>Reading Hash Set");
            if (studentNames.Count == 0)
            {
                Console.WriteLine(">>>\tEmpty HashSet");
                return null;
            }
            foreach (string name in studentNames)
            {
                Console.WriteLine(name);
            }
            return null;
        }
    }
}
