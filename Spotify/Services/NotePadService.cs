using System;
using Spotify.Entities;
namespace Spotify.Services
{
	internal class NotePadService
	{
		public void PlaylistToNotepad(Playlist playlist)
		{
			string directory = @$"{Directory.GetParent(Directory.GetCurrentDirectory()).Parent?.Parent?.FullName}\Playlists";

			if (!File.Exists(directory))
				Directory.CreateDirectory(directory);

			string saveFile = Path.Combine(directory, $"{playlist.Id}.txt");


			File.WriteAllText(saveFile, playlist.GetSongs());

			Console.WriteLine("data sucsessfully saved");
		}

	}
}

