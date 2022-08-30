using System;
using System.Collections.Generic;
using System.Text;

namespace Sealed__static
{
    class Student : Person
    {
        public string StudentCode { get; set; }
        public override void GetInfo()
        {
            Console.WriteLine(Name + " " + Age + " " + StudentCode);
        }
    }
}
