using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Models
{
    class Person
    {
        public string Name;
        public string Surname;
        public int Age;
        public Person()
        {

        }
        public Person(string Name)
        {
            this.Name = Name;
        }
        public Person(string Name, string Surname):this(Name)
        {
            this.Surname = Surname;
        }
        public Person(string Name, string Surname, int Age):this(Name, Surname)
        {
            this.Age = Age;
        }

        public void GetInfo()
        {
            Console.WriteLine($"{Name} {Surname} {Age}");//Name+" "+...
        }
    }
}
