using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePatternFolderApp.Model
{
    class File : IStorageItem
    {
        private string _name;
        private string _size;
        public File(string name, string size)
        {
            _name = name;
            _size = size;
        }
        public void Display(int depth)
        {
            Console.WriteLine(new String('\t',depth)+_name + " | " +_size);
        }
    }
}
