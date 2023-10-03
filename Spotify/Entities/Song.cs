﻿using System;
namespace Spotify.Entities
{

	internal class Song
	{
		public Guid Id { get; set; }

		public string Title { get; set; }

		public string Composer { get; set; }

		public string Artist { get; set; }

		public string Producer { get; set; }

		public Song()
		{
			Id = Guid.NewGuid();
		}

		public Song(string title, string composer, string artist, string producer) : this()
		{
			Title = title;

			Artist = composer;

			Producer = artist;

			Composer = producer;

		}
	}
}