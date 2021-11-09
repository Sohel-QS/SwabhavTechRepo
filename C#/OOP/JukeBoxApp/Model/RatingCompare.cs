using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JukeBoxApp.Model
{
    class RatingCompare : IComparer<Song>
    {
        public int Compare(Song one, Song two)
        {
            return one.Rating().CompareTo(two.Rating());
        }
    }
}
