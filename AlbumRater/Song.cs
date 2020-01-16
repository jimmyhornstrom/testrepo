using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlbumRater
{
    class Song
    {
        
        public string Name { get; set; }
        //public string Artist { get; set; }
        public int Rating { get; set; }


        public Song(string name)
        {
            Name = name;
            //Artist = artist;
        }
        public Song()
        {

        }
    }
}
