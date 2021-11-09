using System;
using System.Collections.Generic;

namespace TodoAppV2.Model
{
    [Serializable]
    class ArrayOfToDo
    {
        private static List<ToDo> _array = new List<ToDo>();

        public ToDo AddToDo
        {
            set
            {
                _array.Add(value);
            }
        }
        public ToDo RemoveToDo
        {
            set
            {
                _array.Remove(value);
            }
        }
        public List<ToDo> ListToDo
        {
            get
            {
                return _array;
            }
            set
            {
                _array = value;
            }
        }
    }
}
