using System;

namespace Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            var songs = new Song[]
            {
                new Song("title1", "name1", 1),
                new Song("title2", "name2", 2),
                new Song("title3", "name3", 3)
            };
            foreach (var song in songs)
            {
                Console.WriteLine(@"{0}, {1} {2:m\:ss}",
                    song.Title, song.ArtistName, TimeSpan.FromSeconds(song.Length));
            }
        }
    }

    class Song
    {
        public Song(string title, string artistName, int length)
        {
            Title = title;
            ArtistName = artistName;
            Length = length;
        }

        public string Title { get; set; }
        public string ArtistName { get; set; }
        public int Length { get; set; }
    }
}