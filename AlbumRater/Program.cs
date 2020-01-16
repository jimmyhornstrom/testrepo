using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlbumRater
{
    class Program
    {
        static void Main(string[] args)
        {
            var allAlbums = new List<Album>();
            allAlbums.Add(new Album("Kanye West", "Ye"));
            allAlbums.Add(new Album("Kendrick Lamar", "GKMC"));
            allAlbums.Add(new Album("Kanye West", "MBDTF"));


            AlbumManager.CreateAlbum(allAlbums);
            foreach (var album in allAlbums)
            {
                Console.WriteLine(album.Artist + "-" + album.Name);
                Console.WriteLine("------------");
                foreach (var song in album.Songs)
                {
                    Console.WriteLine($"{song.Name}");
                }
            }
            var yeSongs = allAlbums[0].Songs;
            var gkmcSongs = allAlbums[1].Songs;
            var mbdtfSongs = allAlbums[2].Songs;
            AlbumManager.ListSongsInAlbum(yeSongs);
            AlbumManager.ListSongsInAlbum(gkmcSongs);
            AlbumManager.ListSongsInAlbum(mbdtfSongs);

            var allSongs = new List<Song>();
            allSongs.AddRange(yeSongs);
            allSongs.AddRange(gkmcSongs);
            allSongs.AddRange(mbdtfSongs);

            //AlbumManager.ListAllSongs(allSongs);
            AlbumManager.RateSong(allSongs, allSongs[0]);
            //AlbumManager.ShowRating(allSongs);
            AlbumManager.RateSong(yeSongs, yeSongs[0]);
            AlbumManager.RateAlbum(allAlbums, allAlbums[0]);

            Console.ReadLine();
        }
    }
}
