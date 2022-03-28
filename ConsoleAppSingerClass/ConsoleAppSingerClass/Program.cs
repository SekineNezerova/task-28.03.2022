using System;

namespace ConsoleAppSingerClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Song song = new Song();
            song.GenreS = "Classic";
            song.AddRating(4);
            song.AddRating(6);
            song.AddRating(7);
            Console.WriteLine(song.GetAverageRating());

        }
    }
}
