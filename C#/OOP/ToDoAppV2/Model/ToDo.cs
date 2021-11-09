using System;
using System.Collections.Generic;

namespace TodoAppV2.Model
{
    class ToDo
    {
        private static int _index = 0;
        private string _task;
        private int _id = 0;

        public ToDo(int flag)
        {
            if (flag == 1)
            {
                _task = "No task in Here!!!!";
                _id = 404;
            }
        }
        public ToDo():this(0)
        {
        }

        public string AddTask
        {
            set
            {
                _task = value;
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
    }
}
