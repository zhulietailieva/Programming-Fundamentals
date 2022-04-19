using System;
using System.Collections.Generic;



    public class Song
    {
        public string TypeList;
        public string Name;
        public string Time;

        public Song(string typeList,string name,string time)
        {
            TypeList = typeList;
            Name = name;
            Time=time;
        }
        

        }
    
    class Program
    {
        static void Main(string[] args)
        {
        List<Song> songs = new List<Song>();
        int numOfSongs = int.Parse(Console.ReadLine());
        for (int i = 0; i < numOfSongs; i++)
        {
            string[] input = Console.ReadLine().Split("_");

            string typeList = input[0];
            string name = input[1];
            string time = input[2];

            Song currSong = new Song(typeList, name, time);
            songs.Add(currSong);          
        }
        string line = Console.ReadLine();
        if (line == "all")
        {
            foreach (var song in songs)
            {
                Console.WriteLine(song.Name);
            }
        }
        else
        {
            List<Song> filteredSongs = songs.FindAll(song =>song.TypeList==line);
            foreach (var song in filteredSongs)
            {
                Console.WriteLine(song.Name);
            }
        }
        }
    }

