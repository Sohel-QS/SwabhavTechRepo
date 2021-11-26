using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CompositePatternFolderApp.Model;

namespace CompositePatternFolderApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Folder movie = new Folder("Movie");
            movie.AddChild(new File("titanic", "700MB"));

            Folder comedy = new Folder("Comedy");
            comedy.AddChild(new File("3 idiots", "800MB"));
            comedy.AddChild(new File("Golmaal", "750MB"));

            movie.AddChild(new File("Avengers", "1.5GB"));

            Folder horror = new Folder("Horror");
            horror.AddChild(new File("Nun", "1GB"));

            comedy.AddChild(horror);
            movie.AddChild(comedy);

            movie.Display(1);
        }
    }
}
