using System;
using System.Collections.Generic;
using System.IO;

namespace TodoAppVersion1
{
    public enum Options { Display = 1, Add, Exit }
    class ToDo
    {
        List<string> todoList = new List<string>();
        string filePath = "ToDo.txt";
        static void Main(string[] args)
        {
            ToDo obj = new ToDo();
            obj.WelcomePage();
        }
        public void WelcomePage()
        {
            Console.WriteLine(" ------ TODO Application ------ ");
            Console.Write("1. Display\n2. Add\n3. Exit\nEnter Your Choice:");
            int opt = Convert.ToInt32(Console.ReadLine());
            switch (opt)
            {
                case (int)Options.Display:
                    Display();
                    break;
                case (int)Options.Add:
                    Add();
                    break;
                case (int)Options.Exit:
                    System.Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine(" Invalid Input.Try Again!!!");
                    WelcomePage();
                    break;
            }
        }
        public void Display()
        {
            Console.WriteLine(">>>ToDo tasks");
            string[] line = File.ReadAllLines(filePath);
            for (int i = 0; i < line.Length; i++)
            {
                Console.WriteLine("#{0} {1}", i+1, line[i]);
            }
            WelcomePage();
        }
        public void Add()
        {
            string item;
            char opt;
            Console.WriteLine("Enter item :");
            item = Convert.ToString(Console.ReadLine());
            todoList.Add(item);
            Console.WriteLine("add more items(y/n) :");
            opt = Convert.ToChar(Console.ReadLine());
            if (opt == 'y')
                Add();
            else
                WriteToFile();
            WelcomePage();
        }
        public void WriteToFile()
        {
            string[] tempList = new string[todoList.Count];
            for (int i = 0; i < todoList.Count; i++)
            {
                tempList[i] = todoList[i];
            }

            File.AppendAllLines(filePath, tempList);
        }
    }
}
