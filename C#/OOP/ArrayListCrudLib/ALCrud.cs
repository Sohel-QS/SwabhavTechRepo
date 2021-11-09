using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayListCrudLib.Model
{
    public class ALCrud
    {
        private ArrayList _array = new ArrayList();

        public void AddElement(object value)
        {
            _array.Add(value);
        }

        public void CreateArrayList(Array values)
        {
            foreach (var element in values)
            {
                _array.Add(element);
            }
        }
        public ArrayList ReadElement()
        {
            return _array;
        }

        public void RemoveElement(int element)
        {
            if (_array.Contains(element))
                _array.Remove(element);
            else
                throw new ItemNotFound("Element not Found");
        }

        public void UpdateElement(object element, int updated)
        {
            if (_array.Contains(element))
            {
                _array.Remove(element);
                _array.Add(updated);
            }
            else
            {
                try
                {
                    throw new Exception("Item Not Found");
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

        public void DeleteArrayList()
        {
            _array.Clear();
        }


    }

}

