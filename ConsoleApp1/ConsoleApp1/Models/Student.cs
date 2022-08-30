using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Models
{
    class Student: Person
    {

        public bool IsGuarantee;
        public Student(string Name):base(Name)
        {

        }
        public void PrepareHomeWork()
        {
            Console.WriteLine($"{Name} preapred home work");
        }
    }
}
