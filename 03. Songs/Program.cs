using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Songs
{
    class Song
    {
        public string TypeList { get; set; }
        public string Name { get; set; }
        public string Time { get; set; }

    }

    internal class Program
    {
        static void Main(string[] args)
        {
            List<Song> songs = new List<Song>();
            int songsCount = int.Parse(Console.ReadLine());
            for (int i = 0; i < songsCount; i++)
            {
                List<string> newSong = Console.ReadLine().Split("_", StringSplitOptions.RemoveEmptyEntries).ToList();
                string type = newSong[0];
                string name = newSong[1];
                string time = newSong[2];
                Song song = new Song();
                song.TypeList = type;
                song.Name = name;
                song.Time = time;
                songs.Add(song);
            }
            string filter = Console.ReadLine();
            if (filter == "all")
            {
                foreach (Song song in songs)
                {
                Console.WriteLine(song.Name);
                }
            }
            else
            {
                foreach (Song song in songs)
                {
                    if (song.TypeList == filter)
                    {
                    Console.WriteLine(song.Name);
                    }
                }
            }
        }
    }
}
