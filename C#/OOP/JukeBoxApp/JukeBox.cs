using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JukeBoxApp.Model
{
    class JuckBox
    {
        List<Song> songList = new List<Song>();
        static void Main(string[] args)
        {
            new JuckBox().Go();
        }
        private void Go()
        {
            GetSongs();
            PrintDetails(songList);
            Console.Write("\n");

            Console.WriteLine("Sorted according to Rating");
            RatingCompare ratingCompare = new RatingCompare();
            songList.Sort(comparer: ratingCompare);
            PrintDetails(songList);

            MostPalyedSong(songList);
        }

        private void MostPalyedSong(List<Song> songList)
        {
            Console.Write("\nMost Played Song :");
            PlayedTimesCompare playedTimes = new PlayedTimesCompare();
            songList.Sort(comparer: playedTimes);

            Console.WriteLine(songList[0]);
        }

        private void PrintDetails(List<Song> songList)
        {
            foreach(Song song in songList)
            {
                Console.WriteLine(song);
            }
        }

        private void GetSongs()
        {
            string[] lines = File.ReadAllLines("SongList.txt");
            foreach(string line in lines)
            {
                AddSong(line);
            }
        }

        private void AddSong(string line)
        {
            string[] tokens = line.Split('/');

            Song song = new Song(tokens[0], tokens[1], tokens[2], tokens[3]);

            songList.Add(song);

        }
    }
}
