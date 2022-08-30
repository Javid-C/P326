using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Models
{
    class Teacher:Person
    {
        public decimal Salary;
        public Teacher():base()
        {

        }
        public Teacher(string Name):base(Name)        
        {

        }
        public Teacher(string Name, string Surname) : base(Name, Surname)
        {

        }
        public Teacher(string Name, string Surname, int Age) : base(Name, Surname, Age)
        {
            Console.WriteLine("3 parametr daxil olundu");
        }
        public Teacher(string Name, string Surname, int Age, decimal Salary):base(Name, Surname,Age)
        {

        }
        public void MarkStudents()
        {
            Console.WriteLine("Marked");
        }
    }
}
