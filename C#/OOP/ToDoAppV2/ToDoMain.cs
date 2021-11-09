using System;
using System.IO;
using System.Collections.Generic;
using System.Runtime.Serialization.Formatters.Binary;

namespace TodoAppV2.Model
{
    class TodoMain
    {
        static int choice = 0;

        static void Main(string[] args)
        {
            FileStream stream = new FileStream("Test.txt", FileMode.OpenOrCreate);
            BinaryFormatter formatter = new BinaryFormatter();

            ArrayOfToDo toDoArray;

            try
            {
                toDoArray = (ArrayOfToDo)formatter.Deserialize(stream);
            }
            catch (System.Runtime.Serialization.SerializationException)
            {
                toDoArray = new ArrayOfToDo();
                toDoArray.AddToDo = new ToDo(1);
            }

            ToDo toDo = new ToDo();
            stream.Close();

            while (choice != 3)
            {
                
                Console.WriteLine(" ---------- ToDo App ---------- ");
                Console.WriteLine("1.Display\n2.Add\n3.Exit");
                Console.Write("Enter Your Choice :");
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        PrintAllTask(toDoArray);
                        break;
                    case 2:
                        InputTask(toDo, toDoArray);
                        Save(toDoArray);
                        break;
                    case 3:
                        Save(toDoArray);
                        Exit();
                        break;
                    default:
                        Console.WriteLine(">>>Invalid Choice !!!");
                        break;
                }
            }
        }
        public static void Save(ArrayOfToDo toDoArray)
        {
            FileStream stream = new FileStream("Test.txt", FileMode.OpenOrCreate);
            BinaryFormatter formatter = new BinaryFormatter();

            formatter.Serialize(stream, toDoArray);

            stream.Close();
        }
        private static void PrintAllTask(ArrayOfToDo toDoArray)
        {
            foreach (ToDo task in toDoArray.ListToDo)
            {
                Console.WriteLine("#{0} {1}", task.Id, task.Task);
            }
        }

        private static void InputTask(ToDo toDo, ArrayOfToDo toDoArray)
        {
            Console.Write(">>>Enter Your Task :");
            toDo.AddTask = Input();

            toDoArray.AddToDo = toDo;
            AddMore(toDo,toDoArray);
        }

        public static string Input()
        {
            return Console.ReadLine();
        }

        public static void AddMore(ToDo toDo ,ArrayOfToDo toDoArray)
        {
            Console.Write(">>>Add More Task [y/n] :");
            if (YesNo())
            {
                InputTask(toDo,toDoArray);
            }
        }

        private static bool YesNo()
        {
            char conf = ' ';
            bool tF = false;
            while (conf == ' ')
            {
                try
                {
                    conf = Convert.ToChar(Input());
                    Console.Write("\n");
                    if (Char.ToLower(conf) == 'y')
                        tF = true;
                    else if (Char.ToLower(conf) == 'n')
                        tF = false;
                    else
                    {
                        Console.Write(">>>Invalid Input Try Again :");
                        conf = ' ';
                    }
                }
                catch (System.FormatException)
                {
                    Console.Write(">>>Format Exception Try Again :");
                }
            }
            return tF;
        }

        private static void Exit()
        {
            Console.Write(">>>Exit ToDoApp [y/n] :");
            if (YesNo())
            {
                Console.WriteLine(" ----------   Exit   ---------- ");
            }
            else
                choice = 0;
        }
    }
}
