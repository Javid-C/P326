using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    class Person
    {
        protected internal string Name { get; set; }
        //private protected string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
    }
    public class Student
    {
        public int No { get; set; }
        public Student()
        {
            //Name = "Rovsen";
        }
    }
    public class Test
    {
        public Test()
        {
            Person p = new Person();
            p.Name = "aslkjkla";
        }
    }
}
