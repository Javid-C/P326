using ConsoleApp1.Models;
using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Class
            //    //string name = "Ceyhun";
            //    //string surname = "Mustafayev";
            //    //int age = 16;
            //    //string name1 = "Esger";
            //    //string surname1 = "Esgerov";
            //    //int age1 = 23;

            //    //object Ceyhun = new {
            //    //    name = "Ceyhun",
            //    //    surname = "Mustafayev",
            //    //    age = 16
            //    //};
            //    //object Esger = new
            //    //{
            //    //    name = "Esger",
            //    //    surname = "Esgerov",
            //    //    age = 23
            //    //};

            //    //Console.WriteLine($"{Esger.GetType().GetProperty("surname").GetValue(Esger,null)}");

            //    Student ceyhun = new Student("Ceyhun", "Mustafayev");
            //    ceyhun.age = 16;
            //    ceyhun.isGuarantee = true;
            //    //Console.WriteLine($"{ceyhun.name} {ceyhun.surname} {ceyhun.age}");
            //    //ceyhun.PrepareHomeWork();

            //    //Student nicat = new Student("Nicat");
            //    //nicat.surname = "Tehmezov";
            //    //nicat.age = 22;
            //    //nicat.isGuarantee = true;
            //    //nicat.PrepareHomeWork();

            //    //Student a = new Student {
            //    //    name = "Rovsen",
            //    //    surname = "Xelilov",
            //    //    age = 19,
            //    //    isGuarantee = true
            //    //};
            //    //Console.WriteLine(a.name);

            //    Student ismayil = new Student("Ismayil","Zeynalov",19);
            //    Student elnur = new Student("Elnur","Ezizov",19);
            //    Console.WriteLine(ismayil.name);
            //    Console.WriteLine(elnur.name);
            #endregion
            //Student ceyhun = new Student("Ceyhun");
            //ceyhun.Surname = "Mustafayev";
            //ceyhun.Age = 16;
            //ceyhun.IsGuarantee = true;

            //ceyhun.GetInfo();
            //ceyhun.PrepareHomeWork();

            Teacher ulvi = new Teacher("Ulvi","Abdullazade",22,5000m);
            //ulvi.Name = "Ulvi";
            //ulvi.Surname = "Abdullazade";
            //ulvi.Age = 22;
            ulvi.GetInfo();
        }

    }
    #region Class
    //class Student
    //{
    //    //field
    //    public string name;
    //    public string surname;
    //    public int age;
    //    public bool isGuarantee;
    //    //property - 

    //    //method
    //    //constructor - Obyekt yaradilarken ishe dushen ilk methoddur, return type-i yoxdur
    //    public Student()
    //    {

    //    }
    //    public Student(string name)
    //    {
    //        this.name = name;
    //    }
    //    public Student(string name, string surname):this(name)
    //    {
    //        this.surname = surname;
    //    }
    //    public Student(string name, string surname, int age):this(name,surname)
    //    {
    //        this.age = age;
    //    }
    //    public void PrepareHomeWork()
    //    {
    //        Console.WriteLine(name + " Preapred");
    //    }
    //    public void GetInfo()
    //    {
    //        Console.WriteLine(name+" "+surname +" "+ age);
    //    }
    //}
    #endregion
}
