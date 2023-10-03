using Spotify.Entities;
using Spotify.Services;


    
    
Console.WriteLine("Spotify - Music for Noone");

string currentDirectory = Directory.GetParent(Directory.GetCurrentDirectory()).Parent?.Parent?.FullName;

Console.WriteLine();

var song1 = new Song("Falling From Grace", "The Gentle Waves", null, null);
var song2 = new Song("Lilies of the Valley", "Jun Miyake", null, null);
var song3 = new Song("Paroles Paroles", "Ibrahim Maalouf, Monica Belluci", "Giovenni Ferrio", "Ibrahim Maaluf");
var song4 = new Song("Tu Fais Semblant", "Marie Laforêt", "Danyel Gerard", "Andrê Popp");

var playlist1 = new Playlist(song1);

playlist1.AddSong(song2);
playlist1.AddSong(song3);
playlist1.AddSong(song4);

Console.WriteLine("Before Shuffle:");
Console.WriteLine(playlist1.GetSongs());

playlist1.ShuffleSongs();

Console.WriteLine("\n\nAfter Shuffle");
Console.WriteLine(playlist1.GetSongs());

NotePadService notePadService = new();
notePadService.WriteToNotepad(playlist1);