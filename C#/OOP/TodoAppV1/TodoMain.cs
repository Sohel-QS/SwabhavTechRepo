using System;

namespace TodoAppV1.Model
{
    class TodoMain
    {
        static ToDo toDo = new ToDo();
        static int choice = 0;

        static void Main(string[] args)
        {

            while (choice != 3)
            {
                Console.WriteLine(" ---------- ToDo App ---------- ");
                Console.WriteLine("1.Display\n2.Add\n3.Exit");
                Console.Write("Enter Your Choice :");
                choice = Convert.ToInt32(Console.ReadLine());
                switch(choice)
                {
                    case 1:
                        PrintAllTask();
                        break;
                    case 2:
                        InputTask();
                        break;
                    case 3:
                        Exit();
                        break;
                    default:
                        Console.WriteLine(">>>Invalid Choice !!!");
                        break;
                }
            }
        }

        private static void InputTask()
        {
            Console.Write(">>>Enter Your Task :");
            toDo = new ToDo();
            toDo.AddTask = Input();
            AddMore();
        }

        public static string Input()
        {
            return Console.ReadLine();
        }

        private static void PrintAllTask()
        {
            toDo.TaskList();
        }

        public static void AddMore()
        {
            Console.Write(">>>Add More Task [y/n] :");
            if (YesNo())
            {
                InputTask();
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
