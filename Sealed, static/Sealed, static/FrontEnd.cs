using System;
using System.Collections.Generic;
using System.Text;

namespace Sealed__static
{
    class FrontEnd:Student
    {
        public string[] Lessons { get; set; }
        public sealed override void GetInfo()
        {
            Console.WriteLine(Name + " " + Age + " " + StudentCode);
            Console.WriteLine("Lessons :");
            foreach (string item in Lessons)
            {
                Console.WriteLine(item);
            }
        }
    }
}
