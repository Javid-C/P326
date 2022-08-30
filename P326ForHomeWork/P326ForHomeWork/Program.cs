using P326ForHomeWork.Models;
using System;

namespace P326ForHomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
            Group g = new Group { Name = "p326" };
            Group g1 = new Group { Name ="AP205" };
            Student ceyhun = new Student {
                FullName = "Ceyhun",
                Group = g
            };
            Student esger = new Student
            {
                FullName = "Esger",
                Group = g
            };
            Student ibrahim = new Student
            {
                FullName = "Ibrahim",
                Group = g
            };
            Student laman = new Student
            {
                FullName = "Laman",
                Group = g
            };
            Student abbas = new Student
            {
                FullName = "Abbas",
                Group = g1
            };
            User ceyhunUser = new User { 
                Username = "jeyhunrm",
                Password="Salam123",
                Student = ceyhun
            };
            Console.WriteLine(ceyhunUser.Username + " " + ceyhunUser.Student.Group.Name);
        }
    }
}
