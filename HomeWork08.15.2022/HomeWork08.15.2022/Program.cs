using HomeWork08._15._2022.Models;
using System;

namespace HomeWork08._15._2022
{
    class Program
    {
        static void Main(string[] args)
        {
            Singer faiq = new Singer { Name = "Faiq", Surname = "Aghayev", Age =49 };
            Song song = new Song { Name = "Pencere", Genre="Pop",Singer = faiq };
            Console.WriteLine(song.GetAverageRating());
            song.AddRaiting(5);
            song.AddRaiting(15);
            song.AddRaiting(1);
            song.AddRaiting(10);
            Console.WriteLine(song.GetAverageRating());
        }
    }
}
