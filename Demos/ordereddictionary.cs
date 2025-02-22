using System;
using System.Collections.Specialized;

public class Playlist
{
    private OrderedDictionary songs = new OrderedDictionary();

    public void AddSong(string title, string artist)
    {
        songs.Add(title, artist);
    }

    public void RemoveSong(string title)
    {
        songs.Remove(title);
    }

    public void DisplayPlaylist()
    {
        foreach (DictionaryEntry entry in songs)
        {
            Console.WriteLine($"Title: {entry.Key}, Artist: {entry.Value}");
        }
    }

    public void DisplaySongAt(int index)
    {
        if (index >= 0 && index < songs.Count)
        {
            Console.WriteLine($"Song at index {index}: {songs[index]}");
        }
        else
        {
            Console.WriteLine("Index out of range.");
        }
    }
}

public class Program
{
    public static void Main()
    {
        Playlist playlist = new Playlist();
        playlist.AddSong("Song A", "Artist 1");
        playlist.AddSong("Song B", "Artist 2");
        playlist.AddSong("Song C", "Artist 3");

        Console.WriteLine("Current Playlist:");
        playlist.DisplayPlaylist();

        playlist.DisplaySongAt(1);

        playlist.RemoveSong("Song B");

        Console.WriteLine("After removal:");
        playlist.DisplayPlaylist();
    }
}
