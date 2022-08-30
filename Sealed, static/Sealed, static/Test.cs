using System;
using System.Collections.Generic;
using System.Text;

namespace Sealed__static
{
    class Test
    {
        private static int _id;
        public int Id { get; }
        public string Name { get; set; }
        static Test()
        {
            Console.WriteLine("Static ctor");
        }
        public Test()
        {
            Console.WriteLine("Non-static ctor");
            //_id++;
            //Id = _id;
        }
        public static void GetName() {
            //Console.WriteLine(Name);
        }
        public static void Random()
        {
            Random r = new Random();
            Console.WriteLine(r.Next());
        }
    }
}
