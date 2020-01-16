using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlbumRater
{
    class AlbumManager
    {
        
        public static void CreateAlbum(List<Album> allAlbums)
        {
            Album albumToAddTo = null;
            
            while (true)
            {
                Console.WriteLine("Vad heter albumet låten ska tillhöra?");
                for (int i = 0; i < allAlbums.Count; i++)
                {
                    Console.WriteLine($"{i + 1} {allAlbums[i].Name}");
                }
                int sel = Convert.ToInt32(Console.ReadLine());
                if (sel < 1 || sel > allAlbums.Count())
                    continue;
                albumToAddTo = allAlbums[sel - 1];
                

                Console.WriteLine("Hur många låtar vill du lägga till i albumet?");
                int antalLåtar = Convert.ToInt32(Console.ReadLine());

                for (int i = 0; i < antalLåtar; i++)
                {
                    Console.WriteLine("Song name");
                    string songName = Console.ReadLine();
                    albumToAddTo.Songs.Add(new Song(songName));
                }
                Console.WriteLine("Vill du lägga in låtar igen?");
                string answer = Console.ReadLine();
                if (answer != "j")
                    break;
            }
        }

        public static void ListSongsInAlbum(List<Song> songs)
        {
            foreach (var song in songs)
            {
                if (songs.Contains(song))
                    Console.WriteLine(song.Name);
            }
        }

        public static void ListAllSongs(List<Song> songs)
        {
            foreach (var song in songs)
            {
                Console.WriteLine("ALL SONGS");
                Console.WriteLine(song.Name);
            }
        }
        public static void RateSong(List<Song> songs, Song song)
        {
            for (int i = 0; i < songs.Count; i++)
            {
                Console.WriteLine($"{i + 1} {songs[i].Name}");
            }
            int sel = Convert.ToInt32(Console.ReadLine());
            if (sel < 1 || sel > songs.Count())
            song = songs[sel - 1];
            Console.WriteLine($"Hur många stjärnor vill du ge {song.Name}");
            song.Rating = Convert.ToInt32(Console.ReadLine());

            foreach (var item in songs)
            {
                Console.WriteLine(song.Name + "-" + song.Rating);
            }
        }

        public static void RateAlbum(List<Album> albums, Album album)
        {
            for (int i = 0; i < albums.Count; i++)
            {
                Console.WriteLine($"{i + 1} {albums[i].Name}");
            }
            int sel = Convert.ToInt32(Console.ReadLine());
            if (sel < 1 || sel > albums.Count())
                album = albums[sel - 1];
            Console.WriteLine($"Hur många stjärnor vill du ge {album.Name}");
            album.Rating = Convert.ToInt32(Console.ReadLine());

            foreach (var item in albums)
            {
                Console.WriteLine(album.Name + "-" + album.Rating);
            }
        }

       
        
    }
}
