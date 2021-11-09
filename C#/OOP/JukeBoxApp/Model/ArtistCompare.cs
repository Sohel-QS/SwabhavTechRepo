using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JukeBoxApp.Model
{
    class ArtistCompare : IComparer<Song>
    {
        public int Compare(Song one, Song two)
        {
            return one.Artist().CompareTo(two.Artist());
        }

    }
}
