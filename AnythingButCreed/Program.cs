// See https://aka.ms/new-console-template for more information
using AnythingButCreed;


Console.WriteLine("Hello, World!");


List<Song> goodSongs = new List<Song>(){ };


List<Song> allSongs = new List<Song>()
{
    new Song ("Alien Ant Farm","Smooth Criminal"),
    new Song("Creed", "Arms Wide Open"),
    new Song ("Sum41","FatLip"),
    new Song ("Shaggy", "It Wasn't Me"),
    new Song ("No Doubt", "Don't Speak"),
    new Song ("David Shawty", "Who let the dogs out?"),
    new Song ( "Alicia Keys", "Girl on Fire"),
    new Song ("Creed", "One Last Breath"),
    new Song ("Warren G", "Regulators"),
    new Song ("Lil Troy", "Wanna be a baller"),
    new Song ("TLC", "No Scrubs"),
    new Song ("Nelly", "Hot in Hurr")
};

goodSongs = allSongs.Where(artist => artist.Name != "Creed" ).ToList();

foreach (Song song in goodSongs)
{
    Console.WriteLine($"{song.Artist}, {song.Name}");
}
