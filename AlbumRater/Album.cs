using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlbumRater
{
    class Album
    {
        public string Name { get; set; }
        public List<Song> Songs { get; set; }
        public string Artist { get; set; }
        //public int ReleaseYear { get; set; }
        public int Rating { get; set; }
        public Album(string artist, string name)
        {
            Artist = artist;
            Name = name;
            Songs = new List<Song>();
        }
        public Album()
        {

        }


    }
}
