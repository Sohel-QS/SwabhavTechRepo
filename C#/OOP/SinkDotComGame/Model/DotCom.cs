using System;
using System.Collections;
using System.Collections.Generic;

namespace SinkDotComGame.Model
{
    class DotCom
    {
        private List<string> locationCells;
        private string _name;
        private static int _count = 0;

        static DotCom()
        {
        }
        public void SetLocationCells(List<string> loc)
        {
            locationCells = loc;
        }


        public void SetName(string name)
        {
            _name = name;
        }

        public string GetName()
        {
            return _name;
        }

        public string CheckYourSelf(string userInput)
        {
            string result = "miss";
            int index = locationCells.IndexOf(userInput);
            if(index >= 0)
            {
                locationCells.RemoveAt(index);
                _count += 1;
                if(_count==3)
                {
                    result = "kill";
                    _count = 0;
                }
                result = "hit";
            }
            return result;
        }

    }
}
