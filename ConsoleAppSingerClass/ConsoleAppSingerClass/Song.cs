using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleAppSingerClass
{
    class Song : Singer
    {
        private string _Name;
        private string _Genre;
        private string _Singer;

        public string NameS
        {
            get
            {
                return _Name;

            }
            set
            {
                if (value.Length <= 100)
                {
                    _Name = value;
                }
                else
                {
                    Console.WriteLine("NameS valid deyil");
                }
            }
        }
        public string GenreS
        {
            get
            {
                return _Genre;
            }


            set
            {
                string[] song = new string[] { "Pop", "Rock", "Jazz", "Techno" };
                if (value == "Pop" || value == "Rock" || value == "Jazz" || value == "Techno")
                {
                    _Genre = value;
                }
                else
                {
                    Console.WriteLine("Başqa value ola bilmez");
                }
            }
        }
        public string Singer{ get ; set; }

        private int[] Ratings = new int[0];
        public void AddRating(int rating)
        {
            if (rating >= 1 && rating <= 8)
            {
                Array.Resize(ref Ratings, Ratings.Length + 1);
                Ratings[Ratings.Length - 1] = rating;
            }
        }

        public double GetAverageRating()
        {
            return Math.Round(Ratings.Average(),1);
        }
    }
}
