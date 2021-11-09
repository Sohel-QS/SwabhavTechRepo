using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JukeBoxApp.Model
{
    class Song : IComparable
    {
        private string _title;
        private string _artist;
        private Double _rating;
        private int _noofTimePlayed;

        public Song(string title,string artist,string rating ,string bpm)
        {
            _title = title;
            _artist = artist;
            _rating = Convert.ToDouble(rating);
            _noofTimePlayed = Convert.ToInt32(bpm);
        }

        public string Title()
        {
            return _title;
        }

        public string Artist()
        {
            return _artist;
        }
        public Double Rating()
        {
            return _rating;
        }

        public int PlayedNos()
        {
            return _noofTimePlayed;
        }

        public int CompareTo(Object obj)
        {
            obj = obj.ToString();
            return _title.CompareTo(obj);
        }

        public override string ToString()
        {
            return _title;
        }
    }
}
