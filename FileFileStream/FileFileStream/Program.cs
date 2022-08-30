using FileFileStream.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.IO;

namespace FileFileStream
{
    internal class Program
    {
        static List<Film> films = new List<Film>();
        static void Main(string[] args)
        {
            //string path = "C:\\Users\\Ülvi\\Desktop\\Programming";
            #region File, Directory
            ////if (!Directory.Exists(path))
            //{
            //    Directory.CreateDirectory(path);
            //}
            //File.Create("C:\\Users\\Ülvi\\Desktop\\Programming\\p326.txt");
            //if (Directory.GetFiles(path).Length == 0 && Directory.GetDirectories(path).Length == 0)
            //{
            //    Directory.Delete("C:\\Users\\Ülvi\\Desktop\\Programming");
            //}
            //else
            //{
            //    DeleteFilesFromDirectory(path);
            //    DeleteDirectoriesFromDirectory(path);
            //    Directory.Delete("C:\\Users\\Ülvi\\Desktop\\Programming");
            //}
            //Directory.Delete("C:\\Users\\Ülvi\\Desktop\\Programming",true);
            //Console.WriteLine(Path.Combine("C:", "Users", "Ülvi", "Desktop", "Programming"));
            #endregion
            #region FileStream
            //using (StreamWriter sw = new StreamWriter(Path.Combine(path, "p326.txt"),true))
            //{
            //    sw.WriteLine("Salam 5");
            //}
            //using (StreamReader sr = new StreamReader(Path.Combine(path, "p326.txt")))
            //{
            //    Console.WriteLine(sr.Peek());
            //}
            #endregion
            #region Serialization
            #region Create
            //File.Create("C:\\Users\\Ülvi\\Desktop\\P326-master\\FileFileStream\\FileFileStream\\Files\\users.json");
            //List<User> users = new List<User>();
            //users.Add(new User { Username = "admin", Password = "admin" });
            //users.Add(new User { Username = "rovshan", Password = "rosenyek" });
            //using (StreamWriter sw = new StreamWriter("C:\\Users\\Ülvi\\Desktop\\P326-master\\FileFileStream\\FileFileStream\\Files\\users.json"))
            //{
            //    sw.Write(JsonConvert.SerializeObject(users));
            //}
            #endregion
            Login:
            Console.WriteLine("Username : ");
            string username = Console.ReadLine();
            Console.WriteLine("Password : ");
            string password = Console.ReadLine();
            List<User> users = new List<User>(); 
            using (StreamReader sr = new StreamReader("C:\\Users\\Ülvi\\Desktop\\P326-master\\FileFileStream\\FileFileStream\\Files\\users.json"))
            {
                users = JsonConvert.DeserializeObject<List<User>>(sr.ReadToEnd());
            }
            User user = users.Find(u => u.Username == username && u.Password == password);
            if (user == null)
            {
                Console.WriteLine("Username ve ya parol yalnishdir");
                goto Login;
            }
            Console.WriteLine("Welcome");
            AddFilm("Spiderman");
            AddFilm("Dr. Strange");
            AddFilm("Spread");
            AddFilm("Split");
            Menu:
            Console.WriteLine("1. Film elave et");
            Console.WriteLine("2. Filmlere bax");
            int key = Convert.ToInt32(Console.ReadLine());
            if (key == 1)
            {
                AddFilm(Console.ReadLine());
                goto Menu;
            }
            else if(key == 2)
            {
                GetFilms();
                goto Menu;
            }
            #endregion
        }
        #region File, Directory

        static void DeleteFilesFromDirectory(string path)
        {
            foreach (var item in Directory.GetFiles(path))
            {
                File.Delete(item);
            }
        }
        static void DeleteDirectoriesFromDirectory(string path)
        {
            foreach (var item in Directory.GetDirectories(path))
            {
                DeleteFilesFromDirectory(item);
                Directory.Delete(item);
            }
        }
        #endregion
        #region Serialization
        static void AddFilm(string filmName)
        {
            films.Add(new Film { 
                Name = filmName
            });
        }
        static void GetFilms()
        {
            foreach (Film item in films)
            {
                Console.WriteLine(item.Id + " " + item.Name);
            }
        }
        #endregion
    }
}
