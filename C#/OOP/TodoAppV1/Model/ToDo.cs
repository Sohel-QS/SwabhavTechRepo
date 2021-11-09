using System.IO;
using System.Collections.Generic;
using System.Runtime.Serialization.Formatters.Binary;

namespace TodoAppV1.Model
{
    class ToDo
    {
        private static int _index = 0;
        private string _task;
        private int _id = 0;

        ArrayOfToDo toDoArray = new ArrayOfToDo();
        FileStream stream = new FileStream("d:\\Test.txt", FileMode.OpenOrCreate);
        BinaryFormatter formatter = new BinaryFormatter();

        public string AddTask
        {
            set
            {
                _task = value;
                toDoArray.AddToDo= this;
                _id = ++_index;
            }
        }

        public int Id
        {
            get
            {
                return _id;
            }
        }

        public string Task
        {
            get
            {
                return _task;
            }
        }

        public List<ToDo> TaskList()
        {
                List<ToDo> list = (List<ToDo>)formatter.Deserialize(stream); 
                return toDoArray.GetList;
        }
    }
}
