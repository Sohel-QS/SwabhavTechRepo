using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePatternFolderApp.Model
{
    class Folder : IStorageItem
    {
        private string _name;
        private List<IStorageItem> _files= new List<IStorageItem>();
        public Folder(string name)
        {
            _name = name;
        }

        public string Name { get => _name; set => _name = value; }
        internal List<IStorageItem> Files { get => _files; set => _files = value; }

        public void AddChild(IStorageItem file)
        {
            _files.Add(file);
        }
        public void Display(int depth)
        {
            Console.WriteLine(new String('\t', depth)+_name);
            foreach(var file in _files)
            {
                file.Display(depth+1);
            }
        }
    }
}
