//using Access_Modifiers.Models;
using ClassLibrary;
using System;

namespace Access_Modifiers
{
    class Program
    {
        static void Main(string[] args)
        {
            #region HomeWork
            //User u = new User("Lyaman");
            //u.Password = "leman123";
            //Console.WriteLine(u.Username + " password: " + u.Password);
            #endregion
            #region Access Modifiers
            //Person Ceyhun = new Person();
            //Ceyhun.Name = "Ceyhun";
            #endregion
            #region Namespace
            Models.User u = new Models.User();
            u.Username = "lakjsdkasl";
            #endregion
        }
    }
    class User
    {
        public int MyProperty { get; set; }
    }
}
