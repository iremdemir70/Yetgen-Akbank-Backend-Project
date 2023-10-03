using System;
namespace Spotify.Entities
{

	internal class Playlist
	{
		public Guid Id { get; set; }

		private List<Song> Songs { get; set; }

		private Random random;

		public Playlist(Song firstSong) 
		{
			Id = Guid.NewGuid();
            Songs = new List<Song>();
			random = new();
            AddSong(firstSong);
		}

		public void AddSong(Song song)
		{
			if (song != null)
				Songs.Add(song);
		}

		public string GetSongs()
		{

			return string.Join("\n", Songs.Select(x => $"{x.Title} - {x.Artist}"));
		}

		public void ShuffleSongs()
		{
			int count = Songs.Count;

       
            while (count > 0)
			{
				count--;

				Song song = Songs[count];

				int randomIndex = random.Next(count);

                Songs[count] = Songs[random.Next(count)];

				Songs[randomIndex] = song;
			}
		}
	}
}